﻿namespace CityPlanningGallery
{
    partial class ucGalleryItemImg
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
            this.panel_BackColor = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Title = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel_BackColor)).BeginInit();
            this.panel_BackColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_BackColor
            // 
            this.panel_BackColor.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panel_BackColor.Appearance.Options.UseBackColor = true;
            this.panel_BackColor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_BackColor.Controls.Add(this.lbl_Title);
            this.panel_BackColor.Location = new System.Drawing.Point(4, 4);
            this.panel_BackColor.Name = "panel_BackColor";
            this.panel_BackColor.Size = new System.Drawing.Size(323, 34);
            this.panel_BackColor.TabIndex = 0;
            this.panel_BackColor.MouseEnter += new System.EventHandler(this.panel_BackColor_MouseEnter);
            this.panel_BackColor.MouseLeave += new System.EventHandler(this.panel_BackColor_MouseLeave);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(18, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(80, 21);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "未找到数据";
            this.lbl_Title.MouseEnter += new System.EventHandler(this.panel_BackColor_MouseEnter);
            this.lbl_Title.MouseLeave += new System.EventHandler(this.panel_BackColor_MouseLeave);
            // 
            // ucGalleryItemImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_BackColor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucGalleryItemImg";
            this.Size = new System.Drawing.Size(330, 41);
            this.Click += new System.EventHandler(this.ucGalleryItem_Click);
            this.MouseEnter += new System.EventHandler(this.ucGalleryItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucGalleryItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.panel_BackColor)).EndInit();
            this.panel_BackColor.ResumeLayout(false);
            this.panel_BackColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_BackColor;
        private DevExpress.XtraEditors.LabelControl lbl_Title;

    }
}
