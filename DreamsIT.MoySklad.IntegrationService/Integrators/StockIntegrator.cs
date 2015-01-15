using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService.Integrators
{
    public class StockIntegrator
    {
        private IMsContextFactory _factory = null;

        public StockIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }


        public void Syncronization(string login, string password)
        {
            StockClient _stockClient = new StockClient(login, password);

            if (_factory.StockTOs.Any())
            {
                _factory.StockTOs.Clear();
            }

            var stockItems = _stockClient.StockBalance();

            foreach (var item in stockItems.Result)
            {
                foreach (var goodRef in item.GoodRefs)
                {
                    goodRef.Id = goodRef.Uuid;
                }
                item.Id = Guid.NewGuid();
                _factory.StockTOs.Add(item);
            }

            _factory.StockTOs.CommitChanges();
        }
    }
}
