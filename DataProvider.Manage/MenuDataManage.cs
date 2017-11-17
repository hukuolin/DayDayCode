using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;
using DataProvider.IService;
namespace DataProvider.Manage
{
    public class MenuDataManage
    {
        ICrewDataService crewService;
        public MenuDataManage(ICrewDataService crew) 
        {
            crewService = crew;
        }
        public JsonData  QueryMenus() 
        {
           JsonData json=  crewService.QueryMenus();
           return json;
        }
    }
}
