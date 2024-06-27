using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Z_Mart.BL;
using Z_Mart.DL;
using Z_Mart.Forms;

namespace Z_Mart.UC
{
    public partial class Uc_ManageAdmins : UserControl
    {
        List<UserControl> Menus = new List<UserControl>();
        UC_AddAdmin uC_AddAdmin1 = new UC_AddAdmin();
        Uc_ViewAdmin uc_ViewAdmin1 = new Uc_ViewAdmin();
        uc_DeleteAdmin uc_DeleteAdmin1 = new uc_DeleteAdmin();
        uc_updateAdmin uc_updateAdmin1 = new uc_updateAdmin();
        uc_SearchAdmin uc_SearchAdmin1 = new uc_SearchAdmin();
        public Uc_ManageAdmins()
        {
            InitializeComponent();
            Menus.Add(uC_AddAdmin1);
            Menus.Add(uc_ViewAdmin1);
            Menus.Add(uc_DeleteAdmin1);
            Menus.Add(uc_updateAdmin1);
            Menus.Add(uc_SearchAdmin1);
            //ADD
            pictureBox2.Click += panel1_Click;
            label2.Click += panel1_Click;
            pictureBox2.MouseEnter += ADD_MouseEnter;
            pictureBox2.MouseLeave += ADD_MouseLeave;
            label2.MouseEnter += ADD_MouseEnter;
            label2.MouseLeave += ADD_MouseLeave;
            add.MouseEnter += ADD_MouseEnter;
            add.MouseLeave += ADD_MouseLeave;
            //Delete
            pictureBox3.Click += panel5_Click;
            label3.Click += panel5_Click;
            pictureBox3.MouseEnter += Delete_MouseEnter;
            pictureBox3.MouseLeave += Delete_MouseLeave;
            label3.MouseEnter += Delete_MouseEnter;
            label3.MouseLeave += Delete_MouseLeave;
            Delete.MouseEnter += Delete_MouseEnter;
            Delete.MouseLeave += Delete_MouseLeave;
            //Update
            pictureBox1.Click += panel9_Click;
            label1.Click += panel9_Click;
            PUpdate.MouseEnter += Update_MouseEnter;
            PUpdate.MouseLeave += Update_MouseLeave;
            pictureBox1.MouseEnter += Update_MouseEnter;
            pictureBox1.MouseLeave += Update_MouseLeave;
            label1.MouseEnter += Update_MouseEnter;
            label1.MouseLeave += Update_MouseLeave;
            //View
            pictureBox4.Click += panel8_Click;
            label4.Click += panel8_Click;
            View.MouseEnter += View_MouseEnter;
            View.MouseLeave += View_MouseLeave;
            pictureBox4.MouseEnter += View_MouseEnter;
            pictureBox4.MouseLeave += View_MouseLeave;
            label4.MouseEnter += View_MouseEnter;
            label4.MouseLeave += View_MouseLeave;
        }
        private void View_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Z_Mart.Properties.Resources.Search_Gif;
            View.BackColor = Color.FromArgb(21, 43, 98);
        }
        private void View_MouseLeave(object sender, EventArgs e)
        {
            View.BackColor = Color.FromArgb(14, 28, 64);
            pictureBox4.Image = Z_Mart.Properties.Resources.Search_png;
        }
        private void Update_MouseEnter(object sender, EventArgs e)
        {
            PUpdate.BackColor = Color.FromArgb(21, 43, 98);
            pictureBox1.Image = Z_Mart.Properties.Resources.UPDATE_GIF_ORG_2;
        }
        private void Update_MouseLeave(object sender, EventArgs e)
        {
            PUpdate.BackColor = Color.FromArgb(14, 28, 64);
            pictureBox1.Image = Z_Mart.Properties.Resources.UPDATE_PNG_2;
        }
        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(21, 43, 98);
            pictureBox3.Image = Z_Mart.Properties.Resources.Delete_Gif;
        }
        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(14, 28, 64);
            pictureBox3.Image = Z_Mart.Properties.Resources.Delete_png;
        }
        private void ADD_MouseEnter(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(21, 43, 98);
            pictureBox2.Image = Z_Mart.Properties.Resources.ADD_GIF_2;
        }
        private void ADD_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(14, 28, 64);
            pictureBox2.Image = Z_Mart.Properties.Resources.ADD_PNG_2;
        }
        private void EnableUserControl(int index)
        {
            for (int i = 0; i < Menus.Count; i++)
            {
                if (i == index)
                {
                    this.Controls.Add(Menus[i]);
                    Menus[i].Visible = true;
                    Menus[i].BringToFront();
                    Menus[i].Dock = DockStyle.Fill;
                    Menus[i].Enabled = true;
                }
                else
                {
                    Menus[i].Visible = false;
                    Menus[i].Enabled = false;
                }
            }
        }


        private void panel1_Click(object sender, EventArgs e)//ADD
        {
            EnableUserControl(0);
        }

        private void panel9_Click(object sender, EventArgs e)//Update
        {
            EnableUserControl(3);
        }

        private void panel8_Click(object sender, EventArgs e)//View
        {
            EnableUserControl(1);
            uc_ViewAdmin1.viewItems();

        }

        private void panel5_Click(object sender, EventArgs e)//Delete
        {
            EnableUserControl(2);
        }

        private void SearchButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string adminName = SearchButton.Text;
                Admin admin = AdminCRUD.Find(adminName);
                if (admin != null)
                {
                    EnableUserControl(4);
                    this.Controls.Add(uc_SearchAdmin1);
                    var ucAdmin = new Uc_Admin(admin.UserName, admin.Password, admin.isExperienced, admin.image);
                    uc_SearchAdmin1.ADD(ucAdmin);
                }
                else
                {
                    var ItemDoesNotExist = new Notification();
                    ItemDoesNotExist.changeMessageDesign(Z_Mart.Properties.Resources.Error_Icon, "Admin Does Not Exist", "Please enter a valid username", Color.FromArgb(255, 74, 74), Color.FromArgb(150, 0, 0));
                    ItemDoesNotExist.Show();
                }
            }
        }
    }
}
