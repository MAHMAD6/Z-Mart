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
    public partial class uc_updateAdmin : UserControl
    {
        public uc_updateAdmin()
        {
            InitializeComponent();
            tb_UserName_1.GotFocus += tb_UserName_1_GotFocus;
            tb_username.GotFocus += tb_UserName_1_GotFocus;
            tb_EnterPassword.GotFocus += tb_UserName_1_GotFocus;
        }
        private void tb_UserName_1_GotFocus(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        bool NameError = false;
        private void tb_ItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = tb_UserName_1.Text;
            if (string.IsNullOrWhiteSpace(tb_UserName_1.Text))
            {
                label1.Visible = true;
                NameError = true;
                label1.Text = "Invalid Item Name";
            }
            else if (!Regex.IsMatch(itemName, @"^[a-zA-z0-9]+$"))
            {
                label1.Visible = true;
                NameError = true;
                label1.Text = "Only number and Alphabets are allowed";
            }
            else
            {
                NameError = false;
                label1.Visible = false;
            }
        }
        Admin admin;
        string orgUserName, orgPassword;
        bool orgIsExperienced, isValidPassword = false, userEnteredImage = false, userEnteredEXP = false;
        Image orgImage;
        bool isCheckedName = false, isCheckedPassword = false, isCheckedImage = false;

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbImage.Checked)
            {
                isCheckedImage = true;
                adminImageL.Visible = true;
                pb_AdminImage.Visible = true;
                Submit.Visible = true;
                cbImage.Text = string.Empty;
            }
            else
            {
                isCheckedImage = false;
                adminImageL.Visible = false;
                pb_AdminImage.Visible = false;
                Submit.Visible = false;
                cbImage.Text = "Update Image";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (userEnteredImage)
            {
                if (isCheckedImage)
                    admin.image = pb_AdminImage.Image;
                else
                    admin.image = orgImage;
                this.Visible = false;

            }
            else
            {
                admin.image = orgImage;

            }
            if (!NameError)
            {
                if (isCheckedName)
                    admin.UserName = tb_username.Text;
                else
                    admin.UserName = orgUserName;
                this.Visible = false;
            }
            else
            {
                admin.UserName = orgUserName;

            }

            if (isValidPassword)
            {
                if (isCheckedPassword)
                    admin.Password = tb_EnterPassword.Text;
                else
                {
                    admin.Password = orgPassword;
                }
                this.Visible = false;
            }
            else
            {
                admin.Password = orgPassword;

            }

            if (userEnteredEXP)
            {
                if (cb_isExperienced.Checked)
                {
                    admin.isExperienced = true;
                }
                else
                {
                    this.Visible = false;
                    admin.isExperienced = false;
                }
            }
            else
            {
                admin.isExperienced = orgIsExperienced;


            }
            try
            {
                AdminCRUD.UpdateAdmin(admin);
            }
            catch
            {
                var ItemDoesNotExist = new Notification();
                ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                ItemDoesNotExist.Show();
            }
            LoginPage.CurrentCustomer = admin.UserName;
            LoginPage.CurrentCustomerProfile = admin.image;
            PersonCRUD.StoreToFile();

            //////////////check boxes
            isCheckedImage = false;
            isCheckedPassword = false;
            isCheckedName = false;
            cbImage.Visible = false;
            cbUpdateExperience.Visible = false;
            cbUpdatePassword.Visible = false;
            cbuserName.Visible = false;
            cbImage.Text = "Update Image";
            cbUpdateExperience.Text = "Update Experience";
            cbUpdatePassword.Text = "Update Password";
            cbuserName.Text = "Update Name";
            cb_isExperienced.Visible = false;
            /////////labels
            adminName.Visible = false;
            adminPassword.Visible = false;
            adminexp.Visible = false;
            adminImageL.Visible = false;
            l_Message.Visible = false;
            L_username.Visible = true;
            //////panels
            panel5.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            //textboxes
            tb_EnterPassword.Visible = false;
            tb_username.Visible = false;
            tb_UserName_1.Visible = true;

            userEnteredEXP = false;
            pb_AdminImage.Visible = false;
            Submit.Visible = false;
        }

        private void uc_updateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cbUpdateExperience_CheckedChanged(object sender, EventArgs e)
        {

            if (cbUpdateExperience.Checked)
            {
                cbUpdateExperience.Text = string.Empty;
                Submit.Visible = true;
                userEnteredEXP = true;
                adminexp.Visible = true;
                cb_isExperienced.Visible = true;
            }
            else
            {
                cb_isExperienced.Visible = false;
                adminexp.Visible = false;
                userEnteredEXP = false;
                cbUpdateExperience.Text = "Update Experience";
                Submit.Visible = false;
            }
        }

        private void cbUpdatePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdatePassword.Checked)
            {
                cbUpdatePassword.Text = string.Empty;
                tb_EnterPassword.Visible = true;
                adminPassword.Visible = true;
                Submit.Visible = true;
                isCheckedPassword = true;
                panel2.Visible = true;
            }
            else
            {
                isCheckedPassword = false;
                cbUpdatePassword.Text = "Update Password";
                tb_EnterPassword.Visible = false;
                adminPassword.Visible = false;
                Submit.Visible = false;
                panel2.Visible = false;
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbuserName.Checked)
            {
                tb_username.Visible = true;
                adminName.Visible = true;
                Submit.Visible = true;
                panel5.Visible = true;
                isCheckedName = true;
                cbuserName.Text = string.Empty;
            }
            else
            {
                isCheckedName = false;
                tb_username.Visible = false;
                adminName.Visible = false;
                Submit.Visible = false;
                panel5.Visible = false;
                cbuserName.Text = "Update Name";
            }
        }

        private void cbUpdateName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pb_itemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = dialog.FileName;
                pb_AdminImage.ImageLocation = imageLocation;
                string locationToStoreImage = "C:\\Program files\\Z Mart";
                if (!Directory.Exists(locationToStoreImage))
                {
                    Directory.CreateDirectory(locationToStoreImage);
                }
                string nameOfImageFile = "Image_Of_" + tb_username.Text;
                File.Copy(imageLocation, locationToStoreImage + "\\" + nameOfImageFile, true);
                userEnteredImage = true;
            }
        }

        private void tb_ItemPrice_TextChanged(object sender, EventArgs e)
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

        private void tb_enter_ItemName_2_TextChanged(object sender, EventArgs e)
        {
            string userName = tb_username.Text.ToString();
            if (string.IsNullOrWhiteSpace(userName))
            {
                userNameError.Text = "Invalid UserName";
                userNameError.Visible = true;
            }
            else if (!Regex.IsMatch(userName, @"^[A-Za-z0-9]+$"))
            {
                userNameError.Text = "Invalid UserName";
                userNameError.Text = "Only Alphabets and Numbers are allowed";
                userNameError.Visible = true;
            }
            else if (userName.Length < 4)
            {
                userNameError.Text = "UserName must have 4 letters";
                userNameError.Visible = true;
            }
            else
            {
                userNameError.Visible = false;
            }
        }

        private void isExperienced_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isExperienced.Checked)
            {
                userEnteredEXP = true;
            }
            else
            {
                userEnteredEXP = false;
            }
        }

        private void tb_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = tb_UserName_1.Text;
                admin = AdminCRUD.Find(name);
                if (admin != null)
                {
                    orgImage = admin.image;
                    orgUserName = admin.UserName;
                    orgPassword = admin.Password;
                    orgIsExperienced = admin.isExperienced;
                    l_Message.Visible = true;
                    cbuserName.Visible = true;
                    cbUpdatePassword.Visible = true;
                    cbUpdateExperience.Visible = true;
                    cbImage.Visible = true;
                    tb_UserName_1.Visible = false;
                    panel3.Visible = false;
                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }
        }
    }
}
