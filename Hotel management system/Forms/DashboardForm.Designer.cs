using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSideBar;
        private Panel panelTopBar;
        private Panel panelContent;

        private Label lblLogoIcon;
        private Label lblTitle;
        private Label lblWelcome;
        private Label lblRole;
        private Label lblPageTitle;
        private Label lblVersion;

        private GlassNavButton btnDashboard;
        private GlassNavButton btnGuests;
        private GlassNavButton btnRooms;
        private GlassNavButton btnBookings;
        private GlassNavButton btnBilling;
        private GlassNavButton btnLogout;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new Size(1240, 760);
            this.Text = "Hotel Management System";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Theme.AppBackground;
            this.MinimumSize = new Size(1100, 650);

            // ---------------- Sidebar ----------------
            panelSideBar = new Panel
            {
                BackColor = Theme.SidebarBackground,
                Dock = DockStyle.Left,
                Width = 232
            };
            this.Controls.Add(panelSideBar);

            lblLogoIcon = new Label
            {
                Text = AppIcons.Rooms,
                Font = Theme.FontIcon(22F),
                ForeColor = Theme.Accent,
                Location = new Point(24, 26),
                Size = new Size(40, 36)
            };
            panelSideBar.Controls.Add(lblLogoIcon);

            lblTitle = new Label
            {
                Text = "HOTELOS",
                Font = Theme.FontHeading(),
                ForeColor = Theme.TextOnDark,
                Location = new Point(66, 30),
                Size = new Size(150, 30)
            };
            panelSideBar.Controls.Add(lblTitle);

            lblWelcome = new Label
            {
                Text = "WELCOME",
                Font = Theme.FontSubheading(),
                ForeColor = Theme.TextOnDark,
                Location = new Point(24, 90),
                Size = new Size(184, 22)
            };
            panelSideBar.Controls.Add(lblWelcome);

            lblRole = new Label
            {
                Text = "STAFF",
                Font = Theme.FontSmall(),
                ForeColor = Theme.TextOnDarkMuted,
                Location = new Point(24, 112),
                Size = new Size(184, 16)
            };
            panelSideBar.Controls.Add(lblRole);

            int navStartY = 160;
            int navGap = 8;
            int navHeight = 44;

            btnDashboard = CreateNavButton(AppIcons.Dashboard, "DASHBOARD", navStartY);
            btnDashboard.Click += new EventHandler(btnDashboard_Click);
            panelSideBar.Controls.Add(btnDashboard);

            btnGuests = CreateNavButton(AppIcons.Guests, "GUESTS", navStartY + (navHeight + navGap) * 1);
            btnGuests.Click += new EventHandler(btnGuests_Click);
            panelSideBar.Controls.Add(btnGuests);

            btnRooms = CreateNavButton(AppIcons.Rooms, "ROOMS", navStartY + (navHeight + navGap) * 2);
            btnRooms.Click += new EventHandler(btnRooms_Click);
            panelSideBar.Controls.Add(btnRooms);

            btnBookings = CreateNavButton(AppIcons.Bookings, "BOOKINGS", navStartY + (navHeight + navGap) * 3);
            btnBookings.Click += new EventHandler(btnBookings_Click);
            panelSideBar.Controls.Add(btnBookings);

            btnBilling = CreateNavButton(AppIcons.Billing, "BILLING", navStartY + (navHeight + navGap) * 4);
            btnBilling.Click += new EventHandler(btnBilling_Click);
            panelSideBar.Controls.Add(btnBilling);

            btnLogout = CreateNavButton(AppIcons.Logout, "LOGOUT", 660);
            btnLogout.Click += new EventHandler(btnLogout_Click);
            panelSideBar.Controls.Add(btnLogout);

            lblVersion = new Label
            {
                Text = "v2.0.0",
                Font = Theme.FontSmall(),
                ForeColor = Theme.TextOnDarkMuted,
                Location = new Point(24, 728),
                Size = new Size(184, 16),
                TextAlign = ContentAlignment.MiddleLeft
            };
            panelSideBar.Controls.Add(lblVersion);

            // ---------------- Top bar ----------------
            panelTopBar = new Panel
            {
                BackColor = Theme.AppBackground,
                Dock = DockStyle.Top,
                Height = 64
            };
            this.Controls.Add(panelTopBar);
            this.Controls.SetChildIndex(panelTopBar, 0);

            lblPageTitle = new Label
            {
                Text = "Guests",
                Font = Theme.FontHeading(),
                ForeColor = Theme.TextPrimary,
                Location = new Point(28, 18),
                Size = new Size(300, 30)
            };
            panelTopBar.Controls.Add(lblPageTitle);

            // ---------------- Content ----------------
            panelContent = new Panel
            {
                BackColor = Theme.AppBackground,
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 0, 24, 24)
            };
            this.Controls.Add(panelContent);

            this.ResumeLayout(false);
        }

        private GlassNavButton CreateNavButton(string icon, string text, int top)
        {
            return new GlassNavButton
            {
                IconGlyph = icon,
                Text = text,
                Location = new Point(18, top),
                Size = new Size(196, 44)
            };
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