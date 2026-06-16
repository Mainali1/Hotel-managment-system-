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
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "Booking Management";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            lblTitle = new Label();
            lblTitle.Text = "BOOKING MANAGEMENT";
            lblTitle.Font = new System.Drawing.Font("Courier New", 16, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Size = new System.Drawing.Size(350, 30);
            this.Controls.Add(lblTitle);

            panelForm = new Panel();
            panelForm.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelForm.Location = new System.Drawing.Point(20, 60);
            panelForm.Size = new System.Drawing.Size(340, 620);
            this.Controls.Add(panelForm);

            grpSearch = new GroupBox();
            grpSearch.Text = "SEARCH";
            grpSearch.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            grpSearch.Location = new System.Drawing.Point(380, 60);
            grpSearch.Size = new System.Drawing.Size(600, 50);
            this.Controls.Add(grpSearch);

            lblSearch = new Label();
            lblSearch.Text = "SEARCH:";
            lblSearch.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            lblSearch.Location = new System.Drawing.Point(15, 22);
            grpSearch.Controls.Add(lblSearch);

            txtSearch = new TextBox();
            txtSearch.Font = new System.Drawing.Font("Courier New", 10);
            txtSearch.Location = new System.Drawing.Point(90, 18);
            txtSearch.Size = new System.Drawing.Size(470, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            grpSearch.Controls.Add(txtSearch);

            int labelX = 15;
            int textX = 15;
            int textWidth = 300;
            int startY = 30;
            int gap = 45;

            lblBookingID = new Label();
            lblBookingID.Text = "BOOKING ID:";
            lblBookingID.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblBookingID.Location = new System.Drawing.Point(labelX, startY);
            lblBookingID.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblBookingID);

            txtBookingID = new TextBox();
            txtBookingID.Location = new System.Drawing.Point(textX, startY + 18);
            txtBookingID.Size = new System.Drawing.Size(textWidth, 25);
            txtBookingID.Font = new System.Drawing.Font("Courier New", 10);
            txtBookingID.ReadOnly = true;
            txtBookingID.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            txtBookingID.Name = "txtBookingID";
            panelForm.Controls.Add(txtBookingID);

            lblGuest = new Label();
            lblGuest.Text = "GUEST:";
            lblGuest.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblGuest.Location = new System.Drawing.Point(labelX, startY + gap);
            lblGuest.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblGuest);

            cmbGuest = new ComboBox();
            cmbGuest.Location = new System.Drawing.Point(textX, startY + gap + 18);
            cmbGuest.Size = new System.Drawing.Size(textWidth, 25);
            cmbGuest.Font = new System.Drawing.Font("Courier New", 10);
            cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuest.Name = "cmbGuest";
            panelForm.Controls.Add(cmbGuest);

            lblRoom = new Label();
            lblRoom.Text = "ROOM:";
            lblRoom.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblRoom.Location = new System.Drawing.Point(labelX, startY + gap * 2);
            lblRoom.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblRoom);

            cmbRoom = new ComboBox();
            cmbRoom.Location = new System.Drawing.Point(textX, startY + gap * 2 + 18);
            cmbRoom.Size = new System.Drawing.Size(textWidth, 25);
            cmbRoom.Font = new System.Drawing.Font("Courier New", 10);
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.Name = "cmbRoom";
            panelForm.Controls.Add(cmbRoom);

            lblCheckInDate = new Label();
            lblCheckInDate.Text = "CHECK-IN DATE:";
            lblCheckInDate.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblCheckInDate.Location = new System.Drawing.Point(labelX, startY + gap * 3);
            lblCheckInDate.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblCheckInDate);

            dtpCheckInDate = new DateTimePicker();
            dtpCheckInDate.Location = new System.Drawing.Point(textX, startY + gap * 3 + 18);
            dtpCheckInDate.Size = new System.Drawing.Size(textWidth, 25);
            dtpCheckInDate.Font = new System.Drawing.Font("Courier New", 10);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Value = DateTime.Now;
            panelForm.Controls.Add(dtpCheckInDate);

            lblCheckOutDate = new Label();
            lblCheckOutDate.Text = "CHECK-OUT DATE:";
            lblCheckOutDate.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblCheckOutDate.Location = new System.Drawing.Point(labelX, startY + gap * 4);
            lblCheckOutDate.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblCheckOutDate);

            dtpCheckOutDate = new DateTimePicker();
            dtpCheckOutDate.Location = new System.Drawing.Point(textX, startY + gap * 4 + 18);
            dtpCheckOutDate.Size = new System.Drawing.Size(textWidth, 25);
            dtpCheckOutDate.Font = new System.Drawing.Font("Courier New", 10);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Value = DateTime.Now.AddDays(1);
            panelForm.Controls.Add(dtpCheckOutDate);

            lblNotes = new Label();
            lblNotes.Text = "NOTES:";
            lblNotes.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblNotes.Location = new System.Drawing.Point(labelX, startY + gap * 5);
            lblNotes.Size = new System.Drawing.Size(120, 15);
            panelForm.Controls.Add(lblNotes);

            txtNotes = new TextBox();
            txtNotes.Location = new System.Drawing.Point(textX, startY + gap * 5 + 18);
            txtNotes.Size = new System.Drawing.Size(textWidth, 25);
            txtNotes.Font = new System.Drawing.Font("Courier New", 10);
            txtNotes.Name = "txtNotes";
            panelForm.Controls.Add(txtNotes);

            int btnWidth = 145;
            int btnHeight = 38;
            int btnX = 15;
            int btnStartY = 280;

            btnBook = new Button();
            btnBook.Text = "BOOK";
            btnBook.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnBook.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnBook.BackColor = System.Drawing.Color.FromArgb(50, 150, 50);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.Location = new System.Drawing.Point(btnX, btnStartY);
            btnBook.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnBook.Cursor = Cursors.Hand;
            btnBook.Click += new EventHandler(btnBook_Click);
            panelForm.Controls.Add(btnBook);

            btnCheckIn = new Button();
            btnCheckIn.Text = "CHECK-IN";
            btnCheckIn.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnCheckIn.BackColor = System.Drawing.Color.FromArgb(50, 100, 200);
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.Location = new System.Drawing.Point(btnX, btnStartY + 48);
            btnCheckIn.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.Click += new EventHandler(btnCheckIn_Click);
            panelForm.Controls.Add(btnCheckIn);

            btnCheckOut = new Button();
            btnCheckOut.Text = "CHECK-OUT";
            btnCheckOut.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnCheckOut.BackColor = System.Drawing.Color.FromArgb(150, 100, 50);
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.Location = new System.Drawing.Point(btnX, btnStartY + 96);
            btnCheckOut.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.Click += new EventHandler(btnCheckOut_Click);
            panelForm.Controls.Add(btnCheckOut);

            btnCancel = new Button();
            btnCancel.Text = "CANCEL BOOKING";
            btnCancel.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnCancel.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new System.Drawing.Point(btnX, btnStartY + 144);
            btnCancel.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Click += new EventHandler(btnCancel_Click);
            panelForm.Controls.Add(btnCancel);

            btnClear = new Button();
            btnClear.Text = "CLEAR";
            btnClear.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnClear.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnClear.Location = new System.Drawing.Point(btnX, btnStartY + 192);
            btnClear.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += new EventHandler(btnClear_Click);
            panelForm.Controls.Add(btnClear);

            panelGrid = new Panel();
            panelGrid.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelGrid.Location = new System.Drawing.Point(380, 120);
            panelGrid.Size = new System.Drawing.Size(600, 560);
            this.Controls.Add(panelGrid);

            dgvBookings = new DataGridView();
            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.Location = new System.Drawing.Point(0, 0);
            dgvBookings.Size = new System.Drawing.Size(600, 560);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.BorderStyle = BorderStyle.None;
            panelGrid.Controls.Add(dgvBookings);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
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