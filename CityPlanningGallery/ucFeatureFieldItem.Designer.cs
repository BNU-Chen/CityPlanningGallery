namespace CityPlanningGallery
{
    partial class ucFeatureFieldItem
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
            this.lbl_Value = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(3, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(82, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "labelControl1";
            // 
            // lbl_Value
            // 
            this.lbl_Value.Location = new System.Drawing.Point(45, 26);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(70, 14);
            this.lbl_Value.TabIndex = 0;
            this.lbl_Value.Text = "labelControl1";
            // 
            // ucFeatureFieldItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_Title);
            this.Name = "ucFeatureFieldItem";
            this.Size = new System.Drawing.Size(140, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Title;
        private DevExpress.XtraEditors.LabelControl lbl_Value;
    }
}
