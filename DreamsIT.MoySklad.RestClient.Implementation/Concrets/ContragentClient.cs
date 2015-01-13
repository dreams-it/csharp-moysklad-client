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
    public class ContragentClient : IContragentClient
    {
        public ContragentClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<CompanyCollection>(login, password, host);
        }
        private RequestGenerator<CompanyCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Company";

        public ResultOrError<List<Company>> GetContragent(List<Guid> ids = null, List<string> names = null)
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
            var requestResult = !string.IsNullOrWhiteSpace(paramsInString) ? requestGenerator.getItemsFromAPI(paramsInString.Substring(1)) : requestGenerator.getItemsFromAPI(paramsInString);
            return getCompanies(requestResult);
        }


        public ResultOrError<List<Company>> GetNewContragent(string updated)
        {
            throw new NotImplementedException();
        }

        public ResultOrError<List<Company>> GetDeletedContragent(string deleted)
        {
            throw new NotImplementedException();
        }

        public ResultOrError<List<Company>> GetOldContragent(string updated)
        {
            throw new NotImplementedException();
        }


        public ResultOrError<List<Company>> getCompanies(ResultOrError<CompanyCollection> companyCollection)
        {
            return new ResultOrError<List<Company>>() { Error = companyCollection.Error, Success = companyCollection.Success, Result = companyCollection.Result.Companies };
        }
    }
}
