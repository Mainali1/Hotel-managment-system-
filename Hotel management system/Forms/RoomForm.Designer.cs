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
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();

            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "ROOM MANAGEMENT";
            this.lblTitle.Font = new Font("Courier New", 16, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 0, 0);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 30);

            //
            // grpFilter
            //
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Text = "FILTER BY STATUS";
            this.grpFilter.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.grpFilter.Location = new Point(340, 60);
            this.grpFilter.Size = new Size(540, 50);

            //
            // lblFilterStatus
            //
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Text = "STATUS:";
            this.lblFilterStatus.Font = new Font("Courier New", 9, FontStyle.Bold);
            this.lblFilterStatus.Location = new Point(15, 22);
            this.lblFilterStatus.Size = new Size(60, 20);

            //
            // cmbFilterStatus
            //
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Location = new Point(80, 18);
            this.cmbFilterStatus.Size = new Size(200, 25);
            this.cmbFilterStatus.Font = new Font("Courier New", 10);
            this.cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.SelectedIndexChanged += new EventHandler(this.cmbFilterStatus_SelectedIndexChanged);

            //
            // panelForm
            //
            this.panelForm.Name = "panelForm";
            this.panelForm.BackColor = Color.FromArgb(255, 255, 255);
            this.panelForm.Location = new Point(20, 60);
            this.panelForm.Size = new Size(300, 570);

            //
            // lblRoomID
            //
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Text = "ROOM ID:";
            this.lblRoomID.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRoomID.Location = new Point(15, 30);
            this.lblRoomID.Size = new Size(120, 15);

            //
            // txtRoomID
            //
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Location = new Point(15, 48);
            this.txtRoomID.Size = new Size(260, 25);
            this.txtRoomID.Font = new Font("Courier New", 10);
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.BackColor = Color.FromArgb(230, 230, 230);

            //
            // lblRoomNumber
            //
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Text = "ROOM NUMBER:";
            this.lblRoomNumber.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRoomNumber.Location = new Point(15, 70);
            this.lblRoomNumber.Size = new Size(120, 15);

            //
            // txtRoomNumber
            //
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Location = new Point(15, 88);
            this.txtRoomNumber.Size = new Size(260, 25);
            this.txtRoomNumber.Font = new Font("Courier New", 10);

            //
            // lblRoomType
            //
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Text = "ROOM TYPE:";
            this.lblRoomType.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRoomType.Location = new Point(15, 110);
            this.lblRoomType.Size = new Size(120, 15);

            //
            // cmbRoomType
            //
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Location = new Point(15, 128);
            this.cmbRoomType.Size = new Size(260, 25);
            this.cmbRoomType.Font = new Font("Courier New", 10);
            this.cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lblRatePerNight
            //
            this.lblRatePerNight.Name = "lblRatePerNight";
            this.lblRatePerNight.Text = "RATE/NIGHT:";
            this.lblRatePerNight.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblRatePerNight.Location = new Point(15, 150);
            this.lblRatePerNight.Size = new Size(120, 15);

            //
            // txtRatePerNight
            //
            this.txtRatePerNight.Name = "txtRatePerNight";
            this.txtRatePerNight.Location = new Point(15, 168);
            this.txtRatePerNight.Size = new Size(260, 25);
            this.txtRatePerNight.Font = new Font("Courier New", 10);

            //
            // lblStatus
            //
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "STATUS:";
            this.lblStatus.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblStatus.Location = new Point(15, 190);
            this.lblStatus.Size = new Size(120, 15);

            //
            // cmbStatus
            //
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Location = new Point(15, 208);
            this.cmbStatus.Size = new Size(260, 25);
            this.cmbStatus.Font = new Font("Courier New", 10);
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lblDescription
            //
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "DESCRIPTION:";
            this.lblDescription.Font = new Font("Courier New", 8, FontStyle.Bold);
            this.lblDescription.Location = new Point(15, 230);
            this.lblDescription.Size = new Size(120, 15);

            //
            // txtDescription
            //
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Location = new Point(15, 248);
            this.txtDescription.Size = new Size(260, 25);
            this.txtDescription.Font = new Font("Courier New", 10);

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
            // dgvRooms
            //
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Dock = DockStyle.Fill;
            this.dgvRooms.Location = new Point(0, 0);
            this.dgvRooms.Size = new Size(540, 510);
            this.dgvRooms.BorderStyle = BorderStyle.None;

            //
            // grpFilter contents
            //
            this.grpFilter.Controls.Add(this.lblFilterStatus);
            this.grpFilter.Controls.Add(this.cmbFilterStatus);

            //
            // panelForm contents
            //
            this.panelForm.Controls.Add(this.lblRoomID);
            this.panelForm.Controls.Add(this.txtRoomID);
            this.panelForm.Controls.Add(this.lblRoomNumber);
            this.panelForm.Controls.Add(this.txtRoomNumber);
            this.panelForm.Controls.Add(this.lblRoomType);
            this.panelForm.Controls.Add(this.cmbRoomType);
            this.panelForm.Controls.Add(this.lblRatePerNight);
            this.panelForm.Controls.Add(this.txtRatePerNight);
            this.panelForm.Controls.Add(this.lblStatus);
            this.panelForm.Controls.Add(this.cmbStatus);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);

            //
            // panelGrid contents
            //
            this.panelGrid.Controls.Add(this.dgvRooms);

            //
            // RoomForm
            //
            this.ClientSize = new Size(900, 650);
            this.Text = "Room Management";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Name = "RoomForm";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.panelGrid);

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
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