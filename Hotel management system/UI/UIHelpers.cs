using System.Drawing;
using System.Drawing.Drawing2D;

namespace Hotel_management_system.UI
{
    public static class UIHelpers
    {
        /// <summary>
        /// Builds a rounded-rectangle path. Used by GlassCard / GlassButton / GlassInput
        /// to clip controls into pill/rounded shapes instead of WinForms' default hard corners.
        /// </summary>
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();

            if (d > bounds.Width) d = bounds.Width;
            if (d > bounds.Height) d = bounds.Height;

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}