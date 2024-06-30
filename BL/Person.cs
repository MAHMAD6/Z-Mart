using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Mart.BL
{
    abstract class Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Image image { get; set; }
        public bool isExperienced;
        public Person()
        {
            image = Z_Mart.Properties.Resources.userProfileHolder_Icon;
        }

    }
}
