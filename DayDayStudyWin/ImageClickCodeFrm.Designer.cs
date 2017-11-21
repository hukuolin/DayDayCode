namespace DayDayStudyWin
{
    partial class ImageClickCodeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbMouse = new System.Windows.Forms.RichTextBox();
            this.pbCodeImg = new System.Windows.Forms.PictureBox();
            this.lsbSmallIcon = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMouse
            // 
            this.rtbMouse.Location = new System.Drawing.Point(311, 12);
            this.rtbMouse.Name = "rtbMouse";
            this.rtbMouse.Size = new System.Drawing.Size(229, 171);
            this.rtbMouse.TabIndex = 8;
            this.rtbMouse.Text = "";
            // 
            // pbCodeImg
            // 
            this.pbCodeImg.Location = new System.Drawing.Point(13, 13);
            this.pbCodeImg.Name = "pbCodeImg";
            this.pbCodeImg.Size = new System.Drawing.Size(292, 310);
            this.pbCodeImg.TabIndex = 9;
            this.pbCodeImg.TabStop = false;
            // 
            // lsbSmallIcon
            // 
            this.lsbSmallIcon.FormattingEnabled = true;
            this.lsbSmallIcon.ItemHeight = 12;
            this.lsbSmallIcon.Location = new System.Drawing.Point(312, 190);
            this.lsbSmallIcon.Name = "lsbSmallIcon";
            this.lsbSmallIcon.Size = new System.Drawing.Size(228, 124);
            this.lsbSmallIcon.TabIndex = 10;
            // 
            // ImageClickCodeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 329);
            this.Controls.Add(this.lsbSmallIcon);
            this.Controls.Add(this.pbCodeImg);
            this.Controls.Add(this.rtbMouse);
            this.Name = "ImageClickCodeFrm";
            this.Text = "ImageClickCodeFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMouse;
        private System.Windows.Forms.PictureBox pbCodeImg;
        private System.Windows.Forms.ListBox lsbSmallIcon;
    }
}