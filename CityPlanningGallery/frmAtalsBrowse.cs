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
        }

        public string ImageFilePath
        {
            set
            {
                string filePath = value;
                if (File.Exists(filePath))
                    this.pe_AtlasShower.Image = Image.FromFile(filePath);
                this.pe_AtlasShower.Properties.SizeMode = PictureSizeMode.Zoom;
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

    }
}
