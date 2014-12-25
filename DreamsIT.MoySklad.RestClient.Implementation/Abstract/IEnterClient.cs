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
        List<Enter> SearchByInternalOrder(List<Guid> internalOrderId);

        List<Enter> SearchByParameters(List<Guid> internalOrderIds = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null,
List<Guid> customerOrderIds = null, List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
List<string> days = null);
    }
}
