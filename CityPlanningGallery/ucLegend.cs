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
using System.Threading;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace CityPlanningGallery
{ 
    public partial class ucLegend : UserControl
    {
        private int AutoPlayInterval = 1000;    //图层自动浏览时间间隔

        public ucLegend()
        {
            InitializeComponent();
        }
        #region //封装字段
        private string legendFolderPath = "";
        public string LegendFolderPath
        {
            set
            {
                legendFolderPath = value;
                SetLegend(legendFolderPath);    //设置图例
            }
        }
        private AxMapControl axMapControl = null;
        public AxMapControl MapControl
        {
            set
            {
                this.axMapControl = value;
            }
            get
            {
                return this.axMapControl;
            }
        }

        public FlowLayoutPanel FlowLayoutLegend
        {
            get
            {
                return this.flowLayoutPanel_Legend;
            }
        }
        #endregion

        #region //设置图例
        private void SetLegend(string path)
        {
            this.flowLayoutPanel_Legend.Controls.Clear();

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
                        string ext = file.Extension.ToLower();
                        if (ext != ".jpg" && ext != ".png")
                        {
                            continue;
                        }
                        //取得图层序号
                        string[] names = file.Name.Split(' ');
                        if (names.Length != 2)
                        {
                            continue;
                        }
                        int layerIndex = Convert.ToInt16(names[0]);
                        if (layerIndex < 0)
                        {
                            continue;
                        }
                        //添加图例
                        Image img = new Bitmap(file.FullName);
                        PictureBox pic = new PictureBox();
                        pic.BackgroundImage = img;
                        pic.Size = new Size(230, 25);
                        pic.BackgroundImageLayout = ImageLayout.Zoom;
                        pic.Click += pic_Click;
                        pic.MouseEnter += pic_MouseEnter;
                        pic.MouseLeave += pic_MouseLeave;
                        pic.Tag = layerIndex;
                        pic.Cursor = Cursors.Hand;

                        this.flowLayoutPanel_Legend.Controls.Add(pic);

                        ILayer layer = this.axMapControl.ActiveView.FocusMap.get_Layer(layerIndex);
                        layer.Visible = false;      //隐藏图例的图层
                    }
                }
                //计算控件位置
                int flowHeight = this.flowLayoutPanel_Legend.Controls.Count * (25 + 5);
                //this.flowLayoutPanel_Legend.Size = new Size(this.flowLayoutPanel_Legend.Size.Width, flowHeight);
                this.Height = 57 + flowHeight;
                Control ctrlParent = this.Parent;
                if (ctrlParent is Panel)
                {
                    this.Location = new Point(this.Location.X, ctrlParent.Height - 25 - this.Height);
                }

                //刷新地图
                this.axMapControl.ActiveView.Refresh();
            }
            catch { }
        }
        #endregion

        #region //图例颜色控制
        void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int layerIndex = Convert.ToInt16(pic.Tag);
            if (layerIndex < 0)
            {
                return;
            }
            if (this.axMapControl == null)
            {
                return;
            }
            //MessageBox.Show("layerIndex:" + layerIndex);
            int layerCount = this.axMapControl.LayerCount;
            if (layerIndex >= layerCount)
            {
                return;
            }
            ILayer layer = this.axMapControl.ActiveView.FocusMap.get_Layer(layerIndex);
            if (layer.Visible)
            {
                pic.BackColor = Color.LightGray;
            }
            else
            {
                pic.BackColor = Color.White;
            }
        }

        void pic_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BackColor = Color.Gray;
            }
        }
        #endregion 

        #region //图例显示控制
        void pic_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                int layerIndex = Convert.ToInt16(pic.Tag);
                if (layerIndex < 0)
                {
                    return;
                }
                if (this.axMapControl == null)
                {
                    return;
                }
                //MessageBox.Show("layerIndex:" + layerIndex);
                int layerCount = this.axMapControl.LayerCount;
                if (layerIndex >= layerCount)
                {
                    return;
                }
                ILayer layer = this.axMapControl.ActiveView.FocusMap.get_Layer(layerIndex);
                layer.Visible = !layer.Visible;
                if (layer.Visible)
                {
                    pic.BackColor = Color.LightGray;
                }
                else
                {
                    pic.BackColor = Color.White;
                }
                this.axMapControl.ActiveView.Refresh();
            }
        }

        //是否显示所有图例图层
        public void ShowLegendLayers(bool layerVisible)
        {            
            if (this.flowLayoutPanel_Legend.Controls.Count > 0)
            {
                foreach (Control ctrl in this.flowLayoutPanel_Legend.Controls)
                {
                    if (ctrl is PictureBox)
                    {
                        PictureBox pic = (PictureBox)ctrl;
                        int index = Convert.ToInt16(pic.Tag);
                        if (index < 0)
                        {
                            continue;
                        }
                        if (layerVisible)
                        {
                            pic.BackColor = Color.LightGray;
                        }
                        else
                        {
                            pic.BackColor = Color.White;
                        }
                        ILayer layer = this.axMapControl.ActiveView.FocusMap.get_Layer(index);
                        layer.Visible = layerVisible;
                    }
                }
                this.axMapControl.ActiveView.Refresh();
            }
        }
        #endregion

    }
}
