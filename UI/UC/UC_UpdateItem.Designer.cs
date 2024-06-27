namespace Z_Mart.UC
{
    partial class UC_UpdateItem
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
            this.back_button = new System.Windows.Forms.PictureBox();
            this.L_ViewItems = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_username = new System.Windows.Forms.Label();
            this.tb_ItemName = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.L_InvalidItemName = new System.Windows.Forms.Label();
            this.P_update1 = new System.Windows.Forms.Panel();
            this.cbUpdateImage = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdateQuantity = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdatePrice = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdateName = new Guna.UI2.WinForms.Guna2CheckBox();
            this.l_Message = new System.Windows.Forms.Label();
            this.L_InvalidItemQuantity = new System.Windows.Forms.Label();
            this.L_InvalidItemPrice = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.Submit = new Guna.UI2.WinForms.Guna2Button();
            this.pb_itemImage = new System.Windows.Forms.PictureBox();
            this.ItemImage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_itemQuantity = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ItemPrice = new Bunifu.Framework.BunifuCustomTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_enter_ItemName_2 = new Bunifu.Framework.BunifuCustomTextbox();
            this.itemQuantity = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.P_update1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.L_ViewItems);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 100);
            this.panel1.TabIndex = 7;
            // 
            // back_button
            // 
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = global::Z_Mart.Properties.Resources.back_Icon;
            this.back_button.Location = new System.Drawing.Point(3, 23);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(80, 50);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 7;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // L_ViewItems
            // 
            this.L_ViewItems.AutoSize = true;
            this.L_ViewItems.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ViewItems.ForeColor = System.Drawing.Color.White;
            this.L_ViewItems.Location = new System.Drawing.Point(376, 28);
            this.L_ViewItems.Name = "L_ViewItems";
            this.L_ViewItems.Size = new System.Drawing.Size(218, 39);
            this.L_ViewItems.TabIndex = 6;
            this.L_ViewItems.Text = "Update Items";
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
            // L_username
            // 
            this.L_username.AutoSize = true;
            this.L_username.BackColor = System.Drawing.Color.White;
            this.L_username.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_username.Location = new System.Drawing.Point(79, 26);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(281, 39);
            this.L_username.TabIndex = 22;
            this.L_username.Text = "Enter New Name :";
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_ItemName.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ItemName.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.ForeColor = System.Drawing.Color.White;
            this.tb_ItemName.Location = new System.Drawing.Point(434, 28);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(366, 30);
            this.tb_ItemName.TabIndex = 23;
            this.tb_ItemName.TabStop = false;
            this.tb_ItemName.Text = "   Enter Item Name";
            this.tb_ItemName.TextChanged += new System.EventHandler(this.tb_ItemName_TextChanged);
            this.tb_ItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ItemName_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(433, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 5);
            this.panel3.TabIndex = 24;
            // 
            // L_InvalidItemName
            // 
            this.L_InvalidItemName.AutoSize = true;
            this.L_InvalidItemName.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemName.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemName.Location = new System.Drawing.Point(440, 175);
            this.L_InvalidItemName.Name = "L_InvalidItemName";
            this.L_InvalidItemName.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemName.TabIndex = 25;
            this.L_InvalidItemName.Text = "Error";
            this.L_InvalidItemName.Visible = false;
            // 
            // P_update1
            // 
            this.P_update1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.P_update1.Controls.Add(this.cbUpdateImage);
            this.P_update1.Controls.Add(this.cbUpdateQuantity);
            this.P_update1.Controls.Add(this.cbUpdatePrice);
            this.P_update1.Controls.Add(this.cbUpdateName);
            this.P_update1.Controls.Add(this.l_Message);
            this.P_update1.Controls.Add(this.L_InvalidItemQuantity);
            this.P_update1.Controls.Add(this.L_InvalidItemPrice);
            this.P_update1.Controls.Add(this.l_name);
            this.P_update1.Controls.Add(this.Submit);
            this.P_update1.Controls.Add(this.pb_itemImage);
            this.P_update1.Controls.Add(this.ItemImage);
            this.P_update1.Controls.Add(this.panel4);
            this.P_update1.Controls.Add(this.tb_itemQuantity);
            this.P_update1.Controls.Add(this.panel2);
            this.P_update1.Controls.Add(this.tb_ItemPrice);
            this.P_update1.Controls.Add(this.panel5);
            this.P_update1.Controls.Add(this.tb_enter_ItemName_2);
            this.P_update1.Controls.Add(this.itemQuantity);
            this.P_update1.Controls.Add(this.itemPrice);
            this.P_update1.Controls.Add(this.itemName);
            this.P_update1.Controls.Add(this.L_InvalidItemName);
            this.P_update1.Controls.Add(this.panel3);
            this.P_update1.Controls.Add(this.tb_ItemName);
            this.P_update1.Controls.Add(this.L_username);
            this.P_update1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_update1.Location = new System.Drawing.Point(0, 100);
            this.P_update1.Name = "P_update1";
            this.P_update1.Size = new System.Drawing.Size(909, 556);
            this.P_update1.TabIndex = 8;
            // 
            // cbUpdateImage
            // 
            this.cbUpdateImage.AutoSize = true;
            this.cbUpdateImage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateImage.CheckedState.BorderRadius = 2;
            this.cbUpdateImage.CheckedState.BorderThickness = 0;
            this.cbUpdateImage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateImage.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateImage.ForeColor = System.Drawing.Color.White;
            this.cbUpdateImage.Location = new System.Drawing.Point(58, 376);
            this.cbUpdateImage.Name = "cbUpdateImage";
            this.cbUpdateImage.Size = new System.Drawing.Size(203, 35);
            this.cbUpdateImage.TabIndex = 45;
            this.cbUpdateImage.Text = "Update Image";
            this.cbUpdateImage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateImage.UncheckedState.BorderRadius = 2;
            this.cbUpdateImage.UncheckedState.BorderThickness = 0;
            this.cbUpdateImage.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateImage.UseVisualStyleBackColor = true;
            this.cbUpdateImage.Visible = false;
            this.cbUpdateImage.CheckedChanged += new System.EventHandler(this.cbUpdateImage_CheckedChanged);
            this.cbUpdateImage.Click += new System.EventHandler(this.cbUpdateImage_Click);
            // 
            // cbUpdateQuantity
            // 
            this.cbUpdateQuantity.AutoSize = true;
            this.cbUpdateQuantity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateQuantity.CheckedState.BorderRadius = 2;
            this.cbUpdateQuantity.CheckedState.BorderThickness = 0;
            this.cbUpdateQuantity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateQuantity.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateQuantity.ForeColor = System.Drawing.Color.White;
            this.cbUpdateQuantity.Location = new System.Drawing.Point(58, 281);
            this.cbUpdateQuantity.Name = "cbUpdateQuantity";
            this.cbUpdateQuantity.Size = new System.Drawing.Size(225, 35);
            this.cbUpdateQuantity.TabIndex = 44;
            this.cbUpdateQuantity.Text = "Update Quanity";
            this.cbUpdateQuantity.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateQuantity.UncheckedState.BorderRadius = 2;
            this.cbUpdateQuantity.UncheckedState.BorderThickness = 0;
            this.cbUpdateQuantity.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateQuantity.UseVisualStyleBackColor = true;
            this.cbUpdateQuantity.Visible = false;
            this.cbUpdateQuantity.CheckedChanged += new System.EventHandler(this.cbUpdateQuantity_CheckedChanged);
            this.cbUpdateQuantity.Click += new System.EventHandler(this.cbUpdateQuantity_Click);
            // 
            // cbUpdatePrice
            // 
            this.cbUpdatePrice.AutoSize = true;
            this.cbUpdatePrice.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdatePrice.CheckedState.BorderRadius = 2;
            this.cbUpdatePrice.CheckedState.BorderThickness = 0;
            this.cbUpdatePrice.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdatePrice.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdatePrice.ForeColor = System.Drawing.Color.White;
            this.cbUpdatePrice.Location = new System.Drawing.Point(58, 204);
            this.cbUpdatePrice.Name = "cbUpdatePrice";
            this.cbUpdatePrice.Size = new System.Drawing.Size(190, 35);
            this.cbUpdatePrice.TabIndex = 43;
            this.cbUpdatePrice.Text = "Update Price";
            this.cbUpdatePrice.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdatePrice.UncheckedState.BorderRadius = 2;
            this.cbUpdatePrice.UncheckedState.BorderThickness = 0;
            this.cbUpdatePrice.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdatePrice.UseVisualStyleBackColor = true;
            this.cbUpdatePrice.Visible = false;
            this.cbUpdatePrice.CheckedChanged += new System.EventHandler(this.cbUpdatePrice_CheckedChanged);
            this.cbUpdatePrice.Click += new System.EventHandler(this.cbUpdatePrice_Click);
            // 
            // cbUpdateName
            // 
            this.cbUpdateName.AutoSize = true;
            this.cbUpdateName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateName.CheckedState.BorderRadius = 2;
            this.cbUpdateName.CheckedState.BorderThickness = 0;
            this.cbUpdateName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateName.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateName.ForeColor = System.Drawing.Color.White;
            this.cbUpdateName.Location = new System.Drawing.Point(58, 130);
            this.cbUpdateName.Name = "cbUpdateName";
            this.cbUpdateName.Size = new System.Drawing.Size(199, 35);
            this.cbUpdateName.TabIndex = 42;
            this.cbUpdateName.Text = "Update Name";
            this.cbUpdateName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateName.UncheckedState.BorderRadius = 2;
            this.cbUpdateName.UncheckedState.BorderThickness = 0;
            this.cbUpdateName.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateName.UseVisualStyleBackColor = true;
            this.cbUpdateName.Visible = false;
            this.cbUpdateName.CheckedChanged += new System.EventHandler(this.cbUpdateName_CheckedChanged);
            this.cbUpdateName.Click += new System.EventHandler(this.cbUpdateName_Click);
            // 
            // l_Message
            // 
            this.l_Message.AutoSize = true;
            this.l_Message.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Message.ForeColor = System.Drawing.Color.White;
            this.l_Message.Location = new System.Drawing.Point(79, 26);
            this.l_Message.Name = "l_Message";
            this.l_Message.Size = new System.Drawing.Size(546, 39);
            this.l_Message.TabIndex = 41;
            this.l_Message.Text = "Check the boxes you want to update";
            this.l_Message.Visible = false;
            // 
            // L_InvalidItemQuantity
            // 
            this.L_InvalidItemQuantity.AutoSize = true;
            this.L_InvalidItemQuantity.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemQuantity.Location = new System.Drawing.Point(440, 332);
            this.L_InvalidItemQuantity.Name = "L_InvalidItemQuantity";
            this.L_InvalidItemQuantity.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemQuantity.TabIndex = 40;
            this.L_InvalidItemQuantity.Text = "Error";
            this.L_InvalidItemQuantity.Visible = false;
            // 
            // L_InvalidItemPrice
            // 
            this.L_InvalidItemPrice.AutoSize = true;
            this.L_InvalidItemPrice.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InvalidItemPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.L_InvalidItemPrice.Location = new System.Drawing.Point(440, 248);
            this.L_InvalidItemPrice.Name = "L_InvalidItemPrice";
            this.L_InvalidItemPrice.Size = new System.Drawing.Size(64, 26);
            this.L_InvalidItemPrice.TabIndex = 39;
            this.L_InvalidItemPrice.Text = "Error";
            this.L_InvalidItemPrice.Visible = false;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.ForeColor = System.Drawing.Color.Firebrick;
            this.l_name.Location = new System.Drawing.Point(440, 81);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(64, 26);
            this.l_name.TabIndex = 38;
            this.l_name.Text = "Error";
            this.l_name.Visible = false;
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
            this.Submit.Location = new System.Drawing.Point(340, 476);
            this.Submit.Name = "Submit";
            this.Submit.ShadowDecoration.Parent = this.Submit;
            this.Submit.Size = new System.Drawing.Size(254, 66);
            this.Submit.TabIndex = 37;
            this.Submit.Text = "Update Item";
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pb_itemImage
            // 
            this.pb_itemImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_itemImage.Image = global::Z_Mart.Properties.Resources.AddPhoto_Icon_white;
            this.pb_itemImage.Location = new System.Drawing.Point(441, 357);
            this.pb_itemImage.Name = "pb_itemImage";
            this.pb_itemImage.Size = new System.Drawing.Size(130, 124);
            this.pb_itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_itemImage.TabIndex = 36;
            this.pb_itemImage.TabStop = false;
            this.pb_itemImage.Visible = false;
            this.pb_itemImage.Click += new System.EventHandler(this.pb_itemImage_Click);
            // 
            // ItemImage
            // 
            this.ItemImage.AutoSize = true;
            this.ItemImage.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemImage.ForeColor = System.Drawing.Color.White;
            this.ItemImage.Location = new System.Drawing.Point(74, 370);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(286, 39);
            this.ItemImage.TabIndex = 35;
            this.ItemImage.Text = "Enter New Image :";
            this.ItemImage.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(440, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 5);
            this.panel4.TabIndex = 34;
            this.panel4.Visible = false;
            // 
            // tb_itemQuantity
            // 
            this.tb_itemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_itemQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_itemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_itemQuantity.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemQuantity.ForeColor = System.Drawing.Color.White;
            this.tb_itemQuantity.Location = new System.Drawing.Point(441, 288);
            this.tb_itemQuantity.Name = "tb_itemQuantity";
            this.tb_itemQuantity.ShortcutsEnabled = false;
            this.tb_itemQuantity.Size = new System.Drawing.Size(370, 30);
            this.tb_itemQuantity.TabIndex = 33;
            this.tb_itemQuantity.Text = "   Enter Quantity";
            this.tb_itemQuantity.Visible = false;
            this.tb_itemQuantity.TextChanged += new System.EventHandler(this.tb_itemQuantity_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(434, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 5);
            this.panel2.TabIndex = 32;
            this.panel2.Visible = false;
            // 
            // tb_ItemPrice
            // 
            this.tb_ItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_ItemPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ItemPrice.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemPrice.ForeColor = System.Drawing.Color.White;
            this.tb_ItemPrice.Location = new System.Drawing.Point(433, 204);
            this.tb_ItemPrice.Name = "tb_ItemPrice";
            this.tb_ItemPrice.ShortcutsEnabled = false;
            this.tb_ItemPrice.Size = new System.Drawing.Size(372, 30);
            this.tb_ItemPrice.TabIndex = 31;
            this.tb_ItemPrice.Text = "   Enter Item Price";
            this.tb_ItemPrice.Visible = false;
            this.tb_ItemPrice.TextChanged += new System.EventHandler(this.tb_ItemPrice_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(439, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 5);
            this.panel5.TabIndex = 30;
            this.panel5.Visible = false;
            // 
            // tb_enter_ItemName_2
            // 
            this.tb_enter_ItemName_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.tb_enter_ItemName_2.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_enter_ItemName_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_enter_ItemName_2.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_enter_ItemName_2.ForeColor = System.Drawing.Color.White;
            this.tb_enter_ItemName_2.Location = new System.Drawing.Point(440, 131);
            this.tb_enter_ItemName_2.Name = "tb_enter_ItemName_2";
            this.tb_enter_ItemName_2.Size = new System.Drawing.Size(366, 30);
            this.tb_enter_ItemName_2.TabIndex = 29;
            this.tb_enter_ItemName_2.TabStop = false;
            this.tb_enter_ItemName_2.Text = "   Enter Item Name";
            this.tb_enter_ItemName_2.Visible = false;
            this.tb_enter_ItemName_2.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // itemQuantity
            // 
            this.itemQuantity.AutoSize = true;
            this.itemQuantity.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantity.ForeColor = System.Drawing.Color.White;
            this.itemQuantity.Location = new System.Drawing.Point(79, 281);
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(325, 39);
            this.itemQuantity.TabIndex = 28;
            this.itemQuantity.Text = "Enter New Quantity :";
            this.itemQuantity.Visible = false;
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.White;
            this.itemPrice.Location = new System.Drawing.Point(79, 197);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(271, 39);
            this.itemPrice.TabIndex = 27;
            this.itemPrice.Text = "Enter New Price :";
            this.itemPrice.Visible = false;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.White;
            this.itemName.Location = new System.Drawing.Point(79, 124);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(284, 39);
            this.itemName.TabIndex = 26;
            this.itemName.Text = "Enter Item Name :";
            this.itemName.Visible = false;
            this.itemName.Click += new System.EventHandler(this.itemName_Click);
            // 
            // UC_UpdateItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.P_update1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_UpdateItem";
            this.Size = new System.Drawing.Size(909, 656);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.P_update1.ResumeLayout(false);
            this.P_update1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_itemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.Label L_ViewItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_username;
        private Bunifu.Framework.BunifuCustomTextbox tb_ItemName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label L_InvalidItemName;
        private System.Windows.Forms.Panel P_update1;
        private System.Windows.Forms.Label L_InvalidItemPrice;
        private System.Windows.Forms.Label l_name;
        private Guna.UI2.WinForms.Guna2Button Submit;
        private System.Windows.Forms.PictureBox pb_itemImage;
        private System.Windows.Forms.Label ItemImage;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.BunifuCustomTextbox tb_ItemPrice;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.BunifuCustomTextbox tb_enter_ItemName_2;
        private System.Windows.Forms.Label itemQuantity;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label itemName;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdateImage;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdateQuantity;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdatePrice;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdateName;
        private System.Windows.Forms.Label l_Message;
        private System.Windows.Forms.Label L_InvalidItemQuantity;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.BunifuCustomTextbox tb_itemQuantity;
    }
}
