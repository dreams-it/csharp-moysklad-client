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
    public class GoodFolderClient:IGoodFolderClient
    {
        public GoodFolderClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<GoodFolderCollection>(login, password, host);
        }

        private RequestGenerator<GoodFolderCollection> requestGenerator = null;

        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/GoodFolder";
        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersById(List<Guid> ids)
        {
            string paramsInString = "";
            if (ids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
            }
            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getGoodFolders(requestResult);
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersByName(List<string> names)
        {
            string paramsInString = "";
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getGoodFolders(requestResult);
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchNewGoodFolders(string updated)
        {
            string requestParams = "updated>" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGoodFolders(requestResult);
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchDeletedGoodFolders(string deleted)
        {
            string requestParams = "deleted=" + deleted;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGoodFolders(requestResult);
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchOldGoodFolders(string updated)
        {
            string requestParams = "updated<" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGoodFolders(requestResult);
        }

        public Models.ResultOrError<List<Models.GoodFolder>> SearchGoodFoldersByParams(List<string> names = null, List<Guid> ids = null)
        {
            string paramsInString = "";
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            if (ids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
            }
            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getGoodFolders(requestResult);
        }

        private ResultOrError<List<GoodFolder>> getGoodFolders(ResultOrError<GoodFolderCollection> requestResult)
        {
            return new ResultOrError<List<GoodFolder>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.GoodFolders };
        }
    }
}
