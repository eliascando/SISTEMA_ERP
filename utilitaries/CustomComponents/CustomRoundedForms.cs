using System.ComponentModel;
using System.Runtime.InteropServices;

namespace utilitaries.CustomComponents
{
    public class CustomRoundedForms : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nWidthEllipse, int nHeightEllipse);

        private Control control;
        private int cornerRadius = 25;
        public Control TargetControl
        {
            get { return control;}
            set
            {
                control = value;
                control.SizeChanged += (sender, eventArgs) => control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerRadius, cornerRadius));
            }
        }
        public int CornerRedius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                if(control != null)
                    Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerRadius, cornerRadius));
            }
        }
    }
}