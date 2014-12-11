using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IIncomingPaymentClient
    {
        List<T> SearchByCustomerOrder(List<Guid> customerOrderIds);

        List<T> SearchByDemand(List<Guid> demandIds);

        List<T> SearchByInvoiceOut(List<Guid> invoiceOutIds);

        List<T> SearchByPurchaseReturn(List<Guid> purchaseReturnIds);

        List<T> SearchByPaymentPurpose(List<Guid> uuids);

        List<T> SearchByParameters(List<Guid> customerOrderIds = null, List<Guid> demandIds = null, List<Guid> invoiceOutIds = null, List<Guid> purchaseReturnIds = null,
            List<Guid> uuids = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null,
List<Guid> customerOrderIds = null, List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
List<string> days = null);
    }
}
