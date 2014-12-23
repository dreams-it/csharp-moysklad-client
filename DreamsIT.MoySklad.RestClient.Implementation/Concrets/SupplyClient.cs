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
            _login = login;
            _password = password;
        }

        private string _login { get; set; }
        private string _password { get; set; }
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/Supply";

        public ResultOrError<List<Supply>> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            string customerOrderIdsInString = "";
            foreach (var customerOrder in customerOrderIds)
            {
                customerOrderIdsInString = customerOrderIdsInString + ";uuid=" + customerOrder;
            }
            customerOrderIdsInString = customerOrderIdsInString.Substring(1);
            return getItemsFromAPI(customerOrderIdsInString);
        }

        public ResultOrError<List<Supply>> SearchByIncomingDate(List<double> incomingDates)
        {
            string dates = "";
            foreach (var incomingDate in incomingDates)
            {
                dates = dates + ";incomingDate=" + incomingDate;
            }
            dates = dates.Substring(1);
            return getItemsFromAPI(dates);
        }

        public ResultOrError<List<Supply>> SearchByIncomingNumber(List<long> incomingNumbers)
        {
            string incomingNumbersInString = "";
            foreach (var incomingNumber in incomingNumbers)
            {
                incomingNumbersInString = incomingNumbersInString + ";incomingNumber=" + incomingNumber;
            }
            incomingNumbersInString = incomingNumbersInString.Substring(1);
            return getItemsFromAPI(incomingNumbersInString);
        }

        public ResultOrError<List<Supply>> SearchByParameters(List<Guid> customerOrderIds = null, List<double> incomingDates = null, List<long> incomingNumbers = null, 
            List<Guid> uuids = null, List<string> updated = null, List<string> names = null, List<double> created = null, List<string> createdBy = null, 
            List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (customerOrderIds!=null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrder");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (incomingDates!=null)
            {
                string datesInString = ConvertParamsInString<double>.ConvertList(incomingDates, "incomingDate");
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
                string createdInString = ConvertParamsInString<double>.ConvertList(created, "created");
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
            return getItemsFromAPI(paramsInString.Substring(1));
        }

        private ResultOrError<List<Supply>> getItemsFromAPI(string filterParams)
        {
            string encodedParams = HttpUtility.UrlEncode(filterParams);
            string address = string.Format("{0}/list?filter={1}", host, encodedParams);

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(_login, _password);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/xml");
            string error = "";
            byte[] data = null;
            try
            {
                data = client.DownloadData(address);
            }
            catch (Exception exc)
            {
                error = exc.Message;
            }

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Supply>));

            var ms = new MemoryStream(data);

            var result = serializer.ReadObject(ms) as List<Supply>;

            return new ResultOrError<List<Supply>>() { Error = error, Result = result, Success = result != null && string.IsNullOrWhiteSpace(error) };
        }
    }
}
