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

namespace CityPlanningGallery
{
    public partial class frmDocViewer : Form
    {
        private frmMapTitleGallery frmMapGallery = null;

        public frmDocViewer(frmMapTitleGallery _frmMapGallery)
        {
            InitializeComponent();
            frmMapGallery = _frmMapGallery;
        }

        private string docPath = "";
        public string DocPath
        {
            set
            {
                docPath = value;
                if(File.Exists(docPath))
                    this.ucDocumentReader1.SearchFromDocument("", docPath);
            }
            get
            {
                return docPath;
            }
        }



        #region //关闭 及 返回 按钮
        private void btn_Return_Click(object sender, EventArgs e)
        {
            frmMapGallery.Visible = true;
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
            Application.Exit();
        }
        #endregion

    }
}
