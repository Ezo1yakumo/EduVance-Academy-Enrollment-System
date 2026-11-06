
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace Login_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Maximize the form
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Hide password characters
            txtpassword.UseSystemPasswordChar = true;

            // Connect Login button
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

            // Check empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter your username and password.");
                return;
            }

            try
            {
                UserRepository repository = new UserRepository();

                // Check Admin credentials
                bool isAdmin = repository.ValidateCredentials(
                    username, password, "Admin");

                // Check Registrar credentials
                bool isRegistrar = false;

                if (!isAdmin)
                {
                    isRegistrar = repository.ValidateCredentials(
                        username, password, "Registrar");
                }

                // Check login credentials
                if (!isAdmin && !isRegistrar)
                {
                    MessageBox.Show(
                        "Invalid username or password.");
                    return;
                }

                // Determine account role
                string role = isAdmin ? "Admin" : "Registrar";

                // =====================================
                // SAVE AUTHENTICATED USER SESSION
                // =====================================

                EduVanceSession.Username = username;
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

                using (Dashboard dashboard = new Dashboard())
                {
                    dashboard.ShowDialog();
                }

                // Clear session after Dashboard closes
                EduVanceSession.Username = "";
                EduVanceSession.Role = "";
                EduVanceSession.StudentId = null;

                Close();
            }
            catch (SqlException ex)
            {
                Show();

                MessageBox.Show(
                    "Database connection error:\n" + ex.Message);
            }
        }
    }
}
