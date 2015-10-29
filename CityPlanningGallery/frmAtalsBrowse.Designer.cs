namespace CityPlanningGallery
{
    partial class frmAtalsBrowse
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
            this.pe_AtlasShower = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pe_AtlasShower.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::CityPlanningGallery.Properties.Resources.close_icon;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(747, 22);
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
            this.btn_Return.BackgroundImage = global::CityPlanningGallery.Properties.Resources.return_left;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Location = new System.Drawing.Point(700, 23);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(30, 30);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.TabStop = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseEnter += new System.EventHandler(this.btn_Return_MouseEnter);
            this.btn_Return.MouseLeave += new System.EventHandler(this.btn_Return_MouseLeave);
            // 
            // pe_AtlasShower
            // 
            this.pe_AtlasShower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pe_AtlasShower.Location = new System.Drawing.Point(12, 13);
            this.pe_AtlasShower.Name = "pe_AtlasShower";
            this.pe_AtlasShower.Size = new System.Drawing.Size(776, 575);
            this.pe_AtlasShower.TabIndex = 8;
            // 
            // frmAtalsBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.pe_AtlasShower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtalsBrowse";
            this.Text = "frmAtalsBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pe_AtlasShower.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Return;
        private DevExpress.XtraEditors.PictureEdit pe_AtlasShower;
    }
}