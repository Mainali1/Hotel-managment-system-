using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// A Panel clipped into a rounded-rectangle shape with a thin border.
    /// Use this instead of Panel for any content "card" (forms, grids, detail boxes).
    /// </summary>
    public class GlassCard : Panel
    {
        public int CornerRadius { get; set; } = Theme.CardRadius;
        public Color BorderColor { get; set; } = Theme.CardBorder;
        public bool ShowBorder { get; set; } = true;

        public GlassCard()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            BackColor = Theme.CardBackground;
            Padding = new Padding(18);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = UIHelpers.RoundedRect(bounds, CornerRadius))
            {
                Region = new Region(path);

                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (var fillBrush = new SolidBrush(BackColor))
                    g.FillPath(fillBrush, path);

                if (ShowBorder)
                {
                    using (var pen = new Pen(BorderColor, 1))
                        g.DrawPath(pen, path);
                }
            }
            base.OnPaint(e);
        }
    }
}