using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseHelper;
using DataProvider.Model;
using DataProvider.IService;
using DataProvider.Service.MsSql;
using System.Timers;
using QuartzJobService;
namespace JustExample
{
    /// <summary>
    /// 后台程序调度帮助类
    /// </summary>
    public class BackStageHelper
    {
        QuartzSchedule schedule = new QuartzSchedule(AppStruct.WinApp);
        public void OpenThreadFun() 
        {
            //异步1 查询总数据量
            AsyncCallback call = new AsyncCallback(t =>
            {
                QuartUinData uin = new QuartUinData();
                uin.QueryUinData(t, schedule);
            });
            AsyncThreadHelper thread = new AsyncThreadHelper();
            object param=new object[] { "参数1", Guid.NewGuid(), DateTime.Now };
            thread.OpenAsyncThread(call,param , AppStruct.WinApp);
            //异步2 数据同步更新
            AsyncCallback updateUinData = new AsyncCallback(t =>
            {
                QuartUinData uin = new QuartUinData();
                uin.SyncUinDataInDbTime(t, schedule);
            });
            AsyncThreadHelper updateTh = new AsyncThreadHelper();
            updateTh.OpenAsyncThread(updateUinData, param, AppStruct.WinApp);
        }
        class DoQueryUinData
        { }
        class DoSyncUinDataInDbTime { }
        class QuartUinData
        {
            public void QueryUinData(IAsyncResult result, QuartzSchedule schedule)
            {
                AsyncRequestHelper th = result as AsyncRequestHelper;
                object param = th.callParam;
                "Into Excute Event".WriteLog(new AssemblyExt().GetAppDir(AppStruct.WinApp));
                QuartzJobCallBack call = new QuartzJobCallBack(QuartQuery);
                object[] callParam = new object[] { call, param };
                //开启 异步循环调度
                
                schedule.CreateSchedule<QuartzJobCallHelper<DoQueryUinData>>(2, 0, DateTime.Now, callParam);
                
               // QuartQuery(param);
            }
            public void QuartQuery(object param) 
            {
               //是否其他进程调度？？
                
                IAsyncDataService<TecentUinData> async = new SyncDataService<TecentUinData>(AppConfig.UinDataConnString);
                // = new SyncDataService<TecentUinData>(AppConfig.DbConnString,AppConfig.CountUinCmd);
                int row= async.Count(AppConfig.CountUinCmd);
                string.Format( "Do Job Event,Query row=【{0}】",row).WriteLog(new AssemblyExt().GetAppDir(AppStruct.WinApp));
            }
            public void SyncUinDataInDbTime(IAsyncResult result, QuartzSchedule schedule)
            {
                //同步数据库数据入库时间戳
               
                //获取传递过来的参数
                AsyncRequestHelper th = result as AsyncRequestHelper;
                object param = th.callParam;
                QuartzJobCallBack call = new QuartzJobCallBack(DoSyncUinInDBDate);
                object[] callParam = new object[] { call, param };
                //开启 异步循环调度
                schedule.CreateSchedule<QuartzJobCallHelper<DoSyncUinDataInDbTime>>(60, 0, DateTime.Now, callParam);
            }
            public void DoSyncUinInDBDate(object obj) 
            {
                string cmd = AppConfig.SyncGatherDateIntSql;
                IAsyncDataService<TecentUinData> uin = new SyncDataService<TecentUinData>(AppConfig.UinDataConnString);
                int row = uin.ExecuteNoQuery(cmd);
                string.Format("Do Job Event, update row=【{0}】", row).WriteLog(new AssemblyExt().GetAppDir(AppStruct.WinApp));
            }
        }
        public void TestThread() 
        {
            //测试异步是否存在干扰
            int total=1000;
            int current = 1;
            while (current < total)
            {
                string.Format("Call Thread time =【{0}】", current).WriteLog(new AssemblyExt().GetAppDir(AppStruct.WinApp));
                current++;
            }
        }
        
    }

}
