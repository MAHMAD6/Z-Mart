using System.Drawing;

namespace Z_Mart.DL
{
    internal class Colores
    {
        public static Color BG { get; private set; }
        public static Color BG_OutLine { get; private set; }

        public static Color Green { get; private set; }
        public static Color DarkGreen { get; private set; }
        public static Color Red { get; private set; }
        public static Color DarkRed { get; private set; }
        static Colores()
        {

            BG = Color.FromArgb(14, 28, 64);
            BG_OutLine = Color.FromArgb(255, 159, 2);

            DarkGreen = Color.FromArgb(36, 234, 60);
            Green = Color.FromArgb(36, 87, 8);

            DarkRed = Color.FromArgb(177, 21, 0);
            Red = Color.Firebrick;
        }
    }
}
