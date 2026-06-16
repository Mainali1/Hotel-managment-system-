using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSideBar;
        private Panel panelTopBar;
        private Panel panelContent;
        private Label lblTitle;
        private Label lblWelcome;
        private Label lblRole;
        private Button btnDashboard;
        private Button btnGuests;
        private Button btnRooms;
        private Button btnBookings;
        private Button btnBilling;
        private Button btnLogout;
        private Label lblUserIcon;
        private Label lblVersion;

        private void InitializeComponent()
        {
            this.panelSideBar = new Panel();
            this.panelTopBar = new Panel();
            this.panelContent = new Panel();
            this.lblTitle = new Label();
            this.lblWelcome = new Label();
            this.lblRole = new Label();
            this.btnDashboard = new Button();
            this.btnGuests = new Button();
            this.btnRooms = new Button();
            this.btnBookings = new Button();
            this.btnBilling = new Button();
            this.btnLogout = new Button();
            this.lblUserIcon = new Label();
            this.lblVersion = new Label();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Text = "Hotel Management System";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            panelSideBar = new Panel();
            panelSideBar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Width = 220;
            panelSideBar.Name = "panelSideBar";
            this.Controls.Add(panelSideBar);

            lblTitle = new Label();
            lblTitle.Text = "HOTEL";
            lblTitle.Font = new System.Drawing.Font("Courier New", 18, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Size = new System.Drawing.Size(180, 30);
            panelSideBar.Controls.Add(lblTitle);

            lblUserIcon = new Label();
            lblUserIcon.Text = "[  ]";
            lblUserIcon.Font = new System.Drawing.Font("Courier New", 40);
            lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblUserIcon.Location = new System.Drawing.Point(60, 60);
            lblUserIcon.Size = new System.Drawing.Size(100, 50);
            lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panelSideBar.Controls.Add(lblUserIcon);

            lblWelcome = new Label();
            lblWelcome.Text = "WELCOME";
            lblWelcome.Font = new System.Drawing.Font("Courier New", 10, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblWelcome.Location = new System.Drawing.Point(20, 120);
            lblWelcome.Size = new System.Drawing.Size(180, 20);
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panelSideBar.Controls.Add(lblWelcome);

            lblRole = new Label();
            lblRole.Text = "STAFF";
            lblRole.Font = new System.Drawing.Font("Courier New", 8);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblRole.Location = new System.Drawing.Point(20, 140);
            lblRole.Size = new System.Drawing.Size(180, 15);
            lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panelSideBar.Controls.Add(lblRole);

            int menuStartY = 180;
            int menuGap = 5;
            int menuHeight = 45;

            btnDashboard = CreateMenuButton("DASHBOARD", menuStartY);
            btnDashboard.Click += new EventHandler(btnDashboard_Click);
            panelSideBar.Controls.Add(btnDashboard);

            btnGuests = CreateMenuButton("GUESTS", menuStartY + (menuHeight + menuGap) * 1);
            btnGuests.Click += new EventHandler(btnGuests_Click);
            panelSideBar.Controls.Add(btnGuests);

            btnRooms = CreateMenuButton("ROOMS", menuStartY + (menuHeight + menuGap) * 2);
            btnRooms.Click += new EventHandler(btnRooms_Click);
            panelSideBar.Controls.Add(btnRooms);

            btnBookings = CreateMenuButton("BOOKINGS", menuStartY + (menuHeight + menuGap) * 3);
            btnBookings.Click += new EventHandler(btnBookings_Click);
            panelSideBar.Controls.Add(btnBookings);

            btnBilling = CreateMenuButton("BILLING", menuStartY + (menuHeight + menuGap) * 4);
            btnBilling.Click += new EventHandler(btnBilling_Click);
            panelSideBar.Controls.Add(btnBilling);

            btnLogout = CreateMenuButton("LOGOUT", 580);
            btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnLogout.Click += new EventHandler(btnLogout_Click);
            panelSideBar.Controls.Add(btnLogout);

            lblVersion = new Label();
            lblVersion.Text = "v1.0.0";
            lblVersion.Font = new System.Drawing.Font("Courier New", 7);
            lblVersion.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            lblVersion.Location = new System.Drawing.Point(20, 630);
            lblVersion.Size = new System.Drawing.Size(180, 15);
            lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panelSideBar.Controls.Add(lblVersion);

            panelTopBar = new Panel();
            panelTopBar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Height = 50;
            panelTopBar.Name = "panelTopBar";
            this.Controls.Add(panelTopBar);
            this.Controls.SetChildIndex(panelTopBar, 0);

            panelContent = new Panel();
            panelContent.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Name = "panelContent";
            this.Controls.Add(panelContent);

            this.ResumeLayout(false);
        }

        private Button CreateMenuButton(string text, int top)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Courier New", 10, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new System.Drawing.Point(20, top);
            btn.Size = new System.Drawing.Size(180, 45);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            return btn;
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