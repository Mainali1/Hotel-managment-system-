using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBookings;
        private TextBox txtBookingID;
        private ComboBox cmbGuest;
        private ComboBox cmbRoom;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private TextBox txtNotes;
        private TextBox txtSearch;
        private Button btnBook;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnCancel;
        private Button btnClear;
        private Label lblTitle;
        private Label lblBookingID;
        private Label lblGuest;
        private Label lblRoom;
        private Label lblCheckInDate;
        private Label lblCheckOutDate;
        private Label lblNotes;
        private Label lblSearch;
        private Panel panelForm;
        private Panel panelGrid;
        private GroupBox grpSearch;

        private void InitializeComponent()
        {
            this.dgvBookings = new DataGridView();
            this.txtBookingID = new TextBox();
            this.cmbGuest = new ComboBox();
            this.cmbRoom = new ComboBox();
            this.dtpCheckInDate = new DateTimePicker();
            this.dtpCheckOutDate = new DateTimePicker();
            this.txtNotes = new TextBox();
            this.txtSearch = new TextBox();
            this.btnBook = new Button();
            this.btnCheckIn = new Button();
            this.btnCheckOut = new Button();
            this.btnCancel = new Button();
            this.btnClear = new Button();
            this.lblTitle = new Label();
            this.lblBookingID = new Label();
            this.lblGuest = new Label();
            this.lblRoom = new Label();
            this.lblCheckInDate = new Label();
            this.lblCheckOutDate = new Label();
            this.lblNotes = new Label();
            this.lblSearch = new Label();
            this.panelForm = new Panel();
            this.panelGrid = new Panel();
            this.grpSearch = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();

            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "BOOKING MANAGEMENT";
            this.lblTitle.Font = new Font("Courier New", 16, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(350, 30);

            //
            // grpSearch
            //
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Text = "SEARCH";
            this.grpSearch.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.grpSearch.Location = new Point(380, 60);
            this.grpSearch.Size = new Size(600, 50);

            //
            // lblSearch
            //
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "SEARCH:";
            this.lblSearch.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.lblSearch.Location = new Point(15, 22);
            this.lblSearch.Size = new Size(70, 20);

            //
            // txtSearch
            //
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Font = new Font("Courier New", 10);
            this.txtSearch.Location = new Point(90, 18);
            this.txtSearch.Size = new Size(470, 25);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);

            //
            // panelForm
            //
            this.panelForm.Name = "panelForm";
            this.panelForm.BackColor = Color.FromArgb(255, 255, 255);
            this.panelForm.Location = new Point(20, 60);
            this.panelForm.Size = new Size(340, 620);

            //
            // lblBookingID
            //
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Text = "BOOKING ID:";
            this.lblBookingID.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblBookingID.Location = new Point(15, 30);
            this.lblBookingID.Size = new Size(120, 15);

            //
            // txtBookingID
            //
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Location = new Point(15, 48);
            this.txtBookingID.Size = new Size(300, 25);
            this.txtBookingID.Font = new Font("Courier New", 10);
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblGuest
            //
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Text = "GUEST:";
            this.lblGuest.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblGuest.Location = new Point(15, 75);
            this.lblGuest.Size = new Size(120, 15);

            //
            // cmbGuest
            //
            this.cmbGuest.Name = "cmbGuest";
            this.cmbGuest.Location = new Point(15, 93);
            this.cmbGuest.Size = new Size(300, 25);
            this.cmbGuest.Font = new Font("Courier New", 10);
            this.cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lblRoom
            //
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Text = "ROOM:";
            this.lblRoom.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRoom.Location = new Point(15, 120);
            this.lblRoom.Size = new Size(120, 15);

            //
            // cmbRoom
            //
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Location = new Point(15, 138);
            this.cmbRoom.Size = new Size(300, 25);
            this.cmbRoom.Font = new Font("Courier New", 10);
            this.cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lblCheckInDate
            //
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Text = "CHECK-IN DATE:";
            this.lblCheckInDate.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblCheckInDate.Location = new Point(15, 165);
            this.lblCheckInDate.Size = new Size(120, 15);

            //
            // dtpCheckInDate
            //
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Location = new Point(15, 183);
            this.dtpCheckInDate.Size = new Size(300, 25);
            this.dtpCheckInDate.Font = new Font("Courier New", 10);
            this.dtpCheckInDate.Value = DateTime.Now;

            //
            // lblCheckOutDate
            //
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Text = "CHECK-OUT DATE:";
            this.lblCheckOutDate.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblCheckOutDate.Location = new Point(15, 210);
            this.lblCheckOutDate.Size = new Size(120, 15);

            //
            // dtpCheckOutDate
            //
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Location = new Point(15, 228);
            this.dtpCheckOutDate.Size = new Size(300, 25);
            this.dtpCheckOutDate.Font = new Font("Courier New", 10);
            this.dtpCheckOutDate.Value = DateTime.Now.AddDays(1);

            //
            // lblNotes
            //
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Text = "NOTES:";
            this.lblNotes.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblNotes.Location = new Point(15, 255);
            this.lblNotes.Size = new Size(120, 15);

            //
            // txtNotes
            //
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Location = new Point(15, 273);
            this.txtNotes.Size = new Size(300, 25);
            this.txtNotes.Font = new Font("Courier New", 10);

            //
            // btnBook
            //
            this.btnBook.Name = "btnBook";
            this.btnBook.Text = "BOOK";
            this.btnBook.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnBook.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnBook.BackColor = Color.FromArgb(50, 150, 50);
            this.btnBook.FlatStyle = FlatStyle.Flat;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.Location = new Point(15, 280);
            this.btnBook.Size = new Size(145, 38);
            this.btnBook.Cursor = Cursors.Hand;
            this.btnBook.Click += new EventHandler(this.btnBook_Click);

            //
            // btnCheckIn
            //
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Text = "CHECK-IN";
            this.btnCheckIn.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnCheckIn.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnCheckIn.BackColor = Color.FromArgb(50, 100, 200);
            this.btnCheckIn.FlatStyle = FlatStyle.Flat;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.Location = new Point(15, 328);
            this.btnCheckIn.Size = new Size(145, 38);
            this.btnCheckIn.Cursor = Cursors.Hand;
            this.btnCheckIn.Click += new EventHandler(this.btnCheckIn_Click);

            //
            // btnCheckOut
            //
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Text = "CHECK-OUT";
            this.btnCheckOut.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnCheckOut.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnCheckOut.BackColor = Color.FromArgb(150, 100, 50);
            this.btnCheckOut.FlatStyle = FlatStyle.Flat;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.Location = new Point(15, 376);
            this.btnCheckOut.Size = new Size(145, 38);
            this.btnCheckOut.Cursor = Cursors.Hand;
            this.btnCheckOut.Click += new EventHandler(this.btnCheckOut_Click);

            //
            // btnCancel
            //
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "CANCEL BOOKING";
            this.btnCancel.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnCancel.BackColor = Color.FromArgb(200, 50, 50);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new Point(15, 424);
            this.btnCancel.Size = new Size(145, 38);
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            //
            // btnClear
            //
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "CLEAR";
            this.btnClear.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnClear.ForeColor = Color.FromArgb(0, 0, 0);
            this.btnClear.BackColor = Color.FromArgb(255, 255, 255);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.btnClear.Location = new Point(15, 472);
            this.btnClear.Size = new Size(145, 38);
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            //
            // panelGrid
            //
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.BackColor = Color.FromArgb(255, 255, 255);
            this.panelGrid.Location = new Point(380, 120);
            this.panelGrid.Size = new Size(600, 560);

            //
            // dgvBookings
            //
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Dock = DockStyle.Fill;
            this.dgvBookings.Location = new Point(0, 0);
            this.dgvBookings.Size = new Size(600, 560);
            this.dgvBookings.BorderStyle = BorderStyle.None;

            //
            // grpSearch contents
            //
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);

            //
            // panelForm contents
            //
            this.panelForm.Controls.Add(this.lblBookingID);
            this.panelForm.Controls.Add(this.txtBookingID);
            this.panelForm.Controls.Add(this.lblGuest);
            this.panelForm.Controls.Add(this.cmbGuest);
            this.panelForm.Controls.Add(this.lblRoom);
            this.panelForm.Controls.Add(this.cmbRoom);
            this.panelForm.Controls.Add(this.lblCheckInDate);
            this.panelForm.Controls.Add(this.dtpCheckInDate);
            this.panelForm.Controls.Add(this.lblCheckOutDate);
            this.panelForm.Controls.Add(this.dtpCheckOutDate);
            this.panelForm.Controls.Add(this.lblNotes);
            this.panelForm.Controls.Add(this.txtNotes);
            this.panelForm.Controls.Add(this.btnBook);
            this.panelForm.Controls.Add(this.btnCheckIn);
            this.panelForm.Controls.Add(this.btnCheckOut);
            this.panelForm.Controls.Add(this.btnCancel);
            this.panelForm.Controls.Add(this.btnClear);

            //
            // panelGrid contents
            //
            this.panelGrid.Controls.Add(this.dgvBookings);

            //
            // BookingForm
            //
            this.ClientSize = new Size(1000, 700);
            this.Text = "Booking Management";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Name = "BookingForm";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panelGrid);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
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