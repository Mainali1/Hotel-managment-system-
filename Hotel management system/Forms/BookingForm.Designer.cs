using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvBookings;
        private Guna2TextBox txtBookingID;
        private Guna2ComboBox cmbGuest;
        private Guna2ComboBox cmbRoom;
        private Guna2DateTimePicker dtpCheckInDate;
        private Guna2DateTimePicker dtpCheckOutDate;
        private Guna2TextBox txtNotes;
        private Guna2TextBox txtSearch;
        private Guna2Button btnBook;
        private Guna2Button btnCheckIn;
        private Guna2Button btnCheckOut;
        private Guna2Button btnCancel;
        private Guna2Button btnClear;
        private Label lblTitle;
        private Label lblBookingID;
        private Label lblGuest;
        private Label lblRoom;
        private Label lblCheckInDate;
        private Label lblCheckOutDate;
        private Label lblNotes;
        private Guna2Panel panelForm;
        private Guna2Panel panelGrid;
        private Guna2GroupBox grpSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbGuest = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.panelForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.grpSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeight = 15;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBookings.Location = new System.Drawing.Point(0, 0);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.Size = new System.Drawing.Size(540, 510);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvBookings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookings.ThemeStyle.ReadOnly = true;
            this.dgvBookings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBookingID
            // 
            this.txtBookingID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtBookingID.BorderRadius = 8;
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBookingID.DefaultText = "";
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookingID.Location = new System.Drawing.Point(15, 48);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PlaceholderText = "";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(270, 36);
            this.txtBookingID.TabIndex = 1;
            // 
            // cmbGuest
            // 
            this.cmbGuest.BackColor = System.Drawing.Color.Transparent;
            this.cmbGuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.cmbGuest.BorderRadius = 8;
            this.cmbGuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuest.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGuest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGuest.ItemHeight = 30;
            this.cmbGuest.Location = new System.Drawing.Point(15, 108);
            this.cmbGuest.Name = "cmbGuest";
            this.cmbGuest.Size = new System.Drawing.Size(270, 36);
            this.cmbGuest.TabIndex = 3;
            // 
            // cmbRoom
            // 
            this.cmbRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.cmbRoom.BorderRadius = 8;
            this.cmbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRoom.ItemHeight = 30;
            this.cmbRoom.Location = new System.Drawing.Point(15, 163);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(270, 36);
            this.cmbRoom.TabIndex = 5;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.dtpCheckInDate.BorderRadius = 8;
            this.dtpCheckInDate.Checked = true;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(15, 218);
            this.dtpCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(270, 36);
            this.dtpCheckInDate.TabIndex = 7;
            this.dtpCheckInDate.Value = new System.DateTime(2026, 6, 25, 7, 9, 39, 947);
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.dtpCheckOutDate.BorderRadius = 8;
            this.dtpCheckOutDate.Checked = true;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(15, 278);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(270, 36);
            this.dtpCheckOutDate.TabIndex = 9;
            this.dtpCheckOutDate.Value = new System.DateTime(2026, 6, 25, 7, 9, 39, 975);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.Location = new System.Drawing.Point(15, 338);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(270, 36);
            this.txtNotes.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(98, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by guest, room, or booking ID...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 36);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnBook.BorderRadius = 8;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(122)))));
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(15, 410);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(130, 38);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "BOOK";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCheckIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCheckIn.BorderRadius = 8;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(15, 458);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(130, 38);
            this.btnCheckIn.TabIndex = 13;
            this.btnCheckIn.Text = "CHECK-IN";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.btnCheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.btnCheckOut.BorderRadius = 8;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(155, 458);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(130, 38);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "CHECK-OUT";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(15, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "CANCEL BOOKING";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnClear.BorderRadius = 8;
            this.btnClear.BorderThickness = 1;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnClear.Location = new System.Drawing.Point(15, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(270, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BOOKING MANAGEMENT";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBookingID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblBookingID.Location = new System.Drawing.Point(15, 30);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(82, 13);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "BOOKING ID:";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblGuest.Location = new System.Drawing.Point(15, 90);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(46, 13);
            this.lblGuest.TabIndex = 2;
            this.lblGuest.Text = "GUEST:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblRoom.Location = new System.Drawing.Point(15, 145);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(44, 13);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "ROOM:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCheckInDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblCheckInDate.Location = new System.Drawing.Point(15, 200);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(101, 13);
            this.lblCheckInDate.TabIndex = 6;
            this.lblCheckInDate.Text = "CHECK-IN DATE:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblCheckOutDate.Location = new System.Drawing.Point(15, 260);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(113, 13);
            this.lblCheckOutDate.TabIndex = 8;
            this.lblCheckOutDate.Text = "CHECK-OUT DATE:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 320);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(47, 13);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "NOTES:";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelForm.BorderRadius = 10;
            this.panelForm.BorderThickness = 1;
            this.panelForm.Location = new System.Drawing.Point(20, 60);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(300, 570);
            this.panelForm.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelGrid.BorderRadius = 10;
            this.panelGrid.BorderThickness = 1;
            this.panelGrid.Controls.Add(this.dgvBookings);
            this.panelGrid.Location = new System.Drawing.Point(340, 120);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(540, 510);
            this.panelGrid.TabIndex = 3;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.White;
            this.grpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grpSearch.BorderRadius = 10;
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.grpSearch.Location = new System.Drawing.Point(340, 60);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(540, 50);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.Text = "SEARCH";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panelGrid);
            this.Name = "BookingForm";
            this.Text = "Booking Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}