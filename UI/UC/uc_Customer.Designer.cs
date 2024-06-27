namespace Z_Mart.UC
{
    partial class uc_Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.adminRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.L_username = new System.Windows.Forms.Label();
            this.pb_Customer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Nexa Heavy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "User Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Nexa Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.Color.ForestGreen;
            this.L_Password.Location = new System.Drawing.Point(157, 286);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(118, 29);
            this.L_Password.TabIndex = 18;
            this.L_Password.Text = "password";
            this.L_Password.Click += new System.EventHandler(this.L_Password_Click);
            // 
            // adminRating
            // 
            this.adminRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.adminRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.adminRating.Location = new System.Drawing.Point(68, 328);
            this.adminRating.Name = "adminRating";
            this.adminRating.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(15)))));
            this.adminRating.Size = new System.Drawing.Size(214, 45);
            this.adminRating.TabIndex = 16;
            this.adminRating.Value = 4F;
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.BackColor = System.Drawing.Color.Gainsboro;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.Location = new System.Drawing.Point(151, 253);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(175, 38);
            this.L_username.TabIndex = 15;
            this.L_username.Text = "User Name";
            this.L_username.Click += new System.EventHandler(this.L_username_Click);
            // 
            // pb_Customer
            // 
            this.pb_Customer.Image = global::Z_Mart.Properties.Resources.user_icon_big;
            this.pb_Customer.Location = new System.Drawing.Point(79, 47);
            this.pb_Customer.Name = "pb_Customer";
            this.pb_Customer.Size = new System.Drawing.Size(200, 200);
            this.pb_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Customer.TabIndex = 14;
            this.pb_Customer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(318, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // uc_Customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.adminRating);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.pb_Customer);
            this.Controls.Add(this.pictureBox2);
            this.Name = "uc_Customer";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(380, 380);
            this.Load += new System.EventHandler(this.uc_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Password;
        private Guna.UI2.WinForms.Guna2RatingStar adminRating;
        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.PictureBox pb_Customer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
