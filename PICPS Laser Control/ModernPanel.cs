using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GPIBReaderWinForms
{
    public class ModernPanel : Panel
    {
        private System.Drawing.Color _backgroundColor = System.Drawing.Color.White;
        private System.Drawing.Color _borderColor = System.Drawing.Color.FromArgb(230, 230, 230);
        private int _borderRadius = 12;
        private int _borderWidth = 1;
        private bool _hasShadow = true;

        public System.Drawing.Color BackgroundColor
        {
            get => _backgroundColor;
            set { _backgroundColor = value; Invalidate(); }
        }

        public System.Drawing.Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public bool HasShadow
        {
            get => _hasShadow;
            set { _hasShadow = value; Invalidate(); }
        }

        public ModernPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor, true);
            
            BackColor = System.Drawing.Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            System.Drawing.Rectangle rect = ClientRectangle;
            
            if (_hasShadow)
            {
                // Draw shadow
                System.Drawing.Rectangle shadowRect = new System.Drawing.Rectangle(rect.X + 2, rect.Y + 2, rect.Width, rect.Height);
                using (GraphicsPath shadowPath = GetRoundedRectangle(shadowRect, _borderRadius))
                {
                    using (SolidBrush shadowBrush = new SolidBrush(System.Drawing.Color.FromArgb(20, 0, 0, 0)))
                    {
                        g.FillPath(shadowBrush, shadowPath);
                    }
                }
                rect = new System.Drawing.Rectangle(rect.X, rect.Y, rect.Width - 2, rect.Height - 2);
            }

            using (GraphicsPath path = GetRoundedRectangle(rect, _borderRadius))
            {
                // Fill background
                using (SolidBrush brush = new SolidBrush(_backgroundColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw border
                if (_borderWidth > 0)
                {
                    using (System.Drawing.Pen pen = new System.Drawing.Pen(_borderColor, _borderWidth))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(System.Drawing.Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            
            return path;
        }
    }
}