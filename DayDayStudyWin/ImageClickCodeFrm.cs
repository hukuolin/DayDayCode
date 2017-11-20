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
            //pbCodeImg.Visible = false;
            pbCodeImg.PictureBoxImage(AppConfig.CodeImg12306Dir);
            int w = pbCodeImg.Width, h = pbCodeImg.Height;
            int avgX = w / AppConfig.ImgNormal[0];
            int avgY = h / AppConfig.ImgNormal[1];
            //几行几列图片
            for (int row = 0; row <=AppConfig.ImgNormal[0]; row++)
            {
                for (int column = 0; column <= AppConfig.ImgNormal[1]; column++)
                {
                    int x = avgX * column + avgX / 2;
                    int y = avgY * row + avgY / 2;
                    PictureBox icon = new PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(icon)).BeginInit();
                    icon.Size = new Size(22, 22);
                    icon.PictureBoxImage(AppConfig.IConDir);
                    icon.Location = new Point(x+500, y);
                    icon.Name = EleTag.Icon.ToString() + (row * column);
                    icon.TabStop = false;
                    this.Controls.Add(icon);
                    ((System.ComponentModel.ISupportInitialize)(icon)).EndInit();
                }
            }
            //生成小图标
          
           
            this.ResumeLayout(false);
        }
    }
}
