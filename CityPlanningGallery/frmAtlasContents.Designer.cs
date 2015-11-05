namespace CityPlanningGallery
{
    partial class frmAtlasContents
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
            this.flowLayoutPanel_Status = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Planning = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Analysis = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Status
            // 
            this.flowLayoutPanel_Status.AutoScroll = true;
            this.flowLayoutPanel_Status.Location = new System.Drawing.Point(42, 90);
            this.flowLayoutPanel_Status.Name = "flowLayoutPanel_Status";
            this.flowLayoutPanel_Status.Size = new System.Drawing.Size(325, 540);
            this.flowLayoutPanel_Status.TabIndex = 5;
            this.flowLayoutPanel_Status.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            this.flowLayoutPanel_Status.MouseLeave += new System.EventHandler(this.flowLayoutPanel_MouseLeave);
            // 
            // flowLayoutPanel_Planning
            // 
            this.flowLayoutPanel_Planning.AutoScroll = true;
            this.flowLayoutPanel_Planning.Location = new System.Drawing.Point(384, 90);
            this.flowLayoutPanel_Planning.Name = "flowLayoutPanel_Planning";
            this.flowLayoutPanel_Planning.Size = new System.Drawing.Size(325, 540);
            this.flowLayoutPanel_Planning.TabIndex = 6;
            this.flowLayoutPanel_Planning.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            this.flowLayoutPanel_Planning.MouseLeave += new System.EventHandler(this.flowLayoutPanel_MouseLeave);
            // 
            // flowLayoutPanel_Analysis
            // 
            this.flowLayoutPanel_Analysis.AutoScroll = true;
            this.flowLayoutPanel_Analysis.Location = new System.Drawing.Point(726, 90);
            this.flowLayoutPanel_Analysis.Name = "flowLayoutPanel_Analysis";
            this.flowLayoutPanel_Analysis.Size = new System.Drawing.Size(325, 540);
            this.flowLayoutPanel_Analysis.TabIndex = 7;
            this.flowLayoutPanel_Analysis.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            this.flowLayoutPanel_Analysis.MouseLeave += new System.EventHandler(this.flowLayoutPanel_MouseLeave);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(1058, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackgroundImage = global::CityPlanningGallery.Properties.Resources.return_black;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Location = new System.Drawing.Point(1017, 12);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(35, 35);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.TabStop = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Return.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(105, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 38);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "国土资源现状图";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Location = new System.Drawing.Point(441, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(203, 38);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "国土资源规划图";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Location = new System.Drawing.Point(788, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(203, 38);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "国土资源分析图";
            // 
            // frmAtlasContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.flowLayoutPanel_Analysis);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.flowLayoutPanel_Planning);
            this.Controls.Add(this.flowLayoutPanel_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtlasContents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "规划图集";
            this.Load += new System.EventHandler(this.frmAtlasContents_Load);
            this.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Planning;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Analysis;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Return;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}