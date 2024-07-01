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
    public partial class UC_AddAdmin : UserControl
    {
        public UC_AddAdmin()
        {
            InitializeComponent();
            tb_username.GotFocus += tb_username_GotFocus;
            tb_EnterPassword.GotFocus += tb_username_GotFocus;
        }
        private void tb_username_GotFocus(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userNameErrorLabel.Visible = false;
            L_InvalidPassword.Visible = false;
            tb_EnterPassword.Text = "Enter Password";
            tb_username.Text = "Enter User Name";
            pb_AdminImage.Image = Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            isExperienced.Checked = false;
            this.Hide();
        }
        bool isUserNameValid = false;
        private void tb_ItemName_TextChanged(object sender, EventArgs e)
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
                isUserNameValid = true;
                userNameErrorLabel.Visible = false;
            }
        }
        bool isValidPassword = false;
        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            string UserPassword = tb_EnterPassword.Text;
            if (string.IsNullOrWhiteSpace(UserPassword))
            {
                L_InvalidPassword.Visible = true;
                isValidPassword = false;
            }
            else
            {
                isValidPassword = true;
                L_InvalidPassword.Visible = false;
            }
        }
        bool userEnteredImage = false;
        private void pb_itemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(tb_username.Text))
            {
                string imageLocation = dialog.FileName;
                pb_AdminImage.ImageLocation = imageLocation;
                string locationToStoreImage = App.PersonImagesFolderPath;
                string nameOfImageFile = "Image_Of_" + tb_username.Text + ".png";
                File.Copy(imageLocation, locationToStoreImage + "\\" + nameOfImageFile , true);
                userEnteredImage = true;
            }
            else
            {
                MessageBox.Show("Enter Username First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool isExperiencedAdmin = false;
        private void isExperienced_CheckedChanged(object sender, EventArgs e)
        {
            if (isExperienced.Checked)
            {
                isExperiencedAdmin = true;
            }
            else
            {
                isExperiencedAdmin = false;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_EnterPassword.Text;
            Image img;
            if (userEnteredImage)
                img = pb_AdminImage.Image;
            else
                img = Z_Mart.Properties.Resources.admin_profile_pic_holder;

            if (isValidPassword && isUserNameValid)
            {
                if (!PersonCRUD.CheckUserName(username))
                {
                    var admin = new Admin(username, password, isExperiencedAdmin, img);
                    PersonCRUD.Add(admin);
                    var itemAdded = new Notification();
                    itemAdded.changeMessageDesign(Z_Mart.Properties.Resources.DoubleTick_Icon, "Admin Added", "You can check the admin in view menu", Color.FromArgb(0, 225, 1), Color.FromArgb(3, 172, 19));
                    itemAdded.Show();
                    this.Hide();
                }
                else
                {
                    var userAlreadyExist = new Notification();
                    userAlreadyExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "UserName already Exists", "Please enter a unique username", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    userAlreadyExist.Show();
                }
            }
            PersonCRUD.StoreToFile();
        }
    }
}
