using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.IO;
namespace JustExampleMvc.Controllers
{
    public class BaseController : Controller
    {
        public string GetUploadDir()
        {
            return Server.MapPath("/Upload");
        }
        /// <summary>
        /// 获取当今天所属的周次序列
        /// </summary>
        /// <returns></returns>
        public int GetWeekIndex()
        {
            GregorianCalendar gc = new GregorianCalendar();
            return gc.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
        /// <summary>
        /// 获取当前时间到秒的字符串
        /// </summary>
        /// <returns></returns>
        public string GetNowString() 
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        /// <summary>
        /// 生成不包含文件类型的全目录名称
        /// </summary>
        /// <returns></returns>
        public string GenerateFullFileNameNoType()
        {
            string dir = GetUploadDir() + "/" + GetWeekIndex();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir+ "/" + GetNowString();
        }
    }
}
