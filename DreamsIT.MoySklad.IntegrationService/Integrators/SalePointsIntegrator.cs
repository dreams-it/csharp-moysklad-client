using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
using DreamsIT.MoySklad.RestClient.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DreamsIT.MoySklad.IntegrationService.Integrators
{
    public class SalePointsIntegrator
    {
        private IMsContextFactory _factory = null;

        public SalePointsIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            SalePointClient _salePointsClient = new SalePointClient(login, password);

            var allSalePoints = _salePointsClient.GetSalePoints().Result;

            var removedSalePoints = _factory.RetailStores.Select(r=>r.Id).Except(allSalePoints.Select(r=>r.Uuid));

            var newSalePointIds = allSalePoints.Select(r => r.Uuid).Except(_factory.RetailStores.Select(r => r.Uuid)).ToList();

            var salePointsForAdd = allSalePoints.Where(r => newSalePointIds.Contains(r.Uuid));

            foreach (var salePoint in removedSalePoints)
            {
                _factory.RetailStores.Remove(salePoint);
            }

            foreach (var salePoint in salePointsForAdd)
            {
                salePoint.Id = salePoint.Uuid;
                _factory.RetailStores.Add(salePoint);
            }

            _factory.RetailStores.CommitChanges();
        }
    }
}
