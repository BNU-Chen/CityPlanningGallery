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
using System.Data.SqlClient;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace CityPlanningGallery
{
    public partial class frmMapView : Form
    {
        private MainForm rootForm = null;
        private frmMapTitleGallery galleryForm = null;

        private int AutoPlayInterval = 1000;    //图层自动浏览时间间隔
        private string mapTitle = "";       //地图标题
        private string mapTitleWithoutIndex = "";   //没有序号的地图标题

        //地图对应的数据表
        private DataTable dt = new DataTable();
        
        public frmMapView(MainForm _rootForm, Form _frmGallery)
        {
            InitializeComponent();
            rootForm = _rootForm;
            galleryForm = (frmMapTitleGallery)_frmGallery;
            galleryForm.Visible = false;

            this.ucLegend1.AutoPlayeButton.Click += AutoPlayeButton_Click;
            clsGISTools.FullExtend(this.axMapControl1);
        }
        private void frmMapView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            

            
            this.ucShowMapInfo1.MapChartButton.Click += MapChartButton_Click;
        }

        void MapChartButton_Click(object sender, EventArgs e)
        {
            //获取表数据
            if (mapTitle != "")
            {
                string[] names = mapTitle.Split(' ');
                if (names.Length == 2)
                {
                    mapTitleWithoutIndex = names[1];
                }
                dt = clsSQLServerConnection.GetDataByTableName(mapTitleWithoutIndex);
                if (dt.DataSet != null && dt.DataSet.Tables.Count > 0 && dt.DataSet.Tables[0].Rows.Count > 0)
                {
                    this.ucShowMapInfo1.ChartDataTable = dt;
                }
            }
        }

        #region //自动加载图例图层按钮
        void AutoPlayeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucLegend1.ShowLegendLayers(false);

                if (this.ucLegend1.FlowLayoutLegend.Controls.Count > 0)
                {
                    foreach (Control ctrl in this.ucLegend1.FlowLayoutLegend.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            PictureBox pic = (PictureBox)ctrl;
                            int index = Convert.ToInt16(pic.Tag);
                            if (index < 0)
                            {
                                continue;
                            }
                            this.Refresh();
                            this.axMapControl1.ActiveView.Refresh();

                            System.Threading.Thread.Sleep(AutoPlayInterval);

                            pic.BackColor = Color.LightGray;
                            ILayer layer = this.axMapControl1.ActiveView.FocusMap.get_Layer(index);
                            layer.Visible = true;
                        }
                    }
                    this.Refresh();
                    this.axMapControl1.ActiveView.Refresh();
                }
            }
            catch { }
        }
        #endregion

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
                mapTitle = System.IO.Path.GetFileNameWithoutExtension(mapPath);
                this.lbl_MapTitle.Text = mapTitle;
                //加载地图
                this.axMapControl1.LoadMxFile(mapPath);
                this.axMapControl1.Refresh();
                //加载图例
                string mapFolder = System.IO.Path.GetDirectoryName(mapPath);
                string legendPath = clsConfig.GetLegendFolder(mapFolder) + "\\" + mapTitle;
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
                //加载缩略图
                string picPath = clsConfig.GetThumbFolder(mapFolder) + "\\" + mapTitle + ".jpg";
                if (File.Exists(picPath))
                {
                    this.panel_LeftTop.BackgroundImage = Image.FromFile(picPath);
                }
            }
        }

        #endregion
        
        #region //关闭按钮

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            galleryForm.Close();
            rootForm.Visible = true;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            galleryForm.Visible = true;
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
            clsGISTools.FullExtend(this.axMapControl1);
        }
        #endregion
        
        #region //MapControl事件
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
                GetFeatureInfo(e.mapX, e.mapY);
            }
            else if (e.button == 4)
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
        private void axMapControl1_Resize(object sender, EventArgs e)
        {
            clsGISTools.FullExtend(this.axMapControl1);
        }

        #endregion

        //获取要素属性
        private void GetFeatureInfo(double x, double y)
        {
            string cityName = "沈阳市";
            this.ucShowMapInfo1.FeatureInfo();      //切换到字段属性展示
            if (dt.DataSet != null && dt.DataSet.Tables.Count > 0 && dt.DataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dt.DataSet.Tables[0].Rows)
                {
                    string areaName = row["区域"].ToString();
                    if (areaName == cityName)
                    {
                        this.ucShowMapInfo1.SetFlowLayoutItems(dt.DataSet.Tables[0].Columns,row.ItemArray);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }


        #region //地图工具按钮事件
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
        #endregion



    }
}
