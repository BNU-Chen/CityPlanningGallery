namespace CityPlanningGallery
{
    partial class ucFeatureFieldItemNormal
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
            this.lbl_Title = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(10, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(82, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "labelControl1";
            // 
            // lbl_Value
            // 
            this.lbl_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Value.Location = new System.Drawing.Point(153, 23);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(100, 23);
            this.lbl_Value.TabIndex = 2;
            this.lbl_Value.Text = "label1";
            this.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucFeatureFieldItemNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_Title);
            this.Name = "ucFeatureFieldItemNormal";
            this.Size = new System.Drawing.Size(260, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Title;
        private System.Windows.Forms.Label lbl_Value;
    }
}
