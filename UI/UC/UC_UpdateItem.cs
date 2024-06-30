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
    public partial class UC_UpdateItem : UserControl
    {
        string orgName;
        double orgPrice, orgQuantity;
        Image orgImg;
        public UC_UpdateItem()
        {
            InitializeComponent();
            tb_ItemName.GotFocus += tb_ItemName_GotFocus;
            tb_enter_ItemName_2.GotFocus += tb_ItemName_GotFocus;
            tb_enter_ItemName_2.GotFocus += tb_ItemName_GotFocus;
            tb_ItemPrice.GotFocus += tb_ItemName_GotFocus;
            tb_itemQuantity.GotFocus += tb_ItemName_GotFocus;

        }
        private void tb_ItemName_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }
        Item item;
        private void tb_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = tb_ItemName.Text;
                item = ItemCRUD.Find(name);
                if (item != null)
                {
                    orgName = item.Name;
                    orgPrice = item.Price;
                    orgQuantity = item.Quantity;
                    orgImg = item.image;
                    l_Message.Visible = true;
                    cbUpdateName.Visible = true;
                    cbUpdatePrice.Visible = true;
                    cbUpdateQuantity.Visible = true;
                    cbUpdateImage.Visible = true;
                    tb_ItemName.Visible = false;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tb_ItemName.Text = "  Enter Item Name";
            tb_ItemPrice.Text = "  Enter Item Price";
            tb_itemQuantity.Text = "  Enter item Quantity";
            tb_enter_ItemName_2.Text = "  Enter item Name";
            //Labels Errors
            L_InvalidItemName.Visible = false;
            L_InvalidItemPrice.Visible = false;
            L_InvalidItemQuantity.Visible = false;
            l_name.Visible = false;
            //check boxes
            cbUpdateName.Visible = false;
            cbUpdatePrice.Visible = false;
            cbUpdateQuantity.Visible = false;
            cbUpdateImage.Visible = false;
            cbUpdateImage.Checked = false;
            cbUpdateQuantity.Checked = false;
            cbUpdateName.Checked = false;
            cbUpdatePrice.Checked = false;
            //headings
            l_Message.Visible = false;
            itemName.Visible = false;
            itemQuantity.Visible = false;
            itemPrice.Visible = false;
            //panel i.e. underlines
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            // others
            pb_itemImage.Visible = false;
            Submit.Visible = false;
            this.Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {
            tb_ItemName.Text = "Enter Item Name";
            this.Hide();
        }
        bool QuantityError = false;
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
        bool PriceError = false;
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
        bool NameError = false;
        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            string itemName = tb_enter_ItemName_2.Text;
            if (string.IsNullOrWhiteSpace(tb_enter_ItemName_2.Text))
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


        private void tb_ItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = tb_ItemName.Text;
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                l_name.Visible = true;
                NameError = true;
                l_name.Text = "Invalid Item Name";
            }
            else if (!Regex.IsMatch(itemName, @"^[a-zA-z0-9]+$"))
            {
                l_name.Visible = true;
                NameError = true;
                l_name.Text = "Only number and Alphabets are allowed";
            }
            else
            {
                NameError = false;
                l_name.Visible = false;
            }
        }
        bool isCheckedName = false, isCheckedPrice = false, isCheckedQuantity = false, isCheckedImage = false;
        private void cbUpdateName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateName.Checked)
            {
                tb_enter_ItemName_2.Visible = true;
                itemName.Visible = true;
                Submit.Visible = true;
                panel5.Visible = true;
                isCheckedName = true;
                cbUpdateName.Text = string.Empty;
            }
            else
            {
                isCheckedName = false;
                tb_enter_ItemName_2.Visible = false;
                itemName.Visible = false;
                Submit.Visible = false;
                panel5.Visible = false;
                cbUpdateName.Text = "Update Name";
            }
        }

        private void cbUpdatePrice_CheckedChanged(object sender, EventArgs e)
        {

            if (cbUpdatePrice.Checked)
            {
                cbUpdatePrice.Text = string.Empty;
                tb_ItemPrice.Visible = true;
                itemPrice.Visible = true;
                Submit.Visible = true;
                isCheckedPrice = true;
                panel2.Visible = true;
            }
            else
            {
                isCheckedPrice = false;
                cbUpdatePrice.Text = "Update Price";
                tb_ItemPrice.Visible = false;
                itemPrice.Visible = false;
                Submit.Visible = false;
                panel2.Visible = false;
            }
        }
        private void cbUpdateQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateQuantity.Checked)
            {
                cbUpdateQuantity.Text = string.Empty;
                panel4.Visible = true;
                itemQuantity.Visible = true;
                isCheckedQuantity = true;
                tb_itemQuantity.Visible = true;
                Submit.Visible = true;
            }
            else
            {
                isCheckedQuantity = false;
                cbUpdateQuantity.Text = "UpdateQuantity";
                panel4.Visible = false;
                itemQuantity.Visible = false;
                tb_itemQuantity.Visible = false;
                Submit.Visible = false;
            }

        }

        private void cbUpdateImage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateImage.Checked)
            {
                isCheckedImage = true;
                ItemImage.Visible = true;
                pb_itemImage.Visible = true;
                Submit.Visible = true;
                cbUpdateImage.Text = string.Empty;
            }
            else
            {
                isCheckedImage = false;
                ItemImage.Visible = false;
                pb_itemImage.Visible = false;
                Submit.Visible = false;
                cbUpdateImage.Text = "Update Image";
            }
        }

        private void cbUpdateName_Click(object sender, EventArgs e)
        {

        }

        private void cbUpdatePrice_Click(object sender, EventArgs e)
        {

        }

        bool userEnteredImage = false;
        private void pb_itemImage_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = dialog.FileName;
                pb_itemImage.ImageLocation = imageLocation;
                string locationToStoreImage = "C:\\Program files\\Z Mart";
                if (!Directory.Exists(locationToStoreImage))
                {
                    Directory.CreateDirectory(locationToStoreImage);
                }
                string nameOfImageFile = DateTime.Now.ToString("yyyyMMddhhmmss") + "Image_Of_" + tb_ItemName.Text + ".png";
                path = locationToStoreImage + "\\" + nameOfImageFile;
                File.Copy(imageLocation, path, true);
                userEnteredImage = true;
            }
            img = Essentials.LoadImageWithoutLocking(path);
        }
        Image img;
        public bool YesHide = false;



        private void Submit_Click(object sender, EventArgs e)
        {

            if (userEnteredImage)
            {
                if (isCheckedImage)
                    item.image = img;
                else
                    item.image = orgImg;
                YesHide = true;
                this.Visible = false;

            }
            else
            {
                item.image = orgImg;

            }
            string itemToUpdate = item.Name;
            if (!NameError)
            {
                if (isCheckedName)
                {

                    item.Name = tb_enter_ItemName_2.Text;
                }
                else
                    item.Name = orgName;
                this.Visible = false;
                YesHide = true;
            }
            else
                item.Name = orgName;

            if (!PriceError)
            {
                if (isCheckedPrice)
                    item.Price = double.Parse(tb_ItemPrice.Text);
                else
                {
                    item.Price = orgPrice;

                }
                this.Visible = false;
                YesHide = true;
            }
            else
            {
                item.Price = orgPrice;

            }

            if (!QuantityError)
            {
                if (isCheckedQuantity)
                    item.Quantity = double.Parse(tb_itemQuantity.Text);
                else
                {
                    item.Quantity = orgQuantity;
                    this.Visible = false;
                }
                YesHide = true;
            }
            else
            {
                item.Quantity = orgQuantity;

            }
            try
            {
                ItemCRUD.Update(item, itemToUpdate);
                ItemCRUD.StoreToFile();
            }
            catch
            {
                var ItemDoesNotExist = new Notification();
                ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                ItemDoesNotExist.Show();
            }

            l_Message.Visible = false;
            cbUpdateName.Visible = false;
            cbUpdatePrice.Visible = false;
            cbUpdateQuantity.Visible = false;
            cbUpdateImage.Visible = false;

            tb_ItemName.Visible = true;
            panel3.Visible = true;
            cbUpdatePrice.Text = "Update Price";
            tb_ItemPrice.Visible = false;
            itemPrice.Visible = false;
            Submit.Visible = false;
            panel2.Visible = false;

            tb_enter_ItemName_2.Visible = false;
            itemName.Visible = false;
            panel5.Visible = false;
            cbUpdateName.Text = "Update Name";

            cbUpdateQuantity.Text = "UpdateQuantity";
            panel4.Visible = false;
            itemQuantity.Visible = false;
            tb_itemQuantity.Visible = false;

            ItemImage.Visible = false;
            pb_itemImage.Visible = false;
            cbUpdateImage.Text = "Update Image";
            // Same as back button
            tb_ItemName.Text = "  Enter Item Name";
            tb_ItemPrice.Text = "  Enter Item Price";
            tb_itemQuantity.Text = "  Enter item Quantity";
            tb_enter_ItemName_2.Text = "  Enter item Name";
            //Labels Errors
            L_InvalidItemName.Visible = false;
            L_InvalidItemPrice.Visible = false;
            L_InvalidItemQuantity.Visible = false;
            l_name.Visible = false;
            //check boxes
            cbUpdateName.Visible = false;
            cbUpdatePrice.Visible = false;
            cbUpdateQuantity.Visible = false;
            cbUpdateImage.Visible = false;
            cbUpdateImage.Checked = false;
            cbUpdateQuantity.Checked = false;
            cbUpdateName.Checked = false;
            cbUpdatePrice.Checked = false;
            //headings
            l_Message.Visible = false;
            itemName.Visible = false;
            itemQuantity.Visible = false;
            itemPrice.Visible = false;
            //panel i.e. underlines
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            // others
            pb_itemImage.Visible = false;
            Submit.Visible = false;
        }

        private void cbUpdateQuantity_Click(object sender, EventArgs e)
        {

        }

        private void cbUpdateImage_Click(object sender, EventArgs e)
        {

        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }
    }
}
