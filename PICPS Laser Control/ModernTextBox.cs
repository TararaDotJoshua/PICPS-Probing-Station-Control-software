using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GPIBReaderWinForms
{
    public class ModernTextBox : TextBox
    {
        private Color _borderColor = Color.FromArgb(200, 200, 200);
        private Color _focusedBorderColor = Color.FromArgb(0, 123, 255);
        private int _borderRadius = 6;
        private bool _isFocused = false;

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public Color FocusedBorderColor
        {
            get => _focusedBorderColor;
            set { _focusedBorderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public ModernTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.ResizeRedraw, true);
            
            BorderStyle = BorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            BackColor = Color.White;
            ForeColor = Color.FromArgb(64, 64, 64);
            Padding = new Padding(8, 8, 8, 8);
        }

        protected override void OnEnter(EventArgs e)
        {
            _isFocused = true;
            Invalidate();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            _isFocused = false;
            Invalidate();
            base.OnLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color currentBorderColor = _isFocused ? _focusedBorderColor : _borderColor;

            using (GraphicsPath path = GetRoundedRectangle(rect, _borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, path);
                }

                using (Pen pen = new Pen(currentBorderColor, _isFocused ? 2 : 1))
                {
                    g.DrawPath(pen, path);
                }
            }

            // Draw text manually
            Rectangle textRect = new Rectangle(8, (Height - Font.Height) / 2, Width - 16, Font.Height);
            TextRenderer.DrawText(g, Text, Font, textRect, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
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