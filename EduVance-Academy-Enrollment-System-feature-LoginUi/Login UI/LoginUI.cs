
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
            txtpassword.UseSystemPasswordChar = true;

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
                MessageBox.Show("Enter both username and password.");
                return;
            }

            bool isAdmin = chkAdmin.Checked;
            bool isRegistrar = chkRegistrar.Checked;

            if (isAdmin == isRegistrar)
            {
                MessageBox.Show("Select only one role.");
                return;
            }

            string role = isAdmin ? "Admin" : "Registrar";

            try
            {
                UserRepository repository = new UserRepository();

                bool validLogin = repository.ValidateCredentials(
                    username, password, role);

                if (!validLogin)
                {
                    MessageBox.Show("Invalid username, password, or role.");
                    return;
                }

                MessageBox.Show("Login successful!");

                Hide();

                using (Dashboard dashboard = new Dashboard())
                {
                    dashboard.ShowDialog();
                }

                Close();
            }
            catch (SqlException ex)
            {
                Show();
                MessageBox.Show("Database error:\n" + ex.Message);
            }
        }
    }
}
