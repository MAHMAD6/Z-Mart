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
            string path = App.ItemTxtPath;
            char ch = App.ch;
            StreamWriter writer = System.IO.File.CreateText(path);
            writer.Close();
            StreamWriter file = new StreamWriter(path, true);
            foreach (var item in ItemList)
            {
                file.WriteLine(item.Name + ch + item.Price + ch + item.Quantity);
            }
            file.Flush();
            file.Close();
        }
        public static void ReadFromFile()
        {
            string path = App.ItemTxtPath;
            string[] filesInDirectory = Directory.GetFiles(App.ImagesFolderPath);

            StreamReader file = new StreamReader(path);
            string record = string.Empty;
            while ((record = file.ReadLine()) != null)
            {
                MatchCollection match = Regex.Matches(record, @"[^\u258C]+");
                string name = match[0].Value;
                string price = match[1].Value;
                string quantity = match[2].Value;
                Item item = new Item(name, double.Parse(price), double.Parse(quantity), Z_Mart.Properties.Resources.Package_2d_Icon);
                foreach (string filePath in filesInDirectory)
                {
                    if (string.Equals(Path.GetFileName(filePath), "Image_Of_" + item.Name + ".png", StringComparison.OrdinalIgnoreCase))
                    {
                        item.image = Image.FromFile(filePath);
                        break;
                    }
                }
                ItemCRUD.Add(item);
            }
            file.Close();
        }
    }
}
