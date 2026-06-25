using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.UI
{
    /// <summary>
    /// Native WinForms TextBox controls can't be rounded directly (they're real
    /// Win32 windows, not GDI-painted). This wraps a borderless TextBox inside a
    /// GlassCard so the *container* looks like a rounded modern input field, and
    /// the textbox itself just sits flush inside it with no visible border.
    /// </summary>
    public class GlassInput : GlassCard
    {
        public TextBox Input { get; }

        public GlassInput()
        {
            CornerRadius = Theme.InputRadius;
            BackColor = Theme.InputBackground;
            BorderColor = Theme.InputBorder;
            Height = 42;
            Padding = new Padding(14, 0, 14, 0);

            Input = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Theme.InputBackground,
                ForeColor = Theme.TextPrimary,
                Font = Theme.FontBody(),
                Dock = DockStyle.Fill
            };

            Controls.Add(Input);

            Input.GotFocus += (s, e) => { BorderColor = Theme.Accent; Invalidate(); };
            Input.LostFocus += (s, e) => { BorderColor = Theme.InputBorder; Invalidate(); };
        }

        public new string Text { get => Input.Text; set => Input.Text = value; }
        public bool UseSystemPasswordChar { get => Input.UseSystemPasswordChar; set => Input.UseSystemPasswordChar = value; }
    }
}