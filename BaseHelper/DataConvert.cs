using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelper
{
    public static class DataConvert
    {
        /// <summary>
        /// 转换为2进制字符串
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Convert01(this long value) 
        {
            long a, b = 0;
            int i=0;
            while (value > 0)
            {
                a = value % 2;
                value = value / 2;
                b = b + a * Pow(10, i);
                i++;
            }
           return b.ToString();
        }
        private static long Pow(long x, long y)
        {
            long i = 1;
            long X = x;
            if (y <= 0)
            {
                return 1;
            }
            while (i < y)
            {
                x = x * X;
                i++;
            }
            return x;
        }
    }
}
