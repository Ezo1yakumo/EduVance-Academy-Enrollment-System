using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class ReportsModuleUI : Form
    {
        private const int PageSize = 20;
        private string userRole = "";
        private string username = "";
        private bool initializingFilters;
        private bool initialized;
        private int page = 1;
        private int totalRecords;
        private ReportFilter activeFilter;
        private DataTable pageData;

        private sealed class SectionOption
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() { return Name; }
        }

        private sealed class ReportFilter
        {
            public string Type;
            public string SchoolYear;
            public string Grade;
            public int SectionId;
            public string SectionName;
            public int StudentId;
            public string StudentName;

            public string Description
            {
                get
                {
                    return "School Year: " + SchoolYear + "   |   Grade: " +
                        (Grade.Length == 0 ? "All" : Grade) +
                        "   |   Section: " + SectionName +
                        (StudentId == 0 ? "" : "   |   ID: " + StudentId) +
                        (StudentName.Length == 0 ? "" : "   |   Name: " + StudentName);
                }
            }
        }

        public ReportsModuleUI()
        {
            InitializeComponent();
            ConfigureGrid();

            btnGenerate.Click += (s, e) => GenerateReport();
            btnClear.Click += (s, e) => ClearFilters();
            btnRefresh.Click += (s, e) => RefreshOptions();
            btnPrevious.Click += (s, e) => ChangePage(-1);
            btnNext.Click += (s, e) => ChangePage(1);
            btnPrintPreview.Click += (s, e) => PrintOrPreview(true);
            btnPrint.Click += (s, e) => PrintOrPreview(false);
            btnExport.Click += (s, e) => ExportCsv();
            cmbSchoolYear.SelectedIndexChanged += (s, e) => LoadGradeAndSectionOptions();
            txtStudentId.KeyDown += SearchOnEnter;
            txtStudentName.KeyDown += SearchOnEnter;
            Shown += (s, e) =>
            {
                initialized = true;
                ConfigureRole();
                if (CanAccess()) LoadSchoolYears();
            };

            ResetResults();
        }

        // Call from Dashboard.OpenChildForm<T>() immediately after creating the child.
        public void SetUserContext(string role, string loggedInUsername)
        {
            userRole = (role ?? "").Trim();
            username = (loggedInUsername ?? "").Trim();
            if (initialized)
            {
                ConfigureRole();
                if (CanAccess()) LoadSchoolYears();
            }
        }

        private bool IsAdmin()
        {
            return userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                   userRole.Equals("Administrator", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsRegistrar()
        {
            return userRole.Equals("Registrar", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsCashier()
        {
            return userRole.Equals("Cashier", StringComparison.OrdinalIgnoreCase);
        }

        private bool CanAccess() { return IsAdmin() || IsRegistrar() || IsCashier(); }

        private bool CanAccessReport(string type)
        {
            if (IsAdmin()) return true;
            if (IsRegistrar()) return type != "Payment Report";
            return IsCashier() && type == "Payment Report";
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(DatabaseConnection.ConnectionString);
        }

        private void ConfigureGrid()
        {
            dgvResults.AutoGenerateColumns = true;
            dgvResults.ReadOnly = true;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.MultiSelect = false;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.DataBindingComplete += (s, e) => FormatGrid();
        }

        private void ConfigureRole()
        {
            bool allowed = CanAccess();
            lblRole.Text = allowed ? userRole.ToUpperInvariant() + "  •  READ ONLY" : "ACCESS RESTRICTED";
            cmbReportType.Enabled = allowed;
            cmbSchoolYear.Enabled = allowed;
            cmbGrade.Enabled = allowed;
            cmbSection.Enabled = allowed;
            txtStudentId.Enabled = allowed;
            txtStudentName.Enabled = allowed;
            btnGenerate.Enabled = allowed;
            btnClear.Enabled = allowed;
            btnRefresh.Enabled = allowed;

            initializingFilters = true;
            cmbReportType.Items.Clear();
            if (IsAdmin() || IsRegistrar())
            {
                cmbReportType.Items.Add("Student Information Report");
                cmbReportType.Items.Add("Enrollment Report");
                cmbReportType.Items.Add("Section Report");
            }
            if (IsAdmin() || IsCashier())
                cmbReportType.Items.Add("Payment Report");
            if (cmbReportType.Items.Count > 0) cmbReportType.SelectedIndex = 0;
            initializingFilters = false;

            if (!allowed)
            {
                ResetResults();
                txtPreview.Text = "Authorized personnel only. Please sign in as Admin, Registrar, or Cashier.";
            }
            UpdateButtons();
        }

        private void SearchOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            GenerateReport();
        }

        private void LoadSchoolYears()
        {
            if (!CanAccess()) return;
            string previous = Convert.ToString(cmbSchoolYear.SelectedItem);
            initializingFilters = true;
            try
            {
                cmbSchoolYear.Items.Clear();
                const string sql = @"
                    SELECT DISTINCT SchoolYear FROM
                    (
                        SELECT SchoolYear FROM dbo.Enrollments
                        UNION ALL
                        SELECT SchoolYear FROM dbo.Assessments
                    ) y
                    WHERE SchoolYear IS NOT NULL AND LTRIM(RTRIM(SchoolYear)) <> ''
                    ORDER BY SchoolYear DESC;";

                using (SqlConnection connection = GetConnection())
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read()) cmbSchoolYear.Items.Add(reader.GetString(0));
                }
                if (!string.IsNullOrEmpty(previous) && cmbSchoolYear.Items.Contains(previous))
                    cmbSchoolYear.SelectedItem = previous;
                else if (cmbSchoolYear.Items.Count > 0)
                    cmbSchoolYear.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cannot load school years:\n" + ex.Message,
                    "Reports Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { initializingFilters = false; }
            LoadGradeAndSectionOptions();
        }

        private void LoadGradeAndSectionOptions()
        {
            if (initializingFilters || !CanAccess()) return;
            string year = Convert.ToString(cmbSchoolYear.SelectedItem) ?? "";
            initializingFilters = true;
            try
            {
                cmbGrade.Items.Clear();
                cmbGrade.Items.Add("All Grades");
                cmbSection.Items.Clear();
                cmbSection.Items.Add(new SectionOption { Id = 0, Name = "All Sections" });
                if (year.Length > 0)
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(@"
                            SELECT DISTINCT GradeLevel
                            FROM dbo.Enrollments
                            WHERE SchoolYear = @Year AND GradeLevel IS NOT NULL
                              AND LTRIM(RTRIM(GradeLevel)) <> ''
                            ORDER BY GradeLevel;", connection))
                        {
                            command.Parameters.Add("@Year", SqlDbType.NVarChar, 50).Value = year;
                            using (SqlDataReader reader = command.ExecuteReader())
                                while (reader.Read()) cmbGrade.Items.Add(reader.GetString(0));
                        }
                        using (SqlCommand command = new SqlCommand(@"
                            SELECT DISTINCT sec.SectionID, sec.SectionName
                            FROM dbo.Sections sec
                            INNER JOIN dbo.Enrollments e ON e.SectionID = sec.SectionID
                            WHERE e.SchoolYear = @Year
                            ORDER BY sec.SectionName;", connection))
                        {
                            command.Parameters.Add("@Year", SqlDbType.NVarChar, 50).Value = year;
                            using (SqlDataReader reader = command.ExecuteReader())
                                while (reader.Read())
                                    cmbSection.Items.Add(new SectionOption
                                    {
                                        Id = Convert.ToInt32(reader[0]),
                                        Name = Convert.ToString(reader[1])
                                    });
                        }
                    }
                }
                cmbGrade.SelectedIndex = 0;
                cmbSection.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cannot load grade/section filters:\n" + ex.Message,
                    "Reports Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { initializingFilters = false; }
        }

        private void RefreshOptions()
        {
            if (!CanAccess()) return;
            LoadSchoolYears();
            if (activeFilter != null) LoadPage();
        }

        private void ClearFilters()
        {
            if (!CanAccess()) return;
            if (cmbReportType.Items.Count > 0) cmbReportType.SelectedIndex = 0;
            if (cmbSchoolYear.Items.Count > 0) cmbSchoolYear.SelectedIndex = 0;
            if (cmbGrade.Items.Count > 0) cmbGrade.SelectedIndex = 0;
            if (cmbSection.Items.Count > 0) cmbSection.SelectedIndex = 0;
            txtStudentId.Clear();
            txtStudentName.Clear();
            ResetResults();
        }

        private void ResetResults()
        {
            activeFilter = null;
            page = 1;
            totalRecords = 0;
            pageData = null;
            dgvResults.DataSource = null;
            lblResults.Text = "No report generated";
            lblPage.Text = "Page 1 of 1";
            lblPreviewType.Text = "Report Preview";
            lblPreviewFilters.Text = "Select a report type and school year.";
            txtPreview.Text = "Generate a report to preview its records here.";
            UpdateButtons();
        }

        private ReportFilter ReadFilter()
        {
            if (!CanAccess()) return null;
            string type = Convert.ToString(cmbReportType.SelectedItem) ?? "";
            string schoolYear = Convert.ToString(cmbSchoolYear.SelectedItem) ?? "";
            if (type.Length == 0 || schoolYear.Length == 0)
            {
                MessageBox.Show(this, "Select a Report Type and School Year.",
                    "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            if (!CanAccessReport(type))
            {
                MessageBox.Show(this, "Your role cannot access this report type.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            int studentId = 0;
            string rawId = txtStudentId.Text.Trim();
            if (rawId.Length > 0 && (!int.TryParse(rawId, out studentId) || studentId <= 0))
            {
                MessageBox.Show(this, "Enter a valid positive numeric Student ID.",
                    "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return null;
            }
            if (txtStudentName.Text.Trim().Length > 100)
            {
                MessageBox.Show(this, "Student Name search must be 100 characters or fewer.",
                    "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            SectionOption section = cmbSection.SelectedItem as SectionOption;
            return new ReportFilter
            {
                Type = type,
                SchoolYear = schoolYear,
                Grade = cmbGrade.SelectedIndex <= 0 ? "" : Convert.ToString(cmbGrade.SelectedItem),
                SectionId = section == null ? 0 : section.Id,
                SectionName = section == null ? "All Sections" : section.Name,
                StudentId = studentId,
                StudentName = txtStudentName.Text.Trim()
            };
        }

        private void GenerateReport()
        {
            ReportFilter filter = ReadFilter();
            if (filter == null) return;
            activeFilter = filter;
            page = 1;
            LoadPage();
        }

        private static string CommonFilter(string yearColumn, string gradeColumn, string sectionColumn)
        {
            return " WHERE " + yearColumn + " = @SchoolYear" +
                   " AND (@Grade = '' OR " + gradeColumn + " = @Grade)" +
                   " AND (@SectionId = 0 OR " + sectionColumn + " = @SectionId)" +
                   " AND (@StudentId = 0 OR s.StudentID = @StudentId)" +
                   " AND (@StudentName = '' OR s.FullName LIKE '%' + @StudentName + '%')";
        }

        private string BuildCoreQuery(string type)
        {
            if (type == "Student Information Report")
            {
                return @"
                    SELECT s.StudentID AS [Student ID],
                           s.FullName AS [Student Name],
                           s.Gender AS [Gender],
                           en.GradeLevel AS [Grade Level],
                           COALESCE(sec.SectionName, 'Unassigned') AS [Section],
                           en.SchoolYear AS [School Year]
                    FROM dbo.Students s
                    CROSS APPLY
                    (
                        SELECT TOP (1) e.StudentID, e.GradeLevel, e.SectionID, e.SchoolYear
                        FROM dbo.Enrollments e
                        WHERE e.StudentID = s.StudentID AND e.SchoolYear = @SchoolYear
                        ORDER BY e.EnrollmentDate DESC, e.EnrollmentID DESC
                    ) en
                    LEFT JOIN dbo.Sections sec ON sec.SectionID = en.SectionID" +
                    CommonFilter("en.SchoolYear", "en.GradeLevel", "en.SectionID");
            }
            if (type == "Enrollment Report")
            {
                return @"
                    SELECT e.EnrollmentID AS [Enrollment ID],
                           s.StudentID AS [Student ID],
                           s.FullName AS [Student Name],
                           e.GradeLevel AS [Grade Level],
                           COALESCE(sec.SectionName, 'Unassigned') AS [Section],
                           e.SchoolYear AS [School Year],
                           e.EnrollmentDate AS [Enrollment Date],
                           COALESCE(e.EnrollmentType, '') AS [Type],
                           COALESCE(e.EnrollmentStatus, '') AS [Status]
                    FROM dbo.Enrollments e
                    INNER JOIN dbo.Students s ON s.StudentID = e.StudentID
                    LEFT JOIN dbo.Sections sec ON sec.SectionID = e.SectionID" +
                    CommonFilter("e.SchoolYear", "e.GradeLevel", "e.SectionID");
            }
            if (type == "Section Report")
            {
                return @"
                    SELECT COALESCE(sec.SectionName, 'Unassigned') AS [Section],
                           e.GradeLevel AS [Grade Level],
                           e.SchoolYear AS [School Year],
                           COUNT(DISTINCT e.StudentID) AS [Student Count]
                    FROM dbo.Enrollments e
                    INNER JOIN dbo.Students s ON s.StudentID = e.StudentID
                    LEFT JOIN dbo.Sections sec ON sec.SectionID = e.SectionID" +
                    CommonFilter("e.SchoolYear", "e.GradeLevel", "e.SectionID") +
                    " GROUP BY sec.SectionName, e.GradeLevel, e.SchoolYear";
            }
            if (type == "Payment Report")
            {
                return @"
                    SELECT p.PaymentID AS [Payment ID],
                           s.StudentID AS [Student ID],
                           s.FullName AS [Student Name],
                           a.SchoolYear AS [School Year],
                           en.GradeLevel AS [Grade Level],
                           COALESCE(sec.SectionName, 'Unassigned') AS [Section],
                           p.PaymentDate AS [Payment Date],
                           COALESCE(p.ReceiptNumber, '') AS [Receipt Number],
                           p.AmountChange AS [Amount Change],
                           COALESCE(p.PaymentMethod, '') AS [Method],
                           p.RemainingBalanceAfter AS [Balance After],
                           CASE
                             WHEN p.AmountChange < 0 THEN 'Reversal'
                             WHEN EXISTS
                               (SELECT 1 FROM dbo.AssessmentPayments rev
                                WHERE rev.ReversesPaymentID = p.PaymentID)
                               THEN 'Reversed'
                             ELSE 'Recorded'
                           END AS [Status]
                    FROM dbo.AssessmentPayments p
                    INNER JOIN dbo.Assessments a ON a.AssessmentID = p.AssessmentID
                    INNER JOIN dbo.Students s ON s.StudentID = a.StudentID
                    OUTER APPLY
                    (
                        SELECT TOP (1) e.GradeLevel, e.SectionID
                        FROM dbo.Enrollments e
                        WHERE e.StudentID = s.StudentID AND e.SchoolYear = a.SchoolYear
                        ORDER BY e.EnrollmentDate DESC, e.EnrollmentID DESC
                    ) en
                    LEFT JOIN dbo.Sections sec ON sec.SectionID = en.SectionID" +
                    CommonFilter("a.SchoolYear", "en.GradeLevel", "en.SectionID") +
                    " AND p.AmountChange <> 0";
            }
            throw new InvalidOperationException("Unsupported report type.");
        }

        private static string OrderBy(string type)
        {
            if (type == "Student Information Report") return "[Student Name], [Student ID]";
            if (type == "Enrollment Report") return "[Enrollment Date] DESC, [Enrollment ID] DESC";
            if (type == "Section Report") return "[Grade Level], [Section]";
            return "[Payment Date] DESC, [Payment ID] DESC";
        }

        private static void AddFilterParameters(SqlCommand command, ReportFilter filter)
        {
            command.Parameters.Add("@SchoolYear", SqlDbType.NVarChar, 50).Value = filter.SchoolYear;
            command.Parameters.Add("@Grade", SqlDbType.NVarChar, 100).Value = filter.Grade;
            command.Parameters.Add("@SectionId", SqlDbType.Int).Value = filter.SectionId;
            command.Parameters.Add("@StudentId", SqlDbType.Int).Value = filter.StudentId;
            command.Parameters.Add("@StudentName", SqlDbType.NVarChar, 100).Value = filter.StudentName;
        }

        private void LoadPage()
        {
            if (activeFilter == null || !CanAccessReport(activeFilter.Type)) return;
            string core = BuildCoreQuery(activeFilter.Type);
            string countSql = "SELECT COUNT(*) FROM (" + core + ") AS ReportRows;";
            string pageSql = "SELECT * FROM (" + core + ") AS ReportRows " +
                             "ORDER BY " + OrderBy(activeFilter.Type) +
                             " OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";
            try
            {
                DataTable rows = new DataTable();
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(countSql, connection))
                    {
                        AddFilterParameters(cmd, activeFilter);
                        totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    int pages = Math.Max(1, (totalRecords + PageSize - 1) / PageSize);
                    page = Math.Min(Math.Max(1, page), pages);
                    using (SqlCommand cmd = new SqlCommand(pageSql, connection))
                    {
                        AddFilterParameters(cmd, activeFilter);
                        cmd.Parameters.Add("@Offset", SqlDbType.Int).Value = (page - 1) * PageSize;
                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) adapter.Fill(rows);
                    }
                }
                pageData = rows;
                dgvResults.DataSource = rows;
                dgvResults.ClearSelection();
                lblResults.Text = totalRecords.ToString("N0") + " matching record(s)";
                lblPage.Text = "Page " + page + " of " +
                               Math.Max(1, (totalRecords + PageSize - 1) / PageSize);
                UpdatePreview();
                UpdateButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to generate report:\n" + ex.Message +
                    "\n\nConfirm the EduVance tables and Payment Module migration exist.",
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetResults();
            }
        }

        private void FormatGrid()
        {
            foreach (DataGridViewColumn column in dgvResults.Columns)
            {
                if (column.Name == "Amount Change" || column.Name == "Balance After")
                {
                    column.DefaultCellStyle.Format = "N2";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else if (column.Name == "Payment Date" || column.Name == "Enrollment Date")
                    column.DefaultCellStyle.Format = "MMM dd, yyyy";
                column.MinimumWidth = 75;
            }
        }

        private void ChangePage(int amount)
        {
            if (activeFilter == null) return;
            int pages = Math.Max(1, (totalRecords + PageSize - 1) / PageSize);
            int newPage = page + amount;
            if (newPage < 1 || newPage > pages) return;
            page = newPage;
            LoadPage();
        }

        private void UpdateButtons()
        {
            int pages = Math.Max(1, (totalRecords + PageSize - 1) / PageSize);
            bool hasReport = activeFilter != null && CanAccessReport(activeFilter.Type);
            btnPrevious.Enabled = hasReport && page > 1;
            btnNext.Enabled = hasReport && page < pages;
            btnPrintPreview.Enabled = hasReport && totalRecords > 0;
            btnPrint.Enabled = hasReport && totalRecords > 0;
            btnExport.Enabled = hasReport && totalRecords > 0;
        }

        private static string ValueText(object value)
        {
            if (value == null || value == DBNull.Value) return "—";
            if (value is DateTime) return ((DateTime)value).ToString("MMM dd, yyyy");
            if (value is decimal) return ((decimal)value).ToString("N2", CultureInfo.GetCultureInfo("en-PH"));
            return Convert.ToString(value);
        }

        private void UpdatePreview()
        {
            if (activeFilter == null) return;
            lblPreviewType.Text = activeFilter.Type;
            lblPreviewFilters.Text = activeFilter.Description;
            StringBuilder preview = new StringBuilder();
            preview.AppendLine("EDUVANCE ACADEMY");
            preview.AppendLine(activeFilter.Type.ToUpperInvariant());
            preview.AppendLine(new string('─', 33));
            preview.AppendLine("Prepared by: " + (username.Length == 0 ? userRole : username));
            preview.AppendLine("Records: " + totalRecords.ToString("N0"));
            preview.AppendLine("Current page: " + page);
            preview.AppendLine("Generated: " + DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"));
            preview.AppendLine();
            preview.AppendLine("FILTERS");
            preview.AppendLine(activeFilter.Description);
            preview.AppendLine();
            preview.AppendLine("RESULTS (CURRENT PAGE)");
            if (pageData == null || pageData.Rows.Count == 0)
                preview.AppendLine("No records found for the selected filters.");
            else
            {
                int shown = Math.Min(9, pageData.Rows.Count);
                for (int i = 0; i < shown; i++)
                {
                    DataRow row = pageData.Rows[i];
                    preview.AppendLine((i + 1 + (page - 1) * PageSize) + ". " +
                        ValueText(row[0]));
                    for (int j = 1; j < Math.Min(row.Table.Columns.Count, 5); j++)
                        preview.AppendLine("   " + row.Table.Columns[j].ColumnName + ": " + ValueText(row[j]));
                    preview.AppendLine();
                }
                if (pageData.Rows.Count > shown)
                    preview.AppendLine("... and more rows on this page.");
            }
            preview.AppendLine();
            preview.AppendLine("Print or export to include ALL matching records.");
            txtPreview.Text = preview.ToString();
        }

        private DataTable LoadAllRows()
        {
            if (activeFilter == null || !CanAccessReport(activeFilter.Type))
                throw new InvalidOperationException("No authorized report has been generated.");
            string core = BuildCoreQuery(activeFilter.Type);
            string sql = "SELECT * FROM (" + core + ") AS ReportRows ORDER BY " +
                         OrderBy(activeFilter.Type) + ";";
            DataTable result = new DataTable();
            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                AddFilterParameters(cmd, activeFilter);
                cmd.CommandTimeout = 60;
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) adapter.Fill(result);
            }
            return result;
        }

        private static string CsvCell(object value)
        {
            string text;
            if (value == null || value == DBNull.Value) text = "";
            else if (value is DateTime) text = ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
            else if (value is IFormattable) text = ((IFormattable)value).ToString(null, CultureInfo.InvariantCulture);
            else
            {
                text = Convert.ToString(value) ?? "";
                string trimmed = text.TrimStart();
                if (trimmed.Length > 0 && (trimmed[0] == '=' || trimmed[0] == '+' ||
                    trimmed[0] == '-' || trimmed[0] == '@' || trimmed[0] == '\t'))
                    text = "'" + text;
            }
            return "\"" + text.Replace("\"", "\"\"") + "\"";
        }

        private void ExportCsv()
        {
            if (activeFilter == null || !CanAccessReport(activeFilter.Type)) return;
            try
            {
                DataTable data = LoadAllRows();
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Save EduVance Report";
                    dialog.Filter = "CSV report (*.csv)|*.csv";
                    dialog.FileName = activeFilter.Type.Replace(" ", "_") + "_" +
                        DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
                    if (dialog.ShowDialog(this) != DialogResult.OK) return;
                    using (StreamWriter writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true)))
                    {
                        for (int c = 0; c < data.Columns.Count; c++)
                        {
                            if (c > 0) writer.Write(",");
                            writer.Write(CsvCell(data.Columns[c].ColumnName));
                        }
                        writer.WriteLine();
                        foreach (DataRow row in data.Rows)
                        {
                            for (int c = 0; c < data.Columns.Count; c++)
                            {
                                if (c > 0) writer.Write(",");
                                writer.Write(CsvCell(row[c]));
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show(this, "Report saved successfully.", "Export Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to export report:\n" + ex.Message,
                    "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintOrPreview(bool previewOnly)
        {
            if (activeFilter == null || !CanAccessReport(activeFilter.Type)) return;
            try
            {
                DataTable data = LoadAllRows();
                if (data.Rows.Count == 0)
                {
                    MessageBox.Show(this, "No records to print.");
                    return;
                }
                int[] nextRow = { 0 };
                ReportFilter snapshot = activeFilter;
                using (PrintDocument document = new PrintDocument())
                {
                    document.DocumentName = "EduVance - " + snapshot.Type;
                    document.DefaultPageSettings.Landscape = true;
                    document.BeginPrint += (s, e) => nextRow[0] = 0;
                    document.PrintPage += (s, e) => DrawReportPage(e, data, snapshot, nextRow);
                    if (previewOnly)
                    {
                        using (PrintPreviewDialog dialog = new PrintPreviewDialog())
                        {
                            dialog.Document = document;
                            dialog.Width = 1020;
                            dialog.Height = 760;
                            dialog.ShowDialog(this);
                        }
                    }
                    else
                    {
                        using (PrintDialog dialog = new PrintDialog())
                        {
                            dialog.Document = document;
                            dialog.UseEXDialog = true;
                            if (dialog.ShowDialog(this) == DialogResult.OK)
                            {
                                document.PrinterSettings = dialog.PrinterSettings;
                                document.Print();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to prepare report for printing:\n" + ex.Message,
                    "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawReportPage(PrintPageEventArgs e, DataTable data,
            ReportFilter filter, int[] nextRow)
        {
            Rectangle area = e.MarginBounds;
            float y = area.Top;
            float left = area.Left;
            float width = area.Width;
            using (Font title = new Font("Segoe UI", 15F, FontStyle.Bold))
            using (Font heading = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Font normal = new Font("Segoe UI", 8F))
            using (Pen pen = new Pen(Color.LightGray))
            using (StringFormat fmt = new StringFormat())
            {
                fmt.Trimming = StringTrimming.EllipsisCharacter;
                fmt.FormatFlags = StringFormatFlags.NoWrap;
                e.Graphics.DrawString("EDUVANCE ACADEMY — " + filter.Type,
                    title, Brushes.Black, new RectangleF(left, y, width, 34));
                y += 38;
                e.Graphics.DrawString(filter.Description, normal, Brushes.DimGray,
                    new RectangleF(left, y, width, 24));
                y += 26;
                e.Graphics.DrawString("Prepared by: " + (username.Length == 0 ? userRole : username) +
                    "   |   " + DateTime.Now.ToString("MMM dd, yyyy") +
                    "   |   Records: " + data.Rows.Count,
                    normal, Brushes.DimGray, new RectangleF(left, y, width, 22));
                y += 30;

                int columns = data.Columns.Count;
                float colWidth = width / (float)columns;
                float rowHeight = 27F;
                for (int c = 0; c < columns; c++)
                {
                    float x = left + c * colWidth;
                    e.Graphics.DrawString(data.Columns[c].ColumnName, heading,
                        Brushes.Black, new RectangleF(x + 3, y, colWidth - 5, 35), fmt);
                }
                y += 35;
                e.Graphics.DrawLine(pen, left, y, left + width, y);
                y += 5;

                while (nextRow[0] < data.Rows.Count && y + rowHeight <= area.Bottom)
                {
                    DataRow row = data.Rows[nextRow[0]];
                    for (int c = 0; c < columns; c++)
                    {
                        float x = left + c * colWidth;
                        e.Graphics.DrawString(ValueText(row[c]), normal,
                            Brushes.Black, new RectangleF(x + 3, y, colWidth - 5, rowHeight), fmt);
                    }
                    nextRow[0]++;
                    y += rowHeight;
                    e.Graphics.DrawLine(pen, left, y, left + width, y);
                }
                e.HasMorePages = nextRow[0] < data.Rows.Count;
            }
        }
    }
}
