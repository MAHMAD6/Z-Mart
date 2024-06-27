using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class UC_DeleteItem : UserControl
    {
        public UC_DeleteItem()
        {
            InitializeComponent();
            tb_ItemName.GotFocus += tb_ItemName_GotFocus;
        }

        private void tb_ItemName_GotFocus(object sender, EventArgs e)
        {
            tb_ItemName.Text = string.Empty;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tb_ItemName.Text = "  Enter Item Name";
            this.Hide();
        }

        private void tb_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = tb_ItemName.Text;
                Item item = ItemCRUD.Find(name);
                if (item != null)
                {
                    ItemCRUD.Remove(item);
                    ItemCRUD.StoreToFile();
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Delete_Gif, "Item Deleted", "Be careful while deleting an item", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                    this.Hide();

                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Item Does Not Exist", "Please enter a valid name", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }

        }

        private void tb_ItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = tb_ItemName.Text;
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                L_InvalidItemName.Visible = true;
                L_InvalidItemName.Text = "Invalid Item Name";
            }
            else if (!Regex.IsMatch(itemName, @"^[a-zA-z0-9]+$"))
            {
                L_InvalidItemName.Visible = true;
                L_InvalidItemName.Text = "Only number and Alphabets are allowed";
            }
            else
            {
                L_InvalidItemName.Visible = false;
            }
        }

        private void UC_DeleteItem_Load(object sender, EventArgs e)
        {

        }
    }
}
