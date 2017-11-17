using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseHelper;
using System.Configuration;
namespace DataProviderWebService
{
    public class AppHelper
    {
        public static void WriteLog(string msg)
        {
            if (!AppConfig.OpenLogFun)
            {
                return;
            }
            AssemblyExt ass = new AssemblyExt();
            string dir = ass.GetAppDir(AppStruct.Web);
            LoggerHeper log = new LoggerHeper();
            log.WriteLog(msg, dir, DateTime.Now.ToString(AppConfig.DateTimeIntFormat) + ".log", true);
        }
    }
    public class AppConfig
    {
        public static bool OpenLogFun
        {
            get 
            {
                string open = ConfigurationManager.AppSettings["OpenLogFun"];
                if (open != "true")
                {
                    return false;
                }
                return true;
            }
        }
        public static string DateTimeIntFormat
        {
            get
            {
                return ConfigurationManager.AppSettings["DateTimeIntFormat"];
            }
        }
    }
}