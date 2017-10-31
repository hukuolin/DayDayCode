using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace BaseHelper
{
    public static class XmlHelper
    {
        /// <summary>
        /// 从指定xml文件中读取，并将数据填写到模板中【 模板填充格式 {config}】
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlPath"></param>
        /// <param name="waitFillData">填充的数据</param>
        /// <returns></returns>
        public static string XmlTemplateFillData<T>(this string xmlPath,T waitFillData) where T:class 
        {
            string xml = ReadXml(xmlPath);//读取xml模板文件内容
            string[] pv = waitFillData.GetProperties();
            foreach (var item in pv)
            {
               string value=  waitFillData.GetPropertyValueString(item);
               xml = xml.Replace("{"+item+"}", value);
            }
            return xml;
        }
        static string  ReadXml(string xmlPath)
        {
            string text = string.Empty;
            if (!File.Exists(xmlPath)) 
            {//没有找到该xml文件
                return text;
            }
            FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            MemoryStream ms = new MemoryStream();
            fs.Seek(0, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs);
            text = sr.ReadToEnd();
            sr.Dispose();
            fs.Dispose();
            return text;
        } 

    }
}
