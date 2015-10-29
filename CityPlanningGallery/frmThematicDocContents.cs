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
                        
                        ucGalleryItem gi = new ucGalleryItem();
                        gi.Tag = file.FullName;
                        gi.Title = title;
                        gi.Size = new Size(this.flowLayoutPanel_ThematicDoc.Size.Width -20, gi.Size.Height);
                        
                        gi.delegateClick += new delegateClick(gi_Click);
                        gi.delegateMouseEnter += new delegateMouseEnter(gi_MouseEnter);
                        gi.delegateMouseLeave += new delegateMouseLeave(gi_MouseLeave);

                        this.flowLayoutPanel_ThematicDoc.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        void gi_Click(ucGalleryItem ucgi)
        {
            frmDocViewer frmDoc = new frmDocViewer(this.parentForm);
            frmDoc.DocPath = ucgi.Tag.ToString();
            this.Visible = false;
            frmDoc.Show();
        }

        void gi_MouseEnter(ucGalleryItem ucgi)
        {
            
        }

        void gi_MouseLeave(ucGalleryItem ucgi)
        {
            
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
            Application.Exit();
        }
        #endregion
    }
}
