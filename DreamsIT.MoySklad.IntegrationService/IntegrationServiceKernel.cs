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
using System.Web.Mvc;
using Ninject;
using DreamsIT.MoySklad.RestClient.Models;
using DreamsIT.Data.BaseTypes;
using DreamsIT.Data.Implementations;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class IntegrationServiceKernel : NinjectModule, IDependencyResolver
    {
        public override void Load()
        {
            Bind<IDependencyResolver>().ToConstant<IntegrationServiceKernel>(this);
            Bind<DbContext>().To<MsRestApiDbContext>();
            Bind<IMsContextFactory>().To<EFMsContextFactory>();
            Bind<IContragentClient>().To<ContragentClient>();
            Bind<IDemandClient>().To<DemandClient>();
            Bind<IEnterClient>().To<EnterClient>();
            Bind<IGoodClient>().To<GoodClient>();
            Bind<IGoodFolderClient>().To<GoodFolderClient>();
            Bind<ISalePointClient>().To<SalePointClient>();
            Bind<IWarehousesClient>().To<WarehousesClient>();

            Bind<IRepository<GoodFolder, Guid>>().To<EfRepository<GoodFolder, Guid>>();
            Bind<IRepository<Good, Guid>>().To<EfRepository<Good, Guid>>();
            Bind<IRepository<RetailStore, Guid>>().To<EfRepository<RetailStore, Guid>>();
            Bind<IRepository<Warehouse, Guid>>().To<EfRepository<Warehouse, Guid>>();
            Bind<IRepository<Company, Guid>>().To<EfRepository<Company, Guid>>();
            Bind<IRepository<Demand, Guid>>().To<EfRepository<Demand, Guid>>();
            Bind<IRepository<Enter, Guid>>().To<EfRepository<Enter, Guid>>();
            Bind<IRepository<EnterPosition, Guid>>().To<EfRepository<EnterPosition, Guid>>();
            Bind<IRepository<StockTO, Guid>>().To<EfRepository<StockTO, Guid>>();
        }

        public object GetService(Type serviceType)
        {
            return base.Kernel.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return base.Kernel.GetAll(serviceType);
        }
    }
}
