namespace CityPlanningGallery
{
    partial class frmGuihuaGallery
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
            this.flowLayoutPanel_Guihua = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_PreViewMapTitle = new DevExpress.XtraEditors.LabelControl();
            this.pic_PreView = new System.Windows.Forms.PictureBox();
            this.lbl_Close = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Guihua
            // 
            this.flowLayoutPanel_Guihua.AutoScroll = true;
            this.flowLayoutPanel_Guihua.Location = new System.Drawing.Point(64, 54);
            this.flowLayoutPanel_Guihua.Name = "flowLayoutPanel_Guihua";
            this.flowLayoutPanel_Guihua.Size = new System.Drawing.Size(340, 486);
            this.flowLayoutPanel_Guihua.TabIndex = 0;
            // 
            // lbl_PreViewMapTitle
            // 
            this.lbl_PreViewMapTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lbl_PreViewMapTitle.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreViewMapTitle.Location = new System.Drawing.Point(569, 362);
            this.lbl_PreViewMapTitle.Name = "lbl_PreViewMapTitle";
            this.lbl_PreViewMapTitle.Size = new System.Drawing.Size(0, 19);
            this.lbl_PreViewMapTitle.TabIndex = 2;
            // 
            // pic_PreView
            // 
            this.pic_PreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_PreView.Location = new System.Drawing.Point(478, 100);
            this.pic_PreView.Name = "pic_PreView";
            this.pic_PreView.Size = new System.Drawing.Size(319, 256);
            this.pic_PreView.TabIndex = 1;
            this.pic_PreView.TabStop = false;
            // 
            // lbl_Close
            // 
            this.lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.Location = new System.Drawing.Point(811, 24);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(22, 19);
            this.lbl_Close.TabIndex = 3;
            this.lbl_Close.Text = " × ";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // frmGuihuaGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_PreViewMapTitle);
            this.Controls.Add(this.pic_PreView);
            this.Controls.Add(this.flowLayoutPanel_Guihua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuihuaGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuihuaGallery";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Guihua;
        private System.Windows.Forms.PictureBox pic_PreView;
        private DevExpress.XtraEditors.LabelControl lbl_PreViewMapTitle;
        private DevExpress.XtraEditors.LabelControl lbl_Close;
    }
}