using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Z_Mart.UC
{
    public partial class Uc_Admin : UserControl
    {
        public Uc_Admin(string username,string password,bool isExperienced,dynamic img)
        {
            InitializeComponent();
            lExperienced.Visible = isExperienced;
            L_username.Text = username;
            L_Password.Text = password;
            pb_Admin.Image = img;
        }

        private void Uc_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
