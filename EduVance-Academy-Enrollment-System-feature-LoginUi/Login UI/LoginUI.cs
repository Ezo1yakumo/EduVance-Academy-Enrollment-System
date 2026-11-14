
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                UserRepository repository = new UserRepository();

                // =====================================
                // AUTOMATIC ACCOUNT ROLE DETECTION
                // =====================================

                // Check Admin account
                bool isAdmin = repository.ValidateCredentials(
                    username, password, "Admin");

                // Check Registrar account
                bool isRegistrar = false;

                if (!isAdmin)
                {
                    isRegistrar = repository.ValidateCredentials(
                        username, password, "Registrar");
                }

                // Check Cashier account
                bool isCashier = false;

                if (!isAdmin && !isRegistrar)
                {
                    isCashier = repository.ValidateCredentials(
                        username, password, "Cashier");
                }

                // =====================================
                // LOGIN VALIDATION
                // =====================================

                if (!isAdmin && !isRegistrar && !isCashier)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // =====================================
                // DETERMINE USER ROLE
                // =====================================

                string role = isAdmin
                    ? "Admin"
                    : isRegistrar
                        ? "Registrar"
                        : "Cashier";

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

                // Clear session after logout
                EduVanceSession.Username = "";
                EduVanceSession.Role = "";
                EduVanceSession.StudentId = null;

                Close();
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
