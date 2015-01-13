using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    public partial class IntegrationService : ServiceBase
    {
        public IntegrationService()
        {
            InitializeComponent();
        }

        static void Main()
        {

            IntegrationService service = new IntegrationService();
            service.OnStart(null);
            Console.ReadLine();
            service.Stop();

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            //{ 
            //    new IntegrationService() 
            //};
            //ServiceBase.Run(ServicesToRun);
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }


    }
}
