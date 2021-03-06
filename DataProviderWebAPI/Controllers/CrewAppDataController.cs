﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Http;
using System.Web.Mvc;
using WebModel;
using DataProvider.IService;
using DataProvider.Manage;
using DataProvider.Service.Oracle;
using System.Web.Services;
using System.ServiceModel.Web;
namespace DataProviderWebAPI.Controllers
{
    public class CrewAppDataController : Controller
    {
        [HttpGet]
        //[WebMethod()]
        [WebInvoke(Method="Get")]
        public JsonResult GetMenuCfg() 
        {
            JsonData json = new JsonData();
            ServiceFactory sf = new ServiceFactory();
            #region 此处需要使用工厂模式实现接口的实例化
            ICrewDataService crew = new CrewDataService(GlobalCfg.DbConnectionString[GlobalCfg.DbCategory.ToString()]);
            #endregion 此处需要使用工厂模式实现接口的实例化
            MenuDataManage menu = new MenuDataManage(crew);
            json= menu.QueryMenus();
            return Json(json,JsonRequestBehavior.AllowGet);
        } 

    }
}
