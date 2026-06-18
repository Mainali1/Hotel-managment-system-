using System;
using System.Windows.Forms;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    public partial class LoginForm : GlassFormBase
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text.Trim();
            string password = inputPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Username and password are required.");
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
                    ShowError("Invalid username or password.");
                    inputPassword.Text = "";
                    inputUsername.Input.Focus();
                }
            }
            catch (Exception)
            {
                ShowError("Connection error. Please check your database.");
            }
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
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