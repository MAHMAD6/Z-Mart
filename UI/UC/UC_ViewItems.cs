using System;
using System.Windows.Forms;
using Z_Mart.DL;

namespace Z_Mart.UC
{
    public partial class UC_ViewItems : UserControl
    {
        public UC_ViewItems()
        {
            InitializeComponent();
        }

   
        
        public void viewItems(bool admin)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(var item in ItemCRUD.ItemList)
            {
                UC_Item UcItem = new UC_Item(item.Name,(item.Price).ToString(),(item.Quantity).ToString(),item.image, admin,true);
                flowLayoutPanel1.Controls.Add(UcItem);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

  
    }
}
