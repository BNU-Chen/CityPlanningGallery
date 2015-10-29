namespace CityPlanningGallery
{
    partial class ucLegend
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_AutoPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_AllLayer = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Legend = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_AutoPlay,
            this.tsbtn_AllLayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 213);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(240, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_AutoPlay
            // 
            this.tsbtn_AutoPlay.Image = global::CityPlanningGallery.Properties.Resources.Pulse_icon;
            this.tsbtn_AutoPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_AutoPlay.Name = "tsbtn_AutoPlay";
            this.tsbtn_AutoPlay.Size = new System.Drawing.Size(80, 24);
            this.tsbtn_AutoPlay.Text = "自动查看";
            // 
            // tsbtn_AllLayer
            // 
            this.tsbtn_AllLayer.Image = global::CityPlanningGallery.Properties.Resources.select_all;
            this.tsbtn_AllLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_AllLayer.Name = "tsbtn_AllLayer";
            this.tsbtn_AllLayer.Size = new System.Drawing.Size(80, 24);
            this.tsbtn_AllLayer.Text = "地图全图";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 27);
            this.panel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(112, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "图例";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel_Legend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 186);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel_Legend
            // 
            this.flowLayoutPanel_Legend.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Legend.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Legend.Name = "flowLayoutPanel_Legend";
            this.flowLayoutPanel_Legend.Size = new System.Drawing.Size(240, 186);
            this.flowLayoutPanel_Legend.TabIndex = 0;
            // 
            // ucLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ucLegend";
            this.Size = new System.Drawing.Size(240, 240);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_AllLayer;
        private System.Windows.Forms.ToolStripButton tsbtn_AutoPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Legend;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
