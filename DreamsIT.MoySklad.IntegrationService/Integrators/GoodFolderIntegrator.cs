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
    public class GoodFolderIntegrator
    {
        private IMsContextFactory _factory = null;

        private StandardKernel kernel;

        public GoodFolderIntegrator()
        {
            kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            GoodFolderClient _goodFolderCient = new GoodFolderClient(login, password);

            
            var maxDate = _factory.GoodFolders.Any() ? _factory.GoodFolders.Max(r => r.Updated) : DateTime.MinValue;

            var goodFolderForRemove = _goodFolderCient.SearchDeletedGoodFolders(maxDate.AddSeconds(1)).Result.ToList();

            var newGoodFoldersFromApi = _goodFolderCient.SearchNewGoodFolders(maxDate);

            var goodFolderIdsForAdd = newGoodFoldersFromApi.Result.Select(r => r.Uuid).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var goodFoldersForAdd = newGoodFoldersFromApi.Result.Where(r => goodFolderIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var goodFolder in goodFolderForRemove)
            {
                _factory.GoodFolders.Remove(goodFolder);
            }

            foreach (var goodFolder in goodFoldersForAdd)
            {
                goodFolder.Id = goodFolder.Uuid;
                _factory.GoodFolders.Add(goodFolder);
            }

            _factory.GoodFolders.CommitChanges();
        }
    }
}
