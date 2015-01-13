using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
using DreamsIT.MoySklad.RestClient.Models;
using Microsoft.Owin.Hosting;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.IntegrationService
{
    public partial class IntegrationService : ServiceBase
    {
        public IntegrationService()
        {
            //InitializeComponent();
        }

        static void Main()
        {
            //string login="stas@ооо нарджилия";
            //string password="nargilia2014";
            //SalePointClient client = new SalePointClient("stas@ооо нарджилия", "nargilia2014");
            //var salePoints = client.GetSalePoints();

            //ContragentClient caClient = new ContragentClient(login, password);
            //var contragentAll = caClient.GetContragent();
            //var contragent1 = caClient.GetContragent(names: new List<string>() { "ООО Любава" });

            //DemandClient demandClient = new DemandClient(login, password);

            //var allData = demandClient.SearchByParameters();
            //var conc = demandClient.SearchByParameters(names: new List<string>() { "00004" });

            //var data = File.ReadAllBytes(@"C:\logs\testXml.xml");
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(CompanyCollection));

            //MemoryStream ms = new MemoryStream(data);

            //var objectDes = xmlSerializer.Deserialize(ms) as CompanyCollection;


            //int i = 0;
            IntegrationService service = new IntegrationService();
            service.OnStart(null);
            Console.ReadLine();



            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            //{ 
            //    new IntegrationService() 
            //};
            //ServiceBase.Run(ServicesToRun);
        }

        IDisposable owinHostApi = null;

        private IntegrationServiceController serviceController = null;

        protected override void OnStart(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            owinHostApi = owinHostApi ?? WebApp.Start<Startup>(url: baseAddress);
            var kernel = new StandardKernel(new IntegrationServiceKernel());
            serviceController = IntegrationServiceController.GetInstance(kernel);
        }

        protected override void OnStop()
        {
            if (owinHostApi!=null)
            {
                owinHostApi.Dispose();
            }
        }
    }
}
