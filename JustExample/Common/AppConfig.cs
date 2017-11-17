using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustExample
{
    public class AppConfig
    {
        static string connString;
        /// <summary>
        /// 主数据库连接字符串
        /// </summary>
        public static string DbConnString 
        {
            get
            {
                if(string.IsNullOrEmpty(connString))
                    connString = ConfigurationManager.AppSettings["MainDbConnString"];
                return connString;
            }
        }
        public static string FSOPTocken
        {
            get
            {
                return ConfigurationManager.AppSettings["FsopTocken"];
            }
        }
        /// <summary>
        /// 已采集的腾讯数据连接字符串
        /// </summary>

        public static string UinDataConnString
        {
            get 
            {
                return ConfigurationManager.AppSettings["UinDataConnString"];
            }
        }
        /// <summary>
        /// 统计腾讯账户数据的sql命令
        /// </summary>
        public static string CountUinCmd
        {
            get 
            {
                return ConfigurationManager.AppSettings["CountUinData"];
            }
        }
        public static string SyncGatherDateIntSql
        {
            get 
            {
                return ConfigurationManager.AppSettings["SyncGatherDateIntSql"];
            }
        }
    }
}
