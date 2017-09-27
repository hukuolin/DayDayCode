using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;
using DataProvider.IService;
using System.Data;
namespace DataProvider.Service.Oracle
{
    public class CrewDataService:ICrewDataService
    {
        public CrewDataService(string dbConnectionString) 
        {
           DbConnString = dbConnectionString;
        }
        public JsonData QueryMenus()
        {
            string queryMenusCmd = @"select Distinct l.parent_menu_tag,l.menu_tag,l.menu_text,l.form_name,
l.idx,l.image_name,l.order_n
from t_sys_menu_func l start with menu_tag in
(
    select t.menu_tag
    from t_sys_menu_func t,t_sys_role_func s
    Where t.menu_tag = s.menu_tag And s.menu_tag Like 'M%' 
    and t.module_flag='F'
    And s.enable_yn ='Y' 
    And s.role_code in (
    select distinct a.role_code from T_SYS_UNIT a ,T_SYS_UNIT_USER b where a.unit_id=b.unit_id 
          
    )
)
connect by prior parent_menu_tag = menu_tag 
Order by l.idx Asc,l.parent_menu_tag Asc,l.menu_tag Asc";
            CallOracleHelper call = new CallOracleHelper(true, DbConnString);
            JsonData json = new JsonData();
            DataSet ds= call.OracleQuery(queryMenusCmd);
            json.Data = ds;
            if (ds != null && ds.Tables.Count > 0) 
            {
                DataTable table = ds.Tables[0];
                json.Count = table.Rows.Count;
            }
            //throw new NotImplementedException();
            return json;
        }


        public void InitBaseParam()
        {
            DbConnString = string.Empty;
            Result = null;
            ExceptionMsg = string.Empty;
        }

        public string DbConnString
        {
            get;
           private set;
        }

        public bool? Result
        {
            get;
            set;
        }

        public string ExceptionMsg
        {
            get;
            set;
        }
    }
}
