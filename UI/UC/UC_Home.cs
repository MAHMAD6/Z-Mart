using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z_Mart.UC
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private int index = 0;
        private string[] bannerNames = { "_1_", "_2_", "_3_", "_4_", "_5_", "_6_", "_7_", "_8_", "_9_" };
        private void UC_Home_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();

            banner();
        }
        private void banner()
        {
            string imageName = bannerNames[index];
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            if (index >= bannerNames.Length)
            {
                index = 0;
            }
            banner();
        }


    }

}
