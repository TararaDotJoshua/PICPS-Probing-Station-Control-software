using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GPIBReaderWinForms
{
    public class ModernButton : Button
    {
        private System.Drawing.Color _baseColor = System.Drawing.Color.FromArgb(0, 123, 255);
        private System.Drawing.Color _hoverColor = System.Drawing.Color.FromArgb(0, 86, 179);
        private System.Drawing.Color _pressedColor = System.Drawing.Color.FromArgb(0, 69, 134);
        private bool _isHovered = false;
        private bool _isPressed = false;
        private int _borderRadius = 8;

        public System.Drawing.Color BaseColor
        {
            get => _baseColor;
            set { _baseColor = value; Invalidate(); }
        }

        public System.Drawing.Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public ModernButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor, true);
            
            BackColor = System.Drawing.Color.Transparent;
            ForeColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new System.Drawing.Size(120, 40);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovered = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _isPressed = true;
            Invalidate();
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _isPressed = false;
            Invalidate();
            base.OnMouseUp(mevent);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            System.Drawing.Color currentColor = _baseColor;
            if (_isPressed) currentColor = _pressedColor;
            else if (_isHovered) currentColor = _hoverColor;

            using (GraphicsPath path = GetRoundedRectangle(ClientRectangle, _borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(currentColor))
                {
                    g.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor, 
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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