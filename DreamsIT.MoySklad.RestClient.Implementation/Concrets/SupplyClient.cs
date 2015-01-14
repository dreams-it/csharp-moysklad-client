using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.EnvitomentMethods;
using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class SupplyClient:ISupplyClient
    {
        public SupplyClient(string login, string password)
        {
            reqestGenerator = new RequestGenerator<SupplyCollection>(login, password, host);
        }

        private RequestGenerator<SupplyCollection> reqestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Supply";

        public ResultOrError<List<Supply>> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrder");
            var requestResult= reqestGenerator.getItemsFromAPI(customerOrderIdsInString);

            return getSupplyResult(requestResult);
        }

        public ResultOrError<List<Supply>> SearchByIncomingDate(List<string> incomingDates)
        {
            string dates = ConvertParamsInString<string>.ConvertList(incomingDates, "incomingDate");

            var requestResult = reqestGenerator.getItemsFromAPI(dates);

            return getSupplyResult(requestResult);
        }

        public ResultOrError<List<Supply>> SearchByIncomingNumber(List<long> incomingNumbers)
        {
            string incomingNumbersInString = ConvertParamsInString<long>.ConvertList(incomingNumbers, "incomingNumber");

            var requestResult = reqestGenerator.getItemsFromAPI(incomingNumbersInString);

            return getSupplyResult(requestResult);
        }

        public ResultOrError<List<Supply>> SearchByParameters(List<Guid> customerOrderIds = null, List<string> incomingDates = null, List<long> incomingNumbers = null,
            List<Guid> uuids = null, List<string> updated = null, List<string> names = null, List<string> created = null, List<string> createdBy = null, 
            List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            #region params for methods
            if (customerOrderIds!=null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrder");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (incomingDates!=null)
            {
                string datesInString = ConvertParamsInString<string>.ConvertList(incomingDates, "incomingDate");
                paramsInString = paramsInString + ";" + datesInString;
            }
            if (incomingNumbers!=null)
            {
                string incomingNumberInString = ConvertParamsInString<long>.ConvertList(incomingNumbers, "incomingNumber");
                paramsInString = paramsInString + ";" + incomingNumberInString;
            }
            if (uuids!=null)
            {
                string uuidsInString = ConvertParamsInString<Guid>.ConvertList(uuids, "incomingNumber");
                paramsInString = paramsInString + ";" + uuidsInString;
            }
            if (updated!=null)
            {
                string updatedInString = ConvertParamsInString<string>.ConvertList(updated, "updated");
                paramsInString = paramsInString + ";" + updatedInString;
            }
            if (names!=null)
            {
                string namesInString = ConvertParamsInString<string>.ConvertList(names, "name");
                paramsInString = paramsInString + ";" + namesInString;
            }
            if (created!=null)
            {
                string createdInString = ConvertParamsInString<string>.ConvertList(created, "created");
                paramsInString = paramsInString + ";" + createdInString;
            }
            if (createdBy!=null)
            {
                string createdByInString = ConvertParamsInString<string>.ConvertList(createdBy, "createdBy");
                paramsInString = paramsInString + ";" + createdByInString;
            }
            if (years!=null)
            {
                string yearsInString = ConvertParamsInString<string>.ConvertList(years, "year");
                paramsInString = paramsInString + ";" + yearsInString;
            }
            if (months!=null)
            {
                string monthsInString = ConvertParamsInString<string>.ConvertList(months, "month");
                paramsInString = paramsInString + ";" + monthsInString;
            }
            if (days!=null)
            {
                string daysInString = ConvertParamsInString<string>.ConvertList(days, "day");
                paramsInString = paramsInString + ";" + daysInString;
            }
            #endregion params for methods

            var requestResult = reqestGenerator.getItemsFromAPI(!string.IsNullOrWhiteSpace(paramsInString) ? paramsInString.Substring(1) : paramsInString);
            return getSupplyResult(requestResult);
        }

        private ResultOrError<List<Supply>> getSupplyResult(ResultOrError<SupplyCollection> requestResult)
        {
            return new ResultOrError<List<Supply>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.Items };
        }
    }
}
