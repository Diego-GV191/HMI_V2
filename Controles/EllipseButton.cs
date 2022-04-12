using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMI_V2.Controles
{
    public class EllipseButton : Button
    {
        // Fields
        private int BorderSize = 0;
        private int BorderRadius = 30;
        private Color BorderColor = Color.PaleVioletRed;

        // Properties
        [Category("EllipseButtons")]
        public int BorderSize1
        {
            get { return BorderSize; }
            set
            {
                BorderSize = value;
                this.Invalidate();
            }
        }

        [Category("EllipseButtons")]
        public int BorderRadius1
        {
            get { return BorderRadius; }
            set
            {
                BorderRadius = value;
                this.Invalidate();
            }
        }

        [Category("EllipseButtons")]
        public Color BorderColor1
        {
            get { return BorderColor; }
            set
            {
                BorderColor = value;
                this.Invalidate();
            }
        }

        [Category("EllipseButtons")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("EllipseButtons")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Constructor
        public EllipseButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (BorderRadius > this.Height) BorderRadius = this.Height;
        }

        // Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF RectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF RectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if(BorderRadius > 2) // Rounded Button
            {
                using (GraphicsPath PathSurface = GetFigurePath(RectSurface, BorderRadius))
                using (GraphicsPath PathBorder = GetFigurePath(RectBorder, BorderRadius - 1))
                using (Pen PenSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen PenBorder = new Pen(BorderColor, BorderSize))
                {
                    PenBorder.Alignment = PenAlignment.Inset;
                    // Button Surface
                    this.Region = new Region(PathSurface);
                    // Draw Surface Border for HD Result
                    pevent.Graphics.DrawPath(PenSurface, PathSurface);
                    // Button Border
                    if (BorderSize >= 1)
                    {
                        // Draw Control Border
                        pevent.Graphics.DrawPath(PenBorder, PathBorder);
                    }
                }
            }
            else // Normal Button
            {
                // Button Surface
                this.Region = new Region(RectSurface);
                // Button Border
                if (BorderSize >= 1)
                {
                    using(Pen PenBorder = new Pen(BorderColor, BorderSize))
                    {
                        PenBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(PenBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }
    }
}