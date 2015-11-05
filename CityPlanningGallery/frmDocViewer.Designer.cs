namespace CityPlanningGallery
{
    partial class frmDocViewer
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
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucDocumentReader1 = new CityPlanningGallery.ucDocumentReader();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(1041, 12);
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
            this.btn_Return.Location = new System.Drawing.Point(999, 12);
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(26, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 25);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "沈阳经济区国土规划文本";
            // 
            // ucDocumentReader1
            // 
            this.ucDocumentReader1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDocumentReader1.BackColor = System.Drawing.SystemColors.Control;
            this.ucDocumentReader1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDocumentReader1.Location = new System.Drawing.Point(26, 54);
            this.ucDocumentReader1.Name = "ucDocumentReader1";
            this.ucDocumentReader1.Searchkeyword = "";
            this.ucDocumentReader1.Size = new System.Drawing.Size(1050, 555);
            this.ucDocumentReader1.TabIndex = 0;
            // 
            // frmDocViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 633);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.ucDocumentReader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "规划文档";
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

        private ucDocumentReader ucDocumentReader1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Return;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}