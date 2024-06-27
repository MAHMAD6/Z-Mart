namespace Z_Mart.UC
{
    partial class UC_Item
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
            this.L_itemName = new System.Windows.Forms.Label();
            this.itemRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.L_itemPrice = new System.Windows.Forms.Label();
            this.L_Item_quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.P_dark = new System.Windows.Forms.Panel();
            this.b_removeFromCart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_addToCart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_Item = new System.Windows.Forms.PictureBox();
            this.P_dark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // L_itemName
            // 
            this.L_itemName.AutoSize = true;
            this.L_itemName.BackColor = System.Drawing.Color.Gainsboro;
            this.L_itemName.Font = new System.Drawing.Font("Nexa Heavy", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_itemName.Location = new System.Drawing.Point(15, 254);
            this.L_itemName.Name = "L_itemName";
            this.L_itemName.Size = new System.Drawing.Size(174, 38);
            this.L_itemName.TabIndex = 0;
            this.L_itemName.Text = "Item Name";
            // 
            // itemRating
            // 
            this.itemRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.itemRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(130)))));
            this.itemRating.Location = new System.Drawing.Point(17, 321);
            this.itemRating.Name = "itemRating";
            this.itemRating.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(15)))));
            this.itemRating.Size = new System.Drawing.Size(207, 40);
            this.itemRating.TabIndex = 2;
            this.itemRating.Value = 4F;
            // 
            // L_itemPrice
            // 
            this.L_itemPrice.AutoSize = true;
            this.L_itemPrice.Font = new System.Drawing.Font("Nexa Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_itemPrice.Location = new System.Drawing.Point(225, 282);
            this.L_itemPrice.Name = "L_itemPrice";
            this.L_itemPrice.Size = new System.Drawing.Size(142, 52);
            this.L_itemPrice.TabIndex = 3;
            this.L_itemPrice.Text = "$9.99";
            // 
            // L_Item_quantity
            // 
            this.L_Item_quantity.AutoSize = true;
            this.L_Item_quantity.Font = new System.Drawing.Font("Nexa Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Item_quantity.Location = new System.Drawing.Point(17, 289);
            this.L_Item_quantity.Name = "L_Item_quantity";
            this.L_Item_quantity.Size = new System.Drawing.Size(138, 29);
            this.L_Item_quantity.TabIndex = 5;
            this.L_Item_quantity.Text = "200pcs left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Nexa Heavy", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 343);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "10% Sale";
            this.label4.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.label4;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // P_dark
            // 
            this.P_dark.BackColor = System.Drawing.Color.Black;
            this.P_dark.Controls.Add(this.b_removeFromCart);
            this.P_dark.Controls.Add(this.b_addToCart);
            this.P_dark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_dark.Location = new System.Drawing.Point(0, 0);
            this.P_dark.Name = "P_dark";
            this.P_dark.Size = new System.Drawing.Size(380, 380);
            this.P_dark.TabIndex = 7;
            this.P_dark.Visible = false;
            // 
            // b_removeFromCart
            // 
            this.b_removeFromCart.Active = false;
            this.b_removeFromCart.Activecolor = System.Drawing.Color.Red;
            this.b_removeFromCart.BackColor = System.Drawing.Color.Firebrick;
            this.b_removeFromCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_removeFromCart.BorderRadius = 0;
            this.b_removeFromCart.ButtonText = "Remove from Cart";
            this.b_removeFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_removeFromCart.DisabledColor = System.Drawing.Color.Gray;
            this.b_removeFromCart.Iconcolor = System.Drawing.Color.Transparent;
            this.b_removeFromCart.Iconimage = global::Z_Mart.Properties.Resources.Delete_Icon_Big;
            this.b_removeFromCart.Iconimage_right = null;
            this.b_removeFromCart.Iconimage_right_Selected = null;
            this.b_removeFromCart.Iconimage_Selected = null;
            this.b_removeFromCart.IconMarginLeft = 0;
            this.b_removeFromCart.IconMarginRight = 0;
            this.b_removeFromCart.IconRightVisible = true;
            this.b_removeFromCart.IconRightZoom = 0D;
            this.b_removeFromCart.IconVisible = true;
            this.b_removeFromCart.IconZoom = 50D;
            this.b_removeFromCart.IsTab = false;
            this.b_removeFromCart.Location = new System.Drawing.Point(30, 162);
            this.b_removeFromCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_removeFromCart.Name = "b_removeFromCart";
            this.b_removeFromCart.Normalcolor = System.Drawing.Color.Firebrick;
            this.b_removeFromCart.OnHovercolor = System.Drawing.Color.Red;
            this.b_removeFromCart.OnHoverTextColor = System.Drawing.Color.White;
            this.b_removeFromCart.selected = false;
            this.b_removeFromCart.Size = new System.Drawing.Size(306, 59);
            this.b_removeFromCart.TabIndex = 1;
            this.b_removeFromCart.Text = "Remove from Cart";
            this.b_removeFromCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_removeFromCart.Textcolor = System.Drawing.Color.White;
            this.b_removeFromCart.TextFont = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_removeFromCart.Visible = false;
            this.b_removeFromCart.Click += new System.EventHandler(this.b_removeFromCart_Click);
            // 
            // b_addToCart
            // 
            this.b_addToCart.Active = false;
            this.b_addToCart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.b_addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.b_addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_addToCart.BorderRadius = 0;
            this.b_addToCart.ButtonText = "Add to cart";
            this.b_addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_addToCart.DisabledColor = System.Drawing.Color.Gray;
            this.b_addToCart.Iconcolor = System.Drawing.Color.Transparent;
            this.b_addToCart.Iconimage = global::Z_Mart.Properties.Resources.cart_Icon;
            this.b_addToCart.Iconimage_right = null;
            this.b_addToCart.Iconimage_right_Selected = null;
            this.b_addToCart.Iconimage_Selected = null;
            this.b_addToCart.IconMarginLeft = 0;
            this.b_addToCart.IconMarginRight = 0;
            this.b_addToCart.IconRightVisible = true;
            this.b_addToCart.IconRightZoom = 0D;
            this.b_addToCart.IconVisible = true;
            this.b_addToCart.IconZoom = 50D;
            this.b_addToCart.IsTab = false;
            this.b_addToCart.Location = new System.Drawing.Point(64, 162);
            this.b_addToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_addToCart.Name = "b_addToCart";
            this.b_addToCart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.b_addToCart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(55)))));
            this.b_addToCart.OnHoverTextColor = System.Drawing.Color.White;
            this.b_addToCart.selected = false;
            this.b_addToCart.Size = new System.Drawing.Size(233, 59);
            this.b_addToCart.TabIndex = 0;
            this.b_addToCart.Text = "Add to cart";
            this.b_addToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_addToCart.Textcolor = System.Drawing.Color.White;
            this.b_addToCart.TextFont = new System.Drawing.Font("Nexa Heavy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addToCart.Visible = false;
            this.b_addToCart.Click += new System.EventHandler(this.b_addToCart_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Z_Mart.Properties.Resources.trolley_icon;
            this.pictureBox2.Location = new System.Drawing.Point(312, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pb_Item
            // 
            this.pb_Item.Image = global::Z_Mart.Properties.Resources.Package_2d_Icon;
            this.pb_Item.Location = new System.Drawing.Point(76, 34);
            this.pb_Item.Name = "pb_Item";
            this.pb_Item.Size = new System.Drawing.Size(200, 200);
            this.pb_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Item.TabIndex = 1;
            this.pb_Item.TabStop = false;
            // 
            // UC_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.P_dark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_Item_quantity);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.L_itemPrice);
            this.Controls.Add(this.itemRating);
            this.Controls.Add(this.pb_Item);
            this.Controls.Add(this.L_itemName);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(380, 380);
            this.Load += new System.EventHandler(this.UC_Item_Load);
            this.P_dark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_itemName;
        private System.Windows.Forms.PictureBox pb_Item;
        private Guna.UI2.WinForms.Guna2RatingStar itemRating;
        private System.Windows.Forms.Label L_itemPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label L_Item_quantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel P_dark;
        private Bunifu.Framework.UI.BunifuFlatButton b_addToCart;
        private Bunifu.Framework.UI.BunifuFlatButton b_removeFromCart;
    }
}
