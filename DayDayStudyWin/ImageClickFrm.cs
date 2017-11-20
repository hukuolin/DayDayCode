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
    public partial class ImageClickFrm : Form
    {
        enum EleTag 
        {
            Icon=1
        }
        int smallImgW=0, smallImgH=0;
        public ImageClickFrm()
        {
            InitializeComponent();
              
            InitImage();
        }
        void InitImage()
        {
            pbCodeImg.Image = Bitmap.FromFile(AppConfig.CodeImg12306Dir);
            pbCodeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            InitIcon(pbIcon1);
            InitIcon(pbIcon2);
            InitIcon(pbIcon3);
            InitIcon(pbIcon4);
            InitIcon(pbIcon5);
            InitIcon(pbIcon6);
            pbCodeImg.Click += new EventHandler(PictureBox_Click);
            int w = pbCodeImg.Width;
            int h = pbCodeImg.Height;
            smallImgW = w / AppConfig.ImgNormal[0];
            smallImgH = h / AppConfig.ImgNormal[1];
        }
        void InitIcon(PictureBox pb)
        {
            pb.Tag = EleTag.Icon.ToString();
            pb.Size = new System.Drawing.Size(24, 24);
            pb.Image = Bitmap.FromFile(AppConfig.IConDir);
            pb.Visible = false;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;
           
            int x = mouse.X / smallImgW + (mouse.X % smallImgW>0?1:0);
            int y = mouse.Y / smallImgH + (mouse.Y % smallImgH > 0 ? 1 : 0);
            string icon = "pbIcon"+(AppConfig.ImgNormal[0]*(y-1)+x);
            rtbMouse.Text += mouse.X + "\t" + mouse.Y+"\t"+icon + "\r\n";
            Control iconEle = this.Controls.FindChild(icon);
            if (iconEle != null)
            {
                iconEle.Visible = !iconEle.Visible;
            }
        }

    }
}
