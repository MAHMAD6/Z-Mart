namespace Z_Mart
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.MakeLoadingElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoadingPageTransiton_Fade = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingLineElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loadingbar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadingPercentage = new System.Windows.Forms.Label();
            this.Elipse_firstPaneLoading = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_SecondPanelLoading = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeLoadingElipse
            // 
            this.MakeLoadingElipse.ElipseRadius = 20;
            this.MakeLoadingElipse.TargetControl = this;
            // 
            // LoadingPageTransiton_Fade
            // 
            this.LoadingPageTransiton_Fade.Delay = 1;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // LoadingLineElipse
            // 
            this.LoadingLineElipse.ElipseRadius = 7;
            this.LoadingLineElipse.TargetControl = this.loadingbar;
            // 
            // loadingbar
            // 
            this.loadingbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadingbar.BackgroundImage")));
            this.loadingbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadingbar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(124)))), ((int)(((byte)(6)))));
            this.loadingbar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.loadingbar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(124)))), ((int)(((byte)(6)))));
            this.loadingbar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.loadingbar.Location = new System.Drawing.Point(406, 374);
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.Quality = 10;
            this.loadingbar.Size = new System.Drawing.Size(255, 10);
            this.loadingbar.TabIndex = 1;
            this.loadingbar.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Z_Mart.Properties.Resources.Loading_Page1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.LoadingPercentage);
            this.panel2.Controls.Add(this.loadingbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 442);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            // 
            // LoadingPercentage
            // 
            this.LoadingPercentage.AutoSize = true;
            this.LoadingPercentage.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPercentage.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingPercentage.ForeColor = System.Drawing.Color.Gold;
            this.LoadingPercentage.Location = new System.Drawing.Point(514, 333);
            this.LoadingPercentage.Name = "LoadingPercentage";
            this.LoadingPercentage.Size = new System.Drawing.Size(0, 23);
            this.LoadingPercentage.TabIndex = 2;
            this.LoadingPercentage.UseWaitCursor = true;
            // 
            // Elipse_firstPaneLoading
            // 
            this.Elipse_firstPaneLoading.ElipseRadius = 20;
            this.Elipse_firstPaneLoading.TargetControl = this.panel1;
            // 
            // Elipse_SecondPanelLoading
            // 
            this.Elipse_SecondPanelLoading.ElipseRadius = 20;
            this.Elipse_SecondPanelLoading.TargetControl = this.panel2;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(2)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z Mart";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse MakeLoadingElipse;
        private Bunifu.Framework.UI.BunifuFormFadeTransition LoadingPageTransiton_Fade;
        private System.Windows.Forms.Timer LoadingTimer;
        private Bunifu.Framework.UI.BunifuElipse LoadingLineElipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse Elipse_firstPaneLoading;
        private Bunifu.Framework.UI.BunifuElipse Elipse_SecondPanelLoading;
        private Bunifu.Framework.UI.BunifuGradientPanel loadingbar;
        private System.Windows.Forms.Label LoadingPercentage;
    }
}

