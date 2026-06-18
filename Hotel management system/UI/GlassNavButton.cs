using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// Left-aligned icon+label button for the dashboard sidebar. Distinct from
    /// GlassButton (which is a centered pill button for forms) because nav items
    /// need a different layout and an "active/selected" highlight state.
    /// </summary>
    public class GlassNavButton : Button
    {
        public string IconGlyph { get; set; } = "";
        public bool IsActive { get; set; }

        private bool _hovering;

        public GlassNavButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = Theme.FontSubheading();
            ForeColor = Theme.TextOnDarkMuted;
            Cursor = Cursors.Hand;
            TextAlign = ContentAlignment.MiddleLeft;
            Size = new Size(196, 44);

            MouseEnter += (s, e) => { _hovering = true; Invalidate(); };
            MouseLeave += (s, e) => { _hovering = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Theme.SidebarBackground);

            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            if (IsActive || _hovering)
            {
                Color fill = IsActive ? Theme.Accent : Theme.SidebarHighlight;
                using (var path = UIHelpers.RoundedRect(bounds, 10))
                using (var brush = new SolidBrush(fill))
                    g.FillPath(brush, path);
            }

            Color fg = IsActive ? Color.White : (_hovering ? Theme.TextOnDark : Theme.TextOnDarkMuted);

            using (var iconFont = Theme.FontIcon(15F))
            using (var iconBrush = new SolidBrush(fg))
            {
                g.DrawString(IconGlyph, iconFont, iconBrush, 16, (Height - 20) / 2f);
            }

            var textRect = new Rectangle(50, 0, Width - 56, Height);
            TextRenderer.DrawText(g, Text, Font, textRect, fg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix);
        }
    }
}