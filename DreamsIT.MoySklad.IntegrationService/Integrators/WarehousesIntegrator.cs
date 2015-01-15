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
    public class WarehousesIntegrator
    {
        private IMsContextFactory _factory = null;

        public WarehousesIntegrator()
        {
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            _factory = kernel.Get<IMsContextFactory>();
        }

        public void Synchronization(string login, string password)
        {
            WarehousesClient warehouseClient=new WarehousesClient(login,password);
            var maxDate = _factory.Warehouses.Any() ? _factory.Warehouses.Max(r => r.Updated) : DateTime.MinValue;

            var deletedWarehouses = warehouseClient.SearchDeletedWarehouses(maxDate);

            var newWarehouses=warehouseClient.SearchNewWarehouses(maxDate);

            var warehousesIdsForAdd = newWarehouses.Result.Select(r => r.Uuid).Except(_factory.Warehouses.Select(r => r.Id)).ToList();

            var warehousesForAdd=newWarehouses.Result.Where(r=>warehousesIdsForAdd.Contains(r.Uuid)).ToList();

            foreach (var warehouse in deletedWarehouses.Result)
            {
                _factory.Warehouses.Remove(warehouse.Uuid);
            }

            foreach (var warehouse in warehousesForAdd)
            {
                warehouse.Id = warehouse.Uuid;
                _factory.Warehouses.Add(warehouse);
            }

            _factory.Warehouses.CommitChanges();
        }
    }
}
