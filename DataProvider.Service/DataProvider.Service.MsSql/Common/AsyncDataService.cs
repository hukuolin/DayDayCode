using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.IService;
using System.Data.SqlClient;
namespace DataProvider.Service.MsSql
{
    public class SyncDataService<T>:IAsyncDataService<T> where T:class
    {
        public SyncDataService(string  connstring) //where T:class
        {
            SqlConnString = connstring;
        }
        private string _SqlConnString;
        public string SqlConnString
        {
            get
            {
                return _SqlConnString;
            }
            private set
            {
                _SqlConnString = value;
            }
        }

        public int Count(string cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(SqlConnString);
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);
                int row = (int)comm.ExecuteScalar();
                conn.Close();
                return row;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int ExecuteNoQuery(string cmd) 
        {
            try
            {
                SqlConnection conn = new SqlConnection(SqlConnString);
                conn.Open();
                SqlCommand comm = new SqlCommand(cmd, conn);
                int row = comm.ExecuteNonQuery();
                conn.Close();
                return row;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
