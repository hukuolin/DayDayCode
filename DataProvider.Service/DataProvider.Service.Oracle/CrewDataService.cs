using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;
using DataProvider.IService;
namespace DataProvider.Service.Oracle
{
    public class CrewDataService:ICrewDataService
    {
        public CrewDataService() 
        {
         //   DbConnString = dbConnectionString;
        }
        JsonData ICrewDataService.QueryMenus()
        {
            throw new NotImplementedException();
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
            set;
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
