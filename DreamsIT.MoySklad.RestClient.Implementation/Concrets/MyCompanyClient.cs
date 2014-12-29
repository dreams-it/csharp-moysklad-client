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
    class MyCompanyClient : IMyCompanyClient
    {
        public MyCompanyClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<MyCompany>(login, password, host);
        }
        private RequestGenerator<MyCompany> requestGenerator = null;
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
            return requestGenerator.getItemsFromAPI(paramsInString);
        }

        public ResultOrError<List<MyCompany>> GetDeletedMyCompanies(string deleted)
        {
            string requestParams = "deleted=" + deleted;
            return requestGenerator.getItemsFromAPI(requestParams);
        }

        public ResultOrError<List<MyCompany>> GetNewMyCompanies(string updated)
        {
            string requestParams = "updated=" + updated;
            return requestGenerator.getItemsFromAPI(requestParams);
        }
    }
}