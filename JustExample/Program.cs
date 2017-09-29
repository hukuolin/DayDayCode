using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace JustExample
{
    class Program
    {
        static void Main(string[] args)
        {

            DllRelyWhere.GetAllRely(@"E:\Code\AirCode\20代码\HNAiCrew\Library\ICrew\Oracle.DataAccess.dll");
            OrclHandler orcl = new OrclHandler();
            DataSet d= orcl.TestRemote();
          //  orcl.Query();
            RemoteWcf.RemoteDataServiceClient wcf = new RemoteWcf.RemoteDataServiceClient();
            DataSet ds= wcf.GetAllAirAccount();
            Console.Read();
        }
        static void Example() 
        {
            string list = "beijing 北京,beijingxistation 北京西站,beijingnan 北京南站,jiangxi 江西,jiangxnanchan 江西南昌,shanghai,nanchan 南昌";
            string now = "beijing 北京,jiangxi 江西";
            string[] all = list.Split(',');
            List<string> maybe = new List<string>();
            List<string> selelct = new List<string>();
            foreach (string item in all)
            {
                if (now.Contains(item))
                {
                    selelct.Add(item);
                }
                else 
                {
                    maybe.Add(item);
                }
            }
        }
    }
}
