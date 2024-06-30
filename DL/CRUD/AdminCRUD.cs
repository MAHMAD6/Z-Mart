using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z_Mart.BL;

namespace Z_Mart.DL
{
    internal class AdminCRUD : PersonCRUD
    {
        
        public static Admin Find(string username)
        {
            foreach (var person in List)
            {
                if (person.UserName == username && person is Admin)
                {
                    return (Admin)person;
                }
            }
            return null;
        }
        public static void UpdateAdmin(Admin adminToUpdate)
        {
            foreach (var admin in List)
            {
                if (admin.UserName == admin.UserName && admin is Admin)
                {
                    admin.Password = admin.Password;
                    admin.UserName = admin.UserName;
                    admin.image = admin.image;
                    admin.isExperienced = admin.isExperienced;
                }
            }
        }
    }
}
