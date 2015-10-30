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
                if (File.Exists(docPath))
                {
                    this.ucDocumentReader1.SearchFromDocument("", docPath);
                    this.labelControl1.Text = Path.GetFileNameWithoutExtension(docPath).ToString();
                }

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


        #region //窗体移动与放大
        System.Drawing.Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new System.Drawing.Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                System.Drawing.Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                this.Location = mouseSet;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void Form_DoubleClick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
