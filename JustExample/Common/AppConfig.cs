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
    }
}
