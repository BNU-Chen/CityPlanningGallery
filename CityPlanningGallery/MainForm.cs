﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //启动界面
            frmStart fs = new frmStart(this);
            fs.ShowDialog();
        }

        #region //关闭窗体

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
            if (MessageBox.Show( "您确定要退出吗？","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region //按钮
        private void btn_Xianzhuang_Click(object sender, EventArgs e)
        {
            frmMapTitleGallery frmGallery = new frmMapTitleGallery(this);
            frmGallery.DataPath = clsConfig.PlanningMapXianzhuangFolder;
            frmGallery.GalleryTitle = "现 状 图";
            frmGallery.Show();
        }

        private void btn_Guihua_Click(object sender, EventArgs e)
        {
            frmMapTitleGallery frmGallery = new frmMapTitleGallery(this);
            frmGallery.DataPath = clsConfig.PlanningMapGuihuaFolder;
            frmGallery.IsShowPlanningDocs = true;
            frmGallery.GalleryTitle = "规 划 图";
            frmGallery.Show();
        }

        private void btn_Fenxi_Click(object sender, EventArgs e)
        {
            frmMapTitleGallery frmGallery = new frmMapTitleGallery(this);
            frmGallery.DataPath = clsConfig.PlanningMapFenxiFolder;
            frmGallery.GalleryTitle = "分 析 图";
            frmGallery.Show();
        }
        private void btn_Xianzhuang_MouseEnter(object sender, EventArgs e)
        {
            SimpleButton sb = (SimpleButton)sender;
            if (sb != null)
            {
                sb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            }
        }

        private void btn_Xianzhuang_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton sb = (SimpleButton)sender;
            if (sb != null)
            {
                sb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
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
