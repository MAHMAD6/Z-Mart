using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class uc_ManageCustomers : UserControl
    {
        List<UserControl> Menus = new List<UserControl>();
        uc_SearchAdmin uc_SearchAdmin1 = new uc_SearchAdmin();
        uc_ViewCustomers uc_ViewCustomers1 = new uc_ViewCustomers();
        uc_DeleteCustomer uc_DeleteCustomer1 = new uc_DeleteCustomer();
        public uc_ManageCustomers()
        {
            InitializeComponent();
            Menus.Add(uc_SearchAdmin1);
            Menus.Add(uc_ViewCustomers1);
            Menus.Add(uc_DeleteCustomer1);
            // View
            pbview.Click += pview_Click;
            lview1.Click += pview_Click;
            lview2.Click += pview_Click;
            pview.MouseEnter += View_MouseEnter;
            pview.MouseLeave += View_MouseLeave;

            lview1.MouseEnter += View_MouseEnter;
            lview1.MouseLeave += View_MouseLeave;

            lview2.MouseEnter += View_MouseEnter;
            lview2.MouseLeave += View_MouseLeave;


            pbview.MouseEnter += View_MouseEnter;
            pbview.MouseLeave += View_MouseLeave;
            //DElete
            pbremove.Click += add_Click;
            lremove.Click += add_Click;
            premove.MouseEnter += Delete_MouseEnter;
            premove.MouseLeave += Delete_MouseLeave;

            lremove.MouseEnter += Delete_MouseEnter;
            lremove.MouseLeave += Delete_MouseLeave;

            pbremove.MouseEnter += Delete_MouseEnter;
            pbremove.MouseLeave += Delete_MouseLeave;
            //Feedback
            pfeedback.MouseEnter += Feedback_MouseEnter;
            pfeedback.MouseLeave += Feedback_MouseLeave;

            lfeedback.MouseEnter += Feedback_MouseEnter;
            lfeedback.MouseLeave += Feedback_MouseLeave;

            pbfeedback.MouseEnter += Feedback_MouseEnter;
            pbfeedback.MouseLeave += Feedback_MouseLeave;
        }
        private void Feedback_MouseEnter(object sender, EventArgs e)
        {
            pbfeedback.Image = Z_Mart.Properties.Resources.feedbck_gif;
            pfeedback.BackColor = Color.FromArgb(21, 43, 98);
        }
        private void Feedback_MouseLeave(object sender, EventArgs e)
        {
            pbfeedback.Image = Z_Mart.Properties.Resources.feedbck_ong;
            pfeedback.BackColor = Color.FromArgb(14, 28, 64);
        }
        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            pbremove.Image = Z_Mart.Properties.Resources.Remove_Customer;
            premove.BackColor = Color.FromArgb(21, 43, 98);
        }
        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            pbremove.Image = Z_Mart.Properties.Resources.Remove_Customer_Png;
            premove.BackColor = Color.FromArgb(14, 28, 64);
        }
        private void View_MouseEnter(object sender, EventArgs e)
        {
            pbview.Image = Z_Mart.Properties.Resources.View_Customers;
            pview.BackColor = Color.FromArgb(21, 43, 98);
        }
        private void View_MouseLeave(object sender, EventArgs e)
        {
            pview.BackColor = Color.FromArgb(14, 28, 64);
            pbview.Image = Z_Mart.Properties.Resources.View_Customer_PNg;
        }
        private void EnableUserControl(int index)
        {
            for (int i = 0; i < Menus.Count; i++)
            {
                if (i == index)
                {
                    Menus[i].BringToFront();
                    this.Controls.Add(Menus[i]);
                    Menus[i].Visible = true;
                    Menus[i].BringToFront();
                    Menus[i].Dock = DockStyle.Fill;
                    Menus[i].Enabled = true;
                }
                else
                {

                    Menus[i].Visible = false;
                    Menus[i].Enabled = false;
                }
            }
        }
        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string customerName = SearchButton.Text;
                Customer customer = CustomerCRUD.Find(customerName);
                if (customer != null && customer is Customer)
                {
                    uc_SearchAdmin1.Visible = true;
                    uc_SearchAdmin1.BringToFront();
                    uc_SearchAdmin1.Dock = DockStyle.Fill;
                    uc_Customer ucCustomer = new uc_Customer(customer.UserName, customer.Password, customer.image);
                    uc_SearchAdmin1.ADDcustomer(ucCustomer);
                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Customer Does Not Exist", "Please enter a valid username", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }
        }

        private void pview_Click(object sender, EventArgs e)
        {
            EnableUserControl(1);
            uc_ViewCustomers1.viewCustomers();

        }

        private void add_Click(object sender, EventArgs e)
        {
            EnableUserControl(2);

        }

        private void pfeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
