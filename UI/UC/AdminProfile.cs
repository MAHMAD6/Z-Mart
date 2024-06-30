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
    public partial class AdminProfile : UserControl
    {
        Admin admin;
        bool isValidUsername = false;
        bool isValidPassword = false;
        AdminMainMenu menu;
        public AdminProfile(AdminMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            pb_password.MouseEnter += pb_username_MouseEnter;
            pb_password.MouseLeave += pb_username_MouseLeave;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
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
            adminRefresh();
            L_InvalidUserName.Visible = false;
        }
        void adminRefresh()
        {
            admin = AdminCRUD.Find(LoginPage.ActiveAdmin);

            if (admin != null)
            {
                pb_profile.Image = admin.image;
                l_username.Text = admin.UserName;
                l_password.Text = admin.Password;
            }

        }

        private void Pb_ChangeProfile_Click(object sender, EventArgs e)
        {

            string currentAdmin = LoginPage.ActiveAdmin;
            PersonCRUD.updateImage(currentAdmin, null);
            Image img = Essentials.ImageDialog(currentAdmin);
            if (img != null)
            {
                pb_profile.Image = img;
                admin.image = img;
                menu.changeUser(admin.UserName, img);
                adminRefresh();
            PersonCRUD.updateImage(currentAdmin, img);
            }
            PersonCRUD.updateImage(currentAdmin, Z_Mart.Properties.Resources.userProfilHolder_Icon);

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
                        admin.UserName = tb_username.Text;
                        l_username.Visible = !false;
                        pb_username.Visible = !false;
                        tb_username.Visible = !true;
                        p_usernme.Visible = !true;
                        L_InvalidUserName.Visible = !true;
                        isValidUsername = false;
                        l_username.Text = tb_username.Text;
                        menu.changeUser(admin.UserName, admin.image);
                        LoginPage.ActiveAdmin = admin.UserName;
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
            }
        }

        private void tb_EnterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isValidPassword)
            {
                admin.Password = tb_EnterPassword.Text;
                pb_password.Visible = !false;
                l_password.Visible = !false;
                p_pssword.Visible = false;
                L_InvalidPassword.Visible = !true;
                isValidPassword = false;
                tb_EnterPassword.Visible = false;
                l_password.Text = tb_EnterPassword.Text;
                menu.changeUser(admin.UserName, admin.image);
                PersonCRUD.StoreToFile();
            }
        }
    }
}
