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
    class IncomingPaymentClient : IIncomingPaymentClient
    {
        public IncomingPaymentClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<PaymentIn>(login, password, host);
        }
        private RequestGenerator<PaymentIn> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/PaymentIn/list";
        public Models.ResultOrError<List<Models.PaymentIn>> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrderId");
            return requestGenerator.getItemsFromAPI(filters);
        }

        public Models.ResultOrError<List<Models.PaymentIn>> SearchByDemand(List<Guid> demandIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(demandIds, "demandId");
            return requestGenerator.getItemsFromAPI(filters);
        }

        public Models.ResultOrError<List<Models.PaymentIn>> SearchByInvoiceOut(List<Guid> invoiceOutIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(invoiceOutIds, "invoiceOutId");
            return requestGenerator.getItemsFromAPI(filters);
        }

        public Models.ResultOrError<List<Models.PaymentIn>> SearchByPurchaseReturn(List<Guid> purchaseReturnIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(purchaseReturnIds, "purchaseReturnId");
            return requestGenerator.getItemsFromAPI(filters);
        }

        public Models.ResultOrError<List<Models.PaymentIn>> SearchByPaymentPurpose(List<Guid> uuids)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(uuids, "uuid");
            return requestGenerator.getItemsFromAPI(filters);
        }

        public Models.ResultOrError<List<Models.PaymentIn>> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> demandIds = null, List<Guid> invoiceOutIds = null,
            List<Guid> purchaseReturnIds = null, List<Guid> uuids = null, List<string> updateds = null, List<string> names = null, List<double> createds = null,
            List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (customerOrderIds != null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrderId");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (demandIds != null)
            {
                string demandIdsInString = ConvertParamsInString<Guid>.ConvertList(demandIds, "demandId");
                paramsInString = paramsInString + ";" + demandIdsInString;
            }
            if (invoiceOutIds != null)
            {
                string invoiceOutIdsInString = ConvertParamsInString<Guid>.ConvertList(invoiceOutIds, "invoiceOutId");
                paramsInString = paramsInString + ";" + invoiceOutIdsInString;
            }
            if (purchaseReturnIds != null)
            {
                string purchaseReturnIdsInString = ConvertParamsInString<Guid>.ConvertList(purchaseReturnIds, "purchaseReturnId");
                paramsInString = paramsInString + ";" + purchaseReturnIdsInString;
            }
            if (uuids != null)
            {
                string uuidsInString = ConvertParamsInString<Guid>.ConvertList(uuids, "uuid");
                paramsInString = paramsInString + ";" + uuidsInString;
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
            if (createds != null)
            {
                string createdsInString = ConvertParamsInString<double>.ConvertList(createds, "created");
                paramsInString = paramsInString + ";" + createdsInString;
            }
            if (createdBy != null)
            {
                string createdByString = ConvertParamsInString<string>.ConvertList(createdBy, "createdBy");
                paramsInString = paramsInString + ";" + createdByString;
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
