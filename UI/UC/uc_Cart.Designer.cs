namespace Z_Mart.UC
{
    partial class uc_Cart
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
            this.L_Cart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_DownPanel = new System.Windows.Forms.Panel();
            this.lTotalbill_ = new System.Windows.Forms.Label();
            this.lTotalNumber_ = new System.Windows.Forms.Label();
            this.lTotalBill = new System.Windows.Forms.Label();
            this.L_noOfItems = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.P_DownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Cart
            // 
            this.L_Cart.AutoSize = true;
            this.L_Cart.Font = new System.Drawing.Font("Nexa Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cart.ForeColor = System.Drawing.Color.White;
            this.L_Cart.Location = new System.Drawing.Point(420, 30);
            this.L_Cart.Name = "L_Cart";
            this.L_Cart.Size = new System.Drawing.Size(84, 39);
            this.L_Cart.TabIndex = 6;
            this.L_Cart.Text = "Cart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.L_Cart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Z_Mart.Properties.Resources.cart_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(292, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // P_DownPanel
            // 
            this.P_DownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.P_DownPanel.Controls.Add(this.lTotalbill_);
            this.P_DownPanel.Controls.Add(this.lTotalNumber_);
            this.P_DownPanel.Controls.Add(this.lTotalBill);
            this.P_DownPanel.Controls.Add(this.L_noOfItems);
            this.P_DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_DownPanel.ForeColor = System.Drawing.Color.White;
            this.P_DownPanel.Location = new System.Drawing.Point(10, 546);
            this.P_DownPanel.Name = "P_DownPanel";
            this.P_DownPanel.Size = new System.Drawing.Size(889, 100);
            this.P_DownPanel.TabIndex = 10;
            // 
            // lTotalbill_
            // 
            this.lTotalbill_.AutoSize = true;
            this.lTotalbill_.Font = new System.Drawing.Font("Nexa Heavy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalbill_.ForeColor = System.Drawing.Color.White;
            this.lTotalbill_.Location = new System.Drawing.Point(637, 37);
            this.lTotalbill_.Name = "lTotalbill_";
            this.lTotalbill_.Size = new System.Drawing.Size(32, 32);
            this.lTotalbill_.TabIndex = 8;
            this.lTotalbill_.Text = "0";
            this.lTotalbill_.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lTotalNumber_
            // 
            this.lTotalNumber_.AutoSize = true;
            this.lTotalNumber_.Font = new System.Drawing.Font("Nexa Heavy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalNumber_.ForeColor = System.Drawing.Color.White;
            this.lTotalNumber_.Location = new System.Drawing.Point(329, 37);
            this.lTotalNumber_.Name = "lTotalNumber_";
            this.lTotalNumber_.Size = new System.Drawing.Size(32, 32);
            this.lTotalNumber_.TabIndex = 7;
            this.lTotalNumber_.Text = "0";
            this.lTotalNumber_.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lTotalBill
            // 
            this.lTotalBill.AutoSize = true;
            this.lTotalBill.Font = new System.Drawing.Font("Nexa Heavy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalBill.ForeColor = System.Drawing.Color.Firebrick;
            this.lTotalBill.Location = new System.Drawing.Point(443, 29);
            this.lTotalBill.Name = "lTotalBill";
            this.lTotalBill.Size = new System.Drawing.Size(188, 44);
            this.lTotalBill.TabIndex = 6;
            this.lTotalBill.Text = "Total Bill : ";
            this.lTotalBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // L_noOfItems
            // 
            this.L_noOfItems.AutoSize = true;
            this.L_noOfItems.Font = new System.Drawing.Font("Nexa Heavy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_noOfItems.ForeColor = System.Drawing.Color.White;
            this.L_noOfItems.Location = new System.Drawing.Point(19, 34);
            this.L_noOfItems.Name = "L_noOfItems";
            this.L_noOfItems.Size = new System.Drawing.Size(308, 32);
            this.L_noOfItems.TabIndex = 5;
            this.L_noOfItems.Text = "Total Number Of Items :";
            this.L_noOfItems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(889, 436);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // uc_Cart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.P_DownPanel);
            this.Controls.Add(this.panel1);
            this.Name = "uc_Cart";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(909, 656);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.P_DownPanel.ResumeLayout(false);
            this.P_DownPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label L_Cart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel P_DownPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lTotalbill_;
        private System.Windows.Forms.Label lTotalNumber_;
        private System.Windows.Forms.Label lTotalBill;
        private System.Windows.Forms.Label L_noOfItems;
    }
}
