using DreamsIT.MoySklad.IntegrationService.Integrators;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    //віндову службу, що хостить кварц
    //задача:
    //1. надає веб апі інтерфейс для активації із зупинки синхронізації (Start, Stop для кварцу)
    //на вхід start (логін, пароль, частота оновлення в хвилинах)
    //джоб повинен виконувати синхронізацію бази через дата лейер для сутдностей мой склад

    public class IntegrationJob:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var login = context.JobDetail.JobDataMap["login"] as string;
            var password = context.JobDetail.JobDataMap["password"] as string;

            new GoodFolderIntegrator().Synchronization(login, password);

            new GoodsIntegrator().Synchronization(login, password);

            new SalePointsIntegrator().Synchronization(login, password);

            new WarehousesIntegrator().Synchronization(login, password);

            new ContragentIntegrator().Syncronization(login, password);

            new DemandIntegrator().Syncronization(login, password);

            new EnterIntegrator().Syncronization(login, password);

            new StockIntegrator().Syncronization(login, password);
            //TODO: BB. to be continue
        }
    }
}
