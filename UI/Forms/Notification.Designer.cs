namespace Z_Mart.Forms
{
    partial class Notification
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
            this.MessageLineTimer = new System.Windows.Forms.Timer(this.components);
            this.InAnimation = new System.Windows.Forms.Timer(this.components);
            this.border = new System.Windows.Forms.Panel();
            this.P_Message_1 = new System.Windows.Forms.Panel();
            this.L_SubText = new System.Windows.Forms.Label();
            this.MessageMain = new System.Windows.Forms.Label();
            this.MessageLoadingLine = new System.Windows.Forms.Panel();
            this.PB_MessageIcon = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.border.SuspendLayout();
            this.P_Message_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLineTimer
            // 
            this.MessageLineTimer.Enabled = true;
            this.MessageLineTimer.Tick += new System.EventHandler(this.MessageLineTimer_Tick);
            // 
            // InAnimation
            // 
            this.InAnimation.Enabled = true;
            this.InAnimation.Tick += new System.EventHandler(this.InAnimation_Tick);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.Controls.Add(this.P_Message_1);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Margin = new System.Windows.Forms.Padding(0);
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(2);
            this.border.Size = new System.Drawing.Size(450, 80);
            this.border.TabIndex = 1;
            // 
            // P_Message_1
            // 
            this.P_Message_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.P_Message_1.Controls.Add(this.L_SubText);
            this.P_Message_1.Controls.Add(this.MessageMain);
            this.P_Message_1.Controls.Add(this.MessageLoadingLine);
            this.P_Message_1.Controls.Add(this.PB_MessageIcon);
            this.P_Message_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Message_1.Location = new System.Drawing.Point(2, 2);
            this.P_Message_1.Margin = new System.Windows.Forms.Padding(0);
            this.P_Message_1.Name = "P_Message_1";
            this.P_Message_1.Size = new System.Drawing.Size(446, 76);
            this.P_Message_1.TabIndex = 6;
            // 
            // L_SubText
            // 
            this.L_SubText.AutoSize = true;
            this.L_SubText.Font = new System.Drawing.Font("Poppins Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SubText.ForeColor = System.Drawing.Color.White;
            this.L_SubText.Location = new System.Drawing.Point(132, 37);
            this.L_SubText.Name = "L_SubText";
            this.L_SubText.Size = new System.Drawing.Size(173, 25);
            this.L_SubText.TabIndex = 5;
            this.L_SubText.Text = "File Added Successfully";
            // 
            // MessageMain
            // 
            this.MessageMain.AutoSize = true;
            this.MessageMain.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageMain.ForeColor = System.Drawing.Color.White;
            this.MessageMain.Location = new System.Drawing.Point(128, 5);
            this.MessageMain.Name = "MessageMain";
            this.MessageMain.Size = new System.Drawing.Size(141, 50);
            this.MessageMain.TabIndex = 1;
            this.MessageMain.Text = "Success";
            // 
            // MessageLoadingLine
            // 
            this.MessageLoadingLine.BackColor = System.Drawing.Color.White;
            this.MessageLoadingLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(94)))));
            this.MessageLoadingLine.Location = new System.Drawing.Point(0, 67);
            this.MessageLoadingLine.Margin = new System.Windows.Forms.Padding(0);
            this.MessageLoadingLine.Name = "MessageLoadingLine";
            this.MessageLoadingLine.Size = new System.Drawing.Size(450, 10);
            this.MessageLoadingLine.TabIndex = 4;
            // 
            // PB_MessageIcon
            // 
            this.PB_MessageIcon.Image = global::Z_Mart.Properties.Resources.close_icon_White;
            this.PB_MessageIcon.Location = new System.Drawing.Point(40, 2);
            this.PB_MessageIcon.Name = "PB_MessageIcon";
            this.PB_MessageIcon.Size = new System.Drawing.Size(55, 62);
            this.PB_MessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MessageIcon.TabIndex = 0;
            this.PB_MessageIcon.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.P_Message_1;
            // 
            // Notification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 80);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(-1, -1);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.border.ResumeLayout(false);
            this.P_Message_1.ResumeLayout(false);
            this.P_Message_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MessageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MessageLineTimer;
        private System.Windows.Forms.Timer InAnimation;
        private System.Windows.Forms.Panel border;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel P_Message_1;
        private System.Windows.Forms.Label L_SubText;
        private System.Windows.Forms.Panel MessageLoadingLine;
        private System.Windows.Forms.Label MessageMain;
        private System.Windows.Forms.PictureBox PB_MessageIcon;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}