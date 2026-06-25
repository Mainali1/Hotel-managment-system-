using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
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
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            this.panelSideBar = new Panel();
            this.panelTopBar = new Panel();
            this.panelContent = new Panel();

            this.lblLogoIcon = new Label();
            this.lblTitle = new Label();
            this.lblWelcome = new Label();
            this.lblRole = new Label();
            this.lblPageTitle = new Label();
            this.lblVersion = new Label();

            this.btnDashboard = new GlassNavButton();
            this.btnGuests = new GlassNavButton();
            this.btnRooms = new GlassNavButton();
            this.btnBookings = new GlassNavButton();
            this.btnBilling = new GlassNavButton();
            this.btnLogout = new GlassNavButton();

            this.ClientSize = new Size(1240, 760);
            this.Text = "Hotel Management System";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1100, 650);

            // Sidebar
            this.panelSideBar.BackColor = Color.FromArgb(24, 26, 34);
            this.panelSideBar.Dock = DockStyle.Left;
            this.panelSideBar.Width = 232;
            this.panelSideBar.Name = "panelSideBar";
            this.Controls.Add(this.panelSideBar);

            // Logo icon
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblLogoIcon.Text = "🏨";
            this.lblLogoIcon.Font = new Font("Segoe UI", 22F);
            this.lblLogoIcon.ForeColor = Color.FromArgb(77, 124, 254);
            this.lblLogoIcon.Location = new Point(24, 26);
            this.lblLogoIcon.Size = new Size(40, 36);
            this.panelSideBar.Controls.Add(this.lblLogoIcon);

            // Title
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "HOTELOS";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(66, 30);
            this.lblTitle.Size = new Size(150, 30);
            this.panelSideBar.Controls.Add(this.lblTitle);

            // Welcome
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.Font = new Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = Color.FromArgb(180, 180, 190);
            this.lblWelcome.Location = new Point(24, 90);
            this.lblWelcome.Size = new Size(184, 22);
            this.panelSideBar.Controls.Add(this.lblWelcome);

            // Role
            this.lblRole.Name = "lblRole";
            this.lblRole.Text = "STAFF";
            this.lblRole.Font = new Font("Segoe UI", 8F);
            this.lblRole.ForeColor = Color.FromArgb(120, 120, 140);
            this.lblRole.Location = new Point(24, 112);
            this.lblRole.Size = new Size(184, 16);
            this.panelSideBar.Controls.Add(this.lblRole);

            // Navigation buttons
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.IconGlyph = "📊";
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Location = new Point(18, 160);
            this.btnDashboard.Size = new Size(196, 44);
            this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);
            this.panelSideBar.Controls.Add(this.btnDashboard);

            this.btnGuests.Name = "btnGuests";
            this.btnGuests.IconGlyph = "👥";
            this.btnGuests.Text = "GUESTS";
            this.btnGuests.Location = new Point(18, 212);
            this.btnGuests.Size = new Size(196, 44);
            this.btnGuests.Click += new EventHandler(this.btnGuests_Click);
            this.panelSideBar.Controls.Add(this.btnGuests);

            this.btnRooms.Name = "btnRooms";
            this.btnRooms.IconGlyph = "🛏️";
            this.btnRooms.Text = "ROOMS";
            this.btnRooms.Location = new Point(18, 264);
            this.btnRooms.Size = new Size(196, 44);
            this.btnRooms.Click += new EventHandler(this.btnRooms_Click);
            this.panelSideBar.Controls.Add(this.btnRooms);

            this.btnBookings.Name = "btnBookings";
            this.btnBookings.IconGlyph = "📅";
            this.btnBookings.Text = "BOOKINGS";
            this.btnBookings.Location = new Point(18, 316);
            this.btnBookings.Size = new Size(196, 44);
            this.btnBookings.Click += new EventHandler(this.btnBookings_Click);
            this.panelSideBar.Controls.Add(this.btnBookings);

            this.btnBilling.Name = "btnBilling";
            this.btnBilling.IconGlyph = "💰";
            this.btnBilling.Text = "BILLING";
            this.btnBilling.Location = new Point(18, 368);
            this.btnBilling.Size = new Size(196, 44);
            this.btnBilling.Click += new EventHandler(this.btnBilling_Click);
            this.panelSideBar.Controls.Add(this.btnBilling);

            this.btnLogout.Name = "btnLogout";
            this.btnLogout.IconGlyph = "🚪";
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Location = new Point(18, 660);
            this.btnLogout.Size = new Size(196, 44);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            this.panelSideBar.Controls.Add(this.btnLogout);

            // Version
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "v2.0.0";
            this.lblVersion.Font = new Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = Color.FromArgb(120, 120, 140);
            this.lblVersion.Location = new Point(24, 728);
            this.lblVersion.Size = new Size(184, 16);
            this.lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            this.panelSideBar.Controls.Add(this.lblVersion);

            // Top bar
            this.panelTopBar.BackColor = Color.FromArgb(245, 245, 250);
            this.panelTopBar.Dock = DockStyle.Top;
            this.panelTopBar.Height = 64;
            this.panelTopBar.Name = "panelTopBar";
            this.Controls.Add(this.panelTopBar);
            this.Controls.SetChildIndex(this.panelTopBar, 0);

            // Page title
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Text = "Guests";
            this.lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblPageTitle.ForeColor = Color.FromArgb(30, 30, 40);
            this.lblPageTitle.Location = new Point(28, 18);
            this.lblPageTitle.Size = new Size(300, 30);
            this.panelTopBar.Controls.Add(this.lblPageTitle);

            // Content panel
            this.panelContent.Name = "panelContent";
            this.panelContent.BackColor = Color.FromArgb(245, 245, 250);
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Padding = new Padding(24, 0, 24, 24);
            this.Controls.Add(this.panelContent);

            this.Name = "DashboardForm";
            this.ResumeLayout(false);
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