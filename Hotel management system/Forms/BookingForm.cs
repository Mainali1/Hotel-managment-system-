using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Hotel_management_system.BLL;
using Hotel_management_system.Models;
using Guna.UI2.WinForms;
using Hotel_management_system.UI;
using System.Drawing;

namespace Hotel_management_system.Forms
{
    public partial class BookingForm : GlassFormBase
    {
        private BookingManager bookingManager = new BookingManager();
        private GuestManager guestManager = new GuestManager();
        private RoomManager roomManager = new RoomManager();
        private List<Booking> bookingList = new List<Booking>();
        private List<Guest> guestList = new List<Guest>();
        private List<Room> roomList = new List<Room>();

        public BookingForm()
        {
            InitializeComponent();
            LoadBookings();
            LoadGuests();
            LoadRooms();
            SetupDataGridView();
        }

        private void LoadGuests()
        {
            try
            {
                guestList = guestManager.GetAllGuests();
                cmbGuest.DataSource = null;
                cmbGuest.DataSource = guestList;
                cmbGuest.DisplayMember = "FullName";
                cmbGuest.ValueMember = "GuestID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRooms()
        {
            try
            {
                roomList = roomManager.GetAvailableRooms();
                cmbRoom.DataSource = null;
                cmbRoom.DataSource = roomList;
                cmbRoom.DisplayMember = "RoomNumber";
                cmbRoom.ValueMember = "RoomID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.MultiSelect = false;
            dgvBookings.ReadOnly = true;
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.SelectionChanged += DgvBookings_SelectionChanged;
        }

        private void LoadBookings()
        {
            try
            {
                bookingList = bookingManager.GetAllBookings();
                dgvBookings.DataSource = null;
                dgvBookings.DataSource = bookingList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgvBookings.Columns.Count > 0)
            {
                dgvBookings.Columns["BookingID"].HeaderText = "ID";
                dgvBookings.Columns["GuestName"].HeaderText = "GUEST";
                dgvBookings.Columns["RoomNumber"].HeaderText = "ROOM";
                dgvBookings.Columns["CheckInDate"].HeaderText = "CHECK-IN";
                dgvBookings.Columns["CheckOutDate"].HeaderText = "CHECK-OUT";
                dgvBookings.Columns["Status"].HeaderText = "STATUS";
                dgvBookings.Columns["Notes"].HeaderText = "NOTES";

                dgvBookings.ColumnHeadersHeight = 35;
                dgvBookings.RowTemplate.Height = 30;
                dgvBookings.RowHeadersVisible = false;
                dgvBookings.BackgroundColor = Color.White;
                dgvBookings.GridColor = Color.FromArgb(230, 230, 230);
                dgvBookings.BorderStyle = BorderStyle.None;
                dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                dgvBookings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 26, 34);
                dgvBookings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvBookings.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 26, 34);
                dgvBookings.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgvBookings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                dgvBookings.DefaultCellStyle.BackColor = Color.White;
                dgvBookings.DefaultCellStyle.SelectionBackColor = Color.FromArgb(77, 124, 254);
                dgvBookings.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvBookings.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgvBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    switch (status)
                    {
                        case "Confirmed":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
                            break;
                        case "CheckedIn":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(200, 200, 255);
                            break;
                        case "CheckedOut":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                            break;
                        case "Cancelled":
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                            break;
                    }
                }
            }
        }

        private void DgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                var booking = (Booking)dgvBookings.SelectedRows[0].DataBoundItem;
                txtBookingID.Text = booking.BookingID.ToString();

                var matchingGuest = guestList.Find(g => g.GuestID == booking.GuestID);
                if (matchingGuest != null)
                {
                    cmbGuest.SelectedValue = booking.GuestID;
                }

                var matchingRoom = roomList.Find(r => r.RoomID == booking.RoomID);
                if (matchingRoom != null)
                {
                    cmbRoom.SelectedValue = booking.RoomID;
                }

                dtpCheckInDate.Value = booking.CheckInDate;
                dtpCheckOutDate.Value = booking.CheckOutDate;
                txtNotes.Text = booking.Notes;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbGuest.SelectedValue == null)
            {
                MessageBox.Show("Please select a guest.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoom.SelectedValue == null)
            {
                MessageBox.Show("Please select a room.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Booking booking = new Booking
            {
                GuestID = (int)cmbGuest.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                CheckInDate = dtpCheckInDate.Value.Date,
                CheckOutDate = dtpCheckOutDate.Value.Date,
                Notes = txtNotes.Text.Trim()
            };

            try
            {
                var result = bookingManager.CreateBooking(booking);
                MessageBox.Show(result.message, "Booking Management",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.success)
                {
                    LoadBookings();
                    LoadRooms();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please select a booking to check in.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Confirm check-in for this booking?",
                "Confirm Check-In",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var checkInResult = bookingManager.CheckIn(int.Parse(txtBookingID.Text));
                    MessageBox.Show(checkInResult.message, "Booking Management",
                        MessageBoxButtons.OK, checkInResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (checkInResult.success)
                    {
                        LoadBookings();
                        LoadRooms();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please select a booking to check out.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Confirm check-out for this booking? This will generate a bill.",
                "Confirm Check-Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var checkOutResult = bookingManager.CheckOut(int.Parse(txtBookingID.Text));
                    MessageBox.Show(checkOutResult.message, "Booking Management",
                        MessageBoxButtons.OK, checkOutResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (checkOutResult.success)
                    {
                        LoadBookings();
                        LoadRooms();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please select a booking to cancel.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var cancelResult = bookingManager.CancelBooking(int.Parse(txtBookingID.Text));
                    MessageBox.Show(cancelResult.message, "Booking Management",
                        MessageBoxButtons.OK, cancelResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (cancelResult.success)
                    {
                        LoadBookings();
                        LoadRooms();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bookingList = bookingManager.SearchBookings(txtSearch.Text.Trim());
                dgvBookings.DataSource = null;
                dgvBookings.DataSource = bookingList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtBookingID.Text = "";
            cmbGuest.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            dtpCheckInDate.Value = DateTime.Now;
            dtpCheckOutDate.Value = DateTime.Now.AddDays(1);
            txtNotes.Text = "";
            txtSearch.Text = "";
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}