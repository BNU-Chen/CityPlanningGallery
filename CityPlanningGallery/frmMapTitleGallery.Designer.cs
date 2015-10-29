namespace CityPlanningGallery
{
    partial class frmMapTitleGallery
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
            this.flowLayoutPanel_GalleryItem = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_PreViewMapTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.PictureBox();
            this.pic_PreView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_GalleryItem
            // 
            this.flowLayoutPanel_GalleryItem.AutoScroll = true;
            this.flowLayoutPanel_GalleryItem.Location = new System.Drawing.Point(47, 54);
            this.flowLayoutPanel_GalleryItem.Name = "flowLayoutPanel_GalleryItem";
            this.flowLayoutPanel_GalleryItem.Size = new System.Drawing.Size(340, 486);
            this.flowLayoutPanel_GalleryItem.TabIndex = 0;
            // 
            // lbl_PreViewMapTitle
            // 
            this.lbl_PreViewMapTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lbl_PreViewMapTitle.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreViewMapTitle.Location = new System.Drawing.Point(551, 378);
            this.lbl_PreViewMapTitle.Name = "lbl_PreViewMapTitle";
            this.lbl_PreViewMapTitle.Size = new System.Drawing.Size(0, 19);
            this.lbl_PreViewMapTitle.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close_icon;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(797, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // btn_Return
            // 
            this.btn_Return.BackgroundImage = global::CityPlanningGallery.Properties.Resources.return_left;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Location = new System.Drawing.Point(750, 13);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(30, 30);
            this.btn_Return.TabIndex = 5;
            this.btn_Return.TabStop = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Return.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // pic_PreView
            // 
            this.pic_PreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_PreView.Location = new System.Drawing.Point(427, 92);
            this.pic_PreView.Name = "pic_PreView";
            this.pic_PreView.Size = new System.Drawing.Size(400, 273);
            this.pic_PreView.TabIndex = 1;
            this.pic_PreView.TabStop = false;
            // 
            // frmMapTitleGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_PreViewMapTitle);
            this.Controls.Add(this.pic_PreView);
            this.Controls.Add(this.flowLayoutPanel_GalleryItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMapTitleGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuihuaGallery";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_GalleryItem;
        private System.Windows.Forms.PictureBox pic_PreView;
        private DevExpress.XtraEditors.LabelControl lbl_PreViewMapTitle;
        private System.Windows.Forms.PictureBox btn_Return;
        private System.Windows.Forms.PictureBox btn_Close;
    }
}