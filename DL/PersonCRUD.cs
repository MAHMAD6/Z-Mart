using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Z_Mart.BL;

namespace Z_Mart.DL
{
    internal abstract class PersonCRUD
    {
        public static string path = "C:\\Program files\\Z Mart\\Data";
        public static string path2 = "C:\\Program files\\Z Mart\\Data\\CustomerData.txt";
        public static string itemsImagesPath = "C:\\Program files\\Z Mart\\Items_Images";
        public static List<Person> List = new List<Person>();
        static PersonCRUD()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = "C:\\Program files\\Z Mart\\Data\\AppData.txt";
            //File.CreateText(path);
            //File.CreateText(itemsImagesPath);
        }
        public static void Add(Person person)
        {
            List.Add(person);
        }
        public static void Remove(Person person)
        {
            List.Remove(person);
        }
        public static bool CheckUserNameAndPassword(Person PersonToAdd)
        {
            foreach (var person in List)
            {
                if (person.UserName == PersonToAdd.UserName && person.Password == PersonToAdd.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckUserName(string username)
        {
            foreach (var person in List)
            {
                if (person.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static void UpdateAdmin(Admin admin)
        {
            foreach (var person in List)
            {
                if (person.UserName == admin.UserName && person is Admin)
                {
                    person.Password = admin.Password;
                    person.UserName = admin.UserName;
                    person.image = admin.image;
                    person.isExperienced = admin.isExperienced;
                }
            }
        }
        public static Person findPerson(string name, string password)
        {
            foreach (Person person in List)
            {
                if (name == person.UserName && password == person.Password)
                {
                    return person;
                }
            }
            return null;
        }
        public static void updateImage(string username, Image img)
        {
            foreach (var person in List)
            {
                if (username == person.UserName)
                    person.image = img;
            }
        }
        // File handling
        public static void StoreToFile()
        {
            char ch = '\u258C';
            StreamWriter writer = System.IO.File.CreateText(path);
            writer.Close();
            StreamWriter file = new StreamWriter(path, true);
            foreach (var person in List)
            {
                if (person is Customer)
                {
                    file.WriteLine(person.UserName + ch + person.Password + ch + "Customer");
                }
                else
                    file.WriteLine(person.UserName + ch + person.Password + ch + "Admin" + ch + person.isExperienced);
            }
            file.Flush();
            file.Close();
        }

        public static void ReadFromFile()
        {
            string[] filesInDirectory = Directory.GetFiles("C:\\Program files\\Z Mart\\Images");

            StreamReader file = new StreamReader(path);
            string record = string.Empty;
            while ((record = file.ReadLine()) != null)
            {
                MatchCollection match = Regex.Matches(record, @"[^\u258C]+");
                string username = match[0].Value;
                string password = match[1].Value;
                bool isExperienced = false;

                if (match.Count > 3)
                {
                    if (match[3].Value == "True")
                        isExperienced = true;
                    else
                        isExperienced = !true;
                }
                if (match[2].Value == "Customer")
                {
                    Customer customer = new Customer(username, password);
                    foreach (string filePath in filesInDirectory)
                    {
                        if (string.Equals(Path.GetFileName(filePath), "Image_Of_" + customer.UserName + ".png", StringComparison.OrdinalIgnoreCase))
                        {
                            customer.image = Image.FromFile(filePath);
                            break;
                        }
                    }
                    ReadCustomerItem(customer);
                    PersonCRUD.Add(customer);
                }
                else
                {
                    Admin admin = new Admin(username, password);
                    foreach (string filePath in filesInDirectory)
                    {
                        if (string.Equals(Path.GetFileName(filePath), "\\Image_Of_" + admin.UserName + ".png", StringComparison.OrdinalIgnoreCase))
                        {
                            admin.image = Image.FromFile(filePath + "\\Image_Of_" + admin.UserName + ".png");
                            break;
                        }
                    }
                    admin.isExperienced = isExperienced;
                    PersonCRUD.Add(admin);
                }
            }
            file.Close();
        }
        public static Image GetUserImage(string username)
        {
            foreach (var person in List)
            {
                if (username == person.UserName)
                    return person.image;
            }
            return null;
        }
        public static void StoreCustomerItem(Customer customer)
        {
            char ch = '\u258C';
            //File.CreateText(path2);
            foreach (var item in customer.Cart)
            {
                using (StreamWriter file = new StreamWriter(path2))
                {
                    file.WriteLine(customer.UserName + ch + item.Name + ch + item.Price + ch + item.Quantity);
                }
            }
        }
        public static void ReadCustomerItem(Customer customer)
        {
            string[] itemImages = Directory.GetFiles(itemsImagesPath);
            StreamReader file = new StreamReader(path2);
            string record = string.Empty;
            while ((record = file.ReadLine()) != null)
            {
                MatchCollection match = Regex.Matches(record, @"[^\u258C]+");
                if (match[0].Value == customer.UserName)
                {
                    Item item = new Item(match[1].Value, double.Parse(match[2].Value), double.Parse(match[3].Value), Z_Mart.Properties.Resources.Items_Icon);
                    foreach (string filePath in itemImages)
                    {
                        if (string.Equals(Path.GetFileName(filePath), "Image_Of_" + match[1].Value + ".png", StringComparison.OrdinalIgnoreCase))
                        {
                            item.image = Image.FromFile(filePath);
                        }
                    }
                    customer.AddToCart(item);
                }
            }
            file.Close();
        }

    }
}
