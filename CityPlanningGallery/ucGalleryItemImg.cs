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
    public delegate void delegateGalleryItemImgClick(ucGalleryItemImg ucgi);
    public delegate void delegateGalleryItemImgMouseEnter(ucGalleryItemImg ucgi);
    public delegate void delegateGalleryItemImgMouseLeave(ucGalleryItemImg ucgi);
    public partial class ucGalleryItemImg : UserControl
    {
        //使用委托，实现调用主窗体函数
        public delegateGalleryItemImgClick delegateGalleryItemImgClick;
        public delegateGalleryItemImgMouseEnter delegateGalleryItemImgMouseEnter;
        public delegateGalleryItemImgMouseLeave delegateGalleryItemImgMouseLeave;

        public ucGalleryItemImg()
        {
            InitializeComponent();
            this.panel_BackColor.BackColor = Color.FromArgb(56, 113, 106);

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
            this.panel_BackColor.BackColor = Color.FromArgb(114,192,182);
        }

        private void panel_BackColor_MouseLeave(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.FromArgb(80,203,188);
        }

        private void ucGalleryItem_Click(object sender, EventArgs e)
        {
            if (delegateGalleryItemImgClick != null)
            {
                delegateGalleryItemImgClick(this);
            }
        }

        private void ucGalleryItem_MouseEnter(object sender, EventArgs e)
        {
            if (delegateGalleryItemImgMouseEnter != null)
            {
                delegateGalleryItemImgMouseEnter(this);
            }
        }

        private void ucGalleryItem_MouseLeave(object sender, EventArgs e)
        {
            if (delegateGalleryItemImgMouseLeave != null)
            {
                delegateGalleryItemImgMouseLeave(this);
            }
        }

    }
}
