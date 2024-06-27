namespace Z_Mart.UC
{
    partial class uc_updateAdmin
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
            this.L_ViewItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_UserName_1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_username = new System.Windows.Forms.Label();
            this.l_Message = new System.Windows.Forms.Label();
            this.L_InvalidPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_EnterPassword = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_username = new Bunifu.Framework.BunifuCustomTextbox();
            this.adminexp = new System.Windows.Forms.Label();
            this.adminPassword = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.Label();
            this.userNameError = new System.Windows.Forms.Label();
            this.Submit = new Guna.UI2.WinForms.Guna2Button();
            this.pb_AdminImage = new System.Windows.Forms.PictureBox();
            this.adminImageL = new System.Windows.Forms.Label();
            this.cbImage = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdateExperience = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdatePassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbuserName = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb_isExperienced = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdminImage)).BeginInit();
            this.SuspendLayout();
            // 
            // L_ViewItems
            // 
            this.L_ViewItems.AutoSize = true;
            this.L_ViewItems.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ViewItems.ForeColor = System.Drawing.Color.White;
            this.L_ViewItems.Location = new System.Drawing.Point(376, 28);
            this.L_ViewItems.Name = "L_ViewItems";
            this.L_ViewItems.Size = new System.Drawing.Size(231, 39);
            this.L_ViewItems.TabIndex = 6;
            this.L_ViewItems.Text = "Update Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(15)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.L_ViewItems);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.back_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Z_Mart.Properties.Resources.Update_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(275, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(440, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "Error";
            this.label1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(433, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 41;
            // 
            // tb_UserName_1
            // 
            this.tb_UserName_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_UserName_1.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_UserName_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_UserName_1.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName_1.ForeColor = System.Drawing.Color.White;
            this.tb_UserName_1.Location = new System.Drawing.Point(434, 154);
            this.tb_UserName_1.Name = "tb_UserName_1";
            this.tb_UserName_1.Size = new System.Drawing.Size(366, 30);
            this.tb_UserName_1.TabIndex = 40;
            this.tb_UserName_1.Text = "   Enter UserName";
            this.tb_UserName_1.TextChanged += new System.EventHandler(this.tb_ItemName_TextChanged);
            this.tb_UserName_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemName_KeyDown);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(79, 152);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(278, 39);
            this.L_username.TabIndex = 39;
            this.L_username.Text = "Enter UserName :";
            // 
            // l_Message
            // 
            this.l_Message.AutoSize = true;
            this.l_Message.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Message.ForeColor = System.Drawing.Color.White;
            this.l_Message.Location = new System.Drawing.Point(83, 156);
            this.l_Message.Name = "l_Message";
            this.l_Message.Size = new System.Drawing.Size(546, 39);
            this.l_Message.TabIndex = 43;
            this.l_Message.Text = "Check the boxes you want to update";
            this.l_Message.Visible = false;
            // 
            // L_InvalidPassword
            // 
            this.L_InvalidPassword.AutoSize = true;
            this.L_InvalidPassword.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidPassword.Location = new System.Drawing.Point(445, 361);
            this.L_InvalidPassword.Name = "L_InvalidPassword";
            this.L_InvalidPassword.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidPassword.TabIndex = 54;
            this.L_InvalidPassword.Text = "Error";
            this.L_InvalidPassword.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(439, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 5);
            this.panel2.TabIndex = 51;
            this.panel2.Visible = false;
            // 
            // tb_EnterPassword
            // 
            this.tb_EnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_EnterPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_EnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_EnterPassword.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterPassword.ForeColor = System.Drawing.Color.White;
            this.tb_EnterPassword.Location = new System.Drawing.Point(438, 317);
            this.tb_EnterPassword.Name = "tb_EnterPassword";
            this.tb_EnterPassword.Size = new System.Drawing.Size(372, 30);
            this.tb_EnterPassword.TabIndex = 50;
            this.tb_EnterPassword.Text = "   Enter Password";
            this.tb_EnterPassword.Visible = false;
            this.tb_EnterPassword.TextChanged += new System.EventHandler(this.tb_ItemPrice_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(444, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 5);
            this.panel5.TabIndex = 49;
            this.panel5.Visible = false;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_username.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(445, 244);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(366, 30);
            this.tb_username.TabIndex = 48;
            this.tb_username.Text = "   Enter User Name";
            this.tb_username.Visible = false;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_enter_ItemName_2_TextChanged);
            // 
            // adminexp
            // 
            this.adminexp.AutoSize = true;
            this.adminexp.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminexp.ForeColor = System.Drawing.Color.White;
            this.adminexp.Location = new System.Drawing.Point(84, 394);
            this.adminexp.Name = "adminexp";
            this.adminexp.Size = new System.Drawing.Size(288, 39);
            this.adminexp.TabIndex = 47;
            this.adminexp.Text = "Enter Experience :";
            this.adminexp.Visible = false;
            // 
            // adminPassword
            // 
            this.adminPassword.AutoSize = true;
            this.adminPassword.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword.ForeColor = System.Drawing.Color.White;
            this.adminPassword.Location = new System.Drawing.Point(84, 310);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(267, 39);
            this.adminPassword.TabIndex = 46;
            this.adminPassword.Text = "Enter Password :";
            this.adminPassword.Visible = false;
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName.ForeColor = System.Drawing.Color.White;
            this.adminName.Location = new System.Drawing.Point(84, 237);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(284, 39);
            this.adminName.TabIndex = 45;
            this.adminName.Text = "Enter User Name :";
            this.adminName.Visible = false;
            // 
            // userNameError
            // 
            this.userNameError.AutoSize = true;
            this.userNameError.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameError.ForeColor = System.Drawing.Color.Firebrick;
            this.userNameError.Location = new System.Drawing.Point(445, 288);
            this.userNameError.Name = "userNameError";
            this.userNameError.Size = new System.Drawing.Size(64, 26);
            this.userNameError.TabIndex = 44;
            this.userNameError.Text = "Error";
            this.userNameError.Visible = false;
            // 
            // Submit
            // 
            this.Submit.CheckedState.Parent = this.Submit;
            this.Submit.CustomImages.Parent = this.Submit;
            this.Submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(19)))));
            this.Submit.Font = new System.Drawing.Font("Nexa Heavy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.Submit.HoverState.Parent = this.Submit;
            this.Submit.Image = global::Z_Mart.Properties.Resources.DoubleTick_Icon;
            this.Submit.ImageSize = new System.Drawing.Size(40, 40);
            this.Submit.Location = new System.Drawing.Point(335, 590);
            this.Submit.Name = "Submit";
            this.Submit.ShadowDecoration.Parent = this.Submit;
            this.Submit.Size = new System.Drawing.Size(254, 66);
            this.Submit.TabIndex = 58;
            this.Submit.Text = "Update Admin";
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pb_AdminImage
            // 
            this.pb_AdminImage.Image = global::Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            this.pb_AdminImage.Location = new System.Drawing.Point(450, 474);
            this.pb_AdminImage.Name = "pb_AdminImage";
            this.pb_AdminImage.Size = new System.Drawing.Size(130, 124);
            this.pb_AdminImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AdminImage.TabIndex = 57;
            this.pb_AdminImage.TabStop = false;
            this.pb_AdminImage.Visible = false;
            this.pb_AdminImage.Click += new System.EventHandler(this.pb_itemImage_Click);
            // 
            // adminImageL
            // 
            this.adminImageL.AutoSize = true;
            this.adminImageL.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminImageL.ForeColor = System.Drawing.Color.White;
            this.adminImageL.Location = new System.Drawing.Point(83, 487);
            this.adminImageL.Name = "adminImageL";
            this.adminImageL.Size = new System.Drawing.Size(286, 39);
            this.adminImageL.TabIndex = 56;
            this.adminImageL.Text = "Enter New Image :";
            this.adminImageL.Visible = false;
            // 
            // cbImage
            // 
            this.cbImage.AutoSize = true;
            this.cbImage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbImage.CheckedState.BorderRadius = 2;
            this.cbImage.CheckedState.BorderThickness = 0;
            this.cbImage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbImage.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImage.ForeColor = System.Drawing.Color.White;
            this.cbImage.Location = new System.Drawing.Point(62, 489);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(203, 35);
            this.cbImage.TabIndex = 62;
            this.cbImage.Text = "Update Image";
            this.cbImage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbImage.UncheckedState.BorderRadius = 2;
            this.cbImage.UncheckedState.BorderThickness = 0;
            this.cbImage.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbImage.UseVisualStyleBackColor = true;
            this.cbImage.Visible = false;
            this.cbImage.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // cbUpdateExperience
            // 
            this.cbUpdateExperience.AutoSize = true;
            this.cbUpdateExperience.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateExperience.CheckedState.BorderRadius = 2;
            this.cbUpdateExperience.CheckedState.BorderThickness = 0;
            this.cbUpdateExperience.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateExperience.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateExperience.ForeColor = System.Drawing.Color.White;
            this.cbUpdateExperience.Location = new System.Drawing.Point(62, 394);
            this.cbUpdateExperience.Name = "cbUpdateExperience";
            this.cbUpdateExperience.Size = new System.Drawing.Size(260, 35);
            this.cbUpdateExperience.TabIndex = 61;
            this.cbUpdateExperience.Text = "Update Experience";
            this.cbUpdateExperience.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateExperience.UncheckedState.BorderRadius = 2;
            this.cbUpdateExperience.UncheckedState.BorderThickness = 0;
            this.cbUpdateExperience.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateExperience.UseVisualStyleBackColor = true;
            this.cbUpdateExperience.Visible = false;
            this.cbUpdateExperience.CheckedChanged += new System.EventHandler(this.cbUpdateExperience_CheckedChanged);
            // 
            // cbUpdatePassword
            // 
            this.cbUpdatePassword.AutoSize = true;
            this.cbUpdatePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdatePassword.CheckedState.BorderRadius = 2;
            this.cbUpdatePassword.CheckedState.BorderThickness = 0;
            this.cbUpdatePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdatePassword.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.cbUpdatePassword.Location = new System.Drawing.Point(62, 317);
            this.cbUpdatePassword.Name = "cbUpdatePassword";
            this.cbUpdatePassword.Size = new System.Drawing.Size(246, 35);
            this.cbUpdatePassword.TabIndex = 60;
            this.cbUpdatePassword.Text = "Update Password";
            this.cbUpdatePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdatePassword.UncheckedState.BorderRadius = 2;
            this.cbUpdatePassword.UncheckedState.BorderThickness = 0;
            this.cbUpdatePassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdatePassword.UseVisualStyleBackColor = true;
            this.cbUpdatePassword.Visible = false;
            this.cbUpdatePassword.CheckedChanged += new System.EventHandler(this.cbUpdatePassword_CheckedChanged);
            // 
            // cbuserName
            // 
            this.cbuserName.AutoSize = true;
            this.cbuserName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbuserName.CheckedState.BorderRadius = 2;
            this.cbuserName.CheckedState.BorderThickness = 0;
            this.cbuserName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbuserName.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbuserName.ForeColor = System.Drawing.Color.White;
            this.cbuserName.Location = new System.Drawing.Point(62, 243);
            this.cbuserName.Name = "cbuserName";
            this.cbuserName.Size = new System.Drawing.Size(259, 35);
            this.cbuserName.TabIndex = 59;
            this.cbuserName.Text = "Update User Name";
            this.cbuserName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbuserName.UncheckedState.BorderRadius = 2;
            this.cbuserName.UncheckedState.BorderThickness = 0;
            this.cbuserName.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbuserName.UseVisualStyleBackColor = true;
            this.cbuserName.Visible = false;
            this.cbuserName.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // cb_isExperienced
            // 
            this.cb_isExperienced.AutoSize = true;
            this.cb_isExperienced.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold);
            this.cb_isExperienced.ForeColor = System.Drawing.Color.White;
            this.cb_isExperienced.Location = new System.Drawing.Point(433, 403);
            this.cb_isExperienced.Name = "cb_isExperienced";
            this.cb_isExperienced.Size = new System.Drawing.Size(277, 43);
            this.cb_isExperienced.TabIndex = 63;
            this.cb_isExperienced.Text = "   Is Experienced";
            this.cb_isExperienced.UseVisualStyleBackColor = true;
            this.cb_isExperienced.Visible = false;
            this.cb_isExperienced.CheckedChanged += new System.EventHandler(this.isExperienced_CheckedChanged);
            // 
            // uc_updateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.cb_isExperienced);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.cbUpdateExperience);
            this.Controls.Add(this.cbUpdatePassword);
            this.Controls.Add(this.cbuserName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pb_AdminImage);
            this.Controls.Add(this.adminImageL);
            this.Controls.Add(this.L_InvalidPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_EnterPassword);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.adminexp);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.userNameError);
            this.Controls.Add(this.l_Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_UserName_1);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.panel1);
            this.Name = "uc_updateAdmin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.Load += new System.EventHandler(this.uc_updateAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdminImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label L_ViewItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.BunifuCustomTextbox tb_UserName_1;
        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.Label l_Message;
        private System.Windows.Forms.Label L_InvalidPassword;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.BunifuCustomTextbox tb_EnterPassword;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.BunifuCustomTextbox tb_username;
        private System.Windows.Forms.Label adminexp;
        private System.Windows.Forms.Label adminPassword;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.Label userNameError;
        private Guna.UI2.WinForms.Guna2Button Submit;
        private System.Windows.Forms.PictureBox pb_AdminImage;
        private System.Windows.Forms.Label adminImageL;
        private Guna.UI2.WinForms.Guna2CheckBox cbImage;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdateExperience;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdatePassword;
        private Guna.UI2.WinForms.Guna2CheckBox cbuserName;
        private System.Windows.Forms.CheckBox cb_isExperienced;
    }
}
