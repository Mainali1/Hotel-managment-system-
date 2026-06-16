using System;
using System.Windows.Forms;
using Hotel_management_system.Helpers;

namespace Hotel_management_system
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                DatabaseSetup.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to initialize database. Please ensure SQL Server is running and credentials are correct.\n\nError: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.LoginForm());
        }
    }
}