using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z_Mart.Forms
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            this.Opacity = 0;
            StartPosition = FormStartPosition.Manual;
            // This will move form in bottom-right corner
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = Width;
            int formHeight = Height;
            int formX = screenWidth - formWidth - 4;
            int formY = screenHeight - formHeight - 4;
            Location = new Point(formX, formY);
            this.TopMost = true;
        }

        private void InAnimation_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.15;
        }

        private void MessageLineTimer_Tick(object sender, EventArgs e)
        {
            if (MessageLoadingLine.Width > 0)
                MessageLoadingLine.Width -= 10;
            else
                this.Close();
        }
        public void changeMessageDesign(Image image, string text, string subText, Color TextColor, Color loadingColor)
        {
            PB_MessageIcon.Image = image;
            MessageMain.Text = text;
            L_SubText.Text = subText;

        }
    }
}
