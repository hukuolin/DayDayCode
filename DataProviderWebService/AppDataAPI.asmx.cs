using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebModel;
using BaseHelper;
namespace DataProviderWebService
{
    /// <summary>
    /// AppDataAPI 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class AppDataAPI : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public JsonData UploadFile(byte[] files) 
        {
            JsonData json = new JsonData();
            int len = files == null ? 0 : files.Length;
            AppHelper.WriteLog(string.Format(" Call Api ,File length=[{0}]", len));
            return json;
        }
    }
}
