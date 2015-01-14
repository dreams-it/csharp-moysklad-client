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
    public class OutcomingPaymentClient : IOutcomingPaymentClient
    {
        public OutcomingPaymentClient(string login, string password)
        {
            requestGenerator = new RequestGenerator<PaymentOutCollection>(login, password, host);
        }
        private RequestGenerator<PaymentOutCollection> requestGenerator = null;
        private string host = "https://online.moysklad.ru/exchange/rest/ms/xml/PaymentOut/list";

        public Models.ResultOrError<List<Models.PaymentOut>> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrderId");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getPaymentOuts(requestResult);
        }

        public Models.ResultOrError<List<Models.PaymentOut>> SearchBySupply(List<Guid> supplyIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(supplyIds, "supplyId");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getPaymentOuts(requestResult);
        }

        public Models.ResultOrError<List<Models.PaymentOut>> SearchByInvoiceIn(List<Guid> invoiceOutIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(invoiceOutIds, "invoiceOutId");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getPaymentOuts(requestResult);
        }

        public Models.ResultOrError<List<Models.PaymentOut>> SearchBySalesReturn(List<Guid> salesReturnIds)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(salesReturnIds, "salesReturnId");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getPaymentOuts(requestResult);
        }

        public Models.ResultOrError<List<Models.PaymentOut>> SearchByPaymentPurpose(List<Guid> uuids)
        {
            var filters = ConvertParamsInString<Guid>.ConvertList(uuids, "uuid");
            var requestResult= requestGenerator.getItemsFromAPI(filters);
            return getPaymentOuts(requestResult);
        }

        public Models.ResultOrError<List<Models.PaymentOut>> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> supplyIds = null, List<Guid> invoiceOutIds = null,
            List<Guid> salesReturnIds = null, List<Guid> uuids = null, List<Guid> ids = null, List<string> updateds = null, List<string> names = null, List<double> createds = null,
            List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null)
        {
            string paramsInString = "";
            if (customerOrderIds != null)
            {
                string customerOrderIdsInString = ConvertParamsInString<Guid>.ConvertList(customerOrderIds, "customerOrderId");
                paramsInString = paramsInString + ";" + customerOrderIdsInString;
            }
            if (supplyIds != null)
            {
                string supplyIdsInString = ConvertParamsInString<Guid>.ConvertList(supplyIds, "supplyId");
                paramsInString = paramsInString + ";" + supplyIdsInString;
            }
            if (invoiceOutIds != null)
            {
                string invoiceOutIdsInString = ConvertParamsInString<Guid>.ConvertList(invoiceOutIds, "invoiceOutId");
                paramsInString = paramsInString + ";" + invoiceOutIdsInString;
            }
            if (salesReturnIds != null)
            {
                string salesReturnIdsInString = ConvertParamsInString<Guid>.ConvertList(salesReturnIds, "salesReturnId");
                paramsInString = paramsInString + ";" + salesReturnIdsInString;
            }
            if (uuids != null)
            {
                string idsInString = ConvertParamsInString<Guid>.ConvertList(ids, "id");
                paramsInString = paramsInString + ";" + idsInString;
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

            var requestResult= requestGenerator.getItemsFromAPI(paramsInString.Substring(1));
            return getPaymentOuts(requestResult);
        }

        private ResultOrError<List<PaymentOut>> getPaymentOuts(ResultOrError<PaymentOutCollection> requestResult)
        {
            return new ResultOrError<List<PaymentOut>>() { Error = requestResult.Error, Success = requestResult.Success, Result = requestResult.Result.PaymentOutList };
        }
    }
}
