namespace CityPlanningGallery
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Xianzhuang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guihua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Fenxi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xianzhuang
            // 
            this.btn_Xianzhuang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Xianzhuang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Xianzhuang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xianzhuang.Image = global::CityPlanningGallery.Properties.Resources.现状图;
            this.btn_Xianzhuang.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Xianzhuang.Location = new System.Drawing.Point(36, 200);
            this.btn_Xianzhuang.Name = "btn_Xianzhuang";
            this.btn_Xianzhuang.Size = new System.Drawing.Size(220, 220);
            this.btn_Xianzhuang.TabIndex = 0;
            this.btn_Xianzhuang.Click += new System.EventHandler(this.btn_Xianzhuang_Click);
            this.btn_Xianzhuang.MouseEnter += new System.EventHandler(this.btn_Xianzhuang_MouseEnter);
            this.btn_Xianzhuang.MouseLeave += new System.EventHandler(this.btn_Xianzhuang_MouseLeave);
            // 
            // btn_Guihua
            // 
            this.btn_Guihua.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Guihua.Appearance.Options.UseBackColor = true;
            this.btn_Guihua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Guihua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guihua.Image = global::CityPlanningGallery.Properties.Resources.Urban_Planning;
            this.btn_Guihua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Guihua.Location = new System.Drawing.Point(294, 200);
            this.btn_Guihua.Name = "btn_Guihua";
            this.btn_Guihua.Size = new System.Drawing.Size(220, 220);
            this.btn_Guihua.TabIndex = 0;
            this.btn_Guihua.Click += new System.EventHandler(this.btn_Guihua_Click);
            this.btn_Guihua.MouseEnter += new System.EventHandler(this.btn_Xianzhuang_MouseEnter);
            this.btn_Guihua.MouseLeave += new System.EventHandler(this.btn_Xianzhuang_MouseLeave);
            // 
            // btn_Fenxi
            // 
            this.btn_Fenxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Fenxi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Fenxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fenxi.Image = global::CityPlanningGallery.Properties.Resources.home_fenxi;
            this.btn_Fenxi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Fenxi.Location = new System.Drawing.Point(543, 200);
            this.btn_Fenxi.Name = "btn_Fenxi";
            this.btn_Fenxi.Size = new System.Drawing.Size(220, 220);
            this.btn_Fenxi.TabIndex = 0;
            this.btn_Fenxi.Click += new System.EventHandler(this.btn_Fenxi_Click);
            this.btn_Fenxi.MouseEnter += new System.EventHandler(this.btn_Xianzhuang_MouseEnter);
            this.btn_Fenxi.MouseLeave += new System.EventHandler(this.btn_Xianzhuang_MouseLeave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(380, 444);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 31);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "规  划";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Location = new System.Drawing.Point(126, 444);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 31);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "现  状";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Location = new System.Drawing.Point(622, 444);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "分  析";
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(777, 25);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CityPlanningGallery.Properties.Resources.主页;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(837, 564);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Fenxi);
            this.Controls.Add(this.btn_Guihua);
            this.Controls.Add(this.btn_Xianzhuang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沈阳经济区国土规划";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Xianzhuang;
        private DevExpress.XtraEditors.SimpleButton btn_Guihua;
        private DevExpress.XtraEditors.SimpleButton btn_Fenxi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox btn_Close;
    }
}

