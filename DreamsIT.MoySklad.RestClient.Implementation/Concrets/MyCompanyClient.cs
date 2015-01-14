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
    public class MyCompanyClient : IMyCompanyClient
    {
        public MyCompanyClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<MyCompanyCollection>(login, password, host);
        }
        private RequestGenerator<MyCompanyCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/MyCompany";
        public Models.ResultOrError<List<Models.MyCompany>> GetMyCompanies(List<Guid> ids = null, List<string> names = null)
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
            var requestResult= requestGenerator.getItemsFromAPI(paramsInString);
            return getMyCompanies(requestResult);
        }

        public ResultOrError<List<MyCompany>> GetDeletedMyCompanies( DateTime deleted)
        {
            string requestParams = "deleted=" + deleted;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getMyCompanies(requestResult);
        }

        public ResultOrError<List<MyCompany>> GetNewMyCompanies( DateTime updated)
        {
            string requestParams = "updated>" + updated;
            var requestResult= requestGenerator.getItemsFromAPI(requestParams);
            return getMyCompanies(requestResult);
        }

        private ResultOrError<List<MyCompany>> getMyCompanies(ResultOrError<MyCompanyCollection> myCompanyCollection)
        {
            return new ResultOrError<List<MyCompany>>() { 
                Error = myCompanyCollection.Error, Success = myCompanyCollection.Success, Result = myCompanyCollection.Result.MyCompanies 
            };
        }
    }
}