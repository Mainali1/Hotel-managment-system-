using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Hotel_management_system.UI;

namespace Hotel_management_system.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel cardLogin;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsernameCaption;
        private Label lblPasswordCaption;
        private GlassInput inputUsername;
        private GlassInput inputPassword;
        private Button btnLogin;
        private Label lblError;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(395, 477);
            this.Name = "LoginForm";
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