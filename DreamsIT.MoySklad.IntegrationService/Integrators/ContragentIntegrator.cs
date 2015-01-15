using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DreamsIT.MoySklad.IntegrationService.Integrators
{
    public class ContragentIntegrator
    {
        private IMsContextFactory _factory = null;

        public ContragentIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Syncronization(string login, string password)
        {
            ContragentClient _contractorCient = new ContragentClient(login, password);

            var maxDate = _factory.Companies.Any() ? _factory.Companies.Max(r => r.Updated) : DateTime.MinValue;

            var contragentsForRemove = _contractorCient.GetDeletedContragent(maxDate).Result.ToList();

            var newContragentsFromApi = _contractorCient.GetNewContragent(maxDate);

            var contragentIdsForAdd = newContragentsFromApi.Result.Select(r => r.Uuid).Except(_factory.Companies.Select(r => r.Id)).ToList();

            var contragentsForAdd = newContragentsFromApi.Result.Where(r => contragentIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var contragent in contragentsForRemove)
            {
                _factory.Companies.Remove(contragent);
            }

            foreach (var contragent in contragentsForAdd)
            {
                contragent.Id = contragent.Uuid;
                _factory.Companies.Add(contragent);
            }

            _factory.Companies.CommitChanges();
        }
    }
}
