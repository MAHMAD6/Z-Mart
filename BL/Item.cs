using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Mart.BL
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Image image { get; set; }

        public Item(string name, double price, double quantity,Image image)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.image = image;
        }
    }
}
