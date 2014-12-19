using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class DemandClient:IDemandClient
    {
        public List<Models.Demand> SearchByCustomerOrder(List<Guid> customerOrderIds)
        {
            throw new NotImplementedException();
        }

        public List<Models.Demand> SearchByParameters(List<Guid> ids = null, List<string> updated = null, List<string> names = null, List<Guid> customerOrderIds = null, List<double> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null)
        {
            throw new NotImplementedException();
        }
    }
}
