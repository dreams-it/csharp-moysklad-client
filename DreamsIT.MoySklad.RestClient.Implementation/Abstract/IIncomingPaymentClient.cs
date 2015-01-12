using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IIncomingPaymentClient
    {
        /// <summary>
        /// Метод получения документов из API с помощью идентификатора заказа покупателя
        /// </summary>
        /// <param name="customerOrderIds"></param>
        /// <returns>Возвращает список объектов, с идентификатором заказа покупателя полученный из API</returns>
        ResultOrError<List<PaymentIn>> SearchByCustomerOrder(List<Guid> customerOrderIds);

        ResultOrError<List<PaymentIn>> SearchByDemand(List<Guid> demandIds);

        ResultOrError<List<PaymentIn>> SearchByInvoiceOut(List<Guid> invoiceOutIds);

        ResultOrError<List<PaymentIn>> SearchByPurchaseReturn(List<Guid> purchaseReturnIds);

        ResultOrError<List<PaymentIn>> SearchByPaymentPurpose(List<Guid> uuids);

        ResultOrError<List<PaymentIn>> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> demandIds = null, List<Guid> invoiceOutIds = null, List<Guid> purchaseReturnIds = null,
            List<Guid> uuids = null, List<string> updateds = null, List<string> names = null, 
            List<double> createds = null, List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null);
    }
}
