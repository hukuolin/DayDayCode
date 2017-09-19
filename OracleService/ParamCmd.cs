using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
namespace OracleService
{
    public class ParamCmd
    {
        string ConnString;
        public ParamCmd(string oracleConnString)
        {
            ConnString = oracleConnString;
        }
        public DataSet Query(string cmd) 
        {
            OracleConnection conn = new OracleConnection(ConnString);
            try 
            {
                conn.Open();
                OracleCommand comm = new OracleCommand(cmd, conn);
                OracleDataAdapter da = new OracleDataAdapter(comm);
                DataSet ds=new DataSet();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }
        public void Excute(string cmd, params OracleParameter[] param) 
        {
            OracleConnection conn = new OracleConnection(ConnString);
            try 
            {
                conn.Open();
                OracleCommand comm = new OracleCommand();
                comm.Connection = conn;
                comm.CommandText = cmd;
                comm.Parameters.AddRange(param);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}
