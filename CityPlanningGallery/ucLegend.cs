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
using ESRI.ArcGIS.Carto;

namespace CityPlanningGallery
{ 
    public partial class ucLegend : UserControl
    {
        public ucLegend()
        {
            InitializeComponent();
        }
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

        //设置图例
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

                        Image img = new Bitmap(file.FullName);
                        PictureBox pic = new PictureBox();
                        pic.BackgroundImage = img;
                        pic.Size = new Size(230, img.Height);
                        pic.Click += pic_Click;
                        pic.Tag = layerIndex;
                        this.flowLayoutPanel_Legend.Controls.Add(pic);
                    }
                }
            }
            catch { }
        }

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
                this.axMapControl.ActiveView.Refresh();
            }
        }
    }
}
