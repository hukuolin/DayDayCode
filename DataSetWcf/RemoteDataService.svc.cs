using OracleService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DataSetWcf
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class RemoteDataService : IRemoteDataService
    {
        public DataSet GetAllAirAccount()
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
            DataSet ds = pm.Query(sql);
            return ds;
        }
    }
}
