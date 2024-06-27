namespace Z_Mart.UC
{
    partial class Uc_AddItem
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
            this.L_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_ItemName = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ItemPrice = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_itemQuantity = new Bunifu.Framework.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.L_InvalidItemName = new System.Windows.Forms.Label();
            this.L_InvalidItemPrice = new System.Windows.Forms.Label();
            this.L_InvalidItemQuantity = new System.Windows.Forms.Label();
            this.Submit = new Guna.UI2.WinForms.Guna2Button();
            this.pb_itemImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.White;
            this.L_username.Location = new System.Drawing.Point(52, 153);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(284, 39);
            this.L_username.TabIndex = 4;
            this.L_username.Text = "Enter Item Name :";
            this.L_username.Click += new System.EventHandler(this.L_username_Click);
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
            this.panel1.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Item ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Item Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Item Quantity :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(410, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_ItemName.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ItemName.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.ForeColor = System.Drawing.Color.White;
            this.tb_ItemName.Location = new System.Drawing.Point(411, 160);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(366, 30);
            this.tb_ItemName.TabIndex = 8;
            this.tb_ItemName.TabStop = false;
            this.tb_ItemName.Text = "   Enter Item Name";
            this.tb_ItemName.TextChanged += new System.EventHandler(this.tb_ItemName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(411, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 5);
            this.panel2.TabIndex = 11;
            // 
            // tb_ItemPrice
            // 
            this.tb_ItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_ItemPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ItemPrice.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemPrice.ForeColor = System.Drawing.Color.White;
            this.tb_ItemPrice.Location = new System.Drawing.Point(404, 243);
            this.tb_ItemPrice.Name = "tb_ItemPrice";
            this.tb_ItemPrice.Size = new System.Drawing.Size(372, 30);
            this.tb_ItemPrice.TabIndex = 10;
            this.tb_ItemPrice.TabStop = false;
            this.tb_ItemPrice.Text = "   Enter Item Price";
            this.tb_ItemPrice.TextChanged += new System.EventHandler(this.tb_ItemPrice_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(411, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 5);
            this.panel4.TabIndex = 13;
            // 
            // tb_itemQuantity
            // 
            this.tb_itemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_itemQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_itemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_itemQuantity.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemQuantity.ForeColor = System.Drawing.Color.White;
            this.tb_itemQuantity.Location = new System.Drawing.Point(412, 327);
            this.tb_itemQuantity.Name = "tb_itemQuantity";
            this.tb_itemQuantity.Size = new System.Drawing.Size(370, 30);
            this.tb_itemQuantity.TabIndex = 12;
            this.tb_itemQuantity.TabStop = false;
            this.tb_itemQuantity.Text = "   Enter Quantity";
            this.tb_itemQuantity.TextChanged += new System.EventHandler(this.tb_itemQuantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter Item Image :";
            // 
            // L_InvalidItemName
            // 
            this.L_InvalidItemName.AutoSize = true;
            this.L_InvalidItemName.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemName.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemName.Location = new System.Drawing.Point(411, 204);
            this.L_InvalidItemName.Name = "L_InvalidItemName";
            this.L_InvalidItemName.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemName.TabIndex = 17;
            this.L_InvalidItemName.Text = "Error";
            this.L_InvalidItemName.Visible = false;
            this.L_InvalidItemName.Click += new System.EventHandler(this.L_InvalidItemName_Click);
            // 
            // L_InvalidItemPrice
            // 
            this.L_InvalidItemPrice.AutoSize = true;
            this.L_InvalidItemPrice.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemPrice.Location = new System.Drawing.Point(411, 287);
            this.L_InvalidItemPrice.Name = "L_InvalidItemPrice";
            this.L_InvalidItemPrice.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemPrice.TabIndex = 18;
            this.L_InvalidItemPrice.Text = "Error";
            this.L_InvalidItemPrice.Visible = false;
            // 
            // L_InvalidItemQuantity
            // 
            this.L_InvalidItemQuantity.AutoSize = true;
            this.L_InvalidItemQuantity.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemQuantity.Location = new System.Drawing.Point(411, 371);
            this.L_InvalidItemQuantity.Name = "L_InvalidItemQuantity";
            this.L_InvalidItemQuantity.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemQuantity.TabIndex = 19;
            this.L_InvalidItemQuantity.Text = "Error";
            this.L_InvalidItemQuantity.Visible = false;
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
            this.Submit.Location = new System.Drawing.Point(334, 546);
            this.Submit.Name = "Submit";
            this.Submit.ShadowDecoration.Parent = this.Submit;
            this.Submit.Size = new System.Drawing.Size(214, 66);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Add Item";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pb_itemImage
            // 
            this.pb_itemImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_itemImage.Image = global::Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            this.pb_itemImage.Location = new System.Drawing.Point(412, 396);
            this.pb_itemImage.Name = "pb_itemImage";
            this.pb_itemImage.Size = new System.Drawing.Size(130, 124);
            this.pb_itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_itemImage.TabIndex = 15;
            this.pb_itemImage.TabStop = false;
            this.pb_itemImage.Click += new System.EventHandler(this.pb_itemImage_Click);
            // 
            // Uc_AddItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.L_InvalidItemQuantity);
            this.Controls.Add(this.L_InvalidItemPrice);
            this.Controls.Add(this.L_InvalidItemName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pb_itemImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tb_itemQuantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_ItemPrice);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.L_username);
            this.Name = "Uc_AddItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.Load += new System.EventHandler(this.Uc_AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.BunifuCustomTextbox tb_ItemName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.BunifuCustomTextbox tb_ItemPrice;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.BunifuCustomTextbox tb_itemQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_itemImage;
        private Guna.UI2.WinForms.Guna2Button Submit;
        private System.Windows.Forms.Label L_InvalidItemName;
        private System.Windows.Forms.Label L_InvalidItemPrice;
        private System.Windows.Forms.Label L_InvalidItemQuantity;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
