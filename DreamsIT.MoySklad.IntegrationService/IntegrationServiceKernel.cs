using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.DataAccess.Concrets;
using DreamsIT.MoySklad.DataAccess.DataDbContext;
using DreamsIT.MoySklad.RestClient.Implementation.Abstract;
using DreamsIT.MoySklad.RestClient.Implementation.Concrets;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class IntegrationServiceKernel:NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<MsRestApiDbContext>();
            Bind<IMsContextFactory>().To<EFMsContextFactory>();

            Bind<IContragentClient>().To<ContragentClient>();
            Bind<IDemandClient>().To<DemandClient>();
            Bind<IEnterClient>().To<EnterClient>();
            Bind<IGoodClient>().To<GoodClient>();
            Bind<IGoodFolderClient>().To<GoodFolderClient>();
            Bind<ISalePointClient>().To<SalePointClient>();
            Bind<IWarehousesClient>().To<WarehousesClient>();
        }
    }
}
