using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CityPlanningGallery
{
    public partial class frmStart : Form
    {
        //渐变步长
        private double OPACITY_STEP1 = 0.03;
        private double OPACITY_STEP2 = 0.07;
        private double OPACITY_STEP3 = 0.1;
        //渐变等级，先慢，后快
        private double OPACITY_LEVEL1 = 0.3;
        private double OPACITY_LEVEL2 = 0.6;
        private MainForm mainFrm;

        public frmStart(MainForm _MainForm)
        {
            InitializeComponent();
            mainFrm = _MainForm;
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.Refresh();
            mainFrm.Opacity = 0;
            
        }

        private void frmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();
            //如果点击取消按钮，则mainFrm已经被释放
            if (mainFrm != null)
            {
                if (!mainFrm.IsDisposed)
                {
                    mainFrm.Opacity = 1;
                }
            }
        }

        //渐变的timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.Opacity >= OPACITY_LEVEL1)
                {
                    this.Opacity -= OPACITY_STEP1;
                }
                else if (this.Opacity < OPACITY_LEVEL2 && this.Opacity >= OPACITY_LEVEL1 && this.Opacity >= OPACITY_STEP2)
                {
                    this.Opacity -= OPACITY_STEP2;
                }
                else if (this.Opacity < OPACITY_LEVEL1 && this.Opacity >= OPACITY_STEP3)
                {
                    this.Opacity -= OPACITY_STEP3;
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                this.Close();
            }
            this.Refresh();
        }

        private void frmStart_Shown(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            timer1.Start();
        }

    }
}
