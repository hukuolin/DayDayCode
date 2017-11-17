using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Specialized;
using BaseHelper;
namespace WebHelper
{
    public class WebRequestHelper
    {
        public void GetBrowserData()
        {
            if (HttpContext.Current == null)
            {

            }
            HttpRequest hr = HttpContext.Current.Request;
            HttpBrowserCapabilities browser = hr.Browser;//浏览器信息
            string useAgentName = browser.Browser;//系统从 use-Agent 中读取到的浏览器信息
            if (useAgentName == "Unknown")
            {//简单的爬虫程序没有设置该信息项 
            
            }
            string requestFile = hr.FilePath;//进行请求时，视图或文件的相对路径
            string appDir = hr.PhysicalApplicationPath;//程序的目录信息
            string appFullDirNoExtension = hr.PhysicalPath;//不含有请求文件格式名的全路径
            string urlParam = hr.QueryString.ToString();
            object param = hr.Form;//post请求时的参数列表【此处没有获取到参数】
            NameValueCollection nameValue = hr.Params;
            Dictionary<string, object> dict = new Dictionary<string, object>();
            StringBuilder sb = new StringBuilder();
            foreach (var item in nameValue)
            {
                string key = item.ToString();
                dict.Add(key, nameValue[key]);
                sb.AppendLine(key + "= \r\n" + nameValue[key]);
            }
            LoggerHeper log = new LoggerHeper();
            log.WriteLog(sb.ToString(), new AssemblyExt().GetAppDir(AppStruct.Web), DateTime.Now.ToString("yyyyMMddHHmmss") + ".log", false);
        }
    }
}
