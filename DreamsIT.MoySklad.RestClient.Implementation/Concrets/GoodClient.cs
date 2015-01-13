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
    public class GoodClient : IGoodClient
    {

        public GoodClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<GoodCollection>(login, password, host);
        }
        private RequestGenerator<GoodCollection> requestGenerator = null;
        private string host = "";
        public Models.ResultOrError<List<Models.Good>> SearchGoodsByName(List<string> names)
        {
            string paramsInString = "";
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }

            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getGood(requestResult);
        }


        public Models.ResultOrError<List<Models.Good>> SearchGoodsById(List<Guid> ids)
        {
            string paramsInString = "";
            if (ids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
            }
            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getGood(requestResult);
        }

        public Models.ResultOrError<List<Models.Good>> SearchNewGoods(string updated)
        {
            string requestParams = "updated>" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGood(requestResult);
        }

        public Models.ResultOrError<List<Models.Good>> SearchOldGoods(string updated)
        {
            string requestParams = "updated<" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGood(requestResult);
        }
        
        public Models.ResultOrError<List<Models.Good>> SearchGoodsByParams(List<string> names=null, List<Guid> ids=null)
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
            return getGood(requestResult);
        }
      
        public Models.ResultOrError<List<Models.Good>> SearchDeletedGoods(string deleted)
        {
            string requestParams = "deleted=" + deleted;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getGood(requestResult);
        }
       
        public ResultOrError<List<Good>> getGood(ResultOrError<GoodCollection> GoodCollection)
        {
            return new ResultOrError<List<Good>>()
            {
                Error = GoodCollection.Error,
                Success = GoodCollection.Success,
                Result = GoodCollection.Result.GoodList
            };
        }
    }
}
