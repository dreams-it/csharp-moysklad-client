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
    public class LossClient : ILossClient
    {
        public LossClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<LossCollection>(login, password, host);
        }
        private RequestGenerator<LossCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Loss";
        public Models.ResultOrError<List<Models.Loss>> SearchByInventoryId(List<Guid> inentoryIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(inentoryIds, "inentoryId");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getLosses(requestResult);
        }

        public Models.ResultOrError<List<Models.Loss>> SearchByParameters(List<Guid> inentoryIds = null, List<Guid> ids = null, List<string> updateds = null,
            List<string> names = null, List<Guid> customerOrderIds = null, List<double> createds = null, List<string> createdBies = null, List<string> years = null,
            List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (inentoryIds != null)
            {
                string inentoryIdsInString = ConvertParamsInString<Guid>.ConvertList(inentoryIds, "inentoryId");
                paramsInString = paramsInString + ";" + inentoryIdsInString;
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
                string createdsInString = ConvertParamsInString<double>.ConvertList(createds, "created");
                paramsInString = paramsInString + ";" + createdsInString;
            }
            if (createdBies != null)
            {
                string createdBiesString = ConvertParamsInString<string>.ConvertList(createdBies, "createdBy");
                paramsInString = paramsInString + ";" + createdBiesString;
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
            return getLosses(requestResult);
        }

        private ResultOrError<List<Loss>> getLosses(ResultOrError<LossCollection> requestResult)
        {
            return new ResultOrError<List<Loss>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.LossList };
        }
    }
}