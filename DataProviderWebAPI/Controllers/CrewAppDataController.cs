using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Http;
using System.Web.Mvc;
using WebModel;
using DataProvider.IService;
using DataProvider.Manage;
namespace DataProviderWebAPI.Controllers
{
    public class CrewAppDataController : Controller
    {
        [HttpGet]
        
        public JsonResult GetMenuCfg() 
        {
            JsonData json = new JsonData();
            ServiceFactory sf = new ServiceFactory();
            //sf.ConvertService(typeof(ICrewDataService), GlobalCfg.DbCategory);
            return Json(json,JsonRequestBehavior.AllowGet);
        } 

    }
}
