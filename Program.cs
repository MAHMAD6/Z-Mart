using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Mart.Forms;

namespace Z_Mart
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                   
            
            
            Application.Run(new Loading());
            LoginPage loginPage = new LoginPage();
            Application.Run(loginPage);
        }
        private static bool HasRequiredPermissions()
        {
            // Your logic to check if permissions are available (replace with your specific logic)
            return false;
        }
    }
}
