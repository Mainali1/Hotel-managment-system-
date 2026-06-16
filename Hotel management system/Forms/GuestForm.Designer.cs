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
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Text = "Guest Management";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            lblTitle = new Label();
            lblTitle.Text = "GUEST MANAGEMENT";
            lblTitle.Font = new System.Drawing.Font("Courier New", 16, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Size = new System.Drawing.Size(300, 30);
            this.Controls.Add(lblTitle);

            panelForm = new Panel();
            panelForm.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelForm.Location = new System.Drawing.Point(20, 60);
            panelForm.Size = new System.Drawing.Size(300, 570);
            this.Controls.Add(panelForm);

            grpSearch = new GroupBox();
            grpSearch.Text = "SEARCH";
            grpSearch.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            grpSearch.Location = new System.Drawing.Point(340, 60);
            grpSearch.Size = new System.Drawing.Size(540, 50);
            this.Controls.Add(grpSearch);

            lblSearch = new Label();
            lblSearch.Text = "SEARCH:";
            lblSearch.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            lblSearch.Location = new System.Drawing.Point(15, 22);
            grpSearch.Controls.Add(lblSearch);

            txtSearch = new TextBox();
            txtSearch.Font = new System.Drawing.Font("Courier New", 10);
            txtSearch.Location = new System.Drawing.Point(90, 18);
            txtSearch.Size = new System.Drawing.Size(400, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            grpSearch.Controls.Add(txtSearch);

            int labelX = 15;
            int labelWidth = 120;
            int textX = 15;
            int textWidth = 260;
            int startY = 30;
            int gap = 40;

            lblGuestID = new Label();
            lblGuestID.Text = "GUEST ID:";
            lblGuestID.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblGuestID.Location = new System.Drawing.Point(labelX, startY);
            lblGuestID.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblGuestID);

            txtGuestID = new TextBox();
            txtGuestID.Location = new System.Drawing.Point(textX, startY + 18);
            txtGuestID.Size = new System.Drawing.Size(textWidth, 25);
            txtGuestID.Font = new System.Drawing.Font("Courier New", 10);
            txtGuestID.ReadOnly = true;
            txtGuestID.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            txtGuestID.Name = "txtGuestID";
            panelForm.Controls.Add(txtGuestID);

            lblFullName = new Label();
            lblFullName.Text = "FULL NAME:";
            lblFullName.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblFullName.Location = new System.Drawing.Point(labelX, startY + gap);
            lblFullName.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblFullName);

            txtFullName = new TextBox();
            txtFullName.Location = new System.Drawing.Point(textX, startY + gap + 18);
            txtFullName.Size = new System.Drawing.Size(textWidth, 25);
            txtFullName.Font = new System.Drawing.Font("Courier New", 10);
            txtFullName.Name = "txtFullName";
            panelForm.Controls.Add(txtFullName);

            lblPhone = new Label();
            lblPhone.Text = "PHONE:";
            lblPhone.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblPhone.Location = new System.Drawing.Point(labelX, startY + gap * 2);
            lblPhone.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblPhone);

            txtPhone = new TextBox();
            txtPhone.Location = new System.Drawing.Point(textX, startY + gap * 2 + 18);
            txtPhone.Size = new System.Drawing.Size(textWidth, 25);
            txtPhone.Font = new System.Drawing.Font("Courier New", 10);
            txtPhone.Name = "txtPhone";
            panelForm.Controls.Add(txtPhone);

            lblEmail = new Label();
            lblEmail.Text = "EMAIL:";
            lblEmail.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblEmail.Location = new System.Drawing.Point(labelX, startY + gap * 3);
            lblEmail.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(textX, startY + gap * 3 + 18);
            txtEmail.Size = new System.Drawing.Size(textWidth, 25);
            txtEmail.Font = new System.Drawing.Font("Courier New", 10);
            txtEmail.Name = "txtEmail";
            panelForm.Controls.Add(txtEmail);

            lblAddress = new Label();
            lblAddress.Text = "ADDRESS:";
            lblAddress.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblAddress.Location = new System.Drawing.Point(labelX, startY + gap * 4);
            lblAddress.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblAddress);

            txtAddress = new TextBox();
            txtAddress.Location = new System.Drawing.Point(textX, startY + gap * 4 + 18);
            txtAddress.Size = new System.Drawing.Size(textWidth, 25);
            txtAddress.Font = new System.Drawing.Font("Courier New", 10);
            txtAddress.Name = "txtAddress";
            panelForm.Controls.Add(txtAddress);

            lblNationalID = new Label();
            lblNationalID.Text = "NATIONAL ID:";
            lblNationalID.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblNationalID.Location = new System.Drawing.Point(labelX, startY + gap * 5);
            lblNationalID.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblNationalID);

            txtNationalID = new TextBox();
            txtNationalID.Location = new System.Drawing.Point(textX, startY + gap * 5 + 18);
            txtNationalID.Size = new System.Drawing.Size(textWidth, 25);
            txtNationalID.Font = new System.Drawing.Font("Courier New", 10);
            txtNationalID.Name = "txtNationalID";
            panelForm.Controls.Add(txtNationalID);

            int btnWidth = 120;
            int btnHeight = 35;
            int btnX = 15;
            int btnStartY = 280;

            btnAdd = new Button();
            btnAdd.Text = "NEW";
            btnAdd.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnAdd.Location = new System.Drawing.Point(btnX, btnStartY);
            btnAdd.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            panelForm.Controls.Add(btnAdd);

            btnSave = new Button();
            btnSave.Text = "SAVE";
            btnSave.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnSave.BackColor = System.Drawing.Color.FromArgb(50, 150, 50);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new System.Drawing.Point(btnX, btnStartY + 45);
            btnSave.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += new EventHandler(btnSave_Click);
            panelForm.Controls.Add(btnSave);

            btnUpdate = new Button();
            btnUpdate.Text = "UPDATE";
            btnUpdate.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(50, 50, 150);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Location = new System.Drawing.Point(btnX, btnStartY + 90);
            btnUpdate.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Click += new EventHandler(btnUpdate_Click);
            panelForm.Controls.Add(btnUpdate);

            btnDelete = new Button();
            btnDelete.Text = "DELETE";
            btnDelete.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnDelete.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new System.Drawing.Point(btnX, btnStartY + 135);
            btnDelete.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += new EventHandler(btnDelete_Click);
            panelForm.Controls.Add(btnDelete);

            btnClear = new Button();
            btnClear.Text = "CLEAR";
            btnClear.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnClear.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnClear.Location = new System.Drawing.Point(btnX, btnStartY + 180);
            btnClear.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += new EventHandler(btnClear_Click);
            panelForm.Controls.Add(btnClear);

            panelGrid = new Panel();
            panelGrid.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            panelGrid.Location = new System.Drawing.Point(340, 120);
            panelGrid.Size = new System.Drawing.Size(540, 510);
            this.Controls.Add(panelGrid);

            dgvGuests = new DataGridView();
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.Location = new System.Drawing.Point(0, 0);
            dgvGuests.Size = new System.Drawing.Size(540, 510);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.BorderStyle = BorderStyle.None;
            panelGrid.Controls.Add(dgvGuests);

            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
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