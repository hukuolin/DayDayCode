using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
namespace BaseHelper
{
    public static class ReflectorHelper
    {
        /// <summary>
        /// 获取实体类的全部属性
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string[] GetProperties<T>(this T obj) where T:class
        {
           //Type t= typeof(T).GetType();//获取到的属性与实际属性不一致
            Type t = System.Activator.CreateInstance<T>().GetType();
           PropertyInfo[] pi = t.GetProperties();//实体自定义的全部属性
           string[] pns= t.GetProperties().Select(s => s.Name).ToArray();
           return pns;
        }
        /// <summary>
        /// 根据 提供的属性名获取该属性的值内容的字符串
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="obj">具体的实体</param>
        /// <param name="propertyName">属性名</param>
        /// <returns>字符串</returns>
        public static string GetPropertyValueString<T>(this T obj,string propertyName) where T : class
        {
            Type t=obj.GetType() ;//System.Activator.CreateInstance<T>().GetType();
            PropertyInfo pi= t.GetProperty(propertyName);
            //此处需要判断该该属性的数据类型是否对应class
            Type pt = pi.PropertyType;//该属性的数据类型
            if (pt.IsPrimitive) 
            {//是否为基源数据类型
            
            }
            string value = string.Empty;
            object pv= pi.GetValue(obj, null);
            if (pv == null) 
            {
                return null;
            }
            return pv.ToString();
        }
        public static void SetPropertyValue<T>(this T obj,string propertyName,object value) where T:class 
        {
            Type entity = obj.GetType();
            PropertyInfo pi= entity.GetProperty(propertyName);
            if (pi == null)
            {//没有改属性 
                return;
            }
            Type t = pi.PropertyType;//需要判断属性的值是否为可空类型，如果为可空类型不能直接进行类型转换
            if (t.Name != typeof(Nullable<>).Name)
            {
                pi.SetValue(obj, Convert.ChangeType(value, t,null));
            }
            else 
            {
                NullableConverter nullableConverter = new NullableConverter(t);//如何获取可空类型属性非空时的数据类型
                Type nt = nullableConverter.UnderlyingType;
                pi.SetValue(obj, Convert.ChangeType(value, nt), null);
            }
        }
    }
}
