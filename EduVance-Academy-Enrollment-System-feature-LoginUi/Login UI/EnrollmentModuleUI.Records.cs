
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class EnrollmentModuleUI
    {
        private DataTable enrollmentRecordsAll =
            new DataTable();

        private int enrollmentPage = 0;
        private const int EnrollmentPageSize = 15;
        private bool loadingRecordFilters = false;

        // =====================================
        // SETUP RECORDS CONTROLS
        // =====================================

        private void SetupEnrollmentRecords()
        {
            dgvEnrollmentRecords.ReadOnly = true;
            dgvEnrollmentRecords.AllowUserToAddRows = false;
            dgvEnrollmentRecords.AllowUserToDeleteRows = false;
            dgvEnrollmentRecords.MultiSelect = false;

            dgvEnrollmentRecords.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEnrollmentRecords.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            cmbFilterGrade.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbFilterSection.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Search automatically while typing
            txtSearchStudent.TextChanged +=
                (s, e) => LoadEnrollmentRecords();

            txtSearchID.TextChanged +=
                (s, e) => LoadEnrollmentRecords();

            // Filter by grade and section
            cmbFilterGrade.SelectedIndexChanged +=
                (s, e) => LoadEnrollmentRecords();

            cmbFilterSection.SelectedIndexChanged +=
                (s, e) => LoadEnrollmentRecords();

            // Previous page
            btnPrev.Click += (s, e) =>
            {
                if (enrollmentPage > 0)
                {
                    enrollmentPage--;
                    DisplayEnrollmentPage();
                }
            };

            // Next page
            btnNext.Click += (s, e) =>
            {
                int pageCount = GetEnrollmentPageCount();

                if (enrollmentPage + 1 < pageCount)
                {
                    enrollmentPage++;
                    DisplayEnrollmentPage();
                }
            };

            // Double-click copies the student ID
            // into the Enrollment Form.
            dgvEnrollmentRecords.CellDoubleClick +=
                (s, e) =>
                {
                    if (e.RowIndex < 0)
                        return;

                    DataGridViewRow row =
                        dgvEnrollmentRecords.Rows[e.RowIndex];

                    txtStudentID.Text =
                        Convert.ToString(
                            row.Cells["StudentID"].Value);

                    groupBoxForm.Text =
                        "Enrollment Form - " +
                        Convert.ToString(
                            row.Cells["FullName"].Value);
                };

            // Load records when the form opens
            this.Shown += (s, e) =>
            {
                RefreshEnrollmentRecords();
            };

            // Refresh after Save or confirmation
            btnSave.Click += (s, e) =>
            {
                RefreshEnrollmentRecords();
            };

            btnYes.Click += (s, e) =>
            {
                RefreshEnrollmentRecords();
            };
        }

        // =====================================
        // LOAD FILTER OPTIONS
        // =====================================

        private void LoadEnrollmentFilters()
        {
            loadingRecordFilters = true;

            string previousGrade =
                cmbFilterGrade.Text;

            string previousSection =
                cmbFilterSection.Text;

            try
            {
                cmbFilterGrade.DataSource = null;
                cmbFilterSection.DataSource = null;

                cmbFilterGrade.Items.Clear();
                cmbFilterSection.Items.Clear();

                cmbFilterGrade.Items.Add("All Grades");
                cmbFilterSection.Items.Add("All Sections");

                using (SqlConnection connection =
                    new SqlConnection(
                        DatabaseConnection.ConnectionString))
                {
                    connection.Open();

                    // Grades from existing enrollments
                    string gradeSql = @"
                        SELECT DISTINCT GradeLevel
                        FROM dbo.Enrollments
                        WHERE GradeLevel IS NOT NULL
                        ORDER BY GradeLevel;";

                    using (SqlCommand command =
                        new SqlCommand(
                            gradeSql, connection))
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFilterGrade.Items.Add(
                                reader["GradeLevel"].ToString());
                        }
                    }

                    // Sections from database
                    string sectionSql = @"
                        SELECT SectionName
                        FROM dbo.Sections
                        ORDER BY SectionName;";

                    using (SqlCommand command =
                        new SqlCommand(
                            sectionSql, connection))
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbFilterSection.Items.Add(
                                reader["SectionName"].ToString());
                        }
                    }
                }

                int gradeIndex =
                    cmbFilterGrade.FindStringExact(
                        previousGrade);

                cmbFilterGrade.SelectedIndex =
                    gradeIndex >= 0 ? gradeIndex : 0;

                int sectionIndex =
                    cmbFilterSection.FindStringExact(
                        previousSection);

                cmbFilterSection.SelectedIndex =
                    sectionIndex >= 0 ? sectionIndex : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load enrollment filters:\n"
                    + ex.Message);
            }
            finally
            {
                loadingRecordFilters = false;
            }
        }

        // =====================================
        // SEARCH AND FILTER SQL RECORDS
        // =====================================

        private void LoadEnrollmentRecords()
        {
            if (loadingRecordFilters)
                return;

            string studentName =
                txtSearchStudent.Text.Trim();

            string studentID =
                txtSearchID.Text.Trim();

            string grade = cmbFilterGrade.Text;

            string section = cmbFilterSection.Text;

            if (string.IsNullOrWhiteSpace(grade))
                grade = "All Grades";

            if (string.IsNullOrWhiteSpace(section))
                section = "All Sections";

            string sql = @"
                SELECT
                    e.EnrollmentID,
                    e.StudentID,
                    s.FullName,
                    e.SchoolYear,
                    e.GradeLevel,
                    sec.SectionName,
                    e.EnrollmentDate,
                    e.EnrollmentType,
                    e.EnrollmentStatus

                FROM dbo.Enrollments e

                INNER JOIN dbo.Students s
                    ON e.StudentID = s.StudentID

                LEFT JOIN dbo.Sections sec
                    ON e.SectionID = sec.SectionID

                WHERE
                    s.FullName LIKE @StudentName

                    AND CONVERT(
                        NVARCHAR(20), e.StudentID
                    ) LIKE @StudentID

                    AND
                    (
                        @Grade = 'All Grades'
                        OR e.GradeLevel = @Grade
                    )

                    AND
                    (
                        @Section = 'All Sections'
                        OR sec.SectionName = @Section
                    )

                ORDER BY e.EnrollmentID DESC;";

            try
            {
                DataTable records = new DataTable();

                using (SqlConnection connection =
                    new SqlConnection(
                        DatabaseConnection.ConnectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@StudentName",
                        SqlDbType.NVarChar, 250).Value =
                        "%" + EscapeSearchText(studentName) + "%";

                    adapter.SelectCommand.Parameters.Add(
                        "@StudentID",
                        SqlDbType.NVarChar, 50).Value =
                        "%" + EscapeSearchText(studentID) + "%";

                    adapter.SelectCommand.Parameters.Add(
                        "@Grade",
                        SqlDbType.NVarChar, 50).Value =
                        grade;

                    adapter.SelectCommand.Parameters.Add(
                        "@Section",
                        SqlDbType.NVarChar, 100).Value =
                        section;

                    adapter.Fill(records);
                }

                enrollmentRecordsAll = records;
                enrollmentPage = 0;

                DisplayEnrollmentPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load enrollment records:\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Treat LIKE wildcard characters literally
        private string EscapeSearchText(string value)
        {
            return value
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("_", "[_]");
        }

        // =====================================
        // PAGINATION
        // =====================================

        private int GetEnrollmentPageCount()
        {
            if (enrollmentRecordsAll.Rows.Count == 0)
                return 0;

            return (enrollmentRecordsAll.Rows.Count
                + EnrollmentPageSize - 1)
                / EnrollmentPageSize;
        }

        private void DisplayEnrollmentPage()
        {
            DataTable pageTable =
                enrollmentRecordsAll.Clone();

            int start =
                enrollmentPage * EnrollmentPageSize;

            int end = Math.Min(
                start + EnrollmentPageSize,
                enrollmentRecordsAll.Rows.Count);

            for (int i = start; i < end; i++)
            {
                pageTable.ImportRow(
                    enrollmentRecordsAll.Rows[i]);
            }

            dgvEnrollmentRecords.DataSource = null;
            dgvEnrollmentRecords.DataSource = pageTable;

            // Column names shown in the table
            RenameEnrollmentColumn(
                "StudentID", "Student ID");

            RenameEnrollmentColumn(
                "FullName", "Student Name");

            RenameEnrollmentColumn(
                "SchoolYear", "School Year");

            RenameEnrollmentColumn(
                "GradeLevel", "Grade Level");

            RenameEnrollmentColumn(
                "SectionName", "Section");

            RenameEnrollmentColumn(
                "EnrollmentDate", "Enrollment Date");

            RenameEnrollmentColumn(
                "EnrollmentType", "Type");

            RenameEnrollmentColumn(
                "EnrollmentStatus", "Status");

            if (dgvEnrollmentRecords.Columns.Contains(
                "EnrollmentID"))
            {
                dgvEnrollmentRecords.Columns[
                    "EnrollmentID"].Visible = false;
            }

            if (dgvEnrollmentRecords.Columns.Contains(
                "EnrollmentDate"))
            {
                dgvEnrollmentRecords.Columns[
                    "EnrollmentDate"]
                    .DefaultCellStyle.Format = "MMM dd, yyyy";
            }

            dgvEnrollmentRecords.ClearSelection();

            int pageCount = GetEnrollmentPageCount();

            btnPrev.Enabled = enrollmentPage > 0;

            btnNext.Enabled =
                enrollmentPage + 1 < pageCount;

            groupBoxRecords.Text =
                "Enrollment Records (" +
                enrollmentRecordsAll.Rows.Count +
                " records | Page " +
                (pageCount == 0
                    ? 0
                    : enrollmentPage + 1) +
                " of " + pageCount + ")";
        }

        private void RenameEnrollmentColumn(
            string columnName,
            string newHeader)
        {
            if (dgvEnrollmentRecords.Columns.Contains(
                columnName))
            {
                dgvEnrollmentRecords.Columns[
                    columnName].HeaderText = newHeader;
            }
        }

        // =====================================
        // MANUAL REFRESH
        // =====================================

        private void RefreshEnrollmentRecords()
        {
            LoadEnrollmentFilters();
            LoadEnrollmentRecords();
        }
    }
}
