using System.Drawing;
using System.Linq;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// Single source of truth for colors, fonts and sizing.
    /// Change a value here and it updates everywhere the theme is used.
    /// </summary>
    public static class Theme
    {
        // ---- Backgrounds ----
        public static readonly Color AppBackground = Color.FromArgb(244, 246, 250);
        public static readonly Color SidebarBackground = Color.FromArgb(24, 26, 34);
        public static readonly Color SidebarHighlight = Color.FromArgb(38, 41, 53);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color CardBorder = Color.FromArgb(232, 234, 240);
        public static readonly Color InputBackground = Color.FromArgb(247, 248, 251);
        public static readonly Color InputBorder = Color.FromArgb(225, 227, 234);

        // ---- Text ----
        public static readonly Color TextPrimary = Color.FromArgb(26, 28, 36);
        public static readonly Color TextSecondary = Color.FromArgb(125, 129, 142);
        public static readonly Color TextOnDark = Color.White;
        public static readonly Color TextOnDarkMuted = Color.FromArgb(162, 166, 180);

        // ---- Accent / status ----
        public static readonly Color Accent = Color.FromArgb(77, 124, 254);
        public static readonly Color AccentHover = Color.FromArgb(58, 104, 235);
        public static readonly Color Success = Color.FromArgb(46, 184, 122);
        public static readonly Color SuccessHover = Color.FromArgb(36, 162, 106);
        public static readonly Color Danger = Color.FromArgb(235, 87, 96);
        public static readonly Color DangerHover = Color.FromArgb(214, 68, 78);
        public static readonly Color Warning = Color.FromArgb(245, 166, 35);
        public static readonly Color Neutral = Color.FromArgb(241, 242, 246);
        public static readonly Color NeutralHover = Color.FromArgb(228, 230, 236);

        // ---- Sizing ----
        public const int CardRadius = 14;
        public const int ButtonRadius = 10;
        public const int InputRadius = 10;

        // ---- Fonts ----
        public static Font FontDisplay() => new Font("Segoe UI", 20F, FontStyle.Bold);
        public static Font FontHeading() => new Font("Segoe UI", 13F, FontStyle.Bold);
        public static Font FontSubheading() => new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
        public static Font FontBody() => new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static Font FontBodyBold() => new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static Font FontSmall() => new Font("Segoe UI", 8F, FontStyle.Regular);
        public static Font FontMono() => new Font("Consolas", 9.5F, FontStyle.Regular);

        // ---- Icon font (auto-falls back depending on Windows version) ----
        private static string _iconFontFamily;
        public static string IconFontFamily
        {
            get
            {
                if (_iconFontFamily != null) return _iconFontFamily;

                var installed = FontFamily.Families.Select(f => f.Name).ToArray();
                if (installed.Contains("Segoe Fluent Icons"))
                    _iconFontFamily = "Segoe Fluent Icons";
                else if (installed.Contains("Segoe MDL2 Assets"))
                    _iconFontFamily = "Segoe MDL2 Assets";
                else
                    _iconFontFamily = "Segoe UI Symbol";

                return _iconFontFamily;
            }
        }

        public static Font FontIcon(float size) => new Font(IconFontFamily, size, FontStyle.Regular);
    }
}