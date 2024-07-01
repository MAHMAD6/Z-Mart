using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart
{
    public partial class LoginPage : Form
    {
        public static string CurrentCustomer = string.Empty;
        public static Image CurrentCustomerProfile;
        public static string ActiveAdmin = string.Empty;
        public static Image ActiveAdminProfile;
        void userNameErrorLabel(string text, int leftPosition, bool isEnabled, int fontSize)
        {
            L_InvalidUserName.Visible = isEnabled;
            L_InvalidUserName.Font = new Font(L_InvalidUserName.Font.FontFamily, fontSize, L_InvalidUserName.Font.Style);
            L_InvalidUserName.Left = leftPosition;
            L_InvalidUserName.Text = text;
        }
        public LoginPage()
        {
            InitializeComponent();
            tb_EnterPassword.TabStop = false;
            tb_username.TabStop = false;
            L_InvalidUserName.Visible = false;
            L_InvalidPassword.Visible = false;
            tb_EnterPassword.GotFocus += tb_EnterPassword_Focus;
            tb_username.GotFocus += tb_username_Focus;
            CurrentCustomerProfile = PersonCRUD.GetUserImage(CurrentCustomer);
            changeMonkey(234567);
        }
        private void tb_EnterPassword_Focus(object sender, EventArgs e)
        {
            tb_EnterPassword.Text = string.Empty;
            tb_EnterPassword.PasswordChar = '*';
        }
        private void tb_username_Focus(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            if (string.IsNullOrWhiteSpace(userName))
            {
                L_InvalidUserName.Visible = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void changeMonkey(int i)
        {
            switch (i)
            {
                case -1:
                    pb_monkey.Image = Z_Mart.Properties.Resources.HIde;
                    break;
                case 0:
                    pb_monkey.Image = Z_Mart.Properties.Resources.Click;
                    break;
                case 1:
                    pb_monkey.Image = Z_Mart.Properties.Resources._1;
                    break;
                case 2:
                    pb_monkey.Image = Z_Mart.Properties.Resources._2;
                    break;
                case 3:
                    pb_monkey.Image = Z_Mart.Properties.Resources._3;
                    break;
                case 4:
                    pb_monkey.Image = Z_Mart.Properties.Resources._4;
                    break;
                case 5:
                    pb_monkey.Image = Z_Mart.Properties.Resources._5;
                    break;
                case 6:
                    pb_monkey.Image = Z_Mart.Properties.Resources._6;
                    break;
                case 7:
                    pb_monkey.Image = Z_Mart.Properties.Resources._7;
                    break;
                case 8:
                    pb_monkey.Image = Z_Mart.Properties.Resources._8;
                    break;
                case 9:
                    pb_monkey.Image = Z_Mart.Properties.Resources._9;
                    break;
                case 10:
                    pb_monkey.Image = Z_Mart.Properties.Resources._10;
                    break;
                case 11:
                    pb_monkey.Image = Z_Mart.Properties.Resources._11;
                    break;
                case 12:
                    pb_monkey.Image = Z_Mart.Properties.Resources._12;
                    break;
                case 13:
                    pb_monkey.Image = Z_Mart.Properties.Resources._13;
                    break;
                case 14:
                    pb_monkey.Image = Z_Mart.Properties.Resources._14;
                    break;
                case 15:
                    pb_monkey.Image = Z_Mart.Properties.Resources._15;
                    break;
                case 16:
                    pb_monkey.Image = Z_Mart.Properties.Resources._16;
                    break;
                case 17:
                    pb_monkey.Image = Z_Mart.Properties.Resources._17;
                    break;
                case 18:
                    pb_monkey.Image = Z_Mart.Properties.Resources._18;
                    break;
                case 19:
                    pb_monkey.Image = Z_Mart.Properties.Resources._19;
                    break;
                case 20:
                    pb_monkey.Image = Z_Mart.Properties.Resources._20;
                    break;
                case 21:
                    pb_monkey.Image = Z_Mart.Properties.Resources._21;
                    break;
                case 22:
                    pb_monkey.Image = Z_Mart.Properties.Resources._22;
                    break;
                default:
                    pb_monkey.Image = Z_Mart.Properties.Resources.Normal;
                    break;
            }
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            string userName = tb_username.Text.ToString();
            if (tb_username.TextLength >= 0)
            {
                changeMonkey(tb_username.TextLength);
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                userNameErrorLabel("Invalid UserName", 60, true, 12);
            }
            else if (!Regex.IsMatch(userName, @"^[A-Za-z0-9]+$"))
            {
                userNameErrorLabel("Only Alphabets and Numbers are allowed", 50, true, 9);
            }
            else if (userName.Length < 4)
            {
                userNameErrorLabel("UserName must have 4 letters", 50, true, 11);
            }
            else
            {
                L_InvalidUserName.Visible = false;
            }
        }
        private void tb_EnterPassword_TextChanged(object sender, EventArgs e)
        {
            changeMonkey(-1);
            string UserPassword = tb_EnterPassword.Text;
            if (string.IsNullOrWhiteSpace(UserPassword))
            {
                L_InvalidPassword.Visible = true;
            }
            else
            {
                L_InvalidPassword.Visible = false;
            }
        }
        private void b_SignIn_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string Password = tb_EnterPassword.Text;
            if (!string.IsNullOrWhiteSpace(userName) && Regex.IsMatch(userName, @"^[A-Za-z0-9]+$") && userName.Length >= 4 && !string.IsNullOrWhiteSpace(Password))
            {
                var person = PersonCRUD.FindPerson(userName, Password);
                if (person != null && person is Admin)
                {
                    ActiveAdmin = person.UserName;
                    ActiveAdminProfile = person.image;
                    var adminMenu = new AdminMainMenu();
                    var itemAdded = new Notification();
                    itemAdded.changeMessageDesign(Z_Mart.Properties.Resources.sparks_gif, "Welcome back", "You Login as an admin.", Colores.DarkGreen, Colores.Green);
                    adminMenu.Show();
                    itemAdded.Show();

                    this.Hide();
                }
                else if (person != null && person is Customer)
                {
                    CurrentCustomerProfile = person.image;
                    CurrentCustomer = person.UserName;
                    var customerMenu = new CustomerMainMenu(person.UserName);
                    customerMenu.Show();
                    this.Hide();
                }
                else
                {
                    ActiveAdmin = string.Empty;
                    CurrentCustomer = string.Empty;
                    var wrongCredentialsMessage = new Notification();
                    wrongCredentialsMessage.changeMessageDesign(Z_Mart.Properties.Resources.error_gif, "Wrong Credentials", "Check your user name or password", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    wrongCredentialsMessage.Show();
                }
            }
        }
        public void hide()
        {
            this.Hide();
        }

        public bool showSignUP = false;
        private void b_SignUp_Click(object sender, EventArgs e)
        {

        }
        bool passwordHide = true;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (passwordHide)
            {
                pb_HideUnhidePassword.Image = Z_Mart.Properties.Resources.ShowPassword_White;
                tb_EnterPassword.PasswordChar = '*';
                passwordHide = !passwordHide;
            }
            else
            {
                pb_HideUnhidePassword.Image = Z_Mart.Properties.Resources.HidePassword_White;
                tb_EnterPassword.PasswordChar = '\0';
                passwordHide = !passwordHide;

            }

        }

        private void tb_username_Click(object sender, EventArgs e)
        {
        }

        private void tb_EnterPassword_Click(object sender, EventArgs e)
        {
            changeMonkey(-1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            changeMonkey(43567);
            this.Hide();
            var signUp = new SignUpPage();
            signUp.Show();
        }
    }
}
