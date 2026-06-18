using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// Flat, rounded-corner button with an optional leading icon glyph.
    /// Drop-in replacement for System.Windows.Forms.Button.
    ///
    /// NOTE: the rounded corners are faked by painting the parent's BackColor
    /// behind the pill shape, so this control looks correct on a solid-colored
    /// parent (a Panel/GlassCard) but will show square corners if placed on a
    /// parent with an image or gradient background. That's a hard WinForms
    /// limitation, not a bug.
    /// </summary>
    public class GlassButton : Button
    {
        public int CornerRadius { get; set; } = Theme.ButtonRadius;
        public string IconGlyph { get; set; } = "";
        public Color BaseColor { get; set; } = Theme.Accent;
        public Color HoverColor { get; set; } = Theme.AccentHover;
        public Color TextColor { get; set; } = Color.White;

        private bool _hovering;
        private bool _pressed;

        public GlassButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            ForeColor = TextColor;
            Font = Theme.FontSubheading();
            Cursor = Cursors.Hand;
            Size = new Size(160, 42);

            MouseEnter += (s, e) => { _hovering = true; Invalidate(); };
            MouseLeave += (s, e) => { _hovering = false; _pressed = false; Invalidate(); };
            MouseDown += (s, e) => { _pressed = true; Invalidate(); };
            MouseUp += (s, e) => { _pressed = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : Theme.CardBackground);

            Color fill = _pressed ? HoverColor : (_hovering ? HoverColor : BaseColor);
            if (!Enabled) fill = Theme.Neutral;

            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = UIHelpers.RoundedRect(bounds, CornerRadius))
            using (var brush = new SolidBrush(fill))
            {
                g.FillPath(brush, path);
            }

            bool hasIcon = !string.IsNullOrEmpty(IconGlyph);
            int leftPad = hasIcon ? 38 : 0;
            var textRect = new Rectangle(leftPad, 0, Width - leftPad, Height);
            Color fg = Enabled ? TextColor : Theme.TextSecondary;

            if (hasIcon)
            {
                using (var iconFont = Theme.FontIcon(13F))
                using (var iconBrush = new SolidBrush(fg))
                {
                    var iconSize = g.MeasureString(IconGlyph, iconFont);
                    float iconX = 14;
                    float iconY = (Height - iconSize.Height) / 2f;
                    g.DrawString(IconGlyph, iconFont, iconBrush, iconX, iconY);
                }
            }

            TextRenderer.DrawText(g, Text, Font, textRect, fg,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix);
        }
    }
}