using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;

namespace Z_Mart
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            loadingbar.Width = 0;
            this.Opacity = 0;

            // Loading & initializing Data for Application
 
            Essentials.InitializeAppDirectories(App.ZMartPath, 
                                                App.DataPath,
                                                App.ImagesFolderPath);
            Essentials.InitializeTxtFiles(App.ItemTxtPath,
                                          App.AppTxtPath);
            
            Admin admin = new Admin("Ahmad", "fff");
            AdminCRUD.Add(admin);
            
            ItemCRUD.ReadFromFile();
            PersonCRUD.ReadFromFile();
        }

        int i = 0;
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.25;
            if (loadingbar.Width <= 185)
            {
                loadingbar.Width += 6;
                LoadingPercentage.Text = i + " %";
                if (i <= 100)
                    i += 3;
            }
            if (loadingbar.Width >= 185)
            {
                this.Opacity -= 50;
                LoadingTimer.Stop();
                this.Close();
            }
        }

    }
}
