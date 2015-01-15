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
    public class EnterIntegrator
    {
        private IMsContextFactory _factory = null;

        public EnterIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Syncronization(string login, string password)
        {
            EnterClient _enterClient = new EnterClient(login, password);

            var maxDate = _factory.Enters.Any() ? _factory.Enters.Max(r => r.Updated) : DateTime.MinValue;

            var entersForRemove = _enterClient.SearchDeletedEnter(maxDate).Result.ToList();

            var newEntersFromApi = _enterClient.SearchNewEnter(maxDate);

            var enterIdsForAdd = newEntersFromApi.Result.Select(r => r.Uuid).Except(_factory.Enters.Select(r => r.Id)).ToList();

            var entersForAdd = newEntersFromApi.Result.Where(r => enterIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var enter in entersForRemove)
            {
                _factory.Enters.Remove(enter);
            }

            foreach (var enter in entersForAdd)
            {
                //var enterPositionsIdsListForAdd = enter.EnterPositions.Select(r => r.Uuid).Except(_factory.EnterPositions.Select(c => c.Uuid)).ToList();

                //var entrPositions = enter.EnterPositions.Where(r => enterPositionsIdsListForAdd.Contains(r.Uuid));

                foreach (var enterPosition in enter.EnterPositions)
                {
                    enterPosition.Id = enterPosition.Uuid;
                    //_factory.EnterPositions.Add(enterPosition);
                }

                enter.Id=enter.Uuid;
                _factory.Enters.Add(enter);
            }

            //_factory.EnterPositions.CommitChanges();
            _factory.Enters.CommitChanges();
        }
    }
}
