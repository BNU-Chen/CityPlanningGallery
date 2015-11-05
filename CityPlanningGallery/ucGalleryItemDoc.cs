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
    public delegate void delegateGalleryItemDocClick(ucGalleryItemDoc ucgi);
    public delegate void delegateGalleryItemDocMouseEnter(ucGalleryItemDoc ucgi);
    public delegate void delegateGalleryItemDocMouseLeave(ucGalleryItemDoc ucgi);
    public partial class ucGalleryItemDoc : UserControl
    {
        //使用委托，实现调用主窗体函数
        public delegateGalleryItemDocClick delegateGalleryItemDocClick;
        public delegateGalleryItemDocMouseEnter delegateGalleryItemDocMouseEnter;
        public delegateGalleryItemDocMouseLeave delegateGalleryItemDocMouseLeave;

        public ucGalleryItemDoc()
        {
            InitializeComponent();
            this.panel_BackColor.BackColor = Color.FromArgb(43, 87, 154);

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
            this.panel_BackColor.BackColor = Color.FromArgb(132, 170, 228);
        }

        private void panel_BackColor_MouseLeave(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.FromArgb(43, 87, 154);
        }

        private void ucGalleryItem_Click(object sender, EventArgs e)
        {
            if (delegateGalleryItemDocClick != null)
            {
                delegateGalleryItemDocClick(this);
            }
        }

        private void ucGalleryItem_MouseEnter(object sender, EventArgs e)
        {
            if (delegateGalleryItemDocMouseEnter != null)
            {
                delegateGalleryItemDocMouseEnter(this);
            }
        }

        private void ucGalleryItem_MouseLeave(object sender, EventArgs e)
        {
            if (delegateGalleryItemDocMouseLeave != null)
            {
                delegateGalleryItemDocMouseLeave(this);
            }
        }

    }
}
