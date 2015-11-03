namespace CityPlanningGallery
{
    partial class frmThematicDocContents
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
            this.flowLayoutPanel_ThematicDoc = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.PictureBox();
            this.pic_PreView = new System.Windows.Forms.PictureBox();
            this.lbl_PreViewMapTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_ThematicDoc
            // 
            this.flowLayoutPanel_ThematicDoc.AutoScroll = true;
            this.flowLayoutPanel_ThematicDoc.Location = new System.Drawing.Point(40, 100);
            this.flowLayoutPanel_ThematicDoc.Name = "flowLayoutPanel_ThematicDoc";
            this.flowLayoutPanel_ThematicDoc.Size = new System.Drawing.Size(340, 400);
            this.flowLayoutPanel_ThematicDoc.TabIndex = 5;
            this.flowLayoutPanel_ThematicDoc.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            this.flowLayoutPanel_ThematicDoc.MouseLeave += new System.EventHandler(this.flowLayoutPanel_MouseLeave);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close_icon;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(819, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackgroundImage = global::CityPlanningGallery.Properties.Resources.return_left;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Location = new System.Drawing.Point(783, 12);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(30, 30);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.TabStop = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Return.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // pic_PreView
            // 
            this.pic_PreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_PreView.Location = new System.Drawing.Point(489, 100);
            this.pic_PreView.Name = "pic_PreView";
            this.pic_PreView.Size = new System.Drawing.Size(267, 338);
            this.pic_PreView.TabIndex = 8;
            this.pic_PreView.TabStop = false;
            // 
            // lbl_PreViewMapTitle
            // 
            this.lbl_PreViewMapTitle.AutoSize = true;
            this.lbl_PreViewMapTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PreViewMapTitle.Location = new System.Drawing.Point(525, 451);
            this.lbl_PreViewMapTitle.Name = "lbl_PreViewMapTitle";
            this.lbl_PreViewMapTitle.Size = new System.Drawing.Size(0, 20);
            this.lbl_PreViewMapTitle.TabIndex = 9;
            this.lbl_PreViewMapTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "专题报告";
            // 
            // frmThematicDocContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PreViewMapTitle);
            this.Controls.Add(this.pic_PreView);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.flowLayoutPanel_ThematicDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThematicDocContents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "规划图集";
            this.Load += new System.EventHandler(this.frmAtlasContents_Load);
            this.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
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

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ThematicDoc;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Return;
        private System.Windows.Forms.PictureBox pic_PreView;
        private System.Windows.Forms.Label lbl_PreViewMapTitle;
        private System.Windows.Forms.Label label1;
    }
}