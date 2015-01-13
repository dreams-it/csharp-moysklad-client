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
    public class DemandClient:IDemandClient
    {

        public DemandClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<DemandCollection>(login, password, host);
        }
        private RequestGenerator<DemandCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Demand";
        public Models.ResultOrError<List<Models.Demand>> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrder");
            return getDemands(requestGenerator.getItemsFromAPI(filters));
        }

        public Models.ResultOrError<List<Models.Demand>> SearchByParameters(List<Guid> uuids = null, List<string> updated = null,
            List<string> names = null, List<Guid> customerOrderIds = null, List<string> created = null, List<string> createdBy = null, 
            List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (uuids != null)
            {
                string uuidsInString = ConvertParamsInString<Guid>.ConvertList(uuids, "uuid");
                paramsInString = paramsInString + ";" + uuidsInString;
            }
            if (updated != null)
            {
                string updatedInString = ConvertParamsInString<string>.ConvertList(updated, "updated");
                paramsInString = paramsInString + ";" + updatedInString;
            }
            if (names != null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            if (customerOrderIds != null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrder");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (created != null)
            {
                string createdInString = ConvertParamsInString<string>.ConvertList(created, "created");
                paramsInString = paramsInString + ";" + createdInString;
            }
            if (created != null)
            {
                string createdByInString = ConvertParamsInString<string>.ConvertList(created, "createdBy");
                paramsInString = paramsInString + ";" + createdByInString;
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
            var requestResult = requestGenerator.getItemsFromAPI(paramsInString.Substring(1));
            return getDemands(requestResult);
        }


        public ResultOrError<List<Demand>> SearchDeletedDemands(string deleted)
        {
            throw new NotImplementedException();
        }

        public ResultOrError<List<Demand>> SearchNewDemands(string updated)
        {
            throw new NotImplementedException();
        }

        private ResultOrError<List<Demand>> getDemands(ResultOrError<DemandCollection> demandCollection)
        {
            return new ResultOrError<List<Demand>>() { Error = demandCollection.Error, Success = demandCollection.Success, Result = demandCollection.Result.Demands };
        }
    }
}
