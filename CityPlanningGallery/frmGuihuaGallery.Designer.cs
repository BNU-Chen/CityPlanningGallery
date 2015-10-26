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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_MapTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Guihua
            // 
            this.flowLayoutPanel_Guihua.Location = new System.Drawing.Point(64, 54);
            this.flowLayoutPanel_Guihua.Name = "flowLayoutPanel_Guihua";
            this.flowLayoutPanel_Guihua.Size = new System.Drawing.Size(319, 486);
            this.flowLayoutPanel_Guihua.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(478, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_MapTitle
            // 
            this.lbl_MapTitle.Appearance.BackColor = System.Drawing.Color.White;
            this.lbl_MapTitle.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MapTitle.Location = new System.Drawing.Point(569, 362);
            this.lbl_MapTitle.Name = "lbl_MapTitle";
            this.lbl_MapTitle.Size = new System.Drawing.Size(0, 19);
            this.lbl_MapTitle.TabIndex = 2;
            // 
            // frmGuihuaGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.lbl_MapTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel_Guihua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuihuaGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuihuaGallery";
            this.Load += new System.EventHandler(this.frmGuihuaGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Guihua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbl_MapTitle;
    }
}