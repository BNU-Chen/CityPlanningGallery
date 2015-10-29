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
    public partial class ucFeatureFieldItemLong : UserControl
    {
        public ucFeatureFieldItemLong()
        {
            InitializeComponent();
        }

        public string Title
        {
            set { this.lbl_Title.Text = value; }
        }
        public string Value
        {
            set { this.lbl_Value.Text = value; }
        }
    }
}
