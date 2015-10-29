using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPlanningGallery
{
    public partial class ucShowMapInfo : UserControl
    {
        public ucShowMapInfo()
        {
            InitializeComponent();
        }

        private void btn_MapDesc_Click(object sender, EventArgs e)
        {
            this.panel_MapChart.Visible = false;
            this.panel_FeatureInfo.Visible = false;
            this.panel_MapDesc.Visible = true;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Bottom;
            this.panel_btn_MapChart.Dock = DockStyle.Bottom;

            this.panel_btn_MapDesc.TabIndex = 2;
            this.panel_btn_MapChart.TabIndex = 4;
            this.panel_btn_FeatureInfo.TabIndex = 3;
            
            this.panel_MapDesc.Dock = DockStyle.Fill;
        }

        private void btn_MapChart_Click(object sender, EventArgs e)
        {
            this.panel_MapDesc.Visible = false;
            this.panel_MapChart.Visible = true;
            this.panel_FeatureInfo.Visible = false;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_MapChart.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Bottom;

            this.panel_btn_MapDesc.TabIndex = 2;
            this.panel_btn_MapChart.TabIndex = 4;
            this.panel_btn_FeatureInfo.TabIndex = 3;

            this.panel_MapChart.Dock = DockStyle.Fill;
        }

        private void btn_FeatureInfo_Click(object sender, EventArgs e)
        {
            this.panel_MapDesc.Visible = false;
            this.panel_MapChart.Visible = false;
            this.panel_FeatureInfo.Visible = true;

            this.panel_btn_MapDesc.Dock = DockStyle.Top;
            this.panel_btn_MapChart.Dock = DockStyle.Top;
            this.panel_btn_FeatureInfo.Dock = DockStyle.Top;

            this.panel_btn_MapDesc.TabIndex = 2;
            this.panel_btn_MapChart.TabIndex = 3;
            this.panel_btn_FeatureInfo.TabIndex = 4;

            this.panel_FeatureInfo.Dock = DockStyle.Fill;
        }
    }
}
