using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace JustExample
{
    public class DllRelyWhere
    {
        public static void GetAllRely(string dllPath)
        {
            Assembly ass = Assembly.LoadFile(dllPath);
            foreach (CustomAttributeData item in ass.CustomAttributes)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void GetClass(string assemblyDir,string className) 
        {
            Assembly ass= Assembly.LoadFrom(assemblyDir);
            Dictionary<string, string> cls = new Dictionary<string, string>();
            foreach (Type item in ass.GetTypes().OrderBy(s=>s.Name))
            {
                cls.Add(item.Name, item.FullName);
            }
            Type t= ass.GetType(className);
        }
    }
}
