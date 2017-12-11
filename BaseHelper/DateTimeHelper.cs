using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelper
{
    public class DateTimeHelper
    {
        /// <summary>
        /// 查询x年中y周日期区间【周日作为每周的第一天】
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="weekIndex">第几周</param>
        public static void  GetWeekInYearTime(int year,int weekIndex) 
        {
            DateTime begin = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int startWeekDay = (int)begin.DayOfWeek;//当前年第一天是星期几
            DateTime first, sunday;//周一到周日
            if (weekIndex == 1)
            {
                first = begin;
                sunday = begin.AddDays(6 - startWeekDay);//从这一年开始的周次信息【如果第一周是包含上一年的日期，则从第一天开始往后推到周日】
            }
            else
            {
              first=  begin.AddDays(7 - startWeekDay + (weekIndex - 2) * 7);
              sunday= first.AddDays(6);
            }
        }
    }
}
