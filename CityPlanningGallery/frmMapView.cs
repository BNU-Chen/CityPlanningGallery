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
        private ucTripleMap m_ucTripleMap = null;   //三图对比控件

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

            clsGISTools.FullExtend(this.axMapControl1);
        }

        #region //预加载
        private void frmMapView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            getMapRelatedData();    //读取地图相关数据
            SetMapDescription();    //读取地图介绍    

            this.ucShowMapInfo1.FeatureInfoButton.Click += FeatureInfoButton_Click;
        }

        private void SetMapDescription()
        {
            if (mapTitle != "")
            {
                string mapFolder = System.IO.Path.GetDirectoryName(mapPath);
                string mapDescPath = clsConfig.GetMapDescription(mapFolder) + "\\" + mapTitle + ".txt";
                if (File.Exists(mapDescPath))
                {
                    System.IO.StreamReader st =null;
                    try
                    {
                        st = new System.IO.StreamReader(mapDescPath, System.Text.Encoding.Default);
                        string text = st.ReadToEnd();
                        //string text = System.IO.File.ReadAllText(mapDescPath, Encoding.ASCII);
                        if (text != "")
                        {
                            this.ucShowMapInfo1.MapDescStr = text;
                        }
                        else
                        {
                            this.ucShowMapInfo1.MapDescStr = mapTitle;
                        }
                    }
                    catch { }
                    finally
                    {
                        if (st != null)
                        {
                            st.Close();
                        }
                    }
                }
                else
                {
                    this.ucShowMapInfo1.MapDescStr = mapTitle;
                }
            }
        }
        
        //获取表数据
        private void getMapRelatedData()
        {            
            if (mapTitle != "")
            {
                string[] names = mapTitle.Split(' ');
                if (names.Length == 2)
                {
                    mapTitleWithoutIndex = names[1];
                }
                if (dt.DataSet == null)
                {
                    //dt = clsSQLServerConnection.GetDataByTableName(mapTitleWithoutIndex);
                    dt = clsAccessDatabase.GetDataByTableName(mapTitleWithoutIndex);
                }
                if (dt.DataSet != null && dt.DataSet.Tables.Count > 0 && dt.DataSet.Tables[0].Rows.Count > 0)
                {
                    this.ucShowMapInfo1.ChartDataTable = dt;
                }
            }
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
                string xzqmc = clsGISHandler.GetXMQMC(this.axMapControl1, e);
                if(xzqmc!=""){
                    GetFeatureInfo(xzqmc);
                }
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

        private void axMapControl1_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            if (m_ucTripleMap != null && m_ucTripleMap.Visible)
            {
                m_ucTripleMap.MapExtent = this.axMapControl1.ActiveView.Extent;
            }
        }
        
        //获取要素属性
        private void GetFeatureInfo(string xzqmc)
        {
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.ucShowMapInfo1.FeatureInfo();      //切换到字段属性展示

            if (xzqmc != "")
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string cityName = row["区域"].ToString();
                        if (xzqmc == cityName)
                        {
                            this.ucShowMapInfo1.SetFlowLayoutItems(dt.DataSet.Tables[0].Columns, row.ItemArray);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        void FeatureInfoButton_Click(object sender, EventArgs e)
        {
            GetFeatureInfo("沈阳市");
        }
        #endregion
                
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
                case "tsbtn_AutoPlayLegend":
                    AutoPlayeButton_Click();
                    break;
                case "tsbtn_CtrlLegendLayer":
                    tsbtn_AllLayer_Click();
                    break;
                case "tsbtn_TripleMap":
                    this.panel_RightInfo.Visible = !this.panel_RightInfo.Visible;
                    if (!this.panel_RightInfo.Visible)
                    {
                        if (m_ucTripleMap == null)
                        {
                            m_ucTripleMap = new ucTripleMap();
                            m_ucTripleMap.Dock = DockStyle.Fill;
                            m_ucTripleMap.Map1Path = clsConfig.RootDataPath+ clsConfig.TripleMap1;
                            m_ucTripleMap.Map2Path = clsConfig.RootDataPath + clsConfig.TripleMap2;
                            m_ucTripleMap.MapExtent = this.axMapControl1.ActiveView.Extent;
                            //m_ucTripleMap.mapExtentChange += new delegateExtentChange(OnExtentChange);
                            this.panel_RightHome.Controls.Add(m_ucTripleMap);
                            this.panel_RightHome.Refresh();
                        }
                        else
                        {
                            m_ucTripleMap.Visible = true;
                        }
                    }
                    else
                    {
                        if (m_ucTripleMap != null)
                        {
                            m_ucTripleMap.Visible = false;
                        }
                    }
                    break;
            }
        }

        //extent改变
        private void OnExtentChange(IEnvelope extent)
        {
            this.axMapControl1.ActiveView.Extent = extent;
        }
 
        //自动播放图例
        void AutoPlayeButton_Click()
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

                    //处理按钮
                    this.tsbtn_CtrlLegendLayer.Text = "局部浏览";
                    this.tsbtn_CtrlLegendLayer.Image = new Bitmap(CityPlanningGallery.Properties.Resources.unCheck_icon);
                }
            }
            catch { }
        }
        //图例图层控制 - 整体浏览和局部浏览
        private void tsbtn_AllLayer_Click()
        {
            try
            {
                if (this.tsbtn_CtrlLegendLayer.Text == "整体浏览")
                {
                    this.tsbtn_CtrlLegendLayer.Text = "局部浏览";
                    this.tsbtn_CtrlLegendLayer.Image = new Bitmap(CityPlanningGallery.Properties.Resources.unCheck_icon);
                    this.ucLegend1.ShowLegendLayers(true);
                }
                else
                {
                    this.tsbtn_CtrlLegendLayer.Text = "整体浏览";
                    this.tsbtn_CtrlLegendLayer.Image = new Bitmap(CityPlanningGallery.Properties.Resources.select_all);
                    this.ucLegend1.ShowLegendLayers(false);
                }
            }
            catch { }
        }
        #endregion

    }
}
