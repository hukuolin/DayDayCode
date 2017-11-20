using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayDayStudyWin
{
    public partial class ImageClickCodeFrm : Form
    {
        public ImageClickCodeFrm()
        {
            InitializeComponent();
            InitPicture();
        }
        void InitPicture() 
        {
            pbCodeImg.PictureBoxImage(AppConfig.CodeImg12306Dir);
            //生成小图标
            PictureBox icon = new PictureBox();
            icon.Size = new Size(22, 22);
            icon.PictureBoxImage(AppConfig.IConDir);
        }
    }
}
