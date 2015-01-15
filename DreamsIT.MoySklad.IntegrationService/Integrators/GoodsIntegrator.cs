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
    public class GoodsIntegrator
    {
        private IMsContextFactory _factory = null;

        public GoodsIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            GoodClient _goodsCient=new GoodClient(login, password);

            var maxDate = _factory.Goods.Any() ? _factory.Goods.Max(r => r.Updated) : DateTime.MinValue;

            var goodsForRemove = _goodsCient.SearchDeletedGoods(maxDate).Result.ToList();

            var newGoodFromApi = _goodsCient.SearchNewGoods(maxDate);

            var goodIdsForAdd = newGoodFromApi.Result.Select(r => r.Uuid).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var goodsForAdd = newGoodFromApi.Result.Where(r => goodIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var goodFolder in goodsForRemove)
            {
                _factory.Goods.Remove(goodFolder);
            }

            foreach (var goodFolder in goodsForAdd)
            {
                goodFolder.Id = goodFolder.Uuid;
                _factory.Goods.Add(goodFolder);
            }

            _factory.GoodFolders.CommitChanges();
        }
    }
}
