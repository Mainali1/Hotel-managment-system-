using System;
using System.Windows.Forms;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// Every Form in the app should inherit from this instead of System.Windows.Forms.Form.
    /// It wires up the Windows 11 Mica backdrop, rounded window corners and a dark title bar
    /// in one place instead of duplicating the DWM calls in every form's OnLoad.
    ///
    /// Reality check: this only affects the WINDOW chrome (title bar + outer corners + a subtle
    /// backdrop tint at the very edges). It does NOT blur the content inside panels/grids —
    /// WinForms has no compositor support for that, and faking it with screenshot tricks looks
    /// worse than not having it. The actual "premium" look comes from the flat rounded-card
    /// design (GlassCard/GlassButton) layered on top of this, not from the Mica call alone.
    /// On Windows 10 these calls simply fail silently and the form looks like a normal window —
    /// no crash, no visual regression.
    /// </summary>
    public class GlassFormBase : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyWindowsGlassEffects();
        }

        private void ApplyWindowsGlassEffects()
        {
            try
            {
                int backdrop = (int)DwmApi.DWM_SYSTEMBACKDROP_TYPE.DWMSBT_MAINWINDOW;
                DwmApi.DwmSetWindowAttribute(Handle, (int)DwmApi.DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, ref backdrop, sizeof(int));

                int darkMode = 1;
                DwmApi.DwmSetWindowAttribute(Handle, (int)DwmApi.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));

                int corner = (int)DwmApi.DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmApi.DwmSetWindowAttribute(Handle, (int)DwmApi.DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref corner, sizeof(int));
            }
            catch
            {
                // Windows 10 or older / API unavailable - fail silently, app still works fine.
            }
        }
    }
}