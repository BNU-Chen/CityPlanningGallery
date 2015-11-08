using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public partial class ucShowMapInfo : UserControl
    {
        public ucShowMapInfo()
        {
            InitializeComponent();
            MapDescClick();
        }

        #region //封装字段
        public string MapDescStr
        {
            set
            {
                this.richTextBox1.Text = value;
            }
        }

        public DataTable ChartDataTable
        {
            set
            {
                //设置图表的数据
                this.ucChartTableShow1.DataSource = value;
                this.ucChartTableShow1.SetChartShow(DevExpress.XtraCharts.ViewType.Pie);
            }
        }

        public FlowLayoutPanel FlowLayoutControl
        {
            get { return this.flowLayoutPanel1; }
        }

        public SimpleButton MapDescButton
        {
            get { return this.btn_MapDesc; }
        }
        public SimpleButton MapChartButton
        {
            get { return this.btn_MapChart; }
        }
        public SimpleButton FeatureInfoButton
        {
            get { return this.btn_FeatureInfo; }
        }
        #endregion

        #region //按钮点击事件
        private void btn_MapDesc_Click(object sender, EventArgs e)
        {
            MapDescClick();
        }

        private void btn_MapChart_Click(object sender, EventArgs e)
        {
            MapChartClick();
        }

        private void btn_FeatureInfo_Click(object sender, EventArgs e)
        {
            FeatureInfo();
        }
        public void MapDescClick()
        {
            this.panel_MapChart.Visible = false;
            this.panel_FeatureInfo.Visible = false;
            this.panel_MapDesc.Visible = true;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Bottom;
            this.panel_btn_MapChart.Dock = DockStyle.Bottom;

            this.panel_btn_FeatureInfo.SendToBack();
            this.panel_MapChart.BringToFront();

            this.panel_MapDesc.Dock = DockStyle.Fill;
            this.panel_MapDesc.BringToFront();
        }
        public void MapChartClick()
        {
            this.panel_MapDesc.Visible = false;
            this.panel_MapChart.Visible = true;
            this.panel_FeatureInfo.Visible = false;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_MapChart.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Bottom;

            this.panel_MapChart.Dock = DockStyle.Fill;
            this.panel_MapChart.BringToFront();
        }
        public void FeatureInfo()
        {
            this.panel_MapDesc.Visible = false;
            this.panel_MapChart.Visible = false;
            this.panel_FeatureInfo.Visible = true;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_MapChart.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Top;

            this.panel_MapChart.SendToBack();
            this.panel_btn_FeatureInfo.BringToFront();

            this.panel_FeatureInfo.Dock = DockStyle.Fill;
            this.panel_FeatureInfo.BringToFront();
        }
        #endregion

        #region //设置要素属性信息
        public void SetFlowLayoutItems(DataColumnCollection cols, object[] rowValues)
        {
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < cols.Count; i++)
            {
                string colName = cols[i].Caption;
                string value = Convert.ToString(rowValues[i]);
                if (colName.Length == 0)
                {
                    continue;
                }
                if (i == 0)
                {
                    ucFeatureFieldItemSpecial ffis = new ucFeatureFieldItemSpecial();
                    ffis.Title = colName;
                    ffis.Value = value;
                    this.flowLayoutPanel1.Controls.Add(ffis);
                }
                else if (i % 2 == 0)
                {
                    ucFeatureFieldItemLong ffil = new ucFeatureFieldItemLong();
                    ffil.Title = colName;
                    ffil.Value = value;
                    this.flowLayoutPanel1.Controls.Add(ffil);
                }
                else
                {
                    ucFeatureFieldItemNormal ffin = new ucFeatureFieldItemNormal();
                    ffin.Title = colName;
                    ffin.Value = value;
                    this.flowLayoutPanel1.Controls.Add(ffin);
                }
            }
            this.flowLayoutPanel1.Refresh();
        }
        #endregion

    }
}
