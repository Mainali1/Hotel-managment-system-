using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel_management_system.Helpers;

namespace Hotel_management_system.Forms
{
    public partial class DashboardForm : Form
    {
        private Form activeForm = null;
        private Button activeMenuButton = null;

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME, " + SessionManager.CurrentUserName.ToUpper();
            lblRole.Text = SessionManager.CurrentUserRole.ToUpper();
            OpenChildForm(new GuestForm());
            SetActiveButton(btnGuests);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetActiveButton(Button button)
        {
            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = Color.FromArgb(255, 255, 255);
                activeMenuButton.ForeColor = Color.FromArgb(0, 0, 0);
            }
            activeMenuButton = button;
            if (button != null)
            {
                button.BackColor = Color.FromArgb(0, 0, 0);
                button.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            SetActiveButton(btnDashboard);
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestForm());
            SetActiveButton(btnGuests);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomForm());
            SetActiveButton(btnRooms);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookingForm());
            SetActiveButton(btnBookings);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillingForm());
            SetActiveButton(btnBilling);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}