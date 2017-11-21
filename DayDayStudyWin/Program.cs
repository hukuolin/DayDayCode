using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BaseHelper;
namespace DayDayStudyWin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImageClickCodeFrm());
        }
    }
    public class AppConfig
    {
        static string dir;
        public static string Dir
        {
            get {
                if (string.IsNullOrEmpty(dir))
                dir= new AssemblyExt().GetAppDir(AppStruct.WinApp);
                return dir;
            }
        }
        /// <summary>
        /// 图标的路径信息
        /// </summary>
        public static string IConDir 
        {
            get 
            {
                string releative = ConfigurationManager.AppSettings["Icon"];
                return Dir + releative;
            }
        }
        public static string CodeImg12306Dir
        {
            get
            {
                string releative = ConfigurationManager.AppSettings["VerifyCodeImg12306"];
                return Dir + releative;
            }
        }
        /// <summary>
        /// 图片排列模式
        /// </summary>
        public static int[] ImgNormal

        {
            get 
            {
                string cfg = ConfigurationManager.AppSettings["CodeImgNormal"];
                string[] items = cfg.Split('*');
                int[] xy = new int[2];
                xy[0] = int.Parse(items[0]);
                xy[1] = int.Parse(items[1]);
                return xy;
            }
        }
        /// <summary>
        /// 12306验证码的文本提示高度
        /// </summary>
        public static int CodeTextHeightIn12306
        {
            get 
            {
                string cfg = ConfigurationManager.AppSettings["CodeTextHeightIn12306"];
                int h = 50;
                if (!string.IsNullOrEmpty(cfg))
                {
                    h = int.Parse(cfg);
                }
                return h;
            }
        }
        public static int SmallIconSpanPXIn12306 
        {
            get 
            {
                string cfg = ConfigurationManager.AppSettings["CodeIconSpanPXIn12306"];
                return int.Parse(cfg);
            }
        }
    }
}
