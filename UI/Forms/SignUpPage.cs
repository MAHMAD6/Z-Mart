using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart
{
    public partial class SignUpPage : Form
    {
        public static string currentCustomer;
        public static bool isSignedUP;
        Panel confirmation = new Panel();
        public SignUpPage()
        {
            InitializeComponent();
            L_InvalidUserName.Visible = false;
            L_InvalidPassword.Visible = false;
            tb_EnterPassword.GotFocus += tb_EnterPassword_Focus;
            tb_username.GotFocus += tb_username_Focus;
            this.Controls.Add(confirmation);
            this.BackColor = Color.FromArgb(0, 130, 244);
            confirmation.Visible = true;
            confirmation.BringToFront();
            confirmation.Dock = DockStyle.Fill;
            confirmation.BackgroundImage = Z_Mart.Properties.Resources.confirmation;
            confirmation.BackgroundImageLayout = ImageLayout.Stretch;
            confirmation.Click += confirmation_Click;
            bunifuElipse1.TargetControl = confirmation;
        }
        private void confirmation_Click(object sender, EventArgs e)
        {
            confirmation.Visible = false;
            this.BackColor = Color.FromArgb(255, 159, 2);
        }
        bool IsUserNameValid = false;
        void userNameErrorLabel(string text, int leftPosition, bool isEnabled, int fontSize)
        {
            IsUserNameValid = false;
            L_InvalidUserName.Visible = isEnabled;
            L_InvalidUserName.Font = new Font(L_InvalidUserName.Font.FontFamily, fontSize, L_InvalidUserName.Font.Style);
            L_InvalidUserName.Left = leftPosition;
            L_InvalidUserName.Text = text;
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            string userName = tb_username.Text.ToString();
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
                IsUserNameValid = true;
                L_InvalidUserName.Visible = false;
            }
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pb_Exitlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isValidPassword = false;

        private void tb_EnterPassword_TextChanged(object sender, EventArgs e)
        {
            string UserPassword = tb_EnterPassword.Text;
            if (string.IsNullOrWhiteSpace(UserPassword))
            {
                L_InvalidPassword.Visible = true;
                isValidPassword = false;
            }
            else
            {
                L_InvalidPassword.Visible = false;
                isValidPassword = true;
            }
        }
        private void b_SignIn_Click(object sender, EventArgs e)
        {
                string username = tb_username.Text;
            if (IsUserNameValid && isValidPassword && Validation.Password(username))
            {
                string password = tb_EnterPassword.Text;
                bool isPresent = CustomerCRUD.CheckUserName(username);
                if (!isPresent)
                {
                    var customer = new Customer(username, password, Z_Mart.Properties.Resources.user_icon_big);
                    PersonCRUD.Add(customer);
                    this.Hide();
                    currentCustomer = customer.UserName;
                    isSignedUP = true;
                    var customerMainMenu = new CustomerMainMenu(customer.UserName);
                    PersonCRUD.StoreToFile();
                    customerMainMenu.Show();
                }
                else
                {
                    currentCustomer = string.Empty;
                    isSignedUP = false;
                    var userAlreadyExist = new Notification();
                    userAlreadyExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "User Already Exist ! ", "Check your user name or password", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    userAlreadyExist.Show();
                }
            }
        }
        private void b_SignIN_Click_1(object sender, EventArgs e)
        {
            var login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}
