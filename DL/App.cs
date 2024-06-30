using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Mart.DL
{
    internal class App
    {
        public static readonly string ZMartPath = "C:\\Program files\\Z Mart";
        public static readonly string ImagesFolderPath = ZMartPath + "\\Items_Images";
        public static readonly string ImageNameWithPath = ImagesFolderPath + "//image_of_{0}.png";
        public static readonly string DataPath = ZMartPath + "\\Data";
        public static readonly string ItemTxtPath = DataPath + "\\ItemData.txt";
        public static readonly string CustomerTxtPath = DataPath + "\\CustomerData.txt";
        public static readonly string AppTxtPath = DataPath + "\\AppData.txt";
        public static readonly char ch = '\u258C';

    }
}
