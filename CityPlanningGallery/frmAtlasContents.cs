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
    public partial class frmAtlasContents : Form
    {
        private MainForm parentForm = null;

        public frmAtlasContents(MainForm _frm)
        {
            InitializeComponent();
            parentForm = _frm;
            parentForm.Visible = false;
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

        private void SetFlowLayout(string path, FlowLayoutPanel flowLayoutPanel, string fileExtension)
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
                        if (ext.ToLower() != fileExtension)
                            continue;
                        string title = Path.GetFileNameWithoutExtension(file.FullName);
                        
                        ucGalleryItem gi = new ucGalleryItem();
                        gi.Tag = file.FullName;
                        gi.Title = title;

                        //滚动事件
                        ReturnucGalleryItemMouseWheelEnterToFlowLayout(gi, flowLayoutPanel);

                        flowLayoutPanel.Controls.Add(gi);
                    }
                }
            }
            catch { }
        }

        #region//ucGalleryItem鼠标滚动事件转移至FlowLayoutPanel
        private void ReturnucGalleryItemMouseWheelEnterToFlowLayout(ucGalleryItem gi, FlowLayoutPanel flowLayoutPanel)
        {
            string flowLayouyPanelName = flowLayoutPanel.Name;
            switch (flowLayouyPanelName)
            {
                case "flowLayoutPanel_Status":
                    gi.MouseWheel += FlowLayoutPanel_Status_MouseWheel;
                    break;
                case "flowLayoutPanel_Planning":
                    gi.MouseWheel += FlowLayoutPanel_Planning_MouseWheel;
                    break;
                case "flowLayoutPanel_Analysis":
                    gi.MouseWheel += FlowLayoutPanel_Analysis_MouseWheel;
                    break;
            }
        }
        //现状FlowLayoutPanel鼠标滚动事件
        private void FlowLayoutPanel_Status_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                this.flowLayoutPanel_Status.Focus();
            }
            catch { }
        }
        //规划FlowLayoutPanel鼠标滚动事件
        private void FlowLayoutPanel_Planning_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                this.flowLayoutPanel_Planning.Focus();
            }
            catch { }
        }
        //分析FlowLayoutPanel鼠标滚动事件
        private void FlowLayoutPanel_Analysis_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                this.flowLayoutPanel_Analysis.Focus();
            }
            catch { }
        }
        #endregion

        #region //关闭按钮相关事件
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
    }
}
