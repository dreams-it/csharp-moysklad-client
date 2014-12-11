using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IBuyerAccountClient
    {
        List<> SearchByCustomerOrder(List<Guid> customerOrderIds);

        List<> SearchByPlannedDate(List<double> paymentPlannedDates);

        List<> SearchByParameters(List<Guid> customerOrderIds = null, List<double> paymentPlannedDates = null,
            List<Guid> ids = null, List<string> updated = null, List<string> names = null, List<Guid> customerOrderIds = null,
            List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null);
    }
}
