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
            this.lbl_Close = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanel_Status = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Planning = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Analysis = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_Close
            // 
            this.lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.Location = new System.Drawing.Point(811, 24);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(22, 19);
            this.lbl_Close.TabIndex = 4;
            this.lbl_Close.Text = " × ";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // flowLayoutPanel_Status
            // 
            this.flowLayoutPanel_Status.Location = new System.Drawing.Point(80, 70);
            this.flowLayoutPanel_Status.Name = "flowLayoutPanel_Status";
            this.flowLayoutPanel_Status.Size = new System.Drawing.Size(200, 480);
            this.flowLayoutPanel_Status.TabIndex = 5;
            // 
            // flowLayoutPanel_Planning
            // 
            this.flowLayoutPanel_Planning.Location = new System.Drawing.Point(330, 70);
            this.flowLayoutPanel_Planning.Name = "flowLayoutPanel_Planning";
            this.flowLayoutPanel_Planning.Size = new System.Drawing.Size(200, 480);
            this.flowLayoutPanel_Planning.TabIndex = 6;
            // 
            // flowLayoutPanel_Analysis
            // 
            this.flowLayoutPanel_Analysis.Location = new System.Drawing.Point(580, 70);
            this.flowLayoutPanel_Analysis.Name = "flowLayoutPanel_Analysis";
            this.flowLayoutPanel_Analysis.Size = new System.Drawing.Size(200, 480);
            this.flowLayoutPanel_Analysis.TabIndex = 7;
            // 
            // frmAtlasContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.flowLayoutPanel_Analysis);
            this.Controls.Add(this.flowLayoutPanel_Planning);
            this.Controls.Add(this.flowLayoutPanel_Status);
            this.Controls.Add(this.lbl_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtlasContents";
            this.Text = "frmAtlasContents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Planning;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Analysis;
    }
}