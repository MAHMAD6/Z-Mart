using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class CustomerProfile : UserControl
    {
        Customer customer;
        bool isValidUsername = false;
        bool isValidPassword = false;
        CustomerMainMenu menu;
        public CustomerProfile(CustomerMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            pb_password.MouseEnter += pb_username_MouseEnter;
            pb_password.MouseLeave += pb_username_MouseLeave;


        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            l_username.Visible = true;
            pb_username.Visible = true;
            tb_username.Visible = false;
            p_usernme.Visible = false;
            // password
            tb_EnterPassword.Visible = false;
            pb_password.Visible = false;
            p_pssword.Visible = false;
            L_InvalidPassword.Visible = false;
            pb_password.Visible = true;
            l_password.Visible = true;

            L_InvalidUserName.Visible = false;
            var customer2 = CustomerCRUD.Find(LoginPage.CurrentCustomer);
            var customer1 = CustomerCRUD.Find(SignUpPage.currentCustomer);
            if (customer1 != null)
            {
                customer = customer1;
            }
            else
            {
                customer = customer2;
            }
            if (customer != null)
            {
                pb_profile.Image = customer.image;
                l_username.Text = customer.UserName;
                l_password.Text = customer.Password;
                refresh();
            }
        }
        public void refresh()
        {
            l_totalOrders.Text = customer.Cart.Count.ToString();
            L_totalcarted.Text = customer.Cart.Count.ToString();
            double total = 0;
            double count = 1;
            foreach (var item in customer.Cart)
            {
                if (total != count)
                {
                    total += item.Quantity * item.Price;
                    count = total;
                }
            }
            l_totalPrice.Text = total.ToString();
        }

        private void Pb_ChangeProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = dialog.FileName;
                string locationToStoreImage = "C:\\Program files\\Z Mart\\Images";
                if (!Directory.Exists(locationToStoreImage))
                {
                    Directory.CreateDirectory(locationToStoreImage);
                }
                string nameOfImageFile = "Image_Of_" + customer.UserName + ".png";
                try
                {
                    File.Copy(imageLocation, locationToStoreImage + "\\" + nameOfImageFile, true);
                }
                catch { }


                pb_profile.ImageLocation = imageLocation;
                customer.image = Image.FromFile(dialog.FileName);
                menu.changeUser(customer.UserName, Image.FromFile(dialog.FileName));
            }
        }

        private void pb_username_Click(object sender, EventArgs e)
        {
            l_username.Visible = false;
            pb_username.Visible = false;
            tb_username.Visible = true;
            p_usernme.Visible = true;
        }

        private void pb_password_Click(object sender, EventArgs e)
        {
            pb_password.Visible = false;
            p_pssword.Visible = true;
            tb_EnterPassword.Visible = true;
            l_password.Visible = false;

        }

        private void Pb_ChangeProfile_MouseEnter(object sender, EventArgs e)
        {
            Pb_ChangeProfile.Image = Z_Mart.Properties.Resources.change_userProfile_pink;
        }

        private void Pb_ChangeProfile_MouseLeave(object sender, EventArgs e)
        {
            Pb_ChangeProfile.Image = Z_Mart.Properties.Resources.change_profile;

        }

        private void pb_username_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = Z_Mart.Properties.Resources.edit_pencil_pinl;
        }

        private void pb_username_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = Z_Mart.Properties.Resources.edit_pencil_white;
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            string userName = tb_username.Text.ToString();


            if (string.IsNullOrWhiteSpace(userName))
            {
                L_InvalidUserName.Text = "Invalid UserName";
                isValidUsername = false;
            }
            else if (!Regex.IsMatch(userName, @"^[A-Za-z0-9]+$"))
            {
                L_InvalidUserName.Text = "Only Alphabets and Numbers are allowed";
                isValidUsername = false;
            }
            else if (userName.Length < 4)
            {
                L_InvalidUserName.Text = "UserName must have 4 letters";
                isValidUsername = false;
            }
            else
            {
                isValidUsername = true;
                L_InvalidUserName.Visible = false;
            }
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!PersonCRUD.CheckUserName(tb_username.Text))
                {

                    if (isValidUsername)
                    {
                        customer.UserName = tb_username.Text;
                        l_username.Visible = !false;
                        pb_username.Visible = !false;
                        tb_username.Visible = !true;
                        p_usernme.Visible = !true;
                        L_InvalidUserName.Visible = !true;
                        isValidUsername = false;
                        l_username.Text = tb_username.Text;
                        menu.changeUser(customer.UserName, customer.image);
                        LoginPage.CurrentCustomer = customer.UserName;
                        PersonCRUD.StoreToFile();
                    }
                }
                else
                {
                    var userAlreadyExist = new Notification();
                    userAlreadyExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "User Already Exist ! ", "Check your user name or password", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    userAlreadyExist.Show();
                }
            }
        }
        private void tb_EnterPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EnterPassword.Text))
            {
                L_InvalidPassword.Visible = true;
                isValidPassword = false;
            }
            else
            {
                isValidPassword = !false;
                L_InvalidPassword.Visible = false;
                PersonCRUD.StoreToFile();
            }
        }

        private void tb_EnterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isValidPassword)
            {
                customer.Password = tb_EnterPassword.Text;
                pb_password.Visible = !false;
                l_password.Visible = !false;
                p_pssword.Visible = false;
                L_InvalidPassword.Visible = !true;
                isValidPassword = false;
                tb_EnterPassword.Visible = false;
                l_password.Text = tb_EnterPassword.Text;
                menu.changeUser(customer.UserName, customer.image);
            }
        }

    }
}
