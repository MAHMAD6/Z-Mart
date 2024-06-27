namespace Z_Mart.UC
{
    partial class uc_DeleteCustomer
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.L_Delete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_username = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.L_Delete);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.back_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // L_Delete
            // 
            this.L_Delete.AutoSize = true;
            this.L_Delete.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Delete.ForeColor = System.Drawing.Color.White;
            this.L_Delete.Location = new System.Drawing.Point(376, 28);
            this.L_Delete.Name = "L_Delete";
            this.L_Delete.Size = new System.Drawing.Size(266, 39);
            this.L_Delete.TabIndex = 6;
            this.L_Delete.Text = "Delete Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Z_Mart.Properties.Resources.Delete_Icon_Big;
            this.pictureBox1.Location = new System.Drawing.Point(275, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.userNameErrorLabel.Location = new System.Drawing.Point(433, 264);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(64, 26);
            this.userNameErrorLabel.TabIndex = 39;
            this.userNameErrorLabel.Text = "Error";
            this.userNameErrorLabel.Visible = false;
            this.userNameErrorLabel.Click += new System.EventHandler(this.userNameErrorLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(432, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 38;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.tb_username.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(433, 220);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(366, 30);
            this.tb_username.TabIndex = 37;
            this.tb_username.Text = "   Enter User Name";
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.BackColor = System.Drawing.Color.White;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_username.Location = new System.Drawing.Point(78, 218);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(277, 39);
            this.L_username.TabIndex = 36;
            this.L_username.Text = "Enter User Name:";
            // 
            // uc_DeleteCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userNameErrorLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.L_username);
            this.Name = "uc_DeleteCustomer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.Load += new System.EventHandler(this.uc_DeleteCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label L_Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameErrorLabel;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.BunifuCustomTextbox tb_username;
        private System.Windows.Forms.Label L_username;
    }
}
