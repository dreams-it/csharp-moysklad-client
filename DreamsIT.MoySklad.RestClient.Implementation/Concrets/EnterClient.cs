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
    public class EnterClient : IEnterClient
    {
        public EnterClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<EnterCollection>(login, password, host);
        }
        private RequestGenerator<EnterCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Enter";

        public ResultOrError<List<Enter>> SearchByInternalOrder(List<Guid> internalOrderId)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(internalOrderId, "internalOrderId");
            var requestResult = requestGenerator.getItemsFromAPI(filters);
            return getEnters(requestResult);
        }

        public ResultOrError<List<Enter>> SearchByParameters(List<Guid> internalOrderIds = null, List<Guid> ids = null,
            List<string> updateds = null, List<string> names = null, List<Guid> customerOrderIds = null, List<double> createds = null,
            List<string> createdBies = null, List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (internalOrderIds != null)
            {
                string internalOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(internalOrderIds, "internalOrderId");
                paramsInString = paramsInString + ";" + internalOrderIdsInString;
            }
            if (ids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
            }
            if (updateds != null)
            {
                string updatedsInString = ConvertParamsInString<string>.ConvertList(updateds, "updated");
                paramsInString = paramsInString + ";" + updatedsInString;
            }
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            if (customerOrderIds != null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrderId");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (createds != null)
            {
                string createdsInString = ConvertParamsInString<double>.ConvertList(createds, "id");
                paramsInString = paramsInString + ";" + createdsInString;
            }
            if (createdBies != null)
            {
                string createdBiesInString = ConvertParamsInString<string>.ConvertList(createdBies, "createdBy");
                paramsInString = paramsInString + ";" + createdBiesInString;
            }
            if (years != null)
            {
                string yearsInString = ConvertParamsInString<string>.ConvertList(years, "year");
                paramsInString = paramsInString + ";" + yearsInString;
            }
            if (months != null)
            {
                string monthsInString = ConvertParamsInString<string>.ConvertList(months, "month");
                paramsInString = paramsInString + ";" + monthsInString;
            }
            if (days != null)
            {
                string daysInString = ConvertParamsInString<string>.ConvertList(days, "day");
                paramsInString = paramsInString + ";" + daysInString;
            }

            var requestResult = requestGenerator.getItemsFromAPI(!string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString);
            return getEnters(requestResult);
        }

        public ResultOrError<List<Enter>> SearchNewEnter(DateTime updated)
        {
            string requestParams = "updated>" + updated;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getEnters(requestResult);
        }

        public ResultOrError<List<Enter>> SearchDeletedEnter(DateTime deleted)
        {
            string requestParams = "deleted=" + deleted;
            var requestResult = requestGenerator.getItemsFromAPI(requestParams);
            return getEnters(requestResult);
        }

        private ResultOrError<List<Enter>> getEnters(ResultOrError<EnterCollection> requestResult)
        {
            return new ResultOrError<List<Enter>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.Enters };
        }
    }
}
