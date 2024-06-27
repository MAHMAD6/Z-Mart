using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Mart.BL
{
    internal class Admin : Person
    {
        public Admin(string username, string password,bool isExperienced,Image image)
        {
            this.UserName = username;
            this.Password = password;
            this.isExperienced = isExperienced;
            this.image = image;
        }
        public Admin(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
    }
}
