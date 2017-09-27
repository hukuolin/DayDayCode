using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleService;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
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
            try
            {
                pc.Excute(cmd, orcl.ToArray());
            }
            catch (Exception ex) 
            {
            
            }
            //DataSet ds=pc.Query(" select * from Category");
        }
        public void BatchInsert(int size)
        {
        
        }
        public DataSet TestRemote() 
        {
            string connString = ConfigurationManager.AppSettings["SMPSDBConnection"];
            ParamCmd pm = new ParamCmd(connString);
            string sql = @"select t.User_Name,
                                       t.USER_CODE,
                                       t.PASSWORDS,
                                       t.DEPT_CODE,
                                       s.dept_name, s.filiale,
                                       t.SEX,
                                       t.PHONE,
                                       t.PASS_MODIFY_DATE,
                                       t.PASS_VALID_DATE,
                                       t.VALID_FLAG,
                                       t.VALID_DATE,
                                       t.E_MAIL,
                                       t.AccessType,
                                       S.valid_flag Module_Flag,
                                       t.AD_ACTIVE,
                                       t.PHOTO_URL
                                  from T_SYS_USER t, t_sys_dept s
                                 Where t.dept_code = s.dept_code";
            DataSet ds= pm.Query(sql);
            return ds;
        }
    }
}
