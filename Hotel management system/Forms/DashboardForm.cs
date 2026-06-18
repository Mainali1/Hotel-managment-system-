using System;
using System.Windows.Forms;
using Hotel_management_system.Helpers;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    public partial class DashboardForm : GlassFormBase
    {
        private Form activeForm = null;
        private GlassNavButton activeNavButton = null;

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME, " + SessionManager.CurrentUserName.ToUpper();
            lblRole.Text = SessionManager.CurrentUserRole.ToUpper();
            OpenChildForm(new GuestForm(), "Guests");
            SetActiveButton(btnGuests);
        }

        private void OpenChildForm(Form childForm, string pageTitle)
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

            lblPageTitle.Text = pageTitle;
        }

        private void SetActiveButton(GlassNavButton button)
        {
            if (activeNavButton != null)
            {
                activeNavButton.IsActive = false;
                activeNavButton.Invalidate();
            }
            activeNavButton = button;
            if (button != null)
            {
                button.IsActive = true;
                button.Invalidate();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            lblPageTitle.Text = "Dashboard";
            SetActiveButton(btnDashboard);
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestForm(), "Guests");
            SetActiveButton(btnGuests);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomForm(), "Rooms");
            SetActiveButton(btnRooms);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookingForm(), "Bookings");
            SetActiveButton(btnBookings);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillingForm(), "Billing");
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