using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class Integration:ApiController
    {
        [HttpPost]
        public bool Start(string login, string password, int refreshTime)
        {
            IntegrationJobService jobService = new IntegrationJobService();
            jobService.StartJob(login, password, refreshTime);
            return jobService.JobExist(login);
        }

        [HttpDelete]
        public bool Stop(string login)
        {
            IntegrationJobService jobService = new IntegrationJobService();
            jobService.DeleteJob(login);
            return !jobService.JobExist(login);
        }
    }
}
