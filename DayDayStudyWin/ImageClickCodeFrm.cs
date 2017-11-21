﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DayDayStudyWin
{
    public partial class ImageClickCodeFrm : Form
    {
        public ImageClickCodeFrm()
        {
            InitializeComponent();
            InitWaterText(pbCodeImg);
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
        void InitWaterText(PictureBox pb)
        { //使用水印形式来实现
           // pb.PictureBoxImage(AppConfig.CodeImg12306Dir);
            Image img = Bitmap.FromFile(AppConfig.CodeImg12306Dir);
            Graphics g = Graphics.FromImage(img);
            int w=img.Width/AppConfig.ImgNormal[0];
            int h=img.Height/AppConfig.ImgNormal[1];
            //在图片上生成水印
            for (int row = 0; row <=AppConfig.ImgNormal[0]; row++)
            {
                for (int column = 0; column <=AppConfig.ImgNormal[1]; column++)
                {
                    int x = w * column + w / 2;
                    int y = h * row + h / 2;
                    Image icon = Bitmap.FromFile(AppConfig.IConDir);
                    int[] showPX = new int[] { 32, 32 };
                    //需要调整图标的大小 22*22
                    Bitmap targetImg = new System.Drawing.Bitmap(showPX[0], showPX[1]);
                    
                    Graphics iconImg = Graphics.FromImage((Image)targetImg);
                    iconImg.DrawImage(icon, 0, 0, targetImg.Width, targetImg.Height);
                    g.DrawImage(targetImg, new Point(x, y));
                }
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = img;
        }
    }
}
