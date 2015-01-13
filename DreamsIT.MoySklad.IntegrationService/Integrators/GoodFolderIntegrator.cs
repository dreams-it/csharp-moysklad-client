using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.IntegrationService.EnviromentServices;
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
    public class GoodFolderIntegrator
    {
        private IMsContextFactory _factory = null;
        //private IDependencyResolver _dependencyResolver = null;

        private StandardKernel kernel;

        public GoodFolderIntegrator()
        {
            kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
            //_factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            GoodFolderClient _goodFolderCient = new GoodFolderClient(login, password);

            var maxDate = _factory.GoodFolders.Max(r => DateTime.Parse(r.Updated));

            var goodFolderForRemove = _goodFolderCient.SearchDeletedGoodFolders(maxDate.ToMoySkladFormatDate()).Result.ToList();

            var newGoodFoldersFromApi = _goodFolderCient.SearchNewGoodFolders(maxDate.ToMoySkladFormatDate());

            var goodFolderIdsForAdd = newGoodFoldersFromApi.Result.Select(r => r.Id).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var goodFoldersForAdd = newGoodFoldersFromApi.Result.Where(r => goodFolderIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var goodFolder in goodFolderForRemove)
            {
                _factory.GoodFolders.Remove(goodFolder);
            }

            foreach (var goodFolder in goodFoldersForAdd)
            {
                _factory.GoodFolders.Add(goodFolder);
            }

            _factory.GoodFolders.CommitChanges();
        }
    }
}
