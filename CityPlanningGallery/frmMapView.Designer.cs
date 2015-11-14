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
            this.panel_BackColor = new System.Windows.Forms.Panel();
            this.panel_RightHome = new System.Windows.Forms.Panel();
            this.panel_RightInfo = new System.Windows.Forms.Panel();
            this.panel_LeftFull = new System.Windows.Forms.Panel();
            this.ucShowMapInfo1 = new CityPlanningGallery.ucShowMapInfo();
            this.panel_LeftTop = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Home = new System.Windows.Forms.ToolStripButton();
            this.btn_Return = new System.Windows.Forms.ToolStripButton();
            this.btn_Close = new System.Windows.Forms.ToolStripButton();
            this.ucLegend1 = new CityPlanningGallery.ucLegend();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.toolStrip_MapTool = new System.Windows.Forms.ToolStrip();
            this.tsbtn_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_FullExtent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_AutoPlayLegend = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_CtrlLegendLayer = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_TripleMap = new System.Windows.Forms.ToolStripButton();
            this.lbl_MapTitle = new DevExpress.XtraEditors.LabelControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.panel_BackColor.SuspendLayout();
            this.panel_RightHome.SuspendLayout();
            this.panel_RightInfo.SuspendLayout();
            this.panel_LeftFull.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.toolStrip_MapTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BackColor
            // 
            this.panel_BackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_BackColor.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel_BackColor.Controls.Add(this.panel_RightHome);
            this.panel_BackColor.Controls.Add(this.toolStrip1);
            this.panel_BackColor.Controls.Add(this.ucLegend1);
            this.panel_BackColor.Controls.Add(this.axLicenseControl1);
            this.panel_BackColor.Controls.Add(this.toolStrip_MapTool);
            this.panel_BackColor.Controls.Add(this.lbl_MapTitle);
            this.panel_BackColor.Controls.Add(this.axMapControl1);
            this.panel_BackColor.Location = new System.Drawing.Point(12, 26);
            this.panel_BackColor.Name = "panel_BackColor";
            this.panel_BackColor.Size = new System.Drawing.Size(960, 657);
            this.panel_BackColor.TabIndex = 5;
            // 
            // panel_RightHome
            // 
            this.panel_RightHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_RightHome.Controls.Add(this.panel_RightInfo);
            this.panel_RightHome.Location = new System.Drawing.Point(657, 61);
            this.panel_RightHome.Name = "panel_RightHome";
            this.panel_RightHome.Size = new System.Drawing.Size(285, 575);
            this.panel_RightHome.TabIndex = 10;
            // 
            // panel_RightInfo
            // 
            this.panel_RightInfo.BackColor = System.Drawing.Color.White;
            this.panel_RightInfo.Controls.Add(this.panel_LeftFull);
            this.panel_RightInfo.Controls.Add(this.panel_LeftTop);
            this.panel_RightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RightInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_RightInfo.Name = "panel_RightInfo";
            this.panel_RightInfo.Size = new System.Drawing.Size(285, 575);
            this.panel_RightInfo.TabIndex = 3;
            // 
            // panel_LeftFull
            // 
            this.panel_LeftFull.Controls.Add(this.ucShowMapInfo1);
            this.panel_LeftFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LeftFull.Location = new System.Drawing.Point(0, 173);
            this.panel_LeftFull.Name = "panel_LeftFull";
            this.panel_LeftFull.Size = new System.Drawing.Size(285, 402);
            this.panel_LeftFull.TabIndex = 8;
            // 
            // ucShowMapInfo1
            // 
            this.ucShowMapInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShowMapInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucShowMapInfo1.Name = "ucShowMapInfo1";
            this.ucShowMapInfo1.Size = new System.Drawing.Size(285, 402);
            this.ucShowMapInfo1.TabIndex = 0;
            // 
            // panel_LeftTop
            // 
            this.panel_LeftTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_LeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LeftTop.Location = new System.Drawing.Point(0, 0);
            this.panel_LeftTop.Name = "panel_LeftTop";
            this.panel_LeftTop.Size = new System.Drawing.Size(285, 173);
            this.panel_LeftTop.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Home,
            this.btn_Return,
            this.btn_Close});
            this.toolStrip1.Location = new System.Drawing.Point(714, 15);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(228, 43);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::CityPlanningGallery.Properties.Resources.home_black;
            this.btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(72, 40);
            this.btn_Home.Text = "主页";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::CityPlanningGallery.Properties.Resources.return_black;
            this.btn_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(72, 40);
            this.btn_Return.Text = "返回";
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::CityPlanningGallery.Properties.Resources.close;
            this.btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(72, 40);
            this.btn_Close.Text = "关闭";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ucLegend1
            // 
            this.ucLegend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLegend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLegend1.Location = new System.Drawing.Point(445, 387);
            this.ucLegend1.MapControl = null;
            this.ucLegend1.Name = "ucLegend1";
            this.ucLegend1.Size = new System.Drawing.Size(200, 240);
            this.ucLegend1.TabIndex = 7;
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
            this.tsbtn_FullExtent,
            this.toolStripSeparator1,
            this.tsbtn_AutoPlayLegend,
            this.tsbtn_CtrlLegendLayer,
            this.tsbtn_TripleMap});
            this.toolStrip_MapTool.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_MapTool.Location = new System.Drawing.Point(249, 19);
            this.toolStrip_MapTool.Name = "toolStrip_MapTool";
            this.toolStrip_MapTool.Size = new System.Drawing.Size(402, 39);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtn_AutoPlayLegend
            // 
            this.tsbtn_AutoPlayLegend.Image = global::CityPlanningGallery.Properties.Resources.Pulse_icon;
            this.tsbtn_AutoPlayLegend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_AutoPlayLegend.Name = "tsbtn_AutoPlayLegend";
            this.tsbtn_AutoPlayLegend.Size = new System.Drawing.Size(92, 36);
            this.tsbtn_AutoPlayLegend.Text = "动态浏览";
            // 
            // tsbtn_CtrlLegendLayer
            // 
            this.tsbtn_CtrlLegendLayer.Image = global::CityPlanningGallery.Properties.Resources.select_all;
            this.tsbtn_CtrlLegendLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_CtrlLegendLayer.Name = "tsbtn_CtrlLegendLayer";
            this.tsbtn_CtrlLegendLayer.Size = new System.Drawing.Size(92, 36);
            this.tsbtn_CtrlLegendLayer.Text = "整体浏览";
            // 
            // tsbtn_TripleMap
            // 
            this.tsbtn_TripleMap.Image = global::CityPlanningGallery.Properties.Resources.tripleMap;
            this.tsbtn_TripleMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_TripleMap.Name = "tsbtn_TripleMap";
            this.tsbtn_TripleMap.Size = new System.Drawing.Size(92, 36);
            this.tsbtn_TripleMap.Text = "多图对比";
            // 
            // lbl_MapTitle
            // 
            this.lbl_MapTitle.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MapTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_MapTitle.Location = new System.Drawing.Point(28, 31);
            this.lbl_MapTitle.Name = "lbl_MapTitle";
            this.lbl_MapTitle.Size = new System.Drawing.Size(150, 25);
            this.lbl_MapTitle.TabIndex = 1;
            this.lbl_MapTitle.Text = "4 生态保护红线图";
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(28, 61);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(623, 575);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl1_OnMouseUp);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            this.axMapControl1.Resize += new System.EventHandler(this.axMapControl1_Resize);
            // 
            // frmMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 695);
            this.Controls.Add(this.panel_BackColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMapView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "规划地图";
            this.Load += new System.EventHandler(this.frmMapView_Load);
            this.DoubleClick += new System.EventHandler(this.frmMapView_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel_BackColor.ResumeLayout(false);
            this.panel_BackColor.PerformLayout();
            this.panel_RightHome.ResumeLayout(false);
            this.panel_RightInfo.ResumeLayout(false);
            this.panel_LeftFull.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.toolStrip_MapTool.ResumeLayout(false);
            this.toolStrip_MapTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_BackColor;
        private DevExpress.XtraEditors.LabelControl lbl_MapTitle;
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
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ToolStripButton tsbtn_AutoPlayLegend;
        private System.Windows.Forms.ToolStripButton tsbtn_CtrlLegendLayer;
        private System.Windows.Forms.ToolStripButton tsbtn_TripleMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel_RightHome;
        private System.Windows.Forms.Panel panel_RightInfo;
        private System.Windows.Forms.Panel panel_LeftFull;
        private ucShowMapInfo ucShowMapInfo1;
        private System.Windows.Forms.Panel panel_LeftTop;
    }
}