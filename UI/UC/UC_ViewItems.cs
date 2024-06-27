using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;

namespace Z_Mart.UC
{
    public partial class UC_ViewItems : UserControl
    {
        public UC_ViewItems()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void viewItems(bool admin)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(var item in ItemCRUD.List)
            {
                UC_Item UcItem = new UC_Item(item.Name,(item.Price).ToString(),(item.Quantity).ToString(),item.image, admin,true);
                flowLayoutPanel1.Controls.Add(UcItem);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
