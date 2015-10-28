namespace CityPlanningGallery
{
    partial class frmMapView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapView));
            this.lbl_Close = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.toolStrip_MapTool = new System.Windows.Forms.ToolStrip();
            this.tsbtn_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_FullExtent = new System.Windows.Forms.ToolStripButton();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.lbl_MapTitle = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Home = new System.Windows.Forms.ToolStripButton();
            this.btn_Return = new System.Windows.Forms.ToolStripButton();
            this.btn_Close = new System.Windows.Forms.ToolStripButton();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.ucLegend1 = new CityPlanningGallery.ucLegend();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.toolStrip_MapTool.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Close
            // 
            this.lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.Location = new System.Drawing.Point(945, 10);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(22, 19);
            this.lbl_Close.TabIndex = 4;
            this.lbl_Close.Text = " × ";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.ucLegend1);
            this.panel1.Controls.Add(this.axLicenseControl1);
            this.panel1.Controls.Add(this.toolStrip_MapTool);
            this.panel1.Controls.Add(this.panel_Right);
            this.panel1.Controls.Add(this.lbl_MapTitle);
            this.panel1.Controls.Add(this.axMapControl1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 615);
            this.panel1.TabIndex = 5;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(510, 231);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 6;
            // 
            // toolStrip_MapTool
            // 
            this.toolStrip_MapTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip_MapTool.BackColor = System.Drawing.Color.DarkKhaki;
            this.toolStrip_MapTool.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_MapTool.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip_MapTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_ZoomIn,
            this.tsbtn_ZoomOut,
            this.tsbtn_FullExtent});
            this.toolStrip_MapTool.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_MapTool.Location = new System.Drawing.Point(500, 19);
            this.toolStrip_MapTool.Name = "toolStrip_MapTool";
            this.toolStrip_MapTool.Size = new System.Drawing.Size(151, 39);
            this.toolStrip_MapTool.TabIndex = 5;
            this.toolStrip_MapTool.Text = "toolStrip1";
            this.toolStrip_MapTool.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_MapTool_ItemClicked);
            // 
            // tsbtn_ZoomIn
            // 
            this.tsbtn_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_ZoomIn.Image = global::CityPlanningGallery.Properties.Resources.zoomIn_32;
            this.tsbtn_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ZoomIn.Name = "tsbtn_ZoomIn";
            this.tsbtn_ZoomIn.Size = new System.Drawing.Size(36, 36);
            this.tsbtn_ZoomIn.Text = "放大";
            // 
            // tsbtn_ZoomOut
            // 
            this.tsbtn_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_ZoomOut.Image = global::CityPlanningGallery.Properties.Resources.zoomOut_32;
            this.tsbtn_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ZoomOut.Name = "tsbtn_ZoomOut";
            this.tsbtn_ZoomOut.Size = new System.Drawing.Size(36, 36);
            this.tsbtn_ZoomOut.Text = "缩小";
            // 
            // tsbtn_FullExtent
            // 
            this.tsbtn_FullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_FullExtent.Image = global::CityPlanningGallery.Properties.Resources.fullExtent_32;
            this.tsbtn_FullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_FullExtent.Name = "tsbtn_FullExtent";
            this.tsbtn_FullExtent.Size = new System.Drawing.Size(36, 36);
            this.tsbtn_FullExtent.Text = "全图";
            // 
            // panel_Right
            // 
            this.panel_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Right.BackColor = System.Drawing.Color.White;
            this.panel_Right.Controls.Add(this.toolStrip1);
            this.panel_Right.Location = new System.Drawing.Point(688, 61);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(253, 533);
            this.panel_Right.TabIndex = 2;
            // 
            // lbl_MapTitle
            // 
            this.lbl_MapTitle.Appearance.Font = new System.Drawing.Font("汉仪菱心体简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MapTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_MapTitle.Location = new System.Drawing.Point(28, 31);
            this.lbl_MapTitle.Name = "lbl_MapTitle";
            this.lbl_MapTitle.Size = new System.Drawing.Size(160, 19);
            this.lbl_MapTitle.TabIndex = 1;
            this.lbl_MapTitle.Text = "4 生态保护红线图";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Home,
            this.btn_Return,
            this.btn_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(253, 47);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::CityPlanningGallery.Properties.Resources.home_black;
            this.btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(76, 44);
            this.btn_Home.Text = "主页";
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::CityPlanningGallery.Properties.Resources.return_black;
            this.btn_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(76, 44);
            this.btn_Return.Text = "返回";
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::CityPlanningGallery.Properties.Resources.close;
            this.btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(76, 44);
            this.btn_Close.Text = "关闭";
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(28, 61);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(654, 533);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl1_OnMouseUp);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // ucLegend1
            // 
            this.ucLegend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLegend1.Location = new System.Drawing.Point(442, 354);
            this.ucLegend1.Name = "ucLegend1";
            this.ucLegend1.Size = new System.Drawing.Size(240, 240);
            this.ucLegend1.TabIndex = 7;
            // 
            // frmMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMapView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMapView";
            this.DoubleClick += new System.EventHandler(this.frmMapView_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.toolStrip_MapTool.ResumeLayout(false);
            this.toolStrip_MapTool.PerformLayout();
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Close;
        private System.Windows.Forms.Panel panel1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private DevExpress.XtraEditors.LabelControl lbl_MapTitle;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.ToolStrip toolStrip_MapTool;
        private System.Windows.Forms.ToolStripButton tsbtn_ZoomIn;
        private System.Windows.Forms.ToolStripButton tsbtn_ZoomOut;
        private System.Windows.Forms.ToolStripButton tsbtn_FullExtent;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ucLegend ucLegend1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Home;
        private System.Windows.Forms.ToolStripButton btn_Return;
        private System.Windows.Forms.ToolStripButton btn_Close;
    }
}