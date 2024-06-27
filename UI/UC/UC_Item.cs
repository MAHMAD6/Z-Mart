using System;
using System.Drawing;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class UC_Item : UserControl
    {
        private Timer timer;
        private bool admin, Add;
        string ItemName;
        public UC_Item(string Name, string Price, string quantity, Image image, bool admin, bool add)
        {
            InitializeComponent();
            Add = add;
            ItemName = Name;
            pb_Item.Image = image;
            L_itemName.Text = Name;
            L_itemPrice.Text = "$" + Price;
            L_Item_quantity.Text = quantity + " pcs left";
            if (!admin)
            {
                P_dark.BackColor = Color.FromArgb(128, Color.Black);
                b_addToCart.Click += b_addToCart_Click;
                this.MouseEnter += item_mouseEnter;
                this.MouseLeave += item_mouseLeave;
                timer = new Timer();
                timer.Interval = 1500; // Set the delay before hiding the panel (in milliseconds)
                timer.Tick += Timer_Tick;
                this.admin = admin;
            }
        }
        private void item_mouseEnter(object sender, EventArgs e)
        {
            if (Add)
            {
                b_addToCart.Visible = true;
            }
            else
            {
                b_removeFromCart.Visible = true;
            }
            P_dark.Visible = true;

        }
        private void item_mouseLeave(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void b_addToCart_Click(object sender, EventArgs e)
        {

        }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            b_addToCart.Visible = false;
            b_removeFromCart.Visible = false;
            P_dark.Visible = false;

        }
        private void b_addToCart_Click_1(object sender, EventArgs e)
        {
            Customer customer = CustomerCRUD.Find(CustomerMainMenu.ActiveCustomer);
            Item item = ItemCRUD.Find(ItemName);
            customer.AddToCart(item);
            item.Quantity = 1;
            PersonCRUD.StoreCustomerItem(customer);
        }

        private void b_removeFromCart_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerCRUD.Find(CustomerMainMenu.ActiveCustomer);
            Item item = ItemCRUD.Find(ItemName);
            item.Quantity++;
            try
            {
                customer.RemoveFromCart(ItemName);
                PersonCRUD.StoreCustomerItem(customer);
            }
            catch
            {

            }
        }
    }
}
