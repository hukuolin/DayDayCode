using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BaseHelper;
using System.Configuration;
namespace JustExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncQueryData();
           
            //CallFSOPApi();
            //TestCallWebService();
            //VerifyXmlConvertObject();
            //XmlTest();
            //DllRelyWhere.GetAllRely(@"E:\Code\AirCode\20代码\HNAiCrew\Library\ICrew\Oracle.DataAccess.dll");
            //DllRelyWhere.GetClass(@"E:\Code\FocChuanAirCode\PMS\PMSSolutions\SunWin.PMS.DAL\bin\Debug\SunWin.PMS.DAL.dll", "SunWin.PMS.DAL.WorkFlowDAL");
            Console.Read();
        }
        static void RemoteData() 
        {
            OrclHandler orcl = new OrclHandler();
            DataSet d = orcl.TestRemote();
            //  orcl.Query();
            RemoteWcf.RemoteDataServiceClient wcf = new RemoteWcf.RemoteDataServiceClient();
            DataSet ds = wcf.GetAllAirAccount();
        }
        static void Example() 
        {
            string list = "beijing 北京,beijingxistation 北京西站,beijingnan 北京南站,jiangxi 江西,jiangxnanchan 江西南昌,shanghai,nanchan 南昌";
            string now = "beijing 北京,jiangxi 江西";
            string[] all = list.Split(',');
            List<string> maybe = new List<string>();
            List<string> selelct = new List<string>();
            string[] collect = list.Split(',');
            foreach (string item in all)
            {
                if (collect.Contains(item))
                {
                    selelct.Add(item);
                }
                else 
                {
                    maybe.Add(item);
                }
            }
        }
        static void XmlTest() 
        {
            AssemblyExt ass = new AssemblyExt();
            string xmlPath= ass.GetAssemblyPath() + @"\Content\StudentOutSendRegister.xml";
            AbroadStudentManage abroad = new AbroadStudentManage();
            string  xml= abroad.FillDataToXml(xmlPath);
            RemoteWcf.RemoteDataServiceClient rds = new RemoteWcf.RemoteDataServiceClient();
            rds.UploadAbroadStudent(xml);
        }
        static void VerifyXmlConvertObject() 
        {
            string dir = new AssemblyExt().GetAppDir(AppStruct.WinApp) + @"\Content\AppStatue.xml";
            ApplyStatueWcfResponseXml response= dir.ReadXmlNodeContent<ApplyStatueWcfResponseXml>("application");
        }
        static void TestCallWebService()
        {
            StudeyWebService sws = new StudeyWebService();
            AssemblyExt ass = new AssemblyExt();
            string xmlPath = ass.GetAssemblyPath() + @"\Content\StudentOutSendRegister.xml";
            sws.UploadFile(xmlPath);
        }
        static void CallFSOPApi() 
        {
            AssemblyExt ass = new AssemblyExt();
            string xmlPath = ass.GetAssemblyPath() + @"\Content\StudentOutSendRegister.xml";
            StudeyWebService sws = new StudeyWebService();
            sws.UploadFileToFSOP(xmlPath, "submitLegFlyFSOPXML", AppConfig.FSOPTocken);
        }
        static void AsyncQueryData() 
        {
            //开启异步线程进行数据调度
            BackStageHelper back = new BackStageHelper();
            //此处是测试程序是否出现卡死情况
            back.OpenThreadFun();
            back.TestThread();
            //轮询
        }
    }
    
}
