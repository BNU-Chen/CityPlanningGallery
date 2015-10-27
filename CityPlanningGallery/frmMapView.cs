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
    public partial class frmMapView : Form
    {
        private MainForm rootForm = null;
        private frmMapTitleGallery galleryForm = null;
        public frmMapView(MainForm _rootForm, Form _frmGallery)
        {
            InitializeComponent();
            rootForm = _rootForm;
            galleryForm = (frmMapTitleGallery)_frmGallery;
            galleryForm.Visible = false;
        }

        #region //封装字段
        private string mapPath = "";

        public string MapPath
        {
            get { return mapPath; }
            set
            {
                mapPath = value;
                if (!File.Exists(mapPath))
                {
                    return;
                }
                string title = Path.GetFileNameWithoutExtension(mapPath);
                this.lbl_MapTitle.Text = title;

                this.axMapControl1.LoadMxFile(mapPath);
                this.axMapControl1.Refresh();
            }
        }

        #endregion


        #region //关闭按钮
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            galleryForm.Visible = true;
            this.Close();
        }

        private void lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Close.BackColor = Color.LightGray;
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Close.BackColor = Color.White;
        }
        #endregion

        #region //窗体移动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
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
        #endregion

    }
}
