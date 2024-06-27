namespace Z_Mart.UC
{
    partial class Uc_Admin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_username = new System.Windows.Forms.Label();
            this.adminRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lExperienced = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Admin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.BackColor = System.Drawing.Color.Gainsboro;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.Location = new System.Drawing.Point(117, 254);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(175, 38);
            this.L_username.TabIndex = 7;
            this.L_username.Text = "User Name";
            // 
            // adminRating
            // 
            this.adminRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.adminRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.adminRating.Location = new System.Drawing.Point(115, 314);
            this.adminRating.Name = "adminRating";
            this.adminRating.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(15)))));
            this.adminRating.Size = new System.Drawing.Size(154, 36);
            this.adminRating.TabIndex = 8;
            this.adminRating.Value = 4F;
            // 
            // lExperienced
            // 
            this.lExperienced.AutoSize = true;
            this.lExperienced.BackColor = System.Drawing.Color.Firebrick;
            this.lExperienced.Font = new System.Drawing.Font("Nexa Heavy", 15F, System.Drawing.FontStyle.Bold);
            this.lExperienced.ForeColor = System.Drawing.Color.White;
            this.lExperienced.Location = new System.Drawing.Point(209, 348);
            this.lExperienced.Name = "lExperienced";
            this.lExperienced.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lExperienced.Size = new System.Drawing.Size(171, 32);
            this.lExperienced.TabIndex = 9;
            this.lExperienced.Text = "Experienced";
            this.lExperienced.Visible = false;
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Nexa Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.Color.ForestGreen;
            this.L_Password.Location = new System.Drawing.Point(123, 287);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(118, 29);
            this.L_Password.TabIndex = 10;
            this.L_Password.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Nexa Heavy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // pb_Admin
            // 
            this.pb_Admin.Image = global::Z_Mart.Properties.Resources.admin_profile_pic_holder;
            this.pb_Admin.Location = new System.Drawing.Point(80, 48);
            this.pb_Admin.Name = "pb_Admin";
            this.pb_Admin.Size = new System.Drawing.Size(200, 200);
            this.pb_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Admin.TabIndex = 6;
            this.pb_Admin.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.admin_icon_2;
            this.pictureBox2.Location = new System.Drawing.Point(319, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Uc_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.lExperienced);
            this.Controls.Add(this.adminRating);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.pb_Admin);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.Name = "Uc_Admin";
            this.Size = new System.Drawing.Size(380, 380);
            this.Load += new System.EventHandler(this.Uc_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_Admin;
        private System.Windows.Forms.Label L_username;
        private Guna.UI2.WinForms.Guna2RatingStar adminRating;
        private System.Windows.Forms.Label lExperienced;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
