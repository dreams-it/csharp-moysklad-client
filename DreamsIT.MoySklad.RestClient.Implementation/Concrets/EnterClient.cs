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
    class EnterClient : IEnterClient
    {
        public EnterClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<Enter>(login, password, host);
        }
        private RequestGenerator<Enter> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Enter/list";

        public ResultOrError<List<Enter>> SearchByInternalOrder(List<Guid> internalOrderId)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(internalOrderId, "internalOrderId");
            return requestGenerator.getItemsFromAPI(filters);
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

            return requestGenerator.getItemsFromAPI(paramsInString.Substring(1));
        }
    }
}
