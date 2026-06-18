using System.Drawing;
using System.Windows.Forms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private GlassCard cardLogin;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsernameCaption;
        private Label lblPasswordCaption;
        private GlassInput inputUsername;
        private GlassInput inputPassword;
        private GlassButton btnLogin;
        private Label lblError;

        private void InitializeComponent()
        {
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 620);
            this.Text = "Hotel Management System - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Theme.AppBackground;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            cardLogin = new GlassCard
            {
                Size = new Size(380, 520),
                Location = new Point((this.ClientSize.Width - 380) / 2, 50),
                BackColor = Theme.CardBackground
            };
            this.Controls.Add(cardLogin);

            lblIcon = new Label
            {
                Text = AppIcons.Rooms,
                Font = Theme.FontIcon(34F),
                ForeColor = Theme.Accent,
                Location = new Point(0, 36),
                Size = new Size(380, 50),
                TextAlign = ContentAlignment.MiddleCenter
            };
            cardLogin.Controls.Add(lblIcon);

            lblTitle = new Label
            {
                Text = "Welcome Back",
                Font = Theme.FontHeading(),
                ForeColor = Theme.TextPrimary,
                Location = new Point(0, 96),
                Size = new Size(380, 28),
                TextAlign = ContentAlignment.MiddleCenter
            };
            cardLogin.Controls.Add(lblTitle);

            lblSubtitle = new Label
            {
                Text = "Sign in to manage the hotel",
                Font = Theme.FontBody(),
                ForeColor = Theme.TextSecondary,
                Location = new Point(0, 126),
                Size = new Size(380, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            cardLogin.Controls.Add(lblSubtitle);

            lblUsernameCaption = new Label
            {
                Text = "USERNAME",
                Font = Theme.FontSmall(),
                ForeColor = Theme.TextSecondary,
                Location = new Point(40, 180),
                Size = new Size(300, 16)
            };
            cardLogin.Controls.Add(lblUsernameCaption);

            inputUsername = new GlassInput
            {
                Location = new Point(40, 200),
                Size = new Size(300, 44)
            };
            cardLogin.Controls.Add(inputUsername);

            lblPasswordCaption = new Label
            {
                Text = "PASSWORD",
                Font = Theme.FontSmall(),
                ForeColor = Theme.TextSecondary,
                Location = new Point(40, 260),
                Size = new Size(300, 16)
            };
            cardLogin.Controls.Add(lblPasswordCaption);

            inputPassword = new GlassInput
            {
                Location = new Point(40, 280),
                Size = new Size(300, 44),
                UseSystemPasswordChar = true
            };
            inputPassword.Input.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
            cardLogin.Controls.Add(inputPassword);

            btnLogin = new GlassButton
            {
                Text = "LOG IN",
                IconGlyph = AppIcons.Lock,
                Location = new Point(40, 350),
                Size = new Size(300, 46),
                BaseColor = Theme.Accent,
                HoverColor = Theme.AccentHover
            };
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            cardLogin.Controls.Add(btnLogin);

            lblError = new Label
            {
                Text = "",
                Font = Theme.FontSmall(),
                ForeColor = Theme.Danger,
                Location = new Point(40, 410),
                Size = new Size(300, 36),
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            cardLogin.Controls.Add(lblError);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}