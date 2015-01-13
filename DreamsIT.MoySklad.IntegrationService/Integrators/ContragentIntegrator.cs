using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.IntegrationService.EnviromentServices;
using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
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
        private IDependencyResolver _dependencyResolver = null;

        public ContragentIntegrator()
        {
            _factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Syncronization(string login, string password)
        {
            IContragentClient _contractorCient = new ContragentClient(login, password);

            var maxDate = _factory.Companies.Max(r => DateTime.Parse(r.Updated));

            var contragentsForRemove = _contractorCient.GetDeletedContragent(maxDate.ToMoySkladFormatDate()).Result.ToList();

            var newContragentsFromApi = _contractorCient.GetNewContragent(maxDate.ToMoySkladFormatDate());

            var contragentIdsForAdd = newContragentsFromApi.Result.Select(r => r.Id).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var contragentsForAdd = newContragentsFromApi.Result.Where(r => contragentIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var contragent in contragentsForRemove)
            {
                _factory.Companies.Remove(contragent);
            }

            foreach (var contragent in contragentsForAdd)
            {
                _factory.Companies.Add(contragent);
            }

            _factory.Companies.CommitChanges();
        }
    }
}
