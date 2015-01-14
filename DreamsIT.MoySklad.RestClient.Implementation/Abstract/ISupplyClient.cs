using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface ISupplyClient
    {
        ResultOrError<List<Supply>> SearchByCustomerOrder(List<Guid> customerOrderIds);

        ResultOrError<List<Supply>> SearchByIncomingDate(List<string> incomingDates);

        ResultOrError<List<Supply>> SearchByIncomingNumber(List<long> incomingNumbers);

        ResultOrError<List<Supply>> SearchByParameters(List<Guid> customerOrderIds = null, List<string> incomingDates = null, List<long> incomingNumbers = null,
            List<Guid> ids = null, List<DateTime> updated = null, List<string> names = null,
            List<string> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
            List<string> days = null);
    }
}
