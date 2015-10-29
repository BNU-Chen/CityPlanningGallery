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
using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public partial class frmMapTitleGallery : Form
    {
        private string dataPath = "";
        private MainForm parentForm = null;

        public frmMapTitleGallery(Form _frm)
        {
            InitializeComponent();
            parentForm = (MainForm)_frm;
            parentForm.Visible = false;
        }

        public string DataPath
        {
            set
            {
                dataPath = value;
                if (!Directory.Exists(dataPath))
                {
                    return;
                }
                SetFlowLayout(dataPath);
            }
            get
            {
                return dataPath;
            }
        }


        #region //GalleryItem
        private void SetFlowLayout(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            try
            {
                for (int i = 0; i < files.Length; i++)
                {
                    //如果不是文件
                    if (files[i] is FileInfo)
                    {
                        FileInfo file = files[i] as FileInfo;
                        string ext = file.Extension;
                        if (ext.ToLower() != ".mxd")
                        {
                            continue;
                        }
                        string title = Path.GetFileNameWithoutExtension(file.FullName);
                        string hoverImgPath = clsConfig.GetThumbFolder(dataPath) + "\\" + title + ".jpg";

                        ucGalleryItem gi = new ucGalleryItem();
                        gi.Title = title;
                        gi.HoverImagePath = hoverImgPath;
                        gi.DataPath = file.FullName;

                        gi.delegateClick += new delegateClick(gi_Click);
                        gi.delegateMouseEnter += new delegateMouseEnter(gi_MouseEnter);
                        gi.delegateMouseLeave += new delegateMouseLeave(gi_MouseLeave);
                        //滚动事件
                        gi.MouseWheel += FlowLayoutMouseWheel_MouseWheel;
                        //gi.BackColorPanel.MouseWheel += FlowLayoutMouseWheel_MouseWheel;
                        //gi.TitleLabel.MouseWheel += FlowLayoutMouseWheel_MouseWheel;
                        this.flowLayoutPanel_GalleryItem.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        void gi_Click(ucGalleryItem ucgi)
        {
            frmMapView frmMap = new frmMapView(parentForm, this);
            frmMap.MapPath = ucgi.DataPath;
            frmMap.Show();
        }

        void gi_MouseEnter(ucGalleryItem ucgi)
        {
            if (ucgi != null)
            {
                if (!File.Exists(ucgi.HoverImagePath))
                {
                    return;
                }
                Image img = Image.FromFile(ucgi.HoverImagePath);
                this.pic_PreView.BackgroundImage = img;
                this.lbl_PreViewMapTitle.Text = ucgi.Title;
            }
        }

        void gi_MouseLeave(ucGalleryItem ucgi)
        {
            this.pic_PreView.BackgroundImage = null;
            this.lbl_PreViewMapTitle.Text = "";
        }

        void FlowLayoutMouseWheel_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                this.flowLayoutPanel_GalleryItem.Focus();
            }
            catch { }
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
