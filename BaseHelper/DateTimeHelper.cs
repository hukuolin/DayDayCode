using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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
        /// <summary>
        /// 计算某年总共存在多少周
        /// 规定每年的1月1号是当年的第一周，每周的第一天是星期日
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int GetYearSumWeek(int year)
        {
            DateTime time = new DateTime(2017,12,31);
            
            //计算着一年总共存在多少周
            CultureInfo ci = new CultureInfo("zh-CN");
            int index = ci.Calendar.GetWeekOfYear(time, ci.DateTimeFormat.CalendarWeekRule, DayOfWeek.Sunday);// ci.Calendar.GetWeekOfYear(time, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            //在手机日历上  2017-12-31 为周日，但是改天算为下一年的周次，【2017年只有52周】
            return index;
        } 
        public static int GetYearWeekCount(int strYear)
        {
            System.DateTime fDt = new DateTime(strYear);
            int k = Convert.ToInt32(fDt.DayOfWeek);//得到该年的第一天是周几
            if (k == 1)
            {
                int countDay = fDt.AddYears(1).AddDays(-1).DayOfYear;
                int countWeek = countDay / 7 + 1;
                return countWeek;
            }
            else
            {
                int countDay = fDt.AddYears(1).AddDays(-1).DayOfYear;
                int countWeek = countDay / 7 + 2;
                return countWeek;
            }
        }

        /// <summary>
        /// 该年总共有多少周
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static  int GetYearSumWeeks(int year)
        {
            GregorianCalendar gc = new GregorianCalendar();
            DateTime yearTime = new DateTime(year, 12, 31);
            int weekOfYear = gc.GetWeekOfYear(yearTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return weekOfYear;
        }
    }
}
