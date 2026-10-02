using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{

    public partial class LoginForm : Form
    {
        private const string ConnectionString =
    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=dblogin;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();

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

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            try
            {
                using (SqlConnection db = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT Role, IsActive, PasswordSalt, PasswordHash
          FROM Users WHERE Username = @username", db))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50)
                        .Value = username;

                    db.Open();

                    using (SqlDataReader user = cmd.ExecuteReader())
                    {
                        // Keep your password-checking code here.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter both username and password.");
                return;
            }

            bool isAdmin = chkAdmin.Checked;
            bool isRegistrar = chkRegistrar.Checked;
            bool isStudent = chkStudent.Checked;

            // Exactly one role must be selected
            if ((isAdmin ? 1 : 0) + (isRegistrar ? 1 : 0) + (isStudent ? 1 : 0) != 1)
            {
                MessageBox.Show("Select one role.");
                return;
            }

            // Student records are restricted to Admin and Registrar/Staff
            if (isStudent)
            {
                MessageBox.Show("The Student Records module is available only to Admin and Registrar/Staff.");
                return;
            }

            bool validLogin =
                (isAdmin && username == "admin" && password == "admin") ||
                (isRegistrar && username == "cashier" && password == "cashier");

            if (!validLogin)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            Hide();

            using (var studentForm = new StudentModuleUI())
            {
                studentForm.ShowDialog();
            }

            Close();
        }
    }
}