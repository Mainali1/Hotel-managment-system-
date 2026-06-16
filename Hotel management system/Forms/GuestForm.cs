using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Hotel_management_system.BLL;
using Hotel_management_system.Models;

namespace Hotel_management_system.Forms
{
    public partial class GuestForm : Form
    {
        private GuestManager guestManager = new GuestManager();
        private List<Guest> guestList = new List<Guest>();

        public GuestForm()
        {
            InitializeComponent();
            LoadGuests();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.MultiSelect = false;
            dgvGuests.ReadOnly = true;
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.SelectionChanged += DgvGuests_SelectionChanged;
        }

        private void LoadGuests()
        {
            try
            {
                guestList = guestManager.GetAllGuests();
                dgvGuests.DataSource = null;
                dgvGuests.DataSource = guestList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgvGuests.Columns.Count > 0)
            {
                dgvGuests.Columns["GuestID"].HeaderText = "ID";
                dgvGuests.Columns["FullName"].HeaderText = "FULL NAME";
                dgvGuests.Columns["Phone"].HeaderText = "PHONE";
                dgvGuests.Columns["Email"].HeaderText = "EMAIL";
                dgvGuests.Columns["Address"].HeaderText = "ADDRESS";
                dgvGuests.Columns["NationalID"].HeaderText = "NATIONAL ID";
                dgvGuests.Columns["CreatedAt"].HeaderText = "CREATED";

                foreach (DataGridViewColumn col in dgvGuests.Columns)
                {
                    col.HeaderCell.Style.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
                    col.HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    col.HeaderCell.Style.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }

                dgvGuests.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9);
                dgvGuests.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                dgvGuests.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
                dgvGuests.RowHeadersVisible = false;
                dgvGuests.ColumnHeadersHeight = 35;
                dgvGuests.RowTemplate.Height = 30;
            }
        }

        private void DgvGuests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count > 0)
            {
                var guest = (Guest)dgvGuests.SelectedRows[0].DataBoundItem;
                txtGuestID.Text = guest.GuestID.ToString();
                txtFullName.Text = guest.FullName;
                txtPhone.Text = guest.Phone;
                txtEmail.Text = guest.Email;
                txtAddress.Text = guest.Address;
                txtNationalID.Text = guest.NationalID;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Guest name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guest guest = new Guest
            {
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                NationalID = txtNationalID.Text.Trim()
            };

            try
            {
                var result = guestManager.AddGuest(guest);
                MessageBox.Show(result.message, "Guest Management",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.success)
                {
                    LoadGuests();
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
            if (string.IsNullOrWhiteSpace(txtGuestID.Text))
            {
                MessageBox.Show("Please select a guest to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guest guest = new Guest
            {
                GuestID = int.Parse(txtGuestID.Text),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                NationalID = txtNationalID.Text.Trim()
            };

            try
            {
                var result = guestManager.UpdateGuest(guest);
                MessageBox.Show(result.message, "Guest Management",
                    MessageBoxButtons.OK, result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.success)
                {
                    LoadGuests();
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
            if (string.IsNullOrWhiteSpace(txtGuestID.Text))
            {
                MessageBox.Show("Please select a guest to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this guest?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var deleteResult = guestManager.DeleteGuest(int.Parse(txtGuestID.Text));
                    MessageBox.Show(deleteResult.message, "Guest Management",
                        MessageBoxButtons.OK, deleteResult.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                    if (deleteResult.success)
                    {
                        LoadGuests();
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
                guestList = guestManager.SearchGuests(txtSearch.Text.Trim());
                dgvGuests.DataSource = null;
                dgvGuests.DataSource = guestList;
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
            txtGuestID.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtNationalID.Clear();
            txtSearch.Clear();
        }
    }
}