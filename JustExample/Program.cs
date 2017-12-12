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
        static void GetDateTime() 
        {
            string timeStr = "2017-11-17 16:08:29";
            DateTime time = Convert.ToDateTime(timeStr);
            long timeMilLong = time.Ticks;
            string str= timeMilLong.Convert01();
            // var js=1510906109905; //dt.getTime()
            // 补码结果  922378286
            long timeMil = Environment.TickCount;
            long mil = DateTime.Now.Ticks;//当前时间的毫秒数

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份:");
            string  line= Console.ReadLine();
            Console.WriteLine(line);
            int year = 0;
            int.TryParse(line, out year);
            while (year > 0)
            {
                int weeks = DateTimeHelper.GetYearSumWeeks(year);
                Console.WriteLine(string.Format("{0}年总共有{1}周", year, weeks));
                Console.WriteLine("请输入年份:");
                line = Console.ReadLine();
                int.TryParse(line, out year);
            }
            DateTest();
            GetDateTime();
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
        static void DateTest() 
        {
            DateTimeHelper.GetWeekInYearTime(2018, 1);
        }
    }
    
}
