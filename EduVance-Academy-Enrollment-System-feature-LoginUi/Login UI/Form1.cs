using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class Form1 : Form
    {
        private const string ConnectionString =
    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=dblogin;Integrated Security=True";

        public Form1()
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
            MessageBox.Show("Login button clicked");
        }
    }
}