using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DayDayStudyWin
{
    public static class WinHelper
    {
        /// <summary>
        /// 查找子元素
        /// </summary>
        /// <param name="name">元素名称</param>
        /// <param name="childrens"></param>
        /// <returns></returns>
        public static Control FindChild(this Control.ControlCollection childrens,string name)
        {
            foreach (Control item in childrens)
            {
                if (item.Name == name.Trim())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
