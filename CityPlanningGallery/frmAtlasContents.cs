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
    public partial class frmAtlasContents : Form
    {
        private frmMapTitleGallery parentForm = null;
        SuperToolTip sToolTip;

        public frmAtlasContents(frmMapTitleGallery _frm)
        {
            InitializeComponent();
            this.flowLayoutPanel_Status.VerticalScroll.Visible = false;
            this.flowLayoutPanel_Planning.VerticalScroll.Visible = false;
            this.flowLayoutPanel_Analysis.VerticalScroll.Visible = false;
            parentForm = _frm;
            parentForm.Visible = false;
        }

        private void frmAtlasContents_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel_Status.MouseWheel += FlowLayoutPanel_MouseWheel;
            this.flowLayoutPanel_Planning.MouseWheel += FlowLayoutPanel_MouseWheel;
            this.flowLayoutPanel_Analysis.MouseWheel += FlowLayoutPanel_MouseWheel;
        }

        public void SetFlowLayouts(string statusFloderPath, string planningFloderPath, string analysisFloderPath, string fileExtension)
        {
            this.flowLayoutPanel_Status.Controls.Clear();
            SetFlowLayout(statusFloderPath, this.flowLayoutPanel_Status, fileExtension);
            this.flowLayoutPanel_Planning.Controls.Clear();
            SetFlowLayout(planningFloderPath, this.flowLayoutPanel_Planning, fileExtension);
            this.flowLayoutPanel_Analysis.Controls.Clear();
            SetFlowLayout(analysisFloderPath, this.flowLayoutPanel_Analysis, fileExtension);
        }

        #region //为FlowLayoutPanel控件加载ucGalleryItem
        private void SetFlowLayout(string path, FlowLayoutPanel flowLayoutPanel, string fileExtension)
        {
            if (!Directory.Exists(path))
            {
                return;
            }
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
                        if (ext.ToLower() != fileExtension)
                            continue;
                        string title = Path.GetFileNameWithoutExtension(file.FullName);

                        ucGalleryItemImg gi = new ucGalleryItemImg();
                        gi.Tag = file.FullName;
                        gi.Title = title;
                        gi.Size = new Size(flowLayoutPanel.Size.Width-25, gi.Size.Height);

                        gi.delegateGalleryItemImgClick += new delegateGalleryItemImgClick(gi_Click);
                        gi.delegateGalleryItemImgMouseEnter += new delegateGalleryItemImgMouseEnter(gi_MouseEnter);
                        gi.delegateGalleryItemImgMouseLeave += new delegateGalleryItemImgMouseLeave(gi_MouseLeave);

                        flowLayoutPanel.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        void gi_Click(ucGalleryItemImg ucgi)
        {
            frmAtalsBrowse frmBrowse = new frmAtalsBrowse(this);
            frmBrowse.ImageFilePath = ucgi.Tag.ToString();
            frmBrowse.Show();
        }

        void gi_MouseEnter(ucGalleryItemImg ucgi)
        {
            this.sToolTip = new SuperToolTip();
            Image img = Image.FromFile(ucgi.Tag.ToString());
            Image imgs = img.GetThumbnailImage(400, 273, null, IntPtr.Zero);
            SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();
            args.Contents.Image = imgs;
            this.sToolTip.Setup(args);
            ucgi.TitleLabel.SuperTip = this.sToolTip;
        }

        void gi_MouseLeave(ucGalleryItemImg ucgi)
        {
            ucgi.TitleLabel.SuperTip = null;
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
