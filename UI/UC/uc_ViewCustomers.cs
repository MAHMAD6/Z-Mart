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
    public partial class uc_ViewCustomers : UserControl
    {
        public uc_ViewCustomers()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void viewCustomers()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var customer in CustomerCRUD.List)
            {
                if(customer is Customer)
                {

                    var customerU = new uc_Customer(customer.UserName, customer.Password, customer.image);
                    flowLayoutPanel1.Controls.Add(customerU);
                }
            }
        }
    }
}
