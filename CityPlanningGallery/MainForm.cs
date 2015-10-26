using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CityPlanningGallery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //启动界面
            frmStart fs = new frmStart(this);
            fs.ShowDialog();
        }

        #region //关闭窗体
        private void lbl_Close_Click(object sender, EventArgs e)
        {
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

        #region //按钮
        private void btn_Xianzhuang_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guihua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fenxi_Click(object sender, EventArgs e)
        {

        }
        private void btn_Xianzhuang_MouseEnter(object sender, EventArgs e)
        {
            SimpleButton sb = (SimpleButton)sender;
            if (sb != null)
            {
                sb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            }
        }

        private void btn_Xianzhuang_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton sb = (SimpleButton)sender;
            if (sb != null)
            {
                sb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
        }
        #endregion
    }
}
