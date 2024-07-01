using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Z_Mart.BL;

namespace Z_Mart.DL
{
    internal class ItemCRUD
    {
        public static List<Item> ItemList = new List<Item>();
        static ItemCRUD()
        {
          
        }
        public static void Add(Item itemToAdd)
        {
            ItemList.Add(itemToAdd);
        }
        public static void Remove(Item itemToRemove)
        {
            ItemList.Remove(itemToRemove);
        }
        public static bool Check(Item itemToCheck)
        {
            foreach (var item in ItemList)
            {
                if (item.Name == itemToCheck.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Update(Item itemToUpdate, string Name)
        {
            foreach (var item in ItemList)
            {
                if (item.Name == Name)
                {
                    item.Name = itemToUpdate.Name;
                    item.Price = itemToUpdate.Price;
                    item.Quantity = itemToUpdate.Quantity;
                    item.image = itemToUpdate.image;
                }
            }
        }
        public static Item Find(string itemToFind)
        {
            foreach (var item in ItemList)
            {
                if (item.Name == itemToFind)
                {
                    return item;
                }
            }
            return null;
        }
        // File handling
        public static void StoreToFile()
        {
            char ch = App.ch;
            StreamWriter file = new StreamWriter(App.ItemTxtPath);
            foreach (var item in ItemList)
            {
                file.WriteLine(item.Name + ch + item.Price + ch + item.Quantity);
            }
            file.Flush();
            file.Close();
        }
        public static void ReadFromFile()
        {
   
            StreamReader file = new StreamReader(App.ItemTxtPath);
            string record = string.Empty;
            while ((record = file.ReadLine()) != null)
            {
                MatchCollection match = Regex.Matches(record, @"[^\u258C]+");
                string name = match[0].Value;
                string price = match[1].Value;
                string quantity = match[2].Value;
                Item item = new Item(name, double.Parse(price), double.Parse(quantity), Z_Mart.Properties.Resources.Package_2d_Icon);
                Image img = GetItemImage(item.Name);
                if (img != null)
                    item.image = img;
                ItemCRUD.Add(item);
            }
            file.Close();
        }
        public static Image GetItemImage(string name)
        {
            string path = string.Format(App.ItemImageNameWithPath, name);
            if (File.Exists(path))
                return Essentials.LoadImageWithoutLocking(path);
            else
                return null;
        }
    }
}
