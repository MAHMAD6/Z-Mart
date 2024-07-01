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
        public static readonly string PersonImagesFolderPath = ZMartPath + "\\Person_Images";
        public static readonly string ItemImagesFolderPath = ZMartPath + "\\Items_Images";
        public static readonly string PersonImageNameWithPath = PersonImagesFolderPath + "//image_of_{0}.png";
        public static readonly string ItemImageNameWithPath = ItemImagesFolderPath + "//image_of_{0}.png";
        public static readonly string DataPath = ZMartPath + "\\Data";
        public static readonly string ItemTxtPath = DataPath + "\\ItemData.txt";
        public static readonly string CustomerTxtPath = DataPath + "\\CustomerData.txt";
        public static readonly string AppTxtPath = DataPath + "\\AppData.txt";
        public static readonly char ch = '\u258C';

    }
}
