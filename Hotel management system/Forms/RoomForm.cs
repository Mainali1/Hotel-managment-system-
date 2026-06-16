using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Hotel_management_system.BLL;
using Hotel_management_system.Models;

namespace Hotel_management_system.Forms
{
    public partial class RoomForm : Form
    {
        private RoomManager roomManager = new RoomManager();
        private List<Room> roomList = new List<Room>();
        private string[] roomTypes = { "Single", "Double", "Deluxe", "Suite" };
        private string[] roomStatuses = { "Available", "Occupied", "Under Maintenance" };

        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
            SetupDataGridView();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.AddRange(roomTypes);
            cmbRoomType.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(roomStatuses);
            cmbStatus.SelectedIndex = 0;

            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("All");
            cmbFilterStatus.Items.AddRange(roomStatuses);
            cmbFilterStatus.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.MultiSelect = false;
            dgvRooms.ReadOnly = true;
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.SelectionChanged += DgvRooms_SelectionChanged;
        }

        private void LoadRooms()
        {
            try
            {
                string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "All";
                if (filterStatus == "All")
                {
                    roomList = roomManager.GetAllRooms();
                }
                else
                {
                    roomList = roomManager.GetRoomsByStatus(filterStatus);
                }
                dgvRooms.DataSource = null;
                dgvRooms.DataSource = roomList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgvRooms.Columns.Count > 0)
            {
                dgvRooms.Columns["RoomID"].HeaderText = "ID";
                dgvRooms.Columns["RoomNumber"].HeaderText = "ROOM NO";
                dgvRooms.Columns["RoomType"].HeaderText = "TYPE";
                dgvRooms.Columns["RatePerNight"].HeaderText = "RATE/NIGHT";
                dgvRooms.Columns["Status"].HeaderText = "STATUS";
                dgvRooms.Columns["Description"].HeaderText = "DESCRIPTION";

                foreach (DataGridViewColumn col in dgvRooms.Columns)
                {
                    col.HeaderCell.Style.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
                    col.HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    col.HeaderCell.Style.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }

                dgvRooms.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9);
                dgvRooms.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                dgvRooms.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
                dgvRooms.RowHeadersVisible = false;
                dgvRooms.ColumnHeadersHeight = 35;
                dgvRooms.RowTemplate.Height = 30;
                dgvRooms.Columns["RatePerNight"].DefaultCellStyle.Format = "N2";

                foreach (DataGridViewRow row in dgvRooms.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    switch (status)
                    {
                        case "Available":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(200, 255, 200);
                            break;
                        case "Occupied":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
                            break;
                        case "Under Maintenance":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 200);
                            break;
                    }
                }
            }
        }

        private void DgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                var room = (Room)dgvRooms.SelectedRows[0].DataBoundItem;
                txtRoomID.Text = room.RoomID.ToString();
                txtRoomNumber.Text = room.RoomNumber;
                cmbRoomType.SelectedItem = room.RoomType;
                txtRatePerNight.Text = room.RatePerNight.ToString("F2");
                cmbStatus.SelectedItem = room.Status;
                txtDescription.Text = room.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtRoomNumber.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Room number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRatePerNight.Text, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid rate per night.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Room room = new Room
            {
                RoomNumber = txtRoomNumber.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? "Single",
                RatePerNight = rate,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available",
                Description = txtDescription.Text.Trim()
            };

            try
            {
                var result = roomManager.AddRoom(room);
                MessageBox.Show(result.message, "Room Management",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.success)
                {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomID.Text))
            {
                MessageBox.Show("Please select a room to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtRatePerNight.Text, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid rate per night.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Room room = new Room
            {
                RoomID = int.Parse(txtRoomID.Text),
                RoomNumber = txtRoomNumber.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? "Single",
                RatePerNight = rate,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available",
                Description = txtDescription.Text.Trim()
            };

            try
            {
                var result = roomManager.UpdateRoom(room);
                MessageBox.Show(result.message, "Room Management",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.success)
                {
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomID.Text))
            {
                MessageBox.Show("Please select a room to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this room?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var deleteResult = roomManager.DeleteRoom(int.Parse(txtRoomID.Text));
                    MessageBox.Show(deleteResult.message, "Room Management",
                        MessageBoxButtons.OK, deleteResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (deleteResult.success)
                    {
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

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void ClearFields()
        {
            txtRoomID.Clear();
            txtRoomNumber.Clear();
            cmbRoomType.SelectedIndex = 0;
            txtRatePerNight.Clear();
            cmbStatus.SelectedIndex = 0;
            txtDescription.Clear();
        }
    }
}