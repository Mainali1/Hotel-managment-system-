using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class RoomForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvRooms;
        private TextBox txtRoomID;
        private TextBox txtRoomNumber;
        private TextBox txtRatePerNight;
        private TextBox txtDescription;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private ComboBox cmbFilterStatus;
        private Button btnAdd;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblTitle;
        private Label lblRoomID;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label lblRatePerNight;
        private Label lblStatus;
        private Label lblDescription;
        private Label lblFilterStatus;
        private Panel panelForm;
        private Panel panelGrid;
        private GroupBox grpFilter;

        private void InitializeComponent()
        {
            this.dgvRooms = new DataGridView();
            this.txtRoomID = new TextBox();
            this.txtRoomNumber = new TextBox();
            this.txtRatePerNight = new TextBox();
            this.txtDescription = new TextBox();
            this.cmbRoomType = new ComboBox();
            this.cmbStatus = new ComboBox();
            this.cmbFilterStatus = new ComboBox();
            this.btnAdd = new Button();
            this.btnSave = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.lblTitle = new Label();
            this.lblRoomID = new Label();
            this.lblRoomNumber = new Label();
            this.lblRoomType = new Label();
            this.lblRatePerNight = new Label();
            this.lblStatus = new Label();
            this.lblDescription = new Label();
            this.lblFilterStatus = new Label();
            this.panelForm = new Panel();
            this.panelGrid = new Panel();
            this.grpFilter = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Text = "Room Management";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            lblTitle = new Label();
            lblTitle.Text = "ROOM MANAGEMENT";
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

            grpFilter = new GroupBox();
            grpFilter.Text = "FILTER BY STATUS";
            grpFilter.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            grpFilter.Location = new System.Drawing.Point(340, 60);
            grpFilter.Size = new System.Drawing.Size(540, 50);
            this.Controls.Add(grpFilter);

            lblFilterStatus = new Label();
            lblFilterStatus.Text = "STATUS:";
            lblFilterStatus.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            lblFilterStatus.Location = new System.Drawing.Point(15, 22);
            grpFilter.Controls.Add(lblFilterStatus);

            cmbFilterStatus = new ComboBox();
            cmbFilterStatus.Location = new System.Drawing.Point(80, 18);
            cmbFilterStatus.Size = new System.Drawing.Size(200, 25);
            cmbFilterStatus.Font = new System.Drawing.Font("Courier New", 10);
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.SelectedIndexChanged += new EventHandler(cmbFilterStatus_SelectedIndexChanged);
            grpFilter.Controls.Add(cmbFilterStatus);

            int labelX = 15;
            int labelWidth = 120;
            int textX = 15;
            int textWidth = 260;
            int startY = 30;
            int gap = 40;

            lblRoomID = new Label();
            lblRoomID.Text = "ROOM ID:";
            lblRoomID.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblRoomID.Location = new System.Drawing.Point(labelX, startY);
            lblRoomID.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblRoomID);

            txtRoomID = new TextBox();
            txtRoomID.Location = new System.Drawing.Point(textX, startY + 18);
            txtRoomID.Size = new System.Drawing.Size(textWidth, 25);
            txtRoomID.Font = new System.Drawing.Font("Courier New", 10);
            txtRoomID.ReadOnly = true;
            txtRoomID.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            txtRoomID.Name = "txtRoomID";
            panelForm.Controls.Add(txtRoomID);

            lblRoomNumber = new Label();
            lblRoomNumber.Text = "ROOM NUMBER:";
            lblRoomNumber.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblRoomNumber.Location = new System.Drawing.Point(labelX, startY + gap);
            lblRoomNumber.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblRoomNumber);

            txtRoomNumber = new TextBox();
            txtRoomNumber.Location = new System.Drawing.Point(textX, startY + gap + 18);
            txtRoomNumber.Size = new System.Drawing.Size(textWidth, 25);
            txtRoomNumber.Font = new System.Drawing.Font("Courier New", 10);
            txtRoomNumber.Name = "txtRoomNumber";
            panelForm.Controls.Add(txtRoomNumber);

            lblRoomType = new Label();
            lblRoomType.Text = "ROOM TYPE:";
            lblRoomType.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblRoomType.Location = new System.Drawing.Point(labelX, startY + gap * 2);
            lblRoomType.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblRoomType);

            cmbRoomType = new ComboBox();
            cmbRoomType.Location = new System.Drawing.Point(textX, startY + gap * 2 + 18);
            cmbRoomType.Size = new System.Drawing.Size(textWidth, 25);
            cmbRoomType.Font = new System.Drawing.Font("Courier New", 10);
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Name = "cmbRoomType";
            panelForm.Controls.Add(cmbRoomType);

            lblRatePerNight = new Label();
            lblRatePerNight.Text = "RATE/NIGHT:";
            lblRatePerNight.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblRatePerNight.Location = new System.Drawing.Point(labelX, startY + gap * 3);
            lblRatePerNight.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblRatePerNight);

            txtRatePerNight = new TextBox();
            txtRatePerNight.Location = new System.Drawing.Point(textX, startY + gap * 3 + 18);
            txtRatePerNight.Size = new System.Drawing.Size(textWidth, 25);
            txtRatePerNight.Font = new System.Drawing.Font("Courier New", 10);
            txtRatePerNight.Name = "txtRatePerNight";
            panelForm.Controls.Add(txtRatePerNight);

            lblStatus = new Label();
            lblStatus.Text = "STATUS:";
            lblStatus.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblStatus.Location = new System.Drawing.Point(labelX, startY + gap * 4);
            lblStatus.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblStatus);

            cmbStatus = new ComboBox();
            cmbStatus.Location = new System.Drawing.Point(textX, startY + gap * 4 + 18);
            cmbStatus.Size = new System.Drawing.Size(textWidth, 25);
            cmbStatus.Font = new System.Drawing.Font("Courier New", 10);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Name = "cmbStatus";
            panelForm.Controls.Add(cmbStatus);

            lblDescription = new Label();
            lblDescription.Text = "DESCRIPTION:";
            lblDescription.Font = new System.Drawing.Font("Courier New", 8, System.Drawing.FontStyle.Bold);
            lblDescription.Location = new System.Drawing.Point(labelX, startY + gap * 5);
            lblDescription.Size = new System.Drawing.Size(labelWidth, 15);
            panelForm.Controls.Add(lblDescription);

            txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(textX, startY + gap * 5 + 18);
            txtDescription.Size = new System.Drawing.Size(textWidth, 25);
            txtDescription.Font = new System.Drawing.Font("Courier New", 10);
            txtDescription.Name = "txtDescription";
            panelForm.Controls.Add(txtDescription);

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

            dgvRooms = new DataGridView();
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.Location = new System.Drawing.Point(0, 0);
            dgvRooms.Size = new System.Drawing.Size(540, 510);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.BorderStyle = BorderStyle.None;
            panelGrid.Controls.Add(dgvRooms);

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
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