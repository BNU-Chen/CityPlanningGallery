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
                        string hoverImgPath = Config.GetThumbFolder(dataPath) + "\\" + title + ".jpg";

                        ucGalleryItem gi = new ucGalleryItem();
                        gi.Title = title;
                        gi.HoverImagePath = hoverImgPath;
                        gi.MxdPath = file.FullName;
                        gi.BackColorPanel.MouseClick += BackColorPanel_MouseClick;
                        gi.BackColorPanel.MouseEnter += BackColorPanel_MouseEnter;
                        gi.BackColorPanel.MouseLeave += BackColorPanel_MouseLeave;

                        gi.TitleLabel.MouseClick += BackColorPanel_MouseClick;
                        gi.TitleLabel.MouseEnter += BackColorPanel_MouseEnter;
                        gi.TitleLabel.MouseLeave += TitleLabel_MouseLeave;

                        this.flowLayoutPanel_Guihua.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        void TitleLabel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        void TitleLabel_MouseLeave(object sender, EventArgs e)
        {
        }

        void TitleLabel_MouseEnter(object sender, EventArgs e)
        {
        }

        void BackColorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            ucGalleryItem ucgi = null;
            if (sender is DevExpress.XtraEditors.PanelControl)
            {
                PanelControl panel = (PanelControl)sender;
                Control ctrl = panel.Parent;
                if (ctrl is ucGalleryItem)
                {
                    ucgi = (ucGalleryItem)ctrl;                    
                }
            }
            else if(sender is DevExpress.XtraEditors.LabelControl)
            {
                LabelControl label = (LabelControl)sender;
                Control ctrlPanel = label.Parent;
                if (ctrlPanel is DevExpress.XtraEditors.PanelControl)
                {
                    PanelControl panel = (PanelControl)ctrlPanel;
                    Control ctrl = panel.Parent;
                    if (ctrl is ucGalleryItem)
                    {
                        ucgi = (ucGalleryItem)ctrl;
                    }
                }
            }
            if (ucgi != null)
            {
                frmMapView frmMap = new frmMapView(parentForm, this);
                frmMap.MapPath = ucgi.MxdPath;
                frmMap.Show();
            }
        }
        void BackColorPanel_MouseEnter(object sender, EventArgs e)
        {
            ucGalleryItem ucgi = null;
            if (sender is DevExpress.XtraEditors.PanelControl)
            {
                PanelControl panel = (PanelControl)sender;
                Control ctrl = panel.Parent;
                if (ctrl is ucGalleryItem)
                {
                    ucgi = (ucGalleryItem)ctrl;
                }
            }
            else if (sender is DevExpress.XtraEditors.LabelControl)
            {
                LabelControl label = (LabelControl)sender;
                Control ctrlPanel = label.Parent;
                if (ctrlPanel is DevExpress.XtraEditors.PanelControl)
                {
                    PanelControl panel = (PanelControl)ctrlPanel;
                    Control ctrl = panel.Parent;
                    if (ctrl is ucGalleryItem)
                    {
                        ucgi = (ucGalleryItem)ctrl;
                    }
                }
            }

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
        void BackColorPanel_MouseLeave(object sender, EventArgs e)
        {            
            if (sender is DevExpress.XtraEditors.PanelControl)
            {
                this.pic_PreView.BackgroundImage = null;
                this.lbl_PreViewMapTitle.Text = "";
            }
        }
        #endregion

        #region //关闭按钮
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            parentForm.Visible = true;
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
