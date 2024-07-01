using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Mart.DL
{
    public static class Validation
    {
        public static bool UserName(string s)
        {
            if(string.IsNullOrWhiteSpace(s) || s == "")
            {
                return false;
            }
            return true;
        }
        public static bool Password(string s)
        {
            if (s.Contains(' ') && string.IsNullOrWhiteSpace(s) && s == "")
                return false;
            return true;
        }
        public static bool ItemName(string s)
        {
            if (string.IsNullOrWhiteSpace(s) && s == "")
                return false;
            return true;
        }
        public static bool ItemPrice(string s)
        {
            if (string.IsNullOrWhiteSpace(s) && s == "")
            {
                return false;
            }
            return true;
        }
        public static bool ItemQuantity(string s)
        {
            if (string.IsNullOrWhiteSpace(s) && s == "")
            {
                return false;
            }
            return true;

        }
    }
}
