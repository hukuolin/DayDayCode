using System;
using System.Collections.Generic;
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
        public string GetAssemblyPath()
        {
            string full = this.GetType().FullName;
            DirectoryInfo di = new DirectoryInfo(full);
            return di.Parent.FullName;
        }
        public string GetWebAssemblyPath() 
        {
            return System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }
    }
}
