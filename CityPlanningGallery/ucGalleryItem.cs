using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public partial class ucGalleryItem : UserControl
    {
        private string mxdPath = "";
        public string MxdPath
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

        public ucGalleryItem()
        {
            InitializeComponent();
        }

        private void panel_BackColor_MouseEnter(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.DarkOliveGreen;
        }

        private void panel_BackColor_MouseLeave(object sender, EventArgs e)
        {
            this.panel_BackColor.BackColor = Color.Olive;
        }
    }
}
