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
using DevExpress.Utils;

namespace CityPlanningGallery
{
    public partial class frmThematicDocContents : Form
    {
        private frmMapTitleGallery parentForm = null;

        SuperToolTip sToolTip;

        public frmThematicDocContents(frmMapTitleGallery _frm)
        {
            InitializeComponent();
            this.flowLayoutPanel_ThematicDoc.VerticalScroll.Visible = false;
            parentForm = _frm;
            parentForm.Visible = false;
        }

        private void frmAtlasContents_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel_ThematicDoc.MouseWheel += FlowLayoutPanel_MouseWheel;
        }

        #region //为FlowLayoutPanel控件加载ucGalleryItem
        public void SetFlowLayout(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
            this.flowLayoutPanel_ThematicDoc.Controls.Clear();

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
                        if (ext.ToLower() != ".doc" && ext.ToLower() != ".docx")
                            continue;
                        string title = Path.GetFileNameWithoutExtension(file.FullName);

                        ucGalleryItemDoc gi = new ucGalleryItemDoc();
                        gi.Title = title;
                        gi.HoverImagePath = clsConfig.GetThumbFolder(path) + "\\" + title + ".jpg"; 
                        gi.Size = new Size(this.flowLayoutPanel_ThematicDoc.Size.Width - 20, gi.Size.Height);
                        gi.DataPath = file.FullName;

                        gi.delegateGalleryItemDocClick += new delegateGalleryItemDocClick(gi_Click);
                        gi.delegateGalleryItemDocMouseEnter += new delegateGalleryItemDocMouseEnter(gi_MouseEnter);
                        gi.delegateGalleryItemDocMouseLeave += new delegateGalleryItemDocMouseLeave(gi_MouseLeave);

                        this.flowLayoutPanel_ThematicDoc.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        void gi_Click(ucGalleryItemDoc ucgi)
        {
            frmDocViewer frmDoc = new frmDocViewer(this);
            frmDoc.DocPath = ucgi.DataPath;
            this.Visible = false;
            frmDoc.Show();
        }

        void gi_MouseEnter(ucGalleryItemDoc ucgi)
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

        void gi_MouseLeave(ucGalleryItemDoc ucgi)
        {
            this.pic_PreView.BackgroundImage = null;
            this.lbl_PreViewMapTitle.Text = "";
        }
        #endregion

        #region//FlowLayoutPanel鼠标事件
        //FlowLayoutPanel鼠标滚动事件
        private void FlowLayoutPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (sender is FlowLayoutPanel)
                {
                    FlowLayoutPanel flow = (FlowLayoutPanel)sender;
                    flow.Focus();
                }
            }
            catch { }
        }
        //FlowLayoutPanel（3个）鼠标进入事件
        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (sender is FlowLayoutPanel)
                {
                    FlowLayoutPanel flow = (FlowLayoutPanel)sender;
                    flow.Focus();
                }
            }
            catch { }
        }
        //FlowLayoutPanel（3个）鼠标移出事件
        private void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {

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
            if (MessageBox.Show("您确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
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
