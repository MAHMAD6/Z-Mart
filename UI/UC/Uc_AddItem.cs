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
    public partial class Uc_AddItem : UserControl
    {
        public Uc_AddItem()
        {
            InitializeComponent();
            tb_ItemName.GotFocus += tb_itemName_GotFocus;
            tb_ItemPrice.GotFocus += tb_itemPrice_GotFocus;
            tb_itemQuantity.GotFocus += tb_itemQuantity_GotFocus;
            pb_itemImage.Image = Z_Mart.Properties.Resources.AddPhoto_Icon_white;
        }
        private void tb_itemName_GotFocus(object sender, EventArgs e)
        {
            tb_ItemName.Text = string.Empty;
        }
        private void tb_itemPrice_GotFocus(object sender, EventArgs e)
        {
            tb_ItemPrice.Text = string.Empty;
        }
        private void tb_itemQuantity_GotFocus(object sender, EventArgs e)
        {
            tb_itemQuantity.Text = string.Empty;
        }

        bool NameError = false;
        bool PriceError = false;
        bool QuantityError = false;
        private void tb_ItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = tb_ItemName.Text;
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                L_InvalidItemName.Visible = true;
                NameError = true;
                L_InvalidItemName.Text = "Invalid Item Name";
            }
            else if (!Regex.IsMatch(itemName, @"^[a-zA-z0-9]+$"))
            {
                L_InvalidItemName.Visible = true;
                NameError = true;
                L_InvalidItemName.Text = "Only number and Alphabets are allowed";
            }
            else
            {
                NameError = false;
                L_InvalidItemName.Visible = false;
            }
        }


        private void tb_ItemPrice_TextChanged(object sender, EventArgs e)
        {
            string price = tb_ItemPrice.Text;
            if (string.IsNullOrWhiteSpace(price) || Regex.IsMatch(price, @"^0{1,}$"))
            {
                L_InvalidItemPrice.Visible = true;
                PriceError = true;
                L_InvalidItemPrice.Text = "Invalid Price";
            }
            else if (!Regex.IsMatch(price, @"^[0-9\.]+$"))
            {
                PriceError = true;
                L_InvalidItemPrice.Visible = true;
                L_InvalidItemPrice.Text = "Only Numbers are allowed";
            }
            else
            {
                PriceError = false;
                L_InvalidItemPrice.Visible = false;
            }
        }

        private void tb_itemQuantity_TextChanged(object sender, EventArgs e)
        {
            string Quantity = tb_itemQuantity.Text;
            if (string.IsNullOrWhiteSpace(Quantity) || Regex.IsMatch(Quantity, @"^0{1,}$"))
            {
                QuantityError = true;
                L_InvalidItemQuantity.Visible = true;
                L_InvalidItemQuantity.Text = "Invalid Quantity";
            }
            else if (!Regex.IsMatch(Quantity, @"^[0-9\.]+$"))
            {
                QuantityError = true;
                L_InvalidItemQuantity.Visible = true;
                L_InvalidItemQuantity.Text = "Only Numbers are allowed";
            }
            else
            {
                QuantityError = false;
                L_InvalidItemQuantity.Visible = false;
            }
        }
        bool userEnteredImage = false;
        private void pb_itemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = dialog.FileName;
                pb_itemImage.ImageLocation = imageLocation;
                string locationToStoreImage = "C:\\Program files\\Z Mart\\Items Images";
                if (!Directory.Exists(locationToStoreImage))
                {
                    Directory.CreateDirectory(locationToStoreImage);
                }
                string nameOfImageFile = "Image_Of_" + tb_ItemName.Text + ".png";
                File.Copy(imageLocation, locationToStoreImage + "\\" + nameOfImageFile, true);
                userEnteredImage = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = tb_ItemName.Text;
            string price = tb_ItemPrice.Text;
            string quantity = tb_itemQuantity.Text;
            Image img;
            if (userEnteredImage)
                img = pb_itemImage.Image;
            else
                img = Z_Mart.Properties.Resources.Package_2d_Icon;
            if (!NameError && !PriceError && !QuantityError )
            {
                var item = new Item(name, double.Parse(price), double.Parse(quantity), img);
                if (ItemCRUD.Check(item))
                {
                    var ItemAlreadyExists = new Notification();
                    ItemAlreadyExists.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Name Already Exists", "Enter a differnt name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemAlreadyExists.Show();
                }
                else
                {
                    var itemAdded = new Notification();
                    itemAdded.changeMessageDesign(Z_Mart.Properties.Resources.DoubleTick_Icon, "Item Added", "You can check the item in view menu", Color.FromArgb(0, 225, 1), Color.FromArgb(3, 172, 19));
                    itemAdded.Show();
                    ItemCRUD.Add(item);
                    ItemCRUD.StoreToFile();
                    tb_ItemName.Text = "Enter Item Name";
                    tb_ItemPrice.Text = "Enter Item Price";
                    tb_itemQuantity.Text = "Enter Item Quantity";
                    pb_itemImage.Image = Z_Mart.Properties.Resources.AddPhoto_Icon;
                    L_InvalidItemName.Visible = false;
                    L_InvalidItemPrice.Visible = false;
                    L_InvalidItemQuantity.Visible = false;
                    this.Visible = false;
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_InvalidItemName_Click(object sender, EventArgs e)
        {

        }

        private void L_username_Click(object sender, EventArgs e)
        {

        }

        private void Uc_AddItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tb_ItemName.Text = "  Enter Item Name";
            tb_ItemPrice.Text = "  Enter Item Price";
            tb_itemQuantity.Text = "  Enter Item Quantity";
            L_InvalidItemName.Visible = false;
            L_InvalidItemPrice.Visible = false;
            L_InvalidItemQuantity.Visible = false;
            pb_itemImage.Image = Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            this.Hide();
        }
    }
}
