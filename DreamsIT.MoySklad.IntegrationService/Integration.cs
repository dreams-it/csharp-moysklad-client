using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using DreamsIT.MoySklad.IntegrationService.Integrators;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class IntegrationController:ApiController
    {
        [HttpGet]
        public bool Start(string login, string password, int refreshTime)
        {
            //IntegrationJobService jobService = new IntegrationJobService();
            //jobService.StartJob(login, password, refreshTime);

            GoodFolderIntegrator integrator = new GoodFolderIntegrator();
            integrator.Synchronization(login, password);
            //return jobService.JobExist(login);
            return false;
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
