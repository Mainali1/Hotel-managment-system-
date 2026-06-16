using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class GuestForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvGuests;
        private TextBox txtGuestID;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtNationalID;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblTitle;
        private Label lblGuestID;
        private Label lblFullName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblNationalID;
        private Label lblSearch;
        private Panel panelForm;
        private Panel panelGrid;
        private GroupBox grpSearch;

        private void InitializeComponent()
        {
            this.dgvGuests = new DataGridView();
            this.txtGuestID = new TextBox();
            this.txtFullName = new TextBox();
            this.txtPhone = new TextBox();
            this.txtEmail = new TextBox();
            this.txtAddress = new TextBox();
            this.txtNationalID = new TextBox();
            this.txtSearch = new TextBox();
            this.btnAdd = new Button();
            this.btnSave = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.lblTitle = new Label();
            this.lblGuestID = new Label();
            this.lblFullName = new Label();
            this.lblPhone = new Label();
            this.lblEmail = new Label();
            this.lblAddress = new Label();
            this.lblNationalID = new Label();
            this.lblSearch = new Label();
            this.panelForm = new Panel();
            this.panelGrid = new Panel();
            this.grpSearch = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();

            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "GUEST MANAGEMENT";
            this.lblTitle.Font = new Font("Courier New", 16, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 30);

            //
            // grpSearch
            //
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Text = "SEARCH";
            this.grpSearch.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.grpSearch.Location = new Point(340, 60);
            this.grpSearch.Size = new Size(540, 50);

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
            this.txtSearch.Size = new Size(400, 25);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);

            //
            // panelForm
            //
            this.panelForm.Name = "panelForm";
            this.panelForm.BackColor = Color.FromArgb(255, 255, 255);
            this.panelForm.Location = new Point(20, 60);
            this.panelForm.Size = new Size(300, 570);

            //
            // lblGuestID
            //
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Text = "GUEST ID:";
            this.lblGuestID.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblGuestID.Location = new Point(15, 30);
            this.lblGuestID.Size = new Size(120, 15);

            //
            // txtGuestID
            //
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Location = new Point(15, 48);
            this.txtGuestID.Size = new Size(260, 25);
            this.txtGuestID.Font = new Font("Courier New", 10);
            this.txtGuestID.ReadOnly = true;
            this.txtGuestID.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblFullName
            //
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Text = "FULL NAME:";
            this.lblFullName.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblFullName.Location = new Point(15, 70);
            this.lblFullName.Size = new Size(120, 15);

            //
            // txtFullName
            //
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Location = new Point(15, 88);
            this.txtFullName.Size = new Size(260, 25);
            this.txtFullName.Font = new Font("Courier New", 10);

            //
            // lblPhone
            //
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "PHONE:";
            this.lblPhone.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblPhone.Location = new Point(15, 110);
            this.lblPhone.Size = new Size(120, 15);

            //
            // txtPhone
            //
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Location = new Point(15, 128);
            this.txtPhone.Size = new Size(260, 25);
            this.txtPhone.Font = new Font("Courier New", 10);

            //
            // lblEmail
            //
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "EMAIL:";
            this.lblEmail.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblEmail.Location = new Point(15, 150);
            this.lblEmail.Size = new Size(120, 15);

            //
            // txtEmail
            //
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new Point(15, 168);
            this.txtEmail.Size = new Size(260, 25);
            this.txtEmail.Font = new Font("Courier New", 10);

            //
            // lblAddress
            //
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "ADDRESS:";
            this.lblAddress.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblAddress.Location = new Point(15, 190);
            this.lblAddress.Size = new Size(120, 15);

            //
            // txtAddress
            //
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Location = new Point(15, 208);
            this.txtAddress.Size = new Size(260, 25);
            this.txtAddress.Font = new Font("Courier New", 10);

            //
            // lblNationalID
            //
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Text = "NATIONAL ID:";
            this.lblNationalID.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblNationalID.Location = new Point(15, 230);
            this.lblNationalID.Size = new Size(120, 15);

            //
            // txtNationalID
            //
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Location = new Point(15, 248);
            this.txtNationalID.Size = new Size(260, 25);
            this.txtNationalID.Font = new Font("Courier New", 10);

            //
            // btnAdd
            //
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "NEW";
            this.btnAdd.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.FromArgb(0, 0, 0);
            this.btnAdd.BackColor = Color.FromArgb(255, 255, 255);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.btnAdd.Location = new Point(15, 280);
            this.btnAdd.Size = new Size(120, 35);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            //
            // btnSave
            //
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "SAVE";
            this.btnSave.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnSave.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnSave.BackColor = Color.FromArgb(50, 150, 50);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new Point(15, 325);
            this.btnSave.Size = new Size(120, 35);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            //
            // btnUpdate
            //
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnUpdate.BackColor = Color.FromArgb(50, 50, 150);
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new Point(15, 370);
            this.btnUpdate.Size = new Size(120, 35);
            this.btnUpdate.Cursor = Cursors.Hand;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            //
            // btnDelete
            //
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnDelete.BackColor = Color.FromArgb(200, 50, 50);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new Point(15, 415);
            this.btnDelete.Size = new Size(120, 35);
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

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
            this.btnClear.Location = new Point(15, 460);
            this.btnClear.Size = new Size(120, 35);
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            //
            // panelGrid
            //
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.BackColor = Color.FromArgb(255, 255, 255);
            this.panelGrid.Location = new Point(340, 120);
            this.panelGrid.Size = new Size(540, 510);

            //
            // dgvGuests
            //
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.Dock = DockStyle.Fill;
            this.dgvGuests.Location = new Point(0, 0);
            this.dgvGuests.Size = new Size(540, 510);
            this.dgvGuests.BorderStyle = BorderStyle.None;

            //
            // grpSearch contents
            //
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);

            //
            // panelForm contents
            //
            this.panelForm.Controls.Add(this.lblGuestID);
            this.panelForm.Controls.Add(this.txtGuestID);
            this.panelForm.Controls.Add(this.lblFullName);
            this.panelForm.Controls.Add(this.txtFullName);
            this.panelForm.Controls.Add(this.lblPhone);
            this.panelForm.Controls.Add(this.txtPhone);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.lblAddress);
            this.panelForm.Controls.Add(this.txtAddress);
            this.panelForm.Controls.Add(this.lblNationalID);
            this.panelForm.Controls.Add(this.txtNationalID);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);

            //
            // panelGrid contents
            //
            this.panelGrid.Controls.Add(this.dgvGuests);

            //
            // GuestForm
            //
            this.ClientSize = new Size(900, 650);
            this.Text = "Guest Management";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Name = "GuestForm";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panelGrid);

            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
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