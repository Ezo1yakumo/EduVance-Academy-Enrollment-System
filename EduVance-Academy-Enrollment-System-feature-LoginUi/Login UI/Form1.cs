using System;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Avoid attaching the same handler more than once.
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

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter both username and password.");
                return;
            }

            bool isAdmin = chkAdmin.Checked;
            bool isRegistrar = chkRegistrar.Checked;

            // Exactly one role must be selected.
            if ((isAdmin ? 1 : 0) + (isRegistrar ? 1 : 0) != 1)
            {
                MessageBox.Show("Select one role.");
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