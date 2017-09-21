using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleService;
using System.Data;
using System.Data.OracleClient;
namespace JustExample
{
    public class OrclHandler
    {
        public void Query() 
        {
            ParamCmd pc = new ParamCmd(AppConfig.DbConnString);
            string cmd = @"insert into Category (id,name,key,DataDesc,ItemSort,createtime,updatetime)
                            values(:id,:name,:key,:DataDesc,:ItemSort,:createtime,:updatetime)";
            List<OracleParameter> orcl = new List<OracleParameter>();
            orcl.Add(new OracleParameter(":id", Guid.NewGuid().ToString()));
            orcl.Add(new OracleParameter(":name","AppConfig"));
            orcl.Add(new OracleParameter(":key", "AppConfigKey"));
            orcl.Add(new OracleParameter(":DataDesc", "data description=AppConfig"));
            orcl.Add(new OracleParameter(":ItemSort", 1));
            DateTime time = DateTime.Now;
            orcl.Add(new OracleParameter(":createtime", time));
            orcl.Add(new OracleParameter(":updatetime", time));
            pc.Excute(cmd, orcl.ToArray());
            //DataSet ds=pc.Query(" select * from Category");
        }
        public void BatchInsert(int size)
        {
        
        }
    }
}
