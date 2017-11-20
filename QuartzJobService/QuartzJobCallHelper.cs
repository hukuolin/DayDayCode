using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using System.Collections.Specialized;
using System.Reflection;
using Quartz;
using Quartz.Core;
using Quartz.Util;
namespace QuartzJobService
{
    public   delegate  void QuartzJobCallBack(object obj);
    public class QuartzJobCallHelper<T>:IJob where T:class
    {
        string callParam = "callParam";

        public void Execute(IJobExecutionContext context)
        {
            object param= context.Get(callParam);// 参数列表 1-> 执行事件  2->执行事件的参数
            JobKey jobkey = context.JobDetail.Key;
            JobDataMap dm = context.JobDetail.JobDataMap;
            object[] dmp= dm.Get(callParam) as object[];
            if (dmp == null || dmp.Length < 2)
            {
                return;
            }
            QuartzJobCallBack call = dmp[0] as QuartzJobCallBack;
            call(dmp[1]);
           // throw new NotImplementedException();
        }
    }
    public class QuartzSchedule
    {
        static string callParam = "callParam";
        static IScheduler AppSchedule;
        public static void CreateSchedule<T>(int interval, int repeat, DateTime startTime, object jobParam) where T : IJob
        {//此处调用存在hack ->如果使用多线程调度时会自动创建一个 计划表（存储在程序池中），但是这个计划表会和其他线程创建的名称相同，从而出现同名程序池
            if (repeat <= 1)
            {
                repeat = int.MaxValue;
            }
            string scheduleName = typeof(T).Name;
            IScheduler sch = AppSchedule;
            if (AppSchedule == null)
            {
                /*
                      其他信息: Scheduler with name 'DefaultQuartzScheduler' already exists.
                */
                //需要检查是否已使用该名称的定时计划
                StdSchedulerFactory factory = new StdSchedulerFactory();
                NameValueCollection nv = new NameValueCollection();
                nv.Add(typeof(T).FullName, typeof(T).FullName);
                factory.Initialize(nv);
               // Properties props = new Properties();
                QuartzSchedulerResources res=new QuartzSchedulerResources();
                QuartzScheduler qs=new QuartzScheduler(res,new TimeSpan());
                
               // factory.Instantiate(null, qs);
              
                sch = factory.GetScheduler(scheduleName);
                if (sch == null)
                {
                    sch = factory.GetScheduler();
                }
                AppSchedule = sch;
            }
            IJobDetail job = JobBuilder.Create<T>().Build();
            job.JobDataMap.Put(callParam, jobParam);
            string triggerName = typeof(T).Name, groupName = typeof(T).Name;
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                .WithIdentity(triggerName, groupName)
                .WithSimpleSchedule(x =>
                    x.WithIntervalInSeconds(interval)
                .WithRepeatCount(repeat)
                ).Build();
            sch.ScheduleJob(job, trigger);
            sch.Start();
        }
    }
}
