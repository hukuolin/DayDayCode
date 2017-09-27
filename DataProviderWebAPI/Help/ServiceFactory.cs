using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.IO;
using BaseHelper;

namespace DataProviderWebAPI
{
    public class ServiceFactory
    {
        static string AssemblyDir;
        public void ConvertService(Type interfaceType, DBType db) 
        {//实例化的接口关系 实例化 name=I+name
            string name = interfaceType.Name;
            //程序集的位置
            if (string.IsNullOrEmpty(AssemblyDir))
            {
                AssemblyExt ext = new AssemblyExt();
                AssemblyDir = ext.GetWebAssemblyPath();
            }
            //如何根据接口实例化具体的实现类
        }
    }
   
}