using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class uc_DeleteCustomer : UserControl
    {
        public uc_DeleteCustomer()
        {
            InitializeComponent();
            tb_username.GotFocus += tb_username_Gotfocus;
        }
        private void tb_username_Gotfocus(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }
        private void uc_DeleteCustomer_Load(object sender, EventArgs e)
        {
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            string userName = tb_username.Text.ToString();
            if (string.IsNullOrWhiteSpace(userName))
            {
                userNameErrorLabel.Text = "Invalid UserName";
                userNameErrorLabel.Visible = true;
            }
            else if (!Regex.IsMatch(userName, @"^[A-Za-z0-9]+$"))
            {
                userNameErrorLabel.Text = "Invalid UserName";
                userNameErrorLabel.Text = "Only Alphabets and Numbers are allowed";
                userNameErrorLabel.Visible = true;
            }
            else if (userName.Length < 4)
            {
                userNameErrorLabel.Text = "UserName must have 4 letters";
                userNameErrorLabel.Visible = true;
            }
            else
            {
                userNameErrorLabel.Visible = false;
            }
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = tb_username.Text;
                var customer = CustomerCRUD.Find(name);
                if (customer != null)
                {
                    PersonCRUD.StoreToFile();
                    CustomerCRUD.Remove(customer);
                    this.Hide();


                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Customer Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            tb_username.Text = "Enter User Name";
            userNameErrorLabel.Visible = false;
            this.Hide();
        }

        private void userNameErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
