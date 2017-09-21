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
            {//如果数据库可以连接此时才需要进行数据库的关闭
            
            }
        }
        public void ListChange(string cmd,List<OracleParameter[]> param) 
        {
            OracleConnection conn = new OracleConnection(ConnString);
            try
            {
                conn.Open();
                OracleCommand comm = new OracleCommand();
                Console.WriteLine("only open once->");
                Console.WriteLine("Start:->" + DateTime.Now);
                comm.CommandText = cmd;
                foreach (OracleParameter[]  items in param)
                {
                    comm.Parameters.AddRange(items);
                    comm.ExecuteNonQuery();
                }
                Console.WriteLine("End->"+DateTime.Now);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
