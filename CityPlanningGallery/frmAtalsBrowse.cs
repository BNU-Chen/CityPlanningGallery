using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace CityPlanningGallery
{
    public partial class frmAtalsBrowse : Form
    {
        private frmAtlasContents parentForm = null;

        public frmAtalsBrowse(frmAtlasContents _frm)
        {
            InitializeComponent();
            parentForm = _frm;
            parentForm.Visible = false;

            this.pe_AtlasShower.Properties.ShowZoomSubMenu = DefaultBoolean.True;
            this.pe_AtlasShower.Properties.ShowScrollBars = true;
            this.pe_AtlasShower.Properties.AllowScrollViaMouseDrag = true;
            this.pe_AtlasShower.MouseWheel += pe_AtlasShower_MouseWheel;
            this.pe_AtlasShower.MouseEnter += pe_AtlasShower_MouseEnter;
        }

        void pe_AtlasShower_MouseEnter(object sender, EventArgs e)
        {
            this.pe_AtlasShower.Focus();
        }

        void pe_AtlasShower_MouseWheel(object sender, MouseEventArgs e)
        {
            this.pe_AtlasShower.Properties.SizeMode = PictureSizeMode.Clip;
            int scalePercent = this.pe_AtlasShower.Properties.ZoomPercent;
            int step = 20;
            if (e.Delta > 0)
            {
                this.pe_AtlasShower.Properties.ZoomPercent = scalePercent + step;
                this.Refresh();
            }
            else
            {
                this.pe_AtlasShower.Properties.ZoomPercent = scalePercent - step;
                this.Refresh();
            }
        }

        public string ImageFilePath
        {
            set
            {
                string filePath = value;
                if (File.Exists(filePath))
                    this.pe_AtlasShower.Image = Image.FromFile(filePath);
                //this.pe_AtlasShower.Properties.ZoomPercent = 50;
                this.pe_AtlasShower.Properties.SizeMode = PictureSizeMode.Zoom;
                this.Refresh();
            }
        }

        #region //关闭 及 返回 按钮
        private void btn_Return_Click(object sender, EventArgs e)
        {
            parentForm.Visible = true;
            this.Close();
        }

        private void btn_Return_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = Color.LightGray;
        }

        private void btn_Return_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = Color.White;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }
        #endregion

        private void frmAtalsBrowse_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
