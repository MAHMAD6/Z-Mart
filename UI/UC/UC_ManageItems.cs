using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Z_Mart.UC
{
    public partial class UC_ManageItems : UserControl
    {
        List<UserControl> Menus = new List<UserControl>();
        Uc_AddItem uc_AddItem1 = new Uc_AddItem();
        UC_UpdateItem uC_UpdateItem1 = new UC_UpdateItem();
        UC_DeleteItem uC_DeleteItem1 = new UC_DeleteItem();
        UC_ViewItems uC_ViewItems1 = new UC_ViewItems();

        public UC_ManageItems()
        {
            InitializeComponent();
            Menus.Add(uc_AddItem1);
            Menus.Add(uC_UpdateItem1);
            Menus.Add(uC_DeleteItem1);
            Menus.Add(uC_ViewItems1);
            pictureBox2.MouseLeave += PictureBox_MouseLeave;
            pictureBox2.MouseEnter += PictureBox_MouseEnter;

            pictureBox3.MouseLeave += PictureBox_MouseLeave;
            pictureBox3.MouseEnter += PictureBox_MouseEnter;

            pictureBox4.MouseLeave += PictureBox_MouseLeave;
            pictureBox4.MouseEnter += PictureBox_MouseEnter;

            pictureBox5.MouseLeave += PictureBox_MouseLeave;
            pictureBox5.MouseEnter += PictureBox_MouseEnter;
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox pictureBox = (System.Windows.Forms.PictureBox)sender;
            pictureBox.Location = new System.Drawing.Point(pictureBox.Location.X, pictureBox.Location.Y - 10); // Move the picture box up by 10 pixels

        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox pictureBox = (System.Windows.Forms.PictureBox)sender;
            pictureBox.Location = new System.Drawing.Point(pictureBox.Location.X, pictureBox.Location.Y + 10); // Move the picture box down by 10 pixels

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EnableUserControl(2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EnableUserControl(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnableUserControl(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EnableUserControl(3);
            uC_ViewItems1.viewItems(true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
