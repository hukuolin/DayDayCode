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
    }
}
