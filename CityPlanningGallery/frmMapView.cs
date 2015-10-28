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
using ESRI.ArcGIS.Controls;

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
                //设置地图标题
                string title = Path.GetFileNameWithoutExtension(mapPath);
                this.lbl_MapTitle.Text = title;
                //加载地图
                this.axMapControl1.LoadMxFile(mapPath);
                this.axMapControl1.Refresh();
                //加载图例
                string mapFolder = Path.GetDirectoryName(mapPath);
                string legendPath = clsConfig.GetLegendFolder(mapFolder) + "\\" + title;
                if (Directory.Exists(legendPath))
                {
                    this.ucLegend1.MapControl = this.axMapControl1;
                    this.ucLegend1.Visible = true;
                    this.ucLegend1.LegendFolderPath = legendPath;
                }
                else
                {
                    this.ucLegend1.Visible = false;
                }
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

        #region //窗体移动与放大
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

        private void frmMapView_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion


        #region //MapControl事件
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 4)
            {
                axMapControl1.ActiveView.ScreenDisplay.PanStart(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPan;
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 4 && axMapControl1.ActiveView != null)
            {
                axMapControl1.ActiveView.ScreenDisplay.PanMoveTo(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
            }
        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            if (e.button == 4 && axMapControl1.ActiveView != null)   //中键
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerArrow;
                axMapControl1.ActiveView.ScreenDisplay.PanStop();
                axMapControl1.ActiveView.Refresh();
            }
        }
        #endregion

        private void toolStrip_MapTool_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string name = e.ClickedItem.Name;
            switch (name)
            {
                case "tsbtn_ZoomIn":
                    clsGISTools.ZoomInFix(this.axMapControl1);
                    break;
                case "tsbtn_ZoomOut":
                    clsGISTools.ZoomOutFix(this.axMapControl1);
                    break;
                case "tsbtn_FullExtent":
                    clsGISTools.FullExtend(this.axMapControl1);
                    break;
            }
        }

    }
}
