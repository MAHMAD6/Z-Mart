using System;
using System.Windows.Forms;

namespace Z_Mart.UC
{
    public partial class Uc_ItemSearch : UserControl
    {
        public Uc_ItemSearch()
        {
            InitializeComponent();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ADD(UC_Item UcItem)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.Controls.Add(UcItem);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_ViewItems_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
