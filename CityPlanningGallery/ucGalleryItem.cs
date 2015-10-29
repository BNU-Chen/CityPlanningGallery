using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public delegate void delegateClick(ucGalleryItem ucgi);
    public delegate void delegateMouseEnter(ucGalleryItem ucgi);
    public delegate void delegateMouseLeave(ucGalleryItem ucgi);
    public partial class ucGalleryItem : UserControl
    {
        //使用委托，实现调用主窗体函数
        public delegateClick delegateClick;
        public delegateMouseEnter delegateMouseEnter;
        public delegateMouseLeave delegateMouseLeave;

        public ucGalleryItem()
        {
            InitializeComponent();
            this.panel_BackColor.BackColor = Color.FromArgb(16, 142, 96);

            this.lbl_Title.Click += ucGalleryItem_Click;
            this.lbl_Title.MouseEnter += ucGalleryItem_MouseEnter;
            this.lbl_Title.MouseLeave += ucGalleryItem_MouseLeave;

            this.panel_BackColor.Click += ucGalleryItem_Click;
            this.panel_BackColor.MouseEnter += ucGalleryItem_MouseEnter;
            this.panel_BackColor.MouseLeave += ucGalleryItem_MouseLeave;

        }

        #region //封装字段
        private string mxdPath = "";
        public string DataPath
        {
            get { return mxdPath; }
            set { mxdPath = value; }
        }

        private string hoverImagePath = "";

        public string HoverImagePath
        {
            get { return hoverImagePath; }
            set { hoverImagePath = value; }
        }
        public string Title
        {
            get
            {
                return this.lbl_Title.Text.Trim();
            }
            set
            {
                this.lbl_Title.Text = value;
            }
        }

        public DevExpress.XtraEditors.PanelControl BackColorPanel
        {
            get { return this.panel_BackColor; }
        }

        public DevExpress.XtraEditors.LabelControl TitleLabel
        {
            get { return this.lbl_Title; }
        }
        #endregion

        private void panel_BackColor_MouseEnter(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.FromArgb(72, 200, 153);
        }

        private void panel_BackColor_MouseLeave(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.FromArgb(16, 142, 96);
        }

        private void ucGalleryItem_Click(object sender, EventArgs e)
        {
            delegateClick(this);
        }

        private void ucGalleryItem_MouseEnter(object sender, EventArgs e)
        {
            delegateMouseEnter(this);
        }

        private void ucGalleryItem_MouseLeave(object sender, EventArgs e)
        {
            delegateMouseLeave(this);
        }

    }
}
