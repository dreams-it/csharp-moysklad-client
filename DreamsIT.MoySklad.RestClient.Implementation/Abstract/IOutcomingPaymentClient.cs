using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IOutcomingPaymentClient
    {
        ResultOrError<List<PaymentOut>> SearchByCustomerOrder(List<Guid> customerOrderIds);

        ResultOrError<List<PaymentOut>> SearchBySupply(List<Guid> supplyIds);

        ResultOrError<List<PaymentOut>> SearchByInvoiceIn(List<Guid> invoiceOutIds);

        ResultOrError<List<PaymentOut>> SearchBySalesReturn(List<Guid> salesReturnIds);

        ResultOrError<List<PaymentOut>> SearchByPaymentPurpose(List<Guid> uuids);

        ResultOrError<List<PaymentOut>> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> supplyIds = null, List<Guid> invoiceOutIds = null,
            List<Guid> salesReturnIds = null, List<Guid> uuids = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null,
            List<string> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
            List<string> days = null);


        //ResultOrError<List<CashOut>> SearchByCustomerOrder(List<Guid> customerOrderIds);

        //ResultOrError<List<CashOut>> SearchBySupply(List<Guid> supplyIds);

        //ResultOrError<List<CashOut>> SearchByInvoiceIn(List<Guid> invoiceOutIds);

        //ResultOrError<List<CashOut>> SearchBySalesReturn(List<Guid> salesReturnIds);

        //ResultOrError<List<CashOut>> SearchByPaymentPurpose(List<Guid> uuids);

        //ResultOrError<List<CashOut>> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> supplyIds = null, List<Guid> invoiceOutIds = null,
        //    List<Guid> salesReturnIds = null, List<Guid> uuids = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null,
        //    List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
        //    List<string> days = null);
    }
}