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
    public partial class uc_Customer : UserControl
    {
        public uc_Customer(string username,string password,Image img)
        {
            InitializeComponent();
            L_username.Text = username;
            L_Password.Text = password;
            pb_Customer.Image = img;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void L_username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L_Password_Click(object sender, EventArgs e)
        {

        }

        private void uc_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
