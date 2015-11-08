using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;

namespace CityPlanningGallery
{
    public delegate void delegateExtentChange(IEnvelope env);
    public partial class ucTripleMap : UserControl
    {
        //使用委托，实现调用主窗体函数
        public delegateExtentChange mapExtentChange;

        public ucTripleMap()
        {
            InitializeComponent();
        }

        private void ucTripleMap_SizeChanged(object sender, EventArgs e)
        {
            this.axMapControl1.Height = this.Height / 2;
            this.axMapControl1.ActiveView.Refresh();
            this.axMapControl2.ActiveView.Refresh();
        }

        #region //封装字段
        //
        private IEnvelope extent;
        public IEnvelope MapExtent
        {
            get
            {
                return extent;
            }
            set
            {
                extent = value;
                this.axMapControl1.ActiveView.Extent = extent;
                this.axMapControl2.ActiveView.Extent = extent;

                this.axMapControl1.ActiveView.Refresh();
                this.axMapControl2.ActiveView.Refresh();

                this.Refresh();
            }
        }

        public string Map1Path
        {
            set
            {
                string path = value;
                if (!File.Exists(path) && System.IO.Path.GetExtension(path)==".mxd")
                {
                    return;
                }
                this.axMapControl1.LoadMxFile(path);
                this.axMapControl1.ActiveView.Refresh();
            }
        }
                
        public string Map2Path
        {
            set
            {
                string path = value;
                if (!File.Exists(path) && System.IO.Path.GetExtension(path) == ".mxd")
                {
                    return;
                }
                this.axMapControl2.LoadMxFile(path);
                this.axMapControl2.ActiveView.Refresh();
            }
        }
        #endregion
        
        #region //MapControl事件
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            AxMapControl mapControl = (AxMapControl)sender;

            if (e.button == 4)
            {
                mapControl.ActiveView.ScreenDisplay.PanStart(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
                mapControl.MousePointer = esriControlsMousePointer.esriPointerPan;
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            AxMapControl mapControl = (AxMapControl)sender;

            if (e.button == 4 && axMapControl1.ActiveView != null)
            {
                mapControl.ActiveView.ScreenDisplay.PanMoveTo(axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y));
            }
        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            AxMapControl mapControl = (AxMapControl)sender;

            if (e.button == 4 && axMapControl1.ActiveView != null)   //中键
            {
                mapControl.MousePointer = esriControlsMousePointer.esriPointerArrow;
                mapControl.ActiveView.ScreenDisplay.PanStop();
                mapControl.ActiveView.Refresh();
            }
        }

        private void axMapControl1_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //AxMapControl mapControl = (AxMapControl)sender;

            //extent = mapControl.ActiveView.Extent;
            //MapExtent = extent;
            //mapExtentChange(extent);            
        }
        #endregion

    }
}
