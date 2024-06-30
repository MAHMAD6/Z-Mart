using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Mart.UC
{
    public partial class uc_SearchAdmin : UserControl
    {
        public uc_SearchAdmin()
        {
            InitializeComponent();
        }
        public void ADD(Uc_Admin UcAdmin)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.Controls.Add(UcAdmin);
        }
        public void ADDcustomer(uc_Customer UcCustomer)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.Controls.Add(UcCustomer);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}
