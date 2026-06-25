using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Hotel_management_system.BLL;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    public partial class DashboardOverviewControl : UserControl
    {
        private DashboardManager dashboardManager = new DashboardManager();

        private TableLayoutPanel mainLayout;
        private Guna2Panel panelTop;
        private Guna2Panel panelBottom;

        private Label lblTotalRooms;
        private Label lblTotalRoomsTitle;
        private Label lblAvailableRooms;
        private Label lblAvailableRoomsTitle;
        private Label lblOccupiedRooms;
        private Label lblOccupiedRoomsTitle;
        private Label lblTotalGuests;
        private Label lblTotalGuestsTitle;
        private Label lblActiveBookings;
        private Label lblActiveBookingsTitle;
        private Label lblTodayRevenue;
        private Label lblTodayRevenueTitle;

        private Label lblCheckInsTitle;
        private Label lblCheckOutsTitle;
        private ListView lstCheckIns;
        private ListView lstCheckOuts;

        public DashboardOverviewControl()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            try
            {
                int totalRooms = dashboardManager.GetTotalRooms();
                int availableRooms = dashboardManager.GetAvailableRooms();
                int occupiedRooms = dashboardManager.GetOccupiedRooms();
                int totalGuests = dashboardManager.GetTotalGuests();
                int activeBookings = dashboardManager.GetActiveBookings();
                decimal todayRevenue = dashboardManager.GetTodayRevenue();

                lblTotalRooms.Text = totalRooms.ToString();
                lblAvailableRooms.Text = availableRooms.ToString();
                lblOccupiedRooms.Text = occupiedRooms.ToString();
                lblTotalGuests.Text = totalGuests.ToString();
                lblActiveBookings.Text = activeBookings.ToString();
                lblTodayRevenue.Text = "Rs. " + todayRevenue.ToString("N0");

                lstCheckIns.Items.Clear();
                var checkIns = dashboardManager.GetTodayCheckIns();
                foreach (var booking in checkIns)
                {
                    var item = new ListViewItem(booking.GuestName);
                    item.SubItems.Add(booking.RoomNumber);
                    item.SubItems.Add(booking.CheckInDate.ToString("HH:mm"));
                    lstCheckIns.Items.Add(item);
                }
                if (lstCheckIns.Items.Count == 0)
                {
                    lstCheckIns.Items.Add(new ListViewItem(new[] { "No check-ins today", "", "" }));
                }

                lstCheckOuts.Items.Clear();
                var checkOuts = dashboardManager.GetTodayCheckOuts();
                foreach (var booking in checkOuts)
                {
                    var item = new ListViewItem(booking.GuestName);
                    item.SubItems.Add(booking.RoomNumber);
                    item.SubItems.Add(booking.CheckOutDate.ToString("HH:mm"));
                    lstCheckOuts.Items.Add(item);
                }
                if (lstCheckOuts.Items.Count == 0)
                {
                    lstCheckOuts.Items.Add(new ListViewItem(new[] { "No check-outs today", "", "" }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();

            this.lblTotalRoomsTitle = new System.Windows.Forms.Label();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblAvailableRoomsTitle = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRoomsTitle = new System.Windows.Forms.Label();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblTotalGuestsTitle = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.lblActiveBookingsTitle = new System.Windows.Forms.Label();
            this.lblActiveBookings = new System.Windows.Forms.Label();
            this.lblTodayRevenueTitle = new System.Windows.Forms.Label();
            this.lblTodayRevenue = new System.Windows.Forms.Label();

            this.lblCheckInsTitle = new System.Windows.Forms.Label();
            this.lblCheckOutsTitle = new System.Windows.Forms.Label();
            this.lstCheckIns = new System.Windows.Forms.ListView();
            this.lstCheckOuts = new System.Windows.Forms.ListView();

            this.mainLayout.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(20);
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Size = new System.Drawing.Size(900, 650);
            this.mainLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelTop.BorderRadius = 10;
            this.panelTop.BorderThickness = 1;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(23, 23);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(15);
            this.panelTop.Size = new System.Drawing.Size(834, 280);
            this.panelTop.TabIndex = 0;
            // 
            // lblTotalRoomsTitle
            // 
            this.lblTotalRoomsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblTotalRoomsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTotalRoomsTitle.Name = "lblTotalRoomsTitle";
            this.lblTotalRoomsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTotalRoomsTitle.Size = new System.Drawing.Size(237, 20);
            this.lblTotalRoomsTitle.TabIndex = 0;
            this.lblTotalRoomsTitle.Text = "TOTAL ROOMS";
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(254)))));
            this.lblTotalRooms.Location = new System.Drawing.Point(15, 35);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(237, 50);
            this.lblTotalRooms.TabIndex = 1;
            this.lblTotalRooms.Text = "0";
            // 
            // lblAvailableRoomsTitle
            // 
            this.lblAvailableRoomsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailableRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAvailableRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblAvailableRoomsTitle.Location = new System.Drawing.Point(278, 15);
            this.lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            this.lblAvailableRoomsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAvailableRoomsTitle.Size = new System.Drawing.Size(237, 20);
            this.lblAvailableRoomsTitle.TabIndex = 2;
            this.lblAvailableRoomsTitle.Text = "AVAILABLE";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.lblAvailableRooms.Location = new System.Drawing.Point(278, 35);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(237, 50);
            this.lblAvailableRooms.TabIndex = 3;
            this.lblAvailableRooms.Text = "0";
            // 
            // lblOccupiedRoomsTitle
            // 
            this.lblOccupiedRoomsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOccupiedRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblOccupiedRoomsTitle.Location = new System.Drawing.Point(541, 15);
            this.lblOccupiedRoomsTitle.Name = "lblOccupiedRoomsTitle";
            this.lblOccupiedRoomsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblOccupiedRoomsTitle.Size = new System.Drawing.Size(278, 20);
            this.lblOccupiedRoomsTitle.TabIndex = 4;
            this.lblOccupiedRoomsTitle.Text = "OCCUPIED";
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.lblOccupiedRooms.Location = new System.Drawing.Point(541, 35);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(278, 50);
            this.lblOccupiedRooms.TabIndex = 5;
            this.lblOccupiedRooms.Text = "0";
            // 
            // lblTotalGuestsTitle
            // 
            this.lblTotalGuestsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalGuestsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalGuestsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblTotalGuestsTitle.Location = new System.Drawing.Point(15, 130);
            this.lblTotalGuestsTitle.Name = "lblTotalGuestsTitle";
            this.lblTotalGuestsTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.lblTotalGuestsTitle.Size = new System.Drawing.Size(237, 20);
            this.lblTotalGuestsTitle.TabIndex = 6;
            this.lblTotalGuestsTitle.Text = "TOTAL GUESTS";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalGuests.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.lblTotalGuests.Location = new System.Drawing.Point(15, 150);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(237, 50);
            this.lblTotalGuests.TabIndex = 7;
            this.lblTotalGuests.Text = "0";
            // 
            // lblActiveBookingsTitle
            // 
            this.lblActiveBookingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblActiveBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblActiveBookingsTitle.Location = new System.Drawing.Point(278, 130);
            this.lblActiveBookingsTitle.Name = "lblActiveBookingsTitle";
            this.lblActiveBookingsTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.lblActiveBookingsTitle.Size = new System.Drawing.Size(237, 20);
            this.lblActiveBookingsTitle.TabIndex = 8;
            this.lblActiveBookingsTitle.Text = "ACTIVE BOOKINGS";
            // 
            // lblActiveBookings
            // 
            this.lblActiveBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveBookings.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActiveBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(43)))), ((int)(((byte)(226)))));
            this.lblActiveBookings.Location = new System.Drawing.Point(278, 150);
            this.lblActiveBookings.Name = "lblActiveBookings";
            this.lblActiveBookings.Size = new System.Drawing.Size(237, 50);
            this.lblActiveBookings.TabIndex = 9;
            this.lblActiveBookings.Text = "0";
            // 
            // lblTodayRevenueTitle
            // 
            this.lblTodayRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTodayRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblTodayRevenueTitle.Location = new System.Drawing.Point(541, 130);
            this.lblTodayRevenueTitle.Name = "lblTodayRevenueTitle";
            this.lblTodayRevenueTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.lblTodayRevenueTitle.Size = new System.Drawing.Size(278, 20);
            this.lblTodayRevenueTitle.TabIndex = 10;
            this.lblTodayRevenueTitle.Text = "TODAY'S REVENUE";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTodayRevenue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblTodayRevenue.Location = new System.Drawing.Point(541, 150);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(278, 40);
            this.lblTodayRevenue.TabIndex = 11;
            this.lblTodayRevenue.Text = "Rs. 0";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelBottom.BorderRadius = 10;
            this.panelBottom.BorderThickness = 1;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(23, 323);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(15);
            this.panelBottom.Size = new System.Drawing.Size(834, 304);
            this.panelBottom.TabIndex = 1;
            // 
            // lblCheckInsTitle
            // 
            this.lblCheckInsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheckInsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckInsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblCheckInsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCheckInsTitle.Name = "lblCheckInsTitle";
            this.lblCheckInsTitle.Size = new System.Drawing.Size(380, 20);
            this.lblCheckInsTitle.TabIndex = 0;
            this.lblCheckInsTitle.Text = "TODAY'S CHECK-INS";
            // 
            // lblCheckOutsTitle
            // 
            this.lblCheckOutsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheckOutsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblCheckOutsTitle.Location = new System.Drawing.Point(420, 15);
            this.lblCheckOutsTitle.Name = "lblCheckOutsTitle";
            this.lblCheckOutsTitle.Size = new System.Drawing.Size(384, 20);
            this.lblCheckOutsTitle.TabIndex = 1;
            this.lblCheckOutsTitle.Text = "TODAY'S CHECK-OUTS";
            // 
            // lstCheckIns
            // 
            this.lstCheckIns.BackColor = System.Drawing.Color.White;
            this.lstCheckIns.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCheckIns.FullRowSelect = true;
            this.lstCheckIns.GridLines = true;
            this.lstCheckIns.Location = new System.Drawing.Point(15, 40);
            this.lstCheckIns.Name = "lstCheckIns";
            this.lstCheckIns.Size = new System.Drawing.Size(380, 249);
            this.lstCheckIns.TabIndex = 2;
            this.lstCheckIns.UseCompatibleStateImageBehavior = false;
            this.lstCheckIns.View = System.Windows.Forms.View.Details;
            this.lstCheckIns.Columns.Add("Guest", 180);
            this.lstCheckIns.Columns.Add("Room", 70);
            this.lstCheckIns.Columns.Add("Time", 100);
            // 
            // lstCheckOuts
            // 
            this.lstCheckOuts.BackColor = System.Drawing.Color.White;
            this.lstCheckOuts.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstCheckOuts.FullRowSelect = true;
            this.lstCheckOuts.GridLines = true;
            this.lstCheckOuts.Location = new System.Drawing.Point(424, 40);
            this.lstCheckOuts.Name = "lstCheckOuts";
            this.lstCheckOuts.Size = new System.Drawing.Size(395, 249);
            this.lstCheckOuts.TabIndex = 3;
            this.lstCheckOuts.UseCompatibleStateImageBehavior = false;
            this.lstCheckOuts.View = System.Windows.Forms.View.Details;
            this.lstCheckOuts.Columns.Add("Guest", 180);
            this.lstCheckOuts.Columns.Add("Room", 70);
            this.lstCheckOuts.Columns.Add("Time", 100);
            // 
            // DashboardOverviewControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.mainLayout);
            this.Name = "DashboardOverviewControl";
            this.Size = new System.Drawing.Size(900, 650);

            this.panelTop.Controls.Add(this.lblTotalRoomsTitle);
            this.panelTop.Controls.Add(this.lblTotalRooms);
            this.panelTop.Controls.Add(this.lblAvailableRoomsTitle);
            this.panelTop.Controls.Add(this.lblAvailableRooms);
            this.panelTop.Controls.Add(this.lblOccupiedRoomsTitle);
            this.panelTop.Controls.Add(this.lblOccupiedRooms);
            this.panelTop.Controls.Add(this.lblTotalGuestsTitle);
            this.panelTop.Controls.Add(this.lblTotalGuests);
            this.panelTop.Controls.Add(this.lblActiveBookingsTitle);
            this.panelTop.Controls.Add(this.lblActiveBookings);
            this.panelTop.Controls.Add(this.lblTodayRevenueTitle);
            this.panelTop.Controls.Add(this.lblTodayRevenue);

            this.panelBottom.Controls.Add(this.lblCheckInsTitle);
            this.panelBottom.Controls.Add(this.lblCheckOutsTitle);
            this.panelBottom.Controls.Add(this.lstCheckIns);
            this.panelBottom.Controls.Add(this.lstCheckOuts);

            this.mainLayout.Controls.Add(this.panelTop, 0, 0);
            this.mainLayout.SetColumnSpan(this.panelTop, 3);
            this.mainLayout.Controls.Add(this.panelBottom, 0, 1);
            this.mainLayout.SetColumnSpan(this.panelBottom, 3);

            this.mainLayout.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}