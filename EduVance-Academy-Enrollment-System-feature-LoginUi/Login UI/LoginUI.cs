using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using EduVance.BusinessLogic.Controller;
using EduVance.Models;

namespace Login_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Maximize login form
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Hide password characters
            txtpassword.UseSystemPasswordChar = true;

            // Connect login button
            btnlogin.Click -= btnlogin_Click;
            btnlogin.Click += btnlogin_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            // Validate empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter your username and password.");
                return;
            }

            try
            {
                UserController controller =
                    new UserController(DatabaseConnection.ConnectionString);
                AuthenticatedUser user = controller.Login(username, password);

                if (user == null)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string role = user.Role;

                // =====================================
                // SAVE AUTHENTICATED USER SESSION
                // =====================================

                EduVanceSession.Username = user.Username;
                EduVanceSession.Role = role;
                EduVanceSession.StudentId = null;

                // =====================================
                // LOGIN SUCCESSFUL
                // =====================================

                MessageBox.Show(
                    "Login successful!\nWelcome, " + role + "!",
                    "EduVance Academy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open Dashboard

                Hide();

                DialogResult dashboardResult;

                using (Dashboard dashboard = new Dashboard())
                {
                    dashboardResult = dashboard.ShowDialog();
                }

                // Clear the previous user's session
                EduVanceSession.Username = "";
                EduVanceSession.Role = "";
                EduVanceSession.StudentId = null;

                // Clear the previous login credentials
                txtusername.Clear();
                txtpassword.Clear();

                if (dashboardResult == DialogResult.Retry)
                {
                    // Return to login without exiting the application
                    Show();
                    Activate();
                    txtusername.Focus();
                }
                else
                {
                    // Exit when the Dashboard is closed normally
                    Close();
                }
            }

            catch (SqlException ex)
            {
                Show();

                MessageBox.Show(
                    "Database connection error:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
