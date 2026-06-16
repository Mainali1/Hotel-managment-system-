using System;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Username and password are required.";
                lblError.Visible = true;
                return;
            }

            try
            {
                var authManager = new BLL.AuthManager();
                var staff = authManager.Login(username, password);
                if (staff != null)
                {
                    Helpers.SessionManager.Login(staff);
                    this.Hide();
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                }
                else
                {
                    lblError.Text = "Invalid username or password.";
                    lblError.Visible = true;
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Connection error. Please check your database.";
                lblError.Visible = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}