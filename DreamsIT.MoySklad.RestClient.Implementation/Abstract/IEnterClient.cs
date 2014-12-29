using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{
    public interface IEnterClient
    {
        ResultOrError<List<Enter>> SearchByInternalOrder(List<Guid> internalOrderId);

        ResultOrError<List<Enter>> SearchNewEnter(string updated);

        ResultOrError<List<Enter>> SearchDeletedEnter(string deleted);

        ResultOrError<List<Enter>> SearchByParameters(List<Guid> internalOrderIds = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null,
List<Guid> customerOrderIds = null, List<string> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
List<string> days = null);
    }
}
