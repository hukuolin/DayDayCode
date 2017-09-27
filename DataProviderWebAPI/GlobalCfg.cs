using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using WebModel;
namespace DataProviderWebAPI
{
   
    public class GlobalCfg
    {
        static string connCfg = "ConnString";
        public static Dictionary<string, string> DbConnectionString = new Dictionary<string, string>();
        public static DBType DbCategory;
        /// <summary>
        /// 初始化数据库连接字符串
        /// </summary>
        public void InitDBConnection()
        {
            string[] fields= Enum.GetNames(typeof(DBType));
            DbConnectionString = new Dictionary<string, string>();
            foreach (string item in fields)
            {
                ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[connCfg + "." + item];
                string value=cfg==null?null:cfg.ConnectionString;
                DbConnectionString.Add(item, value);
            }
            string db = ConfigurationManager.AppSettings[typeof(DBType).Name];
            Enum.TryParse(db, out DbCategory);
        }
        public string GetConnectionString(DBType db)
        {
            if (DbConnectionString.Count == 0) 
            {
                InitDBConnection();
            }
            string key=connCfg + "." + db.ToString();
            if (!DbConnectionString.ContainsKey(key) || DbConnectionString[key] == null)
            {
                ConnectionStringSettings item = ConfigurationManager.ConnectionStrings[key];
                if (item == null) 
                {
                    return null;
                }
                return item.ConnectionString;
            }
            return DbConnectionString[key];

        }
    }
    
}