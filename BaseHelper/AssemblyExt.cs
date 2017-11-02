using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelper
{
    public class AssemblyExt
    {
        /// <summary>
        /// 获取程序所在的目录
        /// </summary>
        /// <returns></returns>
        [Obsolete("不建议使用，此调用只适用桌面程序")]
        public string GetAssemblyPath()
        {
            string full = this.GetType().FullName;
            DirectoryInfo di = new DirectoryInfo(full);
            return di.Parent.FullName;
        }
        [Obsolete("不建议使用，此调用只适用于web程序")]
        public string GetWebAssemblyPath() 
        {
            return System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }
        /// <summary>
        /// 根据提供的程序类别（CS/BS获取程序对应目录）
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetAppDir(AppStruct type) 
        {
            string dir = string.Empty;
            switch (type)
            {
                case AppStruct.Web:
                    dir= GetWebAssemblyPath();
                    break;
                case AppStruct.WinApp:
                    dir= GetAssemblyPath();
                    break;
                default:
                    
                    break;
            }
            return dir;
        }
    }
    public enum AppStruct 
    {
        [Description("web网站类型")]
        Web=1,
        [Description("桌面应用程序")]
        WinApp=2
    }
}
