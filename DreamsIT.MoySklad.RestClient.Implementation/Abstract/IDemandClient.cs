using DreamsIT.MoySklad.RestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Abstract
{

    public interface IDemandClient
    {
        List<Demand> SearchByCustomerOrder(List<Guid> customerOrderIds);

        List<Demand> SearchByParameters(List<Guid> ids = null, List<string> updated = null, List<string> names = null,
            List<Guid> customerOrderIds = null, List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null,
            List<string> days = null);
    }
}
