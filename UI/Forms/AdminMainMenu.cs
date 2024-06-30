using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.UC;

namespace Z_Mart.Forms
{
    public partial class AdminMainMenu : Form
    {
        List<UserControl> Menus = new List<UserControl>();
        Uc_ManageAdmins uc_ManageAdmins1 = new Uc_ManageAdmins();
        uc_ManageCustomers uc_ManageCustomers1 = new uc_ManageCustomers();
        Uc_ItemSearch uc_ItemSearch1 = new Uc_ItemSearch();
        UC_ManageItems uC_ManageItems1 = new UC_ManageItems();
        UC_Home uC_Home1 = new UC_Home();
        AdminProfile adminProfile;

        public void changeUser(string username, Image img)
        {
            L_CurrentAdmin.Text = username;
            UserProfile.Image = img;
            LoginPage.ActiveAdmin = username;
            LoginPage.ActiveAdminProfile = img;
        }
        private void EnableUserControl(int index)
        {
            for (int i = 0; i < Menus.Count; i++)
            {
                if (i == index)
                {
                    MenusPlaceHolder.Controls.Add(Menus[i]);
                    Menus[i].BringToFront();
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
        public AdminMainMenu()
        {
            InitializeComponent();
            adminProfile = new AdminProfile(this);
            Menus.Add(uC_Home1);
            EnableUserControl(0);
            Menus.Add(uC_ManageItems1);
            Menus.Add(uc_ManageAdmins1);
            Menus.Add(uc_ManageCustomers1);
            Menus.Add(uc_ItemSearch1);
            Menus.Add(adminProfile);
            L_CurrentAdmin.Text = LoginPage.ActiveAdmin;
            UserProfile.Image = LoginPage.ActiveAdminProfile;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)// Admin button
        {
            EnableUserControl(2);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            EnableUserControl(1);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)//Home button
        {
            EnableUserControl(0);
        }

        private void SearchButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchName = SearchButton.Text;
                Item item = ItemCRUD.Find(searchName);
                if (item != null)
                {

                    EnableUserControl(4);
                    UC_Item UcItem = new UC_Item(item.Name, (item.Price).ToString(), (item.Quantity).ToString(), item.image, true, true);
                    uc_ItemSearch1.ADD(UcItem);
                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Colores.DarkRed, Colores.Red);
                    SearchButton.Focus();
                    ItemDoesNotExist.Show();
                }
            }
        }


        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            var newLoginPage = new LoginPage();
            newLoginPage.Show();
            LoginPage.CurrentCustomer = string.Empty;
            SignUpPage.currentCustomer = string.Empty;
            this.Close();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            EnableUserControl(3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnableUserControl(5);

        }

        private void SearchButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_CurrentAdmin_Click(object sender, EventArgs e)
        {
            EnableUserControl(5);
        }
    }
}
