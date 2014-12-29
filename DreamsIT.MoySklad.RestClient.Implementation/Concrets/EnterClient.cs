using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Implementation.Concrets
{
    public class EnterClient:IEnterClient
    {
        public EnterClient(string login, string password)
        {

        }

        public Models.ResultOrError<List<Models.Enter>> SearchByInternalOrder(List<Guid> internalOrderId)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Enter>> SearchNewEnter(string updated)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Enter>> SearchDeletedEnter(string deleted)
        {
            throw new NotImplementedException();
        }

        public Models.ResultOrError<List<Models.Enter>> SearchByParameters(List<Guid> internalOrderIds = null, List<Guid> ids = null, List<string> updated = null, List<string> names = null, List<Guid> customerOrderIds = null, List<string> created = null, List<string> createdBy = null, List<string> years = null, List<string> months = null, List<string> days = null)
        {
            throw new NotImplementedException();
        }
    }
}
