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
            orcl.TestRemote();
            orcl.Query();
            RemoteWcf.RemoteDataServiceClient wcf = new RemoteWcf.RemoteDataServiceClient();
            DataSet ds= wcf.GetAllAirAccount();
            Console.Read();
        }
    }
}
