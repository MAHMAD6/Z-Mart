namespace Z_Mart.UC
{
    partial class UC_AddAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_username = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_username = new System.Windows.Forms.Label();
            this.L_InvalidPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EnterPassword = new Bunifu.Framework.BunifuCustomTextbox();
            this.isExperienced = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit = new Guna.UI2.WinForms.Guna2Button();
            this.pb_AdminImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdminImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Admin";
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.userNameErrorLabel.Location = new System.Drawing.Point(410, 218);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(64, 26);
            this.userNameErrorLabel.TabIndex = 24;
            this.userNameErrorLabel.Text = "Error";
            this.userNameErrorLabel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(409, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 23;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_username.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(410, 174);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(366, 30);
            this.tb_username.TabIndex = 22;
            this.tb_username.Text = "   Enter User Name";
            this.tb_username.TextChanged += new System.EventHandler(this.tb_ItemName_TextChanged);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(51, 167);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(284, 39);
            this.L_username.TabIndex = 21;
            this.L_username.Text = "Enter User Name :";
            // 
            // L_InvalidPassword
            // 
            this.L_InvalidPassword.AutoSize = true;
            this.L_InvalidPassword.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidPassword.Location = new System.Drawing.Point(410, 316);
            this.L_InvalidPassword.Name = "L_InvalidPassword";
            this.L_InvalidPassword.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidPassword.TabIndex = 28;
            this.L_InvalidPassword.Text = "Error";
            this.L_InvalidPassword.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(409, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 5);
            this.panel2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enter Password :";
            // 
            // tb_EnterPassword
            // 
            this.tb_EnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_EnterPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_EnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_EnterPassword.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterPassword.ForeColor = System.Drawing.Color.White;
            this.tb_EnterPassword.Location = new System.Drawing.Point(410, 272);
            this.tb_EnterPassword.Name = "tb_EnterPassword";
            this.tb_EnterPassword.Size = new System.Drawing.Size(366, 30);
            this.tb_EnterPassword.TabIndex = 26;
            this.tb_EnterPassword.Text = "   Enter Password";
            this.tb_EnterPassword.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // isExperienced
            // 
            this.isExperienced.AutoSize = true;
            this.isExperienced.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold);
            this.isExperienced.ForeColor = System.Drawing.Color.White;
            this.isExperienced.Location = new System.Drawing.Point(56, 437);
            this.isExperienced.Name = "isExperienced";
            this.isExperienced.Size = new System.Drawing.Size(277, 43);
            this.isExperienced.TabIndex = 29;
            this.isExperienced.Text = "   Is Experienced";
            this.isExperienced.UseVisualStyleBackColor = true;
            this.isExperienced.CheckedChanged += new System.EventHandler(this.isExperienced_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 39);
            this.label4.TabIndex = 30;
            this.label4.Text = "Enter Admin Image :";
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
            this.Submit.Location = new System.Drawing.Point(325, 534);
            this.Submit.Name = "Submit";
            this.Submit.ShadowDecoration.Parent = this.Submit;
            this.Submit.Size = new System.Drawing.Size(214, 66);
            this.Submit.TabIndex = 32;
            this.Submit.Text = "Add Admin";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pb_AdminImage
            // 
            this.pb_AdminImage.Image = global::Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            this.pb_AdminImage.Location = new System.Drawing.Point(409, 356);
            this.pb_AdminImage.Name = "pb_AdminImage";
            this.pb_AdminImage.Size = new System.Drawing.Size(130, 124);
            this.pb_AdminImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AdminImage.TabIndex = 31;
            this.pb_AdminImage.TabStop = false;
            this.pb_AdminImage.Click += new System.EventHandler(this.pb_itemImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.back_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(20, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Z_Mart.Properties.Resources.AddItem_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(302, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_AddAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pb_AdminImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isExperienced);
            this.Controls.Add(this.L_InvalidPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_EnterPassword);
            this.Controls.Add(this.userNameErrorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.tb_username);
            this.Name = "UC_AddAdmin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdminImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameErrorLabel;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.BunifuCustomTextbox tb_username;
        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.Label L_InvalidPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.BunifuCustomTextbox tb_EnterPassword;
        private System.Windows.Forms.CheckBox isExperienced;
        private System.Windows.Forms.PictureBox pb_AdminImage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Submit;
    }
}
