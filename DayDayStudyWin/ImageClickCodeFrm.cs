using System;
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
            InitEle();
            InitWaterText(pbCodeImg);
        }
        void InitEle() 
        {
            pbCodeImg.Click += new EventHandler(PictureBox_Click);
        }
        Dictionary<int, int[]> selectIcon = new Dictionary<int, int[]>();
        int avgX = 50, avgY = 50;//每张小图片平均像素
        /// <summary>
        /// 计算合成图中每张小图片的实际高度
        /// </summary>
        /// <param name="pictureHeight"></param>
        /// <returns></returns>
        int CalculateIconHeight(int pictureHeight) 
        {
            int iconsHeight = pictureHeight - AppConfig.CodeTextHeightIn12306;//这是合成图实际上高度
            return iconsHeight / AppConfig.ImgNormal[1];
        }
        void InitPicture() 
        {
            //pbCodeImg.Visible = false;
            pbCodeImg.PictureBoxImage(AppConfig.CodeImg12306Dir);
            int w = pbCodeImg.Width, h = pbCodeImg.Height;
            avgX = w / AppConfig.ImgNormal[0];
            avgY = CalculateIconHeight(h);
            //几行几列图片
            for (int row = 0; row <=AppConfig.ImgNormal[1]; row++)
            {
                for (int column = 0; column <= AppConfig.ImgNormal[0]; column++)
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
        void PictureBox_Click(object sender,EventArgs e)
        {//点击效果
            MouseEventArgs mouse = e as MouseEventArgs;
            //判断当前点击的是那个小图片
            int column = mouse.X / avgX;// +(mouse.X % avgX > 0 ? 1 : 0);//当前点击为第几列
            int row = (mouse.Y-AppConfig.CodeTextHeightIn12306) / avgY;
            rtbMouse.Text += mouse.X + "\t" + mouse.Y+"\r\n";
            lsbSmallIcon.Items.Add("Icon: r=" + row + "\tc=" + column);
            int index = row * AppConfig.ImgNormal[1] + column;
            if (selectIcon.ContainsKey(index))
            { //
                selectIcon.Remove(index);
            }
            else 
            {
                selectIcon.Add(index, new int[]{ column,row});
            }
            InitWaterText(pbCodeImg);
        }
        void InitWaterText(PictureBox pb)
        { //使用水印形式来实现
           // pb.PictureBoxImage(AppConfig.CodeImg12306Dir);
            Image img = Bitmap.FromFile(AppConfig.CodeImg12306Dir);
            Graphics g = Graphics.FromImage(img);
            avgX = img.Width / AppConfig.ImgNormal[0] + AppConfig.SmallIconSpanPXIn12306;
            //图片宽高 和控件的宽高不是同一单位
            avgY = CalculateIconHeight(img.Height) + AppConfig.SmallIconSpanPXIn12306;//小图片的平均高度
            foreach (var item in selectIcon)
            {
                int[] iconLocation = item.Value;
                int x = avgX * iconLocation[0] + 1 * avgX / 5;
                int y = avgY * iconLocation[1] + 3 * avgY / 5;
                ImageInsertIcon(new Point(x, y), g);
            }
            pb.Width = img.Width;
            pb.Height = img.Height;
            //pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = img;
            g.Dispose();
        }
        void ImageInsertIcon(Point size, Graphics g)
        {
            Image icon = Bitmap.FromFile(AppConfig.IConDir);
            int[] showPX = new int[] { 26, 26 };
            //需要调整图标的大小 22*22
            Bitmap targetImg = new System.Drawing.Bitmap(showPX[0], showPX[1]);
            Graphics iconImg = Graphics.FromImage((Image)targetImg);
            iconImg.DrawImage(icon, 0, 0, targetImg.Width, targetImg.Height);
            iconImg.Dispose();
            g.DrawImage(targetImg, size);
            targetImg.Dispose();
            icon.Dispose();
        }
    }
}
