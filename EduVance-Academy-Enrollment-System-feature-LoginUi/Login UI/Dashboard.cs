
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class Dashboard : Form
    {
        private Timer refreshTimer = new Timer();

        public Dashboard()
        {
            InitializeComponent();

            // Refresh dashboard every 5 seconds
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

            // DataGridView settings
            dgvEnrollmentOverview.ReadOnly = true;
            dgvEnrollmentOverview.AllowUserToAddRows = false;
            dgvEnrollmentOverview.AllowUserToDeleteRows = false;

            dgvEnrollmentOverview.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEnrollmentOverview.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEnrollmentOverview.AutoGenerateColumns = true;

            // Remove default Column1
            dgvEnrollmentOverview.DataSource = null;
            dgvEnrollmentOverview.Columns.Clear();
        }

        // REFRESH DASHBOARD INFORMATION
        private void RefreshDashboard()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    connection.Open();

                    // DASHBOARD COUNTS
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
                    {
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
                    }

                    // DISPLAY SAVED STUDENTS
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

                        // Display saved information
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

        // STUDENTS BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            using (StudentModuleUI student = new StudentModuleUI())
            {
                student.ShowDialog();
            }

            // Refresh dashboard after Student Module closes
            RefreshDashboard();
        }

        // ENROLLMENT BUTTON
        private void button3_Click(object sender, EventArgs e)
        {

        }

        // ASSESSMENT BUTTON
        private void button4_Click(object sender, EventArgs e)
        {

        }

        // PAYMENTS BUTTON
        private void button5_Click(object sender, EventArgs e)
        {

        }

        // REPORTS BUTTON
        private void button6_Click(object sender, EventArgs e)
        {

        }

        // DATAGRIDVIEW EVENT
        private void dgvEnrollmentOverview_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
