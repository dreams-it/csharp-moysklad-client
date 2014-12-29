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
    public class WarehousesIntegrator
    {
        private IMsContextFactory _factory = null;
        private IDependencyResolver _dependencyResolver = null;

        public WarehousesIntegrator()
        {
            _factory = _factory ?? _dependencyResolver.GetService<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            IWarehousesClient warehouseClient=new WarehousesClient(login,password);
            var maxDate = _factory.Warehouses.Max(r => DateTime.Parse(r.Updated));

            var deletedWarehouses = warehouseClient.SearchDeletedWarehouses(maxDate.ToMoySkladFormatDate());

            var newWarehouses=warehouseClient.SearchNewWarehouses(maxDate.ToMoySkladFormatDate());

            var warehousesIdsForAdd = newWarehouses.Result.Select(r => r.Uuid).Except(_factory.Warehouses.Select(r => r.Uuid)).ToList();

            var warehousesForAdd=newWarehouses.Result.Where(r=>warehousesIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var warehouse in deletedWarehouses.Result)
            {
                _factory.Warehouses.Remove(warehouse.Uuid);
            }

            foreach (var warehouse in warehousesForAdd)
            {
                _factory.Warehouses.Add(warehouse);
            }

            _factory.Warehouses.CommitChanges();
        }
    }
}
