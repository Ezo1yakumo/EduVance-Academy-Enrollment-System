
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

            // Maximize Dashboard
            this.WindowState = FormWindowState.Maximized;

            // Setup MDI system
            SetupMdi();

            // Dashboard database refresh every 5 seconds
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, e) => RefreshDashboard();

            this.Shown += (s, e) =>
            {
                ResizeMdiArea();
                RefreshDashboard();
                refreshTimer.Start();
            };

            this.FormClosed += (s, e) =>
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
            };

            // Configure Dashboard DataGridView
            dgvEnrollmentOverview.ReadOnly = true;
            dgvEnrollmentOverview.AllowUserToAddRows = false;
            dgvEnrollmentOverview.AllowUserToDeleteRows = false;
            dgvEnrollmentOverview.AutoGenerateColumns = true;
            dgvEnrollmentOverview.Columns.Clear();

            dgvEnrollmentOverview.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEnrollmentOverview.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
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
                mdiArea.Anchor = AnchorStyles.None;
                mdiArea.BackColor = Color.WhiteSmoke;

                ResizeMdiArea();

                // Hide MDI while Dashboard is open
                mdiArea.Visible = false;
            }

            // Adjust MDI when Dashboard changes size
            this.Resize += (s, e) =>
            {
                ResizeMdiArea();
            };

            // Return to Dashboard when no child is open
            this.MdiChildActivate += (s, e) =>
            {
                if (this.MdiChildren.Length == 0)
                {
                    if (mdiArea != null)
                        mdiArea.Visible = false;

                    pnlDashboardHome.Visible = true;
                }
            };
        }

        // ====================================
        // RESPONSIVE MDI AREA
        // ====================================

        private void ResizeMdiArea()
        {
            if (mdiArea == null)
                return;

            // Get actual sidebar position and width
            int sidebarRight =
                layoutRoot.Left + pnlSidebar.Right;

            int top = layoutRoot.Top;

            // Available content area
            int contentWidth =
                Math.Max(1, this.ClientSize.Width - sidebarRight);

            int contentHeight =
                Math.Max(1, this.ClientSize.Height - top);

            mdiArea.SetBounds(
                sidebarRight,
                top,
                contentWidth,
                contentHeight
            );

            mdiArea.BackColor = Color.WhiteSmoke;
        }

        // ====================================
        // OPEN MDI CHILD FORMS
        // ====================================

        private void OpenChildForm<T>()
            where T : Form, new()
        {
            // Check if requested child is already open
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm is T)
                {
                    pnlDashboardHome.Visible = false;

                    if (mdiArea != null)
                    {
                        ResizeMdiArea();
                        mdiArea.Visible = true;
                        mdiArea.BringToFront();
                    }

                    openForm.Activate();
                    return;
                }
            }

            // Close previously opened modules
            Form[] openForms = this.MdiChildren;

            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }

            // Hide Dashboard content
            pnlDashboardHome.Visible = false;

            // Show MDI content area
            if (mdiArea != null)
            {
                ResizeMdiArea();
                mdiArea.Visible = true;
                mdiArea.BringToFront();
            }

            // Create child form
            T child = new T();

            PrepareChildLayout(child);

            child.MdiParent = this;
            child.FormBorderStyle = FormBorderStyle.None;
            child.WindowState = FormWindowState.Maximized;

            // Show child only once
            child.Show();

            // Make sure it fills the content area
            ResizeMdiArea();

            child.Activate();
        }

        // ====================================
        // PREPARE CHILD FORM LAYOUT
        // ====================================

        private void PrepareChildLayout(Form child)
        {
            // Allow scrolling if child controls need space
            child.AutoScroll = true;
            child.AutoScrollMinSize = Size.Empty;

            // Look for the child's old sidebar
            Control[] sidebars =
                child.Controls.Find("panelSidebar", false);

            if (sidebars.Length > 0)
            {
                Control sidebar = sidebars[0];

                int sidebarWidth = sidebar.Width;

                // Hide duplicate sidebar
                sidebar.Visible = false;

                // Move other controls to the left
                foreach (Control control in child.Controls)
                {
                    if (control != sidebar &&
                        control.Dock == DockStyle.None &&
                        control.Left >= sidebarWidth)
                    {
                        control.Left -= sidebarWidth;
                    }
                }
            }
        }

        // ====================================
        // SHOW DASHBOARD HOME
        // ====================================

        private void ShowDashboardHome()
        {
            // Close all MDI child forms
            Form[] openForms = this.MdiChildren;

            foreach (Form form in openForms)
            {
                form.Close();
            }

            // Hide MDI area
            if (mdiArea != null)
            {
                mdiArea.Visible = false;
            }

            // Show responsive Dashboard content
            pnlDashboardHome.Visible = true;
            pnlDashboardHome.BringToFront();

            // Refresh information
            RefreshDashboard();
        }

        // ====================================
        // DASHBOARD BUTTON
        // ====================================

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
        // ASSESSMENT BUTTON
        // ====================================

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Assessment module is not connected yet.");
        }

        // ====================================
        // PAYMENTS BUTTON
        // ====================================

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Payments module is not connected yet.");
        }

        // ====================================
        // REPORTS BUTTON
        // ====================================

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Reports module is not connected yet.");
        }

        // ====================================
        // REFRESH DASHBOARD DATABASE
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

                    // GET TOTAL STUDENTS, ENROLLMENTS,
                    // AND ACTIVE SECTIONS

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

                    // LOAD SAVED STUDENT RECORDS

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

        // ====================================
        // DATAGRIDVIEW EVENT
        // ====================================

        private void dgvEnrollmentOverview_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }
}
