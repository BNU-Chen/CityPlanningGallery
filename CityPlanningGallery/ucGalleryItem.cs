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
    public partial class ucGalleryItem : UserControl
    {
        public string Title
        {
            get
            {
                return this.lbl_Title.Text.Trim();
            }
            set
            {
                this.lbl_Title.Text = value;
            }
        }

        public ucGalleryItem()
        {
            InitializeComponent();
        }
    }
}
