using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BaseHelper
{
    public class AsyncRequestHelper:IAsyncResult
    {
        //异步调度
        private AsyncCallback _asyncCallBack;//回调函数
        public object callParam{get;private set;}
        private string _result;
        AppStruct appType;
        public bool IsCompleted { get;private set; }
        public AsyncRequestHelper(AsyncCallback asyncCall, object state,AppStruct app)
        {
            _asyncCallBack = asyncCall;
            callParam = state;
            appType = app;
        }
        public void SetComplate(string result) 
        {
            string dir = new AssemblyExt().GetAppDir(appType); 
            _result = result;
            IsCompleted = true;
            "In Async Function".WriteLog(dir);
            if (_asyncCallBack != null)
            {
                _asyncCallBack(this);
            }
        }


        public object AsyncState
        {
            get { throw new NotImplementedException(); }
        }

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get { throw new NotImplementedException(); }
        }

        public bool CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }
    }
    /// <summary>
    /// 异步线程调度
    /// </summary>
    public class AsyncThreadHelper 
    {
        public void OpenAsyncThread(AsyncCallback call,object callParam,AppStruct appType) 
        {
            var async = new AsyncRequestHelper(call, callParam,appType);
            new Thread(() => 
            {//开启线程 
                string dir = new AssemblyExt().GetAppDir(appType);
                //此处应该增加日志记录功能
                "Begin Call Async Thread".WriteLog(dir);
                //线程调度
                async.SetComplate(string.Empty);
                //日志 记录结束标志
                "End Call Async Thread".WriteLog(dir);
            }).Start();
        }
    }
}
