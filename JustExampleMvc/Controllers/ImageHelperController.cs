using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelper;
using WebModel;
namespace JustExampleMvc.Controllers
{
    [MvcRequestHelperAttribute]
    public class ImageHelperController : BaseController
    {
        //
        // GET: /ImageHelper/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult UploadImage(FormCollection form) //这里是表单数据
        {
            HttpFileCollectionBase files = Request.Files;//这里是文件
            if (files.Count == 0)
            {//没有选中文件 
            
            }
            HttpPostedFileBase file = files[0];
            file.SaveAs(GenerateFullFileNameNoType() + ".jpg");
            JsonData json = new JsonData();
            return Json(json);
        }
        [MvcRequestHelper]
        [MvcActionResultHelperAttribute]
        public JsonResult AppDebug(CommonRequestParam param) 
        {
            JsonData json = new JsonData();
            return Json(json);
        }
    }
}
