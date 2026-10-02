using System;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

            {
                using (LoginForm loginForm = new LoginForm("Admin"))
                {
                    loginForm.ShowDialog();
                }
            }
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
            }
            }
        }
    }

