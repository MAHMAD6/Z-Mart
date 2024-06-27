using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class uc_Cart : UserControl
    {
        public uc_Cart()
        {
            InitializeComponent();
        }
        public void viewCartItems()
        {
            double totalbill = 0;
            flowLayoutPanel1.Controls.Clear();
            Customer customer = CustomerCRUD.Find(CustomerMainMenu.ActiveCustomer);
            foreach (var item in customer.Cart)
            {
                totalbill += 1 * item.Price;
                Item ORGitem = ItemCRUD.Find(item.Name);
                ORGitem.Quantity--;
                var ucItem = new UC_Item(item.Name, item.Price.ToString(), "1", item.image, false, false);
                flowLayoutPanel1.Controls.Add(ucItem);
                if (totalbill > 0)
                {
                    lTotalNumber_.Text = customer.Cart.Count.ToString();
                    lTotalbill_.Text = totalbill.ToString();

                }
                else
                {
                    if (customer.Cart.Count == 0)
                        lTotalNumber_.Text = "0";
                    if (totalbill == 0)
                        lTotalbill_.Text = "0";

                }
            }
        }
    }
}
