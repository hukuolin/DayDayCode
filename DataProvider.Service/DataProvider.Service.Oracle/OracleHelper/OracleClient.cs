using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
namespace DataProvider.Service.Oracle
{
    class OracleClient
    {
        public DataSet RunQuery(string cmd,string connectionString) 
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand comm = new OracleCommand(cmd,conn);
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = comm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
