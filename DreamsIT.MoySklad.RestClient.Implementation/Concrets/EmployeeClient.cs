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
    public class EmployeeClient : IEmployeeClient
    {
        public EmployeeClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<EmployeeCollection>(login, password, host);
        }
        private RequestGenerator<EmployeeCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Employee";
        public Models.ResultOrError<List<Models.Employee>> SearchEmployeesByName(List<string> names)
        {
            string paramsInString = "";
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }

            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getEmployee(requestResult);
        }

        public Models.ResultOrError<List<Models.Employee>> SearchEmployeeById(List<Guid> ids)
        {
            string paramsInString = "";
            if (ids != null)
            {
                string namesInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + namesInString;
            }

            paramsInString = !string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString;
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString);
            return getEmployee(requestResult);
        }

        public Models.ResultOrError<List<Models.Employee>> SearchNewEmployees(DateTime updated)
        {
            string requestParams = "updated>" + updated.ToMoySkladFormatDate();
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getEmployee(requestResult);
        }

        public Models.ResultOrError<List<Models.Employee>> SearchDeletedEmployees(DateTime deleted)
        {
            string requestParams = "deleted=" + deleted.ToMoySkladFormatDate();
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getEmployee(requestResult);
        }

        public Models.ResultOrError<List<Models.Employee>> SearchOldEmployees(DateTime updated)
        {
            string requestParams = "updated<" + updated.ToMoySkladFormatDate();
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getEmployee(requestResult);
        }

        public Models.ResultOrError<List<Models.Employee>> SearchEmployeesByParams(List<string> names = null, List<Guid> ids = null)
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
            return getEmployee(requestResult);
        }
        private ResultOrError<List<Employee>> getEmployee(ResultOrError<EmployeeCollection> EmployeeCollection)
        {
            return new ResultOrError<List<Employee>>()
            {
                Error = EmployeeCollection.Error,
                Success = EmployeeCollection.Success,
                Result = EmployeeCollection.Result.EmployeesList
            };
        }
    }
}
