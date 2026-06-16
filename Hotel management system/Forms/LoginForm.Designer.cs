using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_management_system.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel mainPanel;
        private Label lblUsername;
        private Label lblPassword;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Text = "Hotel Management System - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Controls.Add(mainPanel);

            lblTitle = new Label();
            lblTitle.Text = "HOTEL";
            lblTitle.Font = new System.Drawing.Font("Courier New", 28, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblTitle.Location = new System.Drawing.Point(50, 60);
            lblTitle.Size = new System.Drawing.Size(300, 40);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            mainPanel.Controls.Add(lblTitle);

            lblSubtitle = new Label();
            lblSubtitle.Text = "MANAGEMENT SYSTEM";
            lblSubtitle.Font = new System.Drawing.Font("Courier New", 10, System.Drawing.FontStyle.Regular);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblSubtitle.Location = new System.Drawing.Point(50, 100);
            lblSubtitle.Size = new System.Drawing.Size(300, 20);
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            mainPanel.Controls.Add(lblSubtitle);

            lblUsername = new Label();
            lblUsername.Text = "USERNAME";
            lblUsername.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblUsername.Location = new System.Drawing.Point(50, 160);
            lblUsername.Size = new System.Drawing.Size(300, 15);
            mainPanel.Controls.Add(lblUsername);

            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(50, 180);
            txtUsername.Size = new System.Drawing.Size(300, 30);
            txtUsername.Font = new System.Drawing.Font("Courier New", 11);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtUsername.Name = "txtUsername";
            mainPanel.Controls.Add(txtUsername);

            lblPassword = new Label();
            lblPassword.Text = "PASSWORD";
            lblPassword.Font = new System.Drawing.Font("Courier New", 9, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblPassword.Location = new System.Drawing.Point(50, 220);
            lblPassword.Size = new System.Drawing.Size(300, 15);
            mainPanel.Controls.Add(lblPassword);

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(50, 240);
            txtPassword.Size = new System.Drawing.Size(300, 30);
            txtPassword.Font = new System.Drawing.Font("Courier New", 11);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtPassword.PasswordChar = '*';
            txtPassword.Name = "txtPassword";
            txtPassword.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
            mainPanel.Controls.Add(txtPassword);

            btnLogin = new Button();
            btnLogin.Text = "LOGIN";
            btnLogin.Location = new System.Drawing.Point(50, 300);
            btnLogin.Size = new System.Drawing.Size(300, 45);
            btnLogin.Font = new System.Drawing.Font("Courier New", 11, System.Drawing.FontStyle.Bold);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Name = "btnLogin";
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Click += new EventHandler(btnLogin_Click);
            mainPanel.Controls.Add(btnLogin);

            lblError = new Label();
            lblError.Text = "";
            lblError.Font = new System.Drawing.Font("Courier New", 9);
            lblError.ForeColor = System.Drawing.Color.FromArgb(200, 0, 0);
            lblError.Location = new System.Drawing.Point(50, 360);
            lblError.Size = new System.Drawing.Size(300, 20);
            lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            lblError.Name = "lblError";
            mainPanel.Controls.Add(lblError);
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