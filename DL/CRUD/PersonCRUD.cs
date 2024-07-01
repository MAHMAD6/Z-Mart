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
        public static List<Person> List = new List<Person>();
  
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
   
        public static Person FindPerson(string name, string password)
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
            char ch = App.ch;
            StreamWriter file = new StreamWriter(App.AppTxtPath);
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

            StreamReader file = new StreamReader(App.AppTxtPath);
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
                    customer.image = GetPersonImage(username);
                    ReadCustomerItem(customer);
                    PersonCRUD.Add(customer);
                }
                else
                {
                    Admin admin = new Admin(username, password);
                    admin.image = GetPersonImage(username);
                    admin.isExperienced = isExperienced;
                    PersonCRUD.Add(admin);
                }
            }
            file.Close();
        }
        public static Image GetPersonImage(string name)
        {
            string path = string.Format(App.PersonImageNameWithPath, name);
            if (File.Exists(path))
                return Essentials.LoadImageWithoutLocking(path);
            else
                return null;
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
            char ch = App.ch;
            foreach (var item in customer.Cart)
            {
                using (StreamWriter file = new StreamWriter(App.CustomerTxtPath))
                {
                    file.WriteLine(customer.UserName + ch + item.Name + ch + item.Price + ch + item.Quantity);
                }
            }
        }
        public static void ReadCustomerItem(Customer customer)
        {
           
            StreamReader file = new StreamReader(App.CustomerTxtPath);
            string record = string.Empty;
            while ((record = file.ReadLine()) != null)
            {
                MatchCollection match = Regex.Matches(record, @"[^\u258C]+");
                if (match[0].Value == customer.UserName)
                {
                    Item item = new Item(match[1].Value, double.Parse(match[2].Value), double.Parse(match[3].Value), Z_Mart.Properties.Resources.Items_Icon);
                    Image img = ItemCRUD.GetItemImage(item.Name);
                    if (img != null)
                        item.image = img;
                    customer.AddToCart(item);
                }
            }
            file.Close();
        }

    }
}
