namespace CityPlanningGallery
{
    partial class ucChartTableShow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChartTableShow));
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.icChartTypeImage = new DevExpress.Utils.ImageCollection(this.components);
            this.icbeChartType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkedDataFields = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkPercentShow = new DevExpress.XtraEditors.CheckEdit();
            this.btnOutPut = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTableShow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl.Location = new System.Drawing.Point(2, 37);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl.Size = new System.Drawing.Size(293, 234);
            this.chartControl.TabIndex = 13;
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.AllowDrop = true;
            this.spreadsheetControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControl.Location = new System.Drawing.Point(2, 275);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.ThrowExceptionOnInvalidDocument = false;
            this.spreadsheetControl.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Size = new System.Drawing.Size(293, 220);
            this.spreadsheetControl.TabIndex = 14;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            // 
            // icChartTypeImage
            // 
            this.icChartTypeImage.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icChartTypeImage.ImageStream")));
            this.icChartTypeImage.InsertGalleryImage("bar_16x16.png", "images/chart/bar_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/bar_16x16.png"), 0);
            this.icChartTypeImage.Images.SetKeyName(0, "bar_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("pie_16x16.png", "images/chart/pie_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_16x16.png"), 1);
            this.icChartTypeImage.Images.SetKeyName(1, "pie_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("line_16x16.png", "images/chart/line_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/line_16x16.png"), 2);
            this.icChartTypeImage.Images.SetKeyName(2, "line_16x16.png");
            this.icChartTypeImage.InsertGalleryImage("point_16x16.png", "images/chart/point_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/point_16x16.png"), 3);
            this.icChartTypeImage.Images.SetKeyName(3, "point_16x16.png");
            // 
            // icbeChartType
            // 
            this.icbeChartType.Location = new System.Drawing.Point(7, 7);
            this.icbeChartType.Name = "icbeChartType";
            this.icbeChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbeChartType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("柱状图", "柱状图", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("饼状图", "饼状图", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("折线图", "折线图", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("散点图", "散点图", 3)});
            this.icbeChartType.Properties.LargeImages = this.icChartTypeImage;
            this.icbeChartType.Size = new System.Drawing.Size(40, 20);
            this.icbeChartType.TabIndex = 14;
            this.icbeChartType.SelectedIndexChanged += new System.EventHandler(this.icbeChartType_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "数据：";
            // 
            // checkedDataFields
            // 
            this.checkedDataFields.Location = new System.Drawing.Point(87, 7);
            this.checkedDataFields.Name = "checkedDataFields";
            this.checkedDataFields.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedDataFields.Size = new System.Drawing.Size(50, 20);
            this.checkedDataFields.TabIndex = 16;
            this.checkedDataFields.EditValueChanged += new System.EventHandler(this.checkedDataFields_EditValueChanged);
            // 
            // checkPercentShow
            // 
            this.checkPercentShow.EditValue = true;
            this.checkPercentShow.Location = new System.Drawing.Point(252, 8);
            this.checkPercentShow.Name = "checkPercentShow";
            this.checkPercentShow.Properties.Caption = "%";
            this.checkPercentShow.Size = new System.Drawing.Size(41, 19);
            this.checkPercentShow.TabIndex = 17;
            this.checkPercentShow.CheckedChanged += new System.EventHandler(this.checkPercentShow_CheckedChanged);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Location = new System.Drawing.Point(204, 6);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(40, 23);
            this.btnOutPut.TabIndex = 18;
            this.btnOutPut.Text = "导出";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTableShow);
            this.panel1.Controls.Add(this.btnOutPut);
            this.panel1.Controls.Add(this.checkPercentShow);
            this.panel1.Controls.Add(this.checkedDataFields);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.icbeChartType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 34);
            this.panel1.TabIndex = 15;
            // 
            // btnTableShow
            // 
            this.btnTableShow.Location = new System.Drawing.Point(143, 6);
            this.btnTableShow.Name = "btnTableShow";
            this.btnTableShow.Size = new System.Drawing.Size(55, 23);
            this.btnTableShow.TabIndex = 19;
            this.btnTableShow.Text = "数据表";
            this.btnTableShow.Click += new System.EventHandler(this.btnTableShow_Click);
            // 
            // ucChartTableShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spreadsheetControl);
            this.Controls.Add(this.chartControl);
            this.Name = "ucChartTableShow";
            this.Size = new System.Drawing.Size(298, 498);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icChartTypeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbeChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedDataFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPercentShow.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
        private DevExpress.Utils.ImageCollection icChartTypeImage;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbeChartType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedDataFields;
        private DevExpress.XtraEditors.CheckEdit checkPercentShow;
        private DevExpress.XtraEditors.SimpleButton btnOutPut;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTableShow;
    }
}
