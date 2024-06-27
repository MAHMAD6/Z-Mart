namespace Z_Mart.UC
{
    partial class UC_DeleteItem
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
            this.L_ViewItems = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_InvalidItemName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_ItemName = new Bunifu.Framework.BunifuCustomTextbox();
            this.L_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.L_ViewItems);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 100);
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
            // L_ViewItems
            // 
            this.L_ViewItems.AutoSize = true;
            this.L_ViewItems.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ViewItems.ForeColor = System.Drawing.Color.White;
            this.L_ViewItems.Location = new System.Drawing.Point(376, 28);
            this.L_ViewItems.Name = "L_ViewItems";
            this.L_ViewItems.Size = new System.Drawing.Size(190, 39);
            this.L_ViewItems.TabIndex = 6;
            this.L_ViewItems.Text = "Delete Item";
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
            // L_InvalidItemName
            // 
            this.L_InvalidItemName.AutoSize = true;
            this.L_InvalidItemName.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemName.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemName.Location = new System.Drawing.Point(426, 204);
            this.L_InvalidItemName.Name = "L_InvalidItemName";
            this.L_InvalidItemName.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemName.TabIndex = 29;
            this.L_InvalidItemName.Text = "Error";
            this.L_InvalidItemName.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(425, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 28;
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_ItemName.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ItemName.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.ForeColor = System.Drawing.Color.White;
            this.tb_ItemName.Location = new System.Drawing.Point(426, 160);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(366, 30);
            this.tb_ItemName.TabIndex = 27;
            this.tb_ItemName.Text = "   Enter Item Name";
            this.tb_ItemName.TextChanged += new System.EventHandler(this.tb_ItemName_TextChanged);
            this.tb_ItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemName_KeyDown);
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(71, 158);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(281, 39);
            this.L_username.TabIndex = 26;
            this.L_username.Text = "Enter New Name :";
            // 
            // UC_DeleteItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.L_InvalidItemName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DeleteItem";
            this.Size = new System.Drawing.Size(909, 556);
            this.Load += new System.EventHandler(this.UC_DeleteItem_Load);
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
        private System.Windows.Forms.Label L_ViewItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_InvalidItemName;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.BunifuCustomTextbox tb_ItemName;
        private System.Windows.Forms.Label L_username;
    }
}
