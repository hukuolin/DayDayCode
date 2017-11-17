using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataProvider.Service.Oracle
{
   
    public class CallOracleHelper
    {
        public bool userMicrosoftClient { get; private set; }
        public string dbConnectionString { get;private set; }
        public CallOracleHelper(bool useOracleClient, string connectionString) 
        {
            userMicrosoftClient = useOracleClient;
            dbConnectionString = connectionString;
        }
        public DataSet OracleQuery  (string cmd) 
        {
            DataSet ds = new DataSet();
            if (userMicrosoftClient) 
            {
                OracleClient oc = new OracleClient();
               ds= oc.RunQuery(cmd, dbConnectionString);
            }
            return ds;
        }
    }
}
