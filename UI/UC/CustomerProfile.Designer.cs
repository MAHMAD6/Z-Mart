namespace Z_Mart.UC
{
    partial class CustomerProfile
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
            this.p_border = new System.Windows.Forms.Panel();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_totalcarted = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.l_totalOrders = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.l_totalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.Pb_ChangeProfile = new System.Windows.Forms.PictureBox();
            this.L_InvalidUserName = new System.Windows.Forms.Label();
            this.p_usernme = new System.Windows.Forms.Panel();
            this.tb_username = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_InvalidPassword = new System.Windows.Forms.Label();
            this.p_pssword = new System.Windows.Forms.Panel();
            this.tb_EnterPassword = new Bunifu.Framework.BunifuCustomTextbox();
            this.p_border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ChangeProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // p_border
            // 
            this.p_border.BackColor = System.Drawing.Color.White;
            this.p_border.Controls.Add(this.pb_profile);
            this.p_border.Location = new System.Drawing.Point(307, 54);
            this.p_border.Name = "p_border";
            this.p_border.Padding = new System.Windows.Forms.Padding(3);
            this.p_border.Size = new System.Drawing.Size(225, 191);
            this.p_border.TabIndex = 0;
            // 
            // pb_profile
            // 
            this.pb_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_profile.Image = global::Z_Mart.Properties.Resources.Loading_Page1;
            this.pb_profile.Location = new System.Drawing.Point(3, 3);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(219, 185);
            this.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profile.TabIndex = 0;
            this.pb_profile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(176, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(176, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.BackColor = System.Drawing.Color.Transparent;
            this.l_username.Font = new System.Drawing.Font("Nexa Heavy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_username.ForeColor = System.Drawing.Color.White;
            this.l_username.Location = new System.Drawing.Point(407, 288);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(187, 43);
            this.l_username.TabIndex = 3;
            this.l_username.Text = "user name";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.Transparent;
            this.l_password.Font = new System.Drawing.Font("Nexa Heavy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.Color.White;
            this.l_password.Location = new System.Drawing.Point(407, 354);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(177, 43);
            this.l_password.TabIndex = 4;
            this.l_password.Text = "password";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.p_border;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.pb_profile;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.L_totalcarted);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.l_totalOrders);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(51, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 142);
            this.panel1.TabIndex = 8;
            // 
            // L_totalcarted
            // 
            this.L_totalcarted.AutoSize = true;
            this.L_totalcarted.BackColor = System.Drawing.Color.Transparent;
            this.L_totalcarted.Font = new System.Drawing.Font("Nexa Extra Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_totalcarted.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.L_totalcarted.Location = new System.Drawing.Point(177, 109);
            this.L_totalcarted.Name = "L_totalcarted";
            this.L_totalcarted.Size = new System.Drawing.Size(57, 26);
            this.L_totalcarted.TabIndex = 9;
            this.L_totalcarted.Text = "999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nexa Extra Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(7, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Carted :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.cart_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // l_totalOrders
            // 
            this.l_totalOrders.AutoSize = true;
            this.l_totalOrders.BackColor = System.Drawing.Color.Transparent;
            this.l_totalOrders.Font = new System.Drawing.Font("Nexa Heavy", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_totalOrders.ForeColor = System.Drawing.Color.White;
            this.l_totalOrders.Location = new System.Drawing.Point(140, 52);
            this.l_totalOrders.Name = "l_totalOrders";
            this.l_totalOrders.Size = new System.Drawing.Size(98, 48);
            this.l_totalOrders.TabIndex = 6;
            this.l_totalOrders.Text = "999";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nexa Extra Light", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Order Placed";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(54)))), ((int)(((byte)(207)))));
            this.panel3.Controls.Add(this.guna2CircleProgressBar1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(609, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 142);
            this.panel3.TabIndex = 9;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.2F;
            this.guna2CircleProgressBar1.FillThickness = 10;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(65, 42);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.guna2CircleProgressBar1.ProgressThickness = 10;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.ShowPercentage = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(102, 94);
            this.guna2CircleProgressBar1.TabIndex = 7;
            this.guna2CircleProgressBar1.Value = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Nexa Extra Light", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 36);
            this.label13.TabIndex = 6;
            this.label13.Text = "Current Sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.l_totalPrice);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(331, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 142);
            this.panel2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nexa Extra Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(176, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "30%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Nexa Extra Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(7, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Discounted :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Z_Mart.Properties.Resources.cart_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // l_totalPrice
            // 
            this.l_totalPrice.AutoSize = true;
            this.l_totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.l_totalPrice.Font = new System.Drawing.Font("Nexa Heavy", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_totalPrice.ForeColor = System.Drawing.Color.White;
            this.l_totalPrice.Location = new System.Drawing.Point(118, 55);
            this.l_totalPrice.Name = "l_totalPrice";
            this.l_totalPrice.Size = new System.Drawing.Size(84, 42);
            this.l_totalPrice.TabIndex = 6;
            this.l_totalPrice.Text = "999";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Nexa Extra Light", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 36);
            this.label12.TabIndex = 5;
            this.label12.Text = "Total Expense";
            // 
            // pb_password
            // 
            this.pb_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_password.Image = global::Z_Mart.Properties.Resources.edit_pencil_white;
            this.pb_password.Location = new System.Drawing.Point(626, 352);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(31, 65);
            this.pb_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_password.TabIndex = 7;
            this.pb_password.TabStop = false;
            this.pb_password.Click += new System.EventHandler(this.pb_password_Click);
            // 
            // pb_username
            // 
            this.pb_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_username.Image = global::Z_Mart.Properties.Resources.edit_pencil_white;
            this.pb_username.Location = new System.Drawing.Point(626, 272);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(31, 65);
            this.pb_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_username.TabIndex = 6;
            this.pb_username.TabStop = false;
            this.pb_username.Click += new System.EventHandler(this.pb_username_Click);
            this.pb_username.MouseEnter += new System.EventHandler(this.pb_username_MouseEnter);
            this.pb_username.MouseLeave += new System.EventHandler(this.pb_username_MouseLeave);
            // 
            // Pb_ChangeProfile
            // 
            this.Pb_ChangeProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_ChangeProfile.Image = global::Z_Mart.Properties.Resources.change_profile;
            this.Pb_ChangeProfile.Location = new System.Drawing.Point(535, 205);
            this.Pb_ChangeProfile.Name = "Pb_ChangeProfile";
            this.Pb_ChangeProfile.Size = new System.Drawing.Size(53, 49);
            this.Pb_ChangeProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_ChangeProfile.TabIndex = 5;
            this.Pb_ChangeProfile.TabStop = false;
            this.Pb_ChangeProfile.Click += new System.EventHandler(this.Pb_ChangeProfile_Click);
            this.Pb_ChangeProfile.MouseEnter += new System.EventHandler(this.Pb_ChangeProfile_MouseEnter);
            this.Pb_ChangeProfile.MouseLeave += new System.EventHandler(this.Pb_ChangeProfile_MouseLeave);
            // 
            // L_InvalidUserName
            // 
            this.L_InvalidUserName.AutoSize = true;
            this.L_InvalidUserName.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidUserName.Location = new System.Drawing.Point(412, 329);
            this.L_InvalidUserName.Name = "L_InvalidUserName";
            this.L_InvalidUserName.Size = new System.Drawing.Size(190, 26);
            this.L_InvalidUserName.TabIndex = 18;
            this.L_InvalidUserName.Text = "Invalid UserName";
            // 
            // p_usernme
            // 
            this.p_usernme.BackColor = System.Drawing.Color.White;
            this.p_usernme.Location = new System.Drawing.Point(404, 323);
            this.p_usernme.Name = "p_usernme";
            this.p_usernme.Size = new System.Drawing.Size(280, 5);
            this.p_usernme.TabIndex = 17;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_username.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(405, 287);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(280, 30);
            this.tb_username.TabIndex = 16;
            this.tb_username.Text = "   Enter UserName";
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // L_InvalidPassword
            // 
            this.L_InvalidPassword.AutoSize = true;
            this.L_InvalidPassword.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidPassword.Location = new System.Drawing.Point(412, 402);
            this.L_InvalidPassword.Name = "L_InvalidPassword";
            this.L_InvalidPassword.Size = new System.Drawing.Size(183, 26);
            this.L_InvalidPassword.TabIndex = 21;
            this.L_InvalidPassword.Text = "Invalid Password";
            // 
            // p_pssword
            // 
            this.p_pssword.BackColor = System.Drawing.Color.White;
            this.p_pssword.Location = new System.Drawing.Point(404, 394);
            this.p_pssword.Name = "p_pssword";
            this.p_pssword.Size = new System.Drawing.Size(280, 5);
            this.p_pssword.TabIndex = 20;
            // 
            // tb_EnterPassword
            // 
            this.tb_EnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_EnterPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_EnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_EnterPassword.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterPassword.ForeColor = System.Drawing.Color.White;
            this.tb_EnterPassword.Location = new System.Drawing.Point(405, 358);
            this.tb_EnterPassword.Name = "tb_EnterPassword";
            this.tb_EnterPassword.Size = new System.Drawing.Size(240, 30);
            this.tb_EnterPassword.TabIndex = 19;
            this.tb_EnterPassword.Text = "   Enter Password";
            this.tb_EnterPassword.TextChanged += new System.EventHandler(this.tb_EnterPassword_TextChanged);
            this.tb_EnterPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_EnterPassword_KeyDown);
            // 
            // CustomerProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.L_InvalidPassword);
            this.Controls.Add(this.p_pssword);
            this.Controls.Add(this.tb_EnterPassword);
            this.Controls.Add(this.L_InvalidUserName);
            this.Controls.Add(this.p_usernme);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.Pb_ChangeProfile);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_border);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomerProfile";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.Load += new System.EventHandler(this.CustomerProfile_Load);
            this.p_border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ChangeProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_border;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_password;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox Pb_ChangeProfile;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_totalcarted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label l_totalOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label l_totalPrice;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label L_InvalidUserName;
        private System.Windows.Forms.Panel p_usernme;
        private Bunifu.Framework.BunifuCustomTextbox tb_username;
        private System.Windows.Forms.Label L_InvalidPassword;
        private System.Windows.Forms.Panel p_pssword;
        private Bunifu.Framework.BunifuCustomTextbox tb_EnterPassword;
    }
}
