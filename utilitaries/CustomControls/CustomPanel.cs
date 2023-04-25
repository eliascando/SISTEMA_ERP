using System.Drawing.Drawing2D;

namespace utilitaries.CustomControls
{
    public class CustomPanel : Panel
    {
        //Fields
        private int borderRadius = 0;
        private float gradientAngle = 100;
        private Color gradientTopColor = Color.White;
        private Color gradientBottomColor = Color.White;
        private bool solidBorder = false;
        private Color borderColor = Color.Black;
        private int borderWidth = 5;

        //Constructor
        public CustomPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);
        }

        //Properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }
        public bool SolidBorder
        {
            get => solidBorder;
            set { solidBorder = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }
        public int BorderWidth
        {
            get => borderWidth;
            set { borderWidth = value; this.Invalidate(); }
        }

        //Methods
        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        //Overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);

            //SolidBorder
            if (solidBorder)
            {
                Rectangle shadowBounds = new Rectangle(0, 0, Width, Height);
                Color lineColor = borderColor;
                int lineWidth = borderWidth;
                ControlPaint.DrawBorder(
                    e.Graphics, shadowBounds,
                    lineColor, lineWidth, ButtonBorderStyle.Solid,
                    lineColor, lineWidth, ButtonBorderStyle.Solid,
                    lineColor, lineWidth, ButtonBorderStyle.Solid,
                    lineColor, lineWidth, ButtonBorderStyle.Solid);
            }
        }
    }
}