using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.UC;

namespace Z_Mart.Forms
{
    public partial class CustomerMainMenu : Form
    {
        public static string ActiveCustomer;
        public static Image ActiveCustomerImage;
        List<UserControl> Menus = new List<UserControl>();
        UC_Home Home = new UC_Home();
        Uc_ItemSearch searchItem = new Uc_ItemSearch();

        UC_ViewItems viewItems = new UC_ViewItems();
        uc_Cart cart = new uc_Cart();

        public static CustomerProfile customerProfile;
        
        public CustomerMainMenu(string UserName)
        {
            InitializeComponent();
            customerProfile = new CustomerProfile(this);
            ActiveCustomer = UserName;
            ActiveCustomerImage = PersonCRUD.GetPersonImage(ActiveCustomer);
            Menus.Add(Home);
            EnableUserControl(0);
            Menus.Add(searchItem);
            Menus.Add(viewItems);
            Menus.Add(cart);
            Menus.Add(customerProfile);
            //if (SignUpPage.isSignedUP)
            //{
            //    L_current_user.Text = SignUpPage.currentCustomer;
            //}
            //else
            //{
            //    L_current_user.Text = LoginPage.CurrentCustomer;
            //}
            L_current_user.Click += pictureBox3_Click;
            changeUser(ActiveCustomer, ActiveCustomerImage);
        }

        private void SearchButton_TextChanged(object sender, EventArgs e)
        {

        }


        private void B_items_Click_1(object sender, EventArgs e)// view items
        {
            EnableUserControl(2);
            viewItems.viewItems(false);
        }

        private void P_ContainMenus_Paint(object sender, PaintEventArgs e)// panel load
        {
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)//Home
        {
            EnableUserControl(0);
        }
        private void bunifuButton5_Click_1(object sender, EventArgs e)//Log out
        {
            var newLoginPage = new LoginPage();
            newLoginPage.Show();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)// exit picture click
        {
            Application.Exit();
        }

        private void SearchButton_KeyDown_1(object sender, KeyEventArgs e)// search button
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchName = SearchButton.Text;
                Item item = ItemCRUD.Find(searchName);
                if (item != null)
                {
                    EnableUserControl(1);
                    UC_Item UcItem = new UC_Item(item.Name, (item.Price).ToString(), (item.Quantity).ToString(), item.image, false, false);
                    searchItem.ADD(UcItem);
                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)//cart
        {
            EnableUserControl(3);
            cart.viewCartItems();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnableUserControl(4);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            EnableUserControl(4);
            customerProfile.refresh();
        }
        private void EnableUserControl(int index)
        {
            for (int i = 0; i < Menus.Count; i++)
            {
                if (i == index)
                {
                    P_ContainMenus.Controls.Add(Menus[i]);
                    Menus[i].Visible = true;
                    Menus[i].BringToFront();
                    Menus[i].Dock = DockStyle.Fill;
                    Menus[i].Enabled = true;
                    Menus[i].Show();
                }
                else
                {

                    Menus[i].Hide();
                    Menus[i].Visible = false;
                    Menus[i].Enabled = false;
                }
            }
        }
        public void changeUser(string username, Image img)
        {
            ActiveCustomer = username;
            pictureBox3.Image = img;
            L_current_user.Text = username;
        }

    }
}
