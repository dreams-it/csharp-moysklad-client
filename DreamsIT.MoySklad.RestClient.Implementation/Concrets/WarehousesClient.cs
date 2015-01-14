using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods;
using DreamsIT.MoySklad.RestClient.Models;
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
            requestGenerator = new RequestGenerator<WarehouseColllection>(login, password, host);
        }
        private RequestGenerator<WarehouseColllection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Warehouse";

        public Models.ResultOrError<List<Models.Warehouse>> GetWarehousesByName(List<string> names)
        {
            string paramsInString = "";
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }

            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getWarehouse(requestResult);
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchWarehousesById(List<Guid> ids)
        {
            string paramsInString = "";
            if (ids != null)
            {
                string namesInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + namesInString;
            }

            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getWarehouse(requestResult);
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchNewWarehouses( DateTime updated)
        {
            string requestParams = "updated>" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getWarehouse(requestResult);
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchOldWarehouses( DateTime updated)
        {
            string requestParams = "updated<" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getWarehouse(requestResult);
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchWarehousesByParams(List<string> names = null, List<Guid> ids = null)
        {
            string paramsInString = "";
            if (ids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
            }
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getWarehouse(requestResult);
        }

        public Models.ResultOrError<List<Models.Warehouse>> SearchDeletedWarehouses( DateTime deleted)
        {
            string requestParams = "deleted=" + deleted;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getWarehouse(requestResult);
        }
        private ResultOrError<List<Warehouse>> getWarehouse(ResultOrError<WarehouseColllection> WarehouseColllection)
        {
            return new ResultOrError<List<Warehouse>>()
            {
                Error = WarehouseColllection.Error,
                Success = WarehouseColllection.Success,
                Result = WarehouseColllection.Result.WarehouseList
            };
        }
    }
}
