using DreamsIT.MoySklad.DataAccess.Abstracts;
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
    public class DemandIntegrator
    {
        private IMsContextFactory _factory = null;
        private IDependencyResolver _dependencyResolver = null;

        public DemandIntegrator()
        {
            _factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Syncronization(string login, string password)
        {
            DemandClient _demandCient = new DemandClient(login, password);

            var maxDate = _factory.Demands.Max(r => r.Updated);

            var demandsForRemove = _demandCient.SearchDeletedDemands(maxDate).Result.ToList();

            var newDemandsFromApi = _demandCient.SearchNewDemands(maxDate);

            var demandIdsForAdd = newDemandsFromApi.Result.Select(r => r.Id).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var demandsForAdd = newDemandsFromApi.Result.Where(r => demandIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var demand in demandsForRemove)
            {
                _factory.Demands.Remove(demand);
            }

            foreach (var demand in demandsForAdd)
            {
                _factory.Demands.Add(demand);
            }

            _factory.Demands.CommitChanges();
        }
    }
}
