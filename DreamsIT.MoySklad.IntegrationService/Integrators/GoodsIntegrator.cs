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
    public class GoodsIntegrator
    {
        private IMsContextFactory _factory = null;
        private IDependencyResolver _dependencyResolver = null;

        public GoodsIntegrator()
        {
            _factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            GoodClient _goodsCient=new GoodClient(login, password);

            var maxDate=_factory.Goods.Max(r=>DateTime.Parse(r.Updated));

            var goodsForRemove = _goodsCient.SearchDeletedGoods(maxDate.ToMoySkladFormatDate()).Result.ToList();

            var newGoodFromApi = _goodsCient.SearchNewGoods(maxDate.ToMoySkladFormatDate());

            var goodIdsForAdd = newGoodFromApi.Result.Select(r => r.Id).Except(_factory.GoodFolders.Select(r => r.Uuid)).ToList();

            var goodsForAdd = newGoodFromApi.Result.Where(r => goodIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var goodFolder in goodsForRemove)
            {
                _factory.Goods.Remove(goodFolder);
            }

            foreach (var goodFolder in goodsForAdd)
            {
                _factory.Goods.Add(goodFolder);
            }

            _factory.GoodFolders.CommitChanges();
        }
    }
}
