using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;

namespace Z_Mart.UC
{
    public partial class Uc_ViewAdmin : UserControl
    {
        public Uc_ViewAdmin()
        {
            InitializeComponent();
        }
        public void viewItems()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var admin in PersonCRUD.List)
            {
                if(admin is Admin)
                {
                var adminU = new Uc_Admin(admin.UserName,admin.Password,admin.isExperienced, admin.image);
                flowLayoutPanel1.Controls.Add(adminU);
                }
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_ViewItems_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
