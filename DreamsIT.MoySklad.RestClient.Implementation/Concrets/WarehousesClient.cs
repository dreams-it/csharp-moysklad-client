using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class WarehousesClient:IWarehousesClient
    {
        public WarehousesClient(string login, string password)
        {

        }


        public Models.ResultOrError<List<Models.Warehouse>> GetWarehousesByName(List<string> names)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchWarehousesById(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchNewWarehouses(string updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchOldWarehouses(string updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchWarehousesByParams(List<string> names = null, List<Guid> ids = null)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchDeletedWarehouses(string updated)
        {
            throw new NotImplementedException();
        }
    }
}
