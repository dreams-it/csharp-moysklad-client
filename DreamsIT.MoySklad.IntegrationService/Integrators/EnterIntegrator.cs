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
    public class EnterIntegrator
    {
        private IMsContextFactory _factory = null;
        private IDependencyResolver _dependencyResolver = null;

        public EnterIntegrator()
        {
            _factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Syncronization(string login, string password)
        {
            IEnterClient _enterClient = new EnterClient(login, password);

            var maxDate = _factory.Enters.Max(r => DateTime.Parse(r.Updated));

            var entersForRemove = _enterClient.SearchDeletedEnter(maxDate.ToMoySkladFormatDate()).Result.ToList();

            var newEntersFromApi = _enterClient.SearchNewEnter(maxDate.ToMoySkladFormatDate());

            var enterIdsForAdd = newEntersFromApi.Result.Select(r => r.Id).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var entersForAdd = newEntersFromApi.Result.Where(r => enterIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var enter in entersForRemove)
            {
                _factory.Enters.Remove(enter);
            }

            foreach (var enter in entersForAdd)
            {
                _factory.Enters.Add(enter);
            }

            _factory.Enters.CommitChanges();
        }
    }
}
