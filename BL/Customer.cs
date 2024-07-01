using System.Collections.Generic;
using System.Drawing;

namespace Z_Mart.BL
{
    internal class Customer : Person
    {
        public List<Item> Cart = new List<Item>();

        public void AddToCart(Item item)
        { Cart.Add(item); }
        public void RemoveFromCart(string itemName)
        {
            foreach (var item in Cart)
            {
                if (item.Name == itemName)
                    Cart.Remove(item);
            }

        }
        public Customer(string username, string password, Image img)
        {
            this.UserName = username;
            this.Password = password;
            this.image = img;
        }
        public Customer(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
    }
}
