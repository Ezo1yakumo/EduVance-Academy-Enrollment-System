
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class Dashboard : Form
    {
        private Timer refreshTimer = new Timer();
        private MdiClient mdiArea;


        public Dashboard()
        {
            InitializeComponent();

            // Maximize Dashboard when running
            this.WindowState = FormWindowState.Maximized;

            // Enable MDI
            SetupMdi();

            // Refresh SQL information every 5 seconds
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, e) => RefreshDashboard();

            this.Shown += (s, e) =>
            {
                RefreshDashboard();
                refreshTimer.Start();
            };

            this.FormClosed += (s, e) =>
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
            };

            // Dashboard records table
            dgvEnrollmentOverview.ReadOnly = true;
            dgvEnrollmentOverview.AllowUserToAddRows = false;
            dgvEnrollmentOverview.AllowUserToDeleteRows = false;

            dgvEnrollmentOverview.AutoGenerateColumns = true;
            dgvEnrollmentOverview.Columns.Clear();

            dgvEnrollmentOverview.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ====================================
        // SETUP MDI PARENT
        // ====================================

        private void SetupMdi()
        {
            this.IsMdiContainer = true;

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    mdiArea = (MdiClient)control;
                    break;
                }
            }

            if (mdiArea != null)
            {
                mdiArea.Dock = DockStyle.None;
                mdiArea.Anchor =
                    AnchorStyles.Top |
                    AnchorStyles.Bottom |
                    AnchorStyles.Left |
                    AnchorStyles.Right;

                ResizeMdiArea();

                mdiArea.BackColor = Color.WhiteSmoke;

                // Dashboard home is visible initially
                mdiArea.Visible = false;
            }

            this.Resize += (s, e) => ResizeMdiArea();

            this.MdiChildActivate += (s, e) =>
            {
                if (this.MdiChildren.Length == 0)
                {
                    if (mdiArea != null)
                        mdiArea.Visible = false;

                    RefreshDashboard();
                }
            };
        }
        private void ResizeMdiArea()
        {
            if (mdiArea == null)
                return;

            // Keep the blue sidebar visible
            int sidebarWidth = 116;

            // Fill the entire space beside the sidebar
            mdiArea.SetBounds(
                sidebarWidth,
                0,
                this.ClientSize.Width - sidebarWidth,
                this.ClientSize.Height
            );

            mdiArea.BackColor = Color.WhiteSmoke;
        }

        // ====================================
        // OPEN MDI CHILD FORMS
        // ====================================

        private void OpenChildForm<T>()
            where T : Form, new()
        {
            // If the requested form is already open,
            // activate it instead of opening another.
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm is T)
                {
                    openForm.Activate();
                    return;
                }
            }

            // Close the previously opened module
            Form[] openForms = this.MdiChildren;

            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }

            // Open the new module
            T child = new T();

            PrepareChildLayout(child);

            child.MdiParent = this;
            child.FormBorderStyle = FormBorderStyle.None;
            child.WindowState = FormWindowState.Maximized;
            child.Show();

            if (mdiArea != null)
            {
                mdiArea.Visible = true;
                mdiArea.BringToFront();
            }

            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        // Adjust child layout for the MDI content area
        private void PrepareChildLayout(Form child)
        {
            int originalWidth = child.ClientSize.Width;
            int originalHeight = child.ClientSize.Height;
            int sidebarWidth = 0;

            // Enrollment form already has its own sidebar.
            // Hide it because Dashboard has a sidebar.
            Control[] sidebars =
                child.Controls.Find("panelSidebar", false);

            if (sidebars.Length > 0)
            {
                Control sidebar = sidebars[0];

                sidebarWidth = sidebar.Width;
                sidebar.Visible = false;

                foreach (Control control in child.Controls)
                {
                    if (control != sidebar)
                    {
                        control.Left -= sidebarWidth;
                    }
                }
            }

            // Enable scrolling for larger child forms
            child.AutoScroll = true;

            child.AutoScrollMinSize = new Size(
                Math.Max(650, originalWidth - sidebarWidth),
                Math.Max(420, originalHeight)
            );
        }

        // ====================================
        // DASHBOARD HOME
        // ====================================

        private void ShowDashboardHome()
        {
            Form[] openForms = this.MdiChildren;

            foreach (Form form in openForms)
            {
                form.Close();
            }

            if (mdiArea != null)
                mdiArea.Visible = false;

            RefreshDashboard();
        }

        // Connect to the Dashboard navigation button
        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboardHome();
        }

        // ====================================
        // STUDENTS BUTTON
        // ====================================

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm<StudentModuleUI>();
        }

        // ====================================
        // ENROLLMENT BUTTON
        // ====================================

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm<EnrollmentModuleUI>();
        }

        // ====================================
        // SECTIONS BUTTON
        // ====================================

        private void btnSections_Click(object sender, EventArgs e)
        {
            OpenChildForm<DataBase_Module_UI>();
        }

        // ====================================
        // OTHER NAVIGATION BUTTONS
        // ====================================

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Assessment module is not connected yet.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Payments module is not connected yet.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Reports module is not connected yet.");
        }

        // ====================================
        // DATABASE DASHBOARD REFRESH
        // ====================================

        private void RefreshDashboard()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(
                        DatabaseConnection.ConnectionString))
                {
                    connection.Open();

                    // Dashboard counters
                    string sql = @"
                        SELECT
                            (SELECT COUNT(*)
                             FROM dbo.Students)
                                AS TotalStudents,

                            (SELECT COUNT(*)
                             FROM dbo.Enrollments)
                                AS TotalEnrollments,

                            (SELECT COUNT(*)
                             FROM dbo.Sections
                             WHERE IsActive = 1)
                                AS ActiveSections";

                    using (SqlCommand command =
                        new SqlCommand(sql, connection))
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalStudentsValue.Text =
                                reader["TotalStudents"].ToString();

                            lblTotalEnrollmentsValue.Text =
                                reader["TotalEnrollments"].ToString();

                            lblActiveSectionsValue.Text =
                                reader["ActiveSections"].ToString();
                        }
                    }

                    // Display saved student information
                    string studentSql = @"
                        SELECT
                            StudentID AS [Student ID],
                            FullName AS [Full Name],
                            Gender,
                            DateOfBirth AS [Date of Birth],
                            Address,
                            ContactNumber AS [Contact Number],
                            EmailAddress AS [Email Address]
                        FROM dbo.Students
                        ORDER BY StudentID DESC";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(studentSql, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvEnrollmentOverview.DataSource = table;
                        dgvEnrollmentOverview.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                refreshTimer.Stop();

                MessageBox.Show(
                    "Dashboard database error:\n" + ex.Message);
            }
        }

        // Keep existing DataGridView event
        private void dgvEnrollmentOverview_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
