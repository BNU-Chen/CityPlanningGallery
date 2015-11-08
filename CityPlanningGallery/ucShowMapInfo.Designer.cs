namespace CityPlanningGallery
{
    partial class ucShowMapInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowMapInfo));
            this.panel_FeatureInfo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_btn_MapDesc = new System.Windows.Forms.Panel();
            this.btn_MapDesc = new DevExpress.XtraEditors.SimpleButton();
            this.panel_btn_FeatureInfo = new System.Windows.Forms.Panel();
            this.btn_FeatureInfo = new DevExpress.XtraEditors.SimpleButton();
            this.panel_MapChart = new System.Windows.Forms.Panel();
            this.ucChartTableShow1 = new CityPlanningGallery.ucChartTableShow();
            this.panel_MapDesc = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel_btn_MapChart = new System.Windows.Forms.Panel();
            this.btn_MapChart = new DevExpress.XtraEditors.SimpleButton();
            this.panel_FeatureInfo.SuspendLayout();
            this.panel_btn_MapDesc.SuspendLayout();
            this.panel_btn_FeatureInfo.SuspendLayout();
            this.panel_MapChart.SuspendLayout();
            this.panel_MapDesc.SuspendLayout();
            this.panel_btn_MapChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_FeatureInfo
            // 
            this.panel_FeatureInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_FeatureInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_FeatureInfo.Controls.Add(this.flowLayoutPanel1);
            this.panel_FeatureInfo.Location = new System.Drawing.Point(0, 322);
            this.panel_FeatureInfo.Name = "panel_FeatureInfo";
            this.panel_FeatureInfo.Size = new System.Drawing.Size(259, 111);
            this.panel_FeatureInfo.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 111);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_btn_MapDesc
            // 
            this.panel_btn_MapDesc.Controls.Add(this.btn_MapDesc);
            this.panel_btn_MapDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_btn_MapDesc.Location = new System.Drawing.Point(0, 0);
            this.panel_btn_MapDesc.Name = "panel_btn_MapDesc";
            this.panel_btn_MapDesc.Size = new System.Drawing.Size(259, 32);
            this.panel_btn_MapDesc.TabIndex = 2;
            // 
            // btn_MapDesc
            // 
            this.btn_MapDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapDesc.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MapDesc.Appearance.Options.UseFont = true;
            this.btn_MapDesc.Location = new System.Drawing.Point(19, 3);
            this.btn_MapDesc.Name = "btn_MapDesc";
            this.btn_MapDesc.Size = new System.Drawing.Size(222, 25);
            this.btn_MapDesc.TabIndex = 1;
            this.btn_MapDesc.Text = "地图介绍";
            this.btn_MapDesc.Click += new System.EventHandler(this.btn_MapDesc_Click);
            // 
            // panel_btn_FeatureInfo
            // 
            this.panel_btn_FeatureInfo.Controls.Add(this.btn_FeatureInfo);
            this.panel_btn_FeatureInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn_FeatureInfo.Location = new System.Drawing.Point(0, 504);
            this.panel_btn_FeatureInfo.Name = "panel_btn_FeatureInfo";
            this.panel_btn_FeatureInfo.Size = new System.Drawing.Size(259, 32);
            this.panel_btn_FeatureInfo.TabIndex = 4;
            // 
            // btn_FeatureInfo
            // 
            this.btn_FeatureInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FeatureInfo.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FeatureInfo.Appearance.Options.UseFont = true;
            this.btn_FeatureInfo.Location = new System.Drawing.Point(19, 5);
            this.btn_FeatureInfo.Name = "btn_FeatureInfo";
            this.btn_FeatureInfo.Size = new System.Drawing.Size(222, 25);
            this.btn_FeatureInfo.TabIndex = 1;
            this.btn_FeatureInfo.Text = "要素信息";
            this.btn_FeatureInfo.Click += new System.EventHandler(this.btn_FeatureInfo_Click);
            // 
            // panel_MapChart
            // 
            this.panel_MapChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MapChart.BackColor = System.Drawing.Color.White;
            this.panel_MapChart.Controls.Add(this.ucChartTableShow1);
            this.panel_MapChart.Location = new System.Drawing.Point(0, 179);
            this.panel_MapChart.Name = "panel_MapChart";
            this.panel_MapChart.Size = new System.Drawing.Size(259, 122);
            this.panel_MapChart.TabIndex = 1;
            // 
            // ucChartTableShow1
            // 
            this.ucChartTableShow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucChartTableShow1.DataSource = null;
            this.ucChartTableShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChartTableShow1.Location = new System.Drawing.Point(0, 0);
            this.ucChartTableShow1.Name = "ucChartTableShow1";
            this.ucChartTableShow1.Size = new System.Drawing.Size(259, 122);
            this.ucChartTableShow1.TabIndex = 0;
            // 
            // panel_MapDesc
            // 
            this.panel_MapDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MapDesc.BackColor = System.Drawing.Color.White;
            this.panel_MapDesc.Controls.Add(this.richTextBox1);
            this.panel_MapDesc.Location = new System.Drawing.Point(0, 76);
            this.panel_MapDesc.Name = "panel_MapDesc";
            this.panel_MapDesc.Size = new System.Drawing.Size(259, 80);
            this.panel_MapDesc.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(259, 80);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel_btn_MapChart
            // 
            this.panel_btn_MapChart.Controls.Add(this.btn_MapChart);
            this.panel_btn_MapChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn_MapChart.Location = new System.Drawing.Point(0, 472);
            this.panel_btn_MapChart.Name = "panel_btn_MapChart";
            this.panel_btn_MapChart.Size = new System.Drawing.Size(259, 32);
            this.panel_btn_MapChart.TabIndex = 3;
            // 
            // btn_MapChart
            // 
            this.btn_MapChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapChart.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MapChart.Appearance.Options.UseFont = true;
            this.btn_MapChart.Location = new System.Drawing.Point(19, 3);
            this.btn_MapChart.Name = "btn_MapChart";
            this.btn_MapChart.Size = new System.Drawing.Size(222, 25);
            this.btn_MapChart.TabIndex = 1;
            this.btn_MapChart.Text = "统计信息";
            this.btn_MapChart.Click += new System.EventHandler(this.btn_MapChart_Click);
            // 
            // ucShowMapInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_btn_MapChart);
            this.Controls.Add(this.panel_btn_FeatureInfo);
            this.Controls.Add(this.panel_btn_MapDesc);
            this.Controls.Add(this.panel_MapDesc);
            this.Controls.Add(this.panel_MapChart);
            this.Controls.Add(this.panel_FeatureInfo);
            this.Name = "ucShowMapInfo";
            this.Size = new System.Drawing.Size(259, 536);
            this.panel_FeatureInfo.ResumeLayout(false);
            this.panel_btn_MapDesc.ResumeLayout(false);
            this.panel_btn_FeatureInfo.ResumeLayout(false);
            this.panel_MapChart.ResumeLayout(false);
            this.panel_MapDesc.ResumeLayout(false);
            this.panel_btn_MapChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_FeatureInfo;
        private System.Windows.Forms.Panel panel_btn_MapDesc;
        private DevExpress.XtraEditors.SimpleButton btn_MapDesc;
        private System.Windows.Forms.Panel panel_btn_FeatureInfo;
        private DevExpress.XtraEditors.SimpleButton btn_FeatureInfo;
        private System.Windows.Forms.Panel panel_MapChart;
        private System.Windows.Forms.Panel panel_MapDesc;
        private System.Windows.Forms.Panel panel_btn_MapChart;
        private DevExpress.XtraEditors.SimpleButton btn_MapChart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ucChartTableShow ucChartTableShow1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
