using System;
using System.Runtime.InteropServices;

namespace Hotel_management_system.Helpers
{
    public static class DwmApi
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_WINDOW_CORNER_PREFERENCE = 33,
            DWMWA_SYSTEMBACKDROP_TYPE = 38
        }

        public enum DWM_SYSTEMBACKDROP_TYPE
        {
            DWMSBT_NONE = 1,
            DWMSBT_MAINWINDOW = 2,      // Mica
            DWMSBT_TRANSIENTWINDOW = 3, // Acrylic
            DWMSBT_TABBEDWINDOW = 4     // Tabbed / Mica Alt
        }

        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }
    }
}