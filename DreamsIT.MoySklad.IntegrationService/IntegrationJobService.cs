using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class IntegrationJobService
    {

        private ISchedulerFactory factory;
        private IScheduler scheduler;

        public IntegrationJobService()
        {
            if (scheduler!=null)
            {
                return;
            }

            factory = new StdSchedulerFactory();
            scheduler = factory.GetScheduler();
            scheduler.Start();
        }

        public void StartJob(string login, string password, int refreshTimeInHours)
        {
            var key = new JobKey("job_refresh_" + login);

            if (scheduler.CheckExists(key))
            {
                return;
            }

            var dataDetails = new Dictionary<string, string>() { { "login", login }, { "password", password } };

            var jobDetail =
                JobBuilder.Create<IntegrationJob>().UsingJobData(new JobDataMap(dataDetails))
                                      .WithIdentity(key)
                                      .Build();
            var trigger = TriggerBuilder.Create()
                              .WithIdentity("job_refresh_trigger_"+login)
                              .StartAt(DateBuilder.FutureDate(5, IntervalUnit.Second))
                              .WithSimpleSchedule(x => x.RepeatForever().WithIntervalInHours(refreshTimeInHours))
                              .Build();

            scheduler.ScheduleJob(jobDetail, trigger);
        }

        public void DeleteJob(string login)
        {
            var key = new JobKey("job_refresh_" + login);
            scheduler.DeleteJob(key);
        }

        public bool JobExist(string login)
        {
            var key = new JobKey("job_refresh_" + login);
            return scheduler.CheckExists(key);
        }
    }
}
