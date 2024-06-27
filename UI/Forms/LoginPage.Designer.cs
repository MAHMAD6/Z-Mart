namespace Z_Mart
{
    partial class LoginPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_MainText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.L_InvalidPassword = new System.Windows.Forms.Label();
            this.L_InvalidUserName = new System.Windows.Forms.Label();
            this.l_NotHaveAAccount = new System.Windows.Forms.Label();
            this.b_SignIn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_EnterPassword = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_Password = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_username = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_username = new System.Windows.Forms.Label();
            this.SignInElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SignInPanel1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SignInPanel2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SignInTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pb_monkey = new System.Windows.Forms.PictureBox();
            this.pb_HideUnhidePassword = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.icon_username = new System.Windows.Forms.PictureBox();
            this.Pb_Exitlogin = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_monkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HideUnhidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Exitlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.SignInTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(441, 842);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.L_MainText);
            this.panel2.Controls.Add(this.pb_monkey);
            this.panel2.Controls.Add(this.pb_HideUnhidePassword);
            this.panel2.Controls.Add(this.L_InvalidPassword);
            this.panel2.Controls.Add(this.L_InvalidUserName);
            this.panel2.Controls.Add(this.l_NotHaveAAccount);
            this.panel2.Controls.Add(this.b_SignIn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.tb_EnterPassword);
            this.panel2.Controls.Add(this.L_Password);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.icon_username);
            this.panel2.Controls.Add(this.tb_username);
            this.panel2.Controls.Add(this.L_username);
            this.panel2.Controls.Add(this.Pb_Exitlogin);
            this.SignInTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 834);
            this.panel2.TabIndex = 0;
            // 
            // L_MainText
            // 
            this.L_MainText.AutoSize = true;
            this.L_MainText.BackColor = System.Drawing.Color.Transparent;
            this.SignInTransition.SetDecoration(this.L_MainText, BunifuAnimatorNS.DecorationType.None);
            this.L_MainText.Font = new System.Drawing.Font("Nexa Heavy", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.L_MainText.Location = new System.Drawing.Point(122, 218);
            this.L_MainText.Name = "L_MainText";
            this.L_MainText.Size = new System.Drawing.Size(182, 61);
            this.L_MainText.TabIndex = 2;
            this.L_MainText.Text = "Sign in";
            // 
            // L_InvalidPassword
            // 
            this.L_InvalidPassword.AutoSize = true;
            this.SignInTransition.SetDecoration(this.L_InvalidPassword, BunifuAnimatorNS.DecorationType.None);
            this.L_InvalidPassword.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidPassword.Location = new System.Drawing.Point(99, 536);
            this.L_InvalidPassword.Name = "L_InvalidPassword";
            this.L_InvalidPassword.Size = new System.Drawing.Size(183, 26);
            this.L_InvalidPassword.TabIndex = 16;
            this.L_InvalidPassword.Text = "Invalid Password";
            // 
            // L_InvalidUserName
            // 
            this.L_InvalidUserName.AutoSize = true;
            this.SignInTransition.SetDecoration(this.L_InvalidUserName, BunifuAnimatorNS.DecorationType.None);
            this.L_InvalidUserName.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidUserName.Location = new System.Drawing.Point(100, 416);
            this.L_InvalidUserName.Name = "L_InvalidUserName";
            this.L_InvalidUserName.Size = new System.Drawing.Size(190, 26);
            this.L_InvalidUserName.TabIndex = 15;
            this.L_InvalidUserName.Text = "Invalid UserName";
            // 
            // l_NotHaveAAccount
            // 
            this.l_NotHaveAAccount.AutoSize = true;
            this.SignInTransition.SetDecoration(this.l_NotHaveAAccount, BunifuAnimatorNS.DecorationType.None);
            this.l_NotHaveAAccount.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_NotHaveAAccount.ForeColor = System.Drawing.Color.White;
            this.l_NotHaveAAccount.Location = new System.Drawing.Point(101, 676);
            this.l_NotHaveAAccount.Name = "l_NotHaveAAccount";
            this.l_NotHaveAAccount.Size = new System.Drawing.Size(216, 26);
            this.l_NotHaveAAccount.TabIndex = 13;
            this.l_NotHaveAAccount.Text = "Not have a Account?";
            // 
            // b_SignIn
            // 
            this.b_SignIn.CheckedState.Parent = this.b_SignIn;
            this.b_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_SignIn.CustomImages.Parent = this.b_SignIn;
            this.SignInTransition.SetDecoration(this.b_SignIn, BunifuAnimatorNS.DecorationType.None);
            this.b_SignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(15)))), ((int)(((byte)(197)))));
            this.b_SignIn.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.b_SignIn.ForeColor = System.Drawing.Color.White;
            this.b_SignIn.HoverState.Parent = this.b_SignIn;
            this.b_SignIn.Location = new System.Drawing.Point(101, 593);
            this.b_SignIn.Name = "b_SignIn";
            this.b_SignIn.ShadowDecoration.Parent = this.b_SignIn;
            this.b_SignIn.Size = new System.Drawing.Size(222, 65);
            this.b_SignIn.TabIndex = 12;
            this.b_SignIn.Text = "Sign In";
            this.b_SignIn.Click += new System.EventHandler(this.b_SignIn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(91, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 5);
            this.panel4.TabIndex = 10;
            // 
            // tb_EnterPassword
            // 
            this.tb_EnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_EnterPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_EnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignInTransition.SetDecoration(this.tb_EnterPassword, BunifuAnimatorNS.DecorationType.None);
            this.tb_EnterPassword.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterPassword.ForeColor = System.Drawing.Color.White;
            this.tb_EnterPassword.Location = new System.Drawing.Point(92, 492);
            this.tb_EnterPassword.Name = "tb_EnterPassword";
            this.tb_EnterPassword.Size = new System.Drawing.Size(240, 30);
            this.tb_EnterPassword.TabIndex = 8;
            this.tb_EnterPassword.Text = "   Enter Password";
            this.tb_EnterPassword.Click += new System.EventHandler(this.tb_EnterPassword_Click);
            this.tb_EnterPassword.TextChanged += new System.EventHandler(this.tb_EnterPassword_TextChanged);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.SignInTransition.SetDecoration(this.L_Password, BunifuAnimatorNS.DecorationType.None);
            this.L_Password.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.Color.White;
            this.L_Password.Location = new System.Drawing.Point(88, 446);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(162, 39);
            this.L_Password.TabIndex = 7;
            this.L_Password.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(92, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 5);
            this.panel3.TabIndex = 6;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_username.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignInTransition.SetDecoration(this.tb_username, BunifuAnimatorNS.DecorationType.None);
            this.tb_username.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(93, 374);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(280, 30);
            this.tb_username.TabIndex = 4;
            this.tb_username.Text = "   Enter UserName";
            this.tb_username.Click += new System.EventHandler(this.tb_username_Click);
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.SignInTransition.SetDecoration(this.L_username, BunifuAnimatorNS.DecorationType.None);
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(89, 328);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(179, 39);
            this.L_username.TabIndex = 3;
            this.L_username.Text = "User Name";
            // 
            // SignInElipse
            // 
            this.SignInElipse.ElipseRadius = 20;
            this.SignInElipse.TargetControl = this;
            // 
            // SignInPanel1
            // 
            this.SignInPanel1.ElipseRadius = 20;
            this.SignInPanel1.TargetControl = this.panel1;
            // 
            // SignInPanel2
            // 
            this.SignInPanel2.ElipseRadius = 20;
            this.SignInPanel2.TargetControl = this.panel2;
            // 
            // SignInTransition
            // 
            this.SignInTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.SignInTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.SignInTransition.DefaultAnimation = animation6;
            // 
            // pb_monkey
            // 
            this.SignInTransition.SetDecoration(this.pb_monkey, BunifuAnimatorNS.DecorationType.None);
            this.pb_monkey.Image = global::Z_Mart.Properties.Resources.Normal;
            this.pb_monkey.Location = new System.Drawing.Point(71, -4);
            this.pb_monkey.Name = "pb_monkey";
            this.pb_monkey.Size = new System.Drawing.Size(282, 256);
            this.pb_monkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_monkey.TabIndex = 18;
            this.pb_monkey.TabStop = false;
            // 
            // pb_HideUnhidePassword
            // 
            this.pb_HideUnhidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInTransition.SetDecoration(this.pb_HideUnhidePassword, BunifuAnimatorNS.DecorationType.None);
            this.pb_HideUnhidePassword.Image = global::Z_Mart.Properties.Resources.ShowPassword_White;
            this.pb_HideUnhidePassword.Location = new System.Drawing.Point(327, 492);
            this.pb_HideUnhidePassword.Name = "pb_HideUnhidePassword";
            this.pb_HideUnhidePassword.Size = new System.Drawing.Size(44, 30);
            this.pb_HideUnhidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_HideUnhidePassword.TabIndex = 17;
            this.pb_HideUnhidePassword.TabStop = false;
            this.pb_HideUnhidePassword.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox3
            // 
            this.SignInTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Z_Mart.Properties.Resources.Lock_White_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(32, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // icon_username
            // 
            this.SignInTransition.SetDecoration(this.icon_username, BunifuAnimatorNS.DecorationType.None);
            this.icon_username.Image = global::Z_Mart.Properties.Resources.user_White_icon;
            this.icon_username.Location = new System.Drawing.Point(33, 318);
            this.icon_username.Name = "icon_username";
            this.icon_username.Size = new System.Drawing.Size(50, 43);
            this.icon_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_username.TabIndex = 5;
            this.icon_username.TabStop = false;
            // 
            // Pb_Exitlogin
            // 
            this.Pb_Exitlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInTransition.SetDecoration(this.Pb_Exitlogin, BunifuAnimatorNS.DecorationType.None);
            this.Pb_Exitlogin.Image = global::Z_Mart.Properties.Resources.close_icon_White;
            this.Pb_Exitlogin.Location = new System.Drawing.Point(383, 3);
            this.Pb_Exitlogin.Name = "Pb_Exitlogin";
            this.Pb_Exitlogin.Size = new System.Drawing.Size(47, 47);
            this.Pb_Exitlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Exitlogin.TabIndex = 0;
            this.Pb_Exitlogin.TabStop = false;
            this.Pb_Exitlogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.SignInTransition.SetDecoration(this.guna2Button1, BunifuAnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(115, 718);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(189, 65);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Sign UP";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(441, 842);
            this.Controls.Add(this.panel1);
            this.SignInTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_monkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HideUnhidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Exitlogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Pb_Exitlogin;
        private System.Windows.Forms.PictureBox icon_username;
        private Bunifu.Framework.BunifuCustomTextbox tb_username;
        private System.Windows.Forms.Label L_username;
        private Bunifu.Framework.UI.BunifuCustomLabel L_MainText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.BunifuCustomTextbox tb_EnterPassword;
        private System.Windows.Forms.Label L_Password;
        private Guna.UI2.WinForms.Guna2Button b_SignIn;
        private System.Windows.Forms.Label l_NotHaveAAccount;
        private Bunifu.Framework.UI.BunifuElipse SignInElipse;
        private Bunifu.Framework.UI.BunifuElipse SignInPanel1;
        private Bunifu.Framework.UI.BunifuElipse SignInPanel2;
        private System.Windows.Forms.Label L_InvalidPassword;
        private System.Windows.Forms.Label L_InvalidUserName;
        private BunifuAnimatorNS.BunifuTransition SignInTransition;
        private System.Windows.Forms.PictureBox pb_HideUnhidePassword;
        private System.Windows.Forms.PictureBox pb_monkey;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}