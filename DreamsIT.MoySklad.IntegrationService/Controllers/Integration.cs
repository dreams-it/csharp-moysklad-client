using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using DreamsIT.MoySklad.IntegrationService.Integrators;

namespace DreamsIT.MoySklad.IntegrationService.Controllers
{
    public class IntegrationController:ApiController
    {
        [HttpGet]
        public bool Start(string login, string password, int refreshTime)
        {
            IntegrationJobService jobService = new IntegrationJobService();
            jobService.StartJob(login, password, refreshTime);

            //new GoodFolderIntegrator().Synchronization(login, password);

            //GoodsIntegrator intergrator = new GoodsIntegrator();
            //intergrator.Synchronization(login, password);

            //new SalePointsIntegrator().Synchronization(login, password);

            //new WarehousesIntegrator().Synchronization(login, password);

            //new ContragentIntegrator().Syncronization(login, password);

            //new DemandIntegrator().Syncronization(login, password);

            //new EnterIntegrator().Syncronization(login, password);

            //new StockIntegrator().Syncronization(login, password);

            return jobService.JobExist(login);
            //return false;
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
