
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class SearchStudentAccountBalanceUI : Form
    {
        private DataTable allResults = new DataTable();

        private const int PageSize = 15;
        private int currentPage = 0;

        private bool loadingGrid = false;
        private string currentRole = "";

        public SearchStudentAccountBalanceUI()
        {
            InitializeComponent();

            // Search button
            btnSearch.Click += (s, e) => SearchStudents();

            // Clear search
            btnClear.Click += (s, e) =>
            {
                txtSearch.Clear();
                SearchStudents();
            };

            // Refresh current account balances
            btnRefresh.Click += (s, e) => SearchStudents();

            // Search using Enter key
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SearchStudents();
                }
            };

            // Previous page
            btnPrevious.Click += (s, e) =>
            {
                if (currentPage > 0)
                {
                    currentPage--;
                    DisplayPage();
                }
            };

            // Next page
            btnNext.Click += (s, e) =>
            {
                int totalPages = GetTotalPages();

                if (currentPage + 1 < totalPages)
                {
                    currentPage++;
                    DisplayPage();
                }
            };

            // Show account when a student is selected
            dgvAccounts.SelectionChanged += (s, e) =>
            {
                if (!loadingGrid)
                    DisplaySelectedStudent();
            };

            // Do not show private account data until
            // an authenticated user role is supplied.
            btnSearch.Enabled = false;
            btnClear.Enabled = false;
            btnRefresh.Enabled = false;
            txtSearch.Enabled = false;

            ClearAccountDetails();

            Shown += (s, e) =>
            {
                if (CanViewAccounts())
                    SearchStudents();
                else
                    lblHint.Text =
                        "Access denied. Cashier or Staff permission required.";
            };
        }

        // ===========================================
        // USER PERMISSIONS
        // ===========================================

        public void SetUserRole(string authenticatedRole)
        {
            currentRole = (authenticatedRole ?? "").Trim();

            bool allowed = CanViewAccounts();

            txtSearch.Enabled = allowed;
            btnSearch.Enabled = allowed;
            btnClear.Enabled = allowed;
            btnRefresh.Enabled = allowed;

            lblHint.Text = allowed
                ? "Search by name or Student ID, then select a record."
                : "You do not have permission to view student accounts.";

            if (Visible)
            {
                if (allowed)
                    SearchStudents();
                else
                {
                    allResults = new DataTable();
                    DisplayPage();
                    ClearAccountDetails();
                }
            }
        }

        private bool CanViewAccounts()
        {
            return currentRole.Equals(
                       "Cashier",
                       StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                       "Staff",
                       StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                       "Admin",
                       StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                       "Administrator",
                       StringComparison.OrdinalIgnoreCase);
        }

        // ===========================================
        // SEARCH STUDENT ACCOUNTS
        // ===========================================

        private void SearchStudents()
        {
            if (!CanViewAccounts())
            {
                MessageBox.Show(
                    "You do not have permission to view student accounts.");
                return;
            }

            string searchText = txtSearch.Text.Trim();

            if (searchText.Length > 100)
            {
                MessageBox.Show(
                    "Enter a shorter student name or ID.");
                return;
            }

            // Treat % _ and [ as literal search text.
            string safeSearch = searchText
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("_", "[_]");

            string searchPattern = "%" + safeSearch + "%";

            string sql = @"
                ;WITH RankedEnrollments AS
                (
                    SELECT
                        e.StudentID,
                        e.SchoolYear,
                        e.GradeLevel,
                        e.SectionID,

                        ROW_NUMBER() OVER
                        (
                            PARTITION BY
                                e.StudentID,
                                e.SchoolYear

                            ORDER BY
                                e.EnrollmentDate DESC
                        ) AS RowNumber

                    FROM dbo.Enrollments e
                ),

                PaymentTotals AS
                (
                    SELECT
                        AssessmentID,
                        SUM(AmountChange) AS AmountPaid

                    FROM dbo.AssessmentPayments

                    GROUP BY AssessmentID
                ),

                StudentAccounts AS
                (
                    SELECT
                        s.StudentID,
                        s.FullName,

                        e.SchoolYear,

                        ISNULL(
                            e.GradeLevel,
                            'Not recorded'
                        ) AS GradeLevel,

                        ISNULL(
                            sec.SectionName,
                            'Not assigned'
                        ) AS SectionName,

                        CASE
                            WHEN a.AssessmentID IS NULL
                                THEN CAST(
                                    NULL AS DECIMAL(18,2)
                                )

                            ELSE
                                a.TuitionFee
                                + a.MiscellaneousFee
                                + a.OtherFee
                                - a.Discount
                        END AS TotalAssessment,

                        CASE
                            WHEN a.AssessmentID IS NULL
                                THEN CAST(
                                    NULL AS DECIMAL(18,2)
                                )

                            ELSE
                                ISNULL(p.AmountPaid, 0)
                        END AS AmountPaid

                    FROM RankedEnrollments e

                    INNER JOIN dbo.Students s
                        ON s.StudentID = e.StudentID

                    LEFT JOIN dbo.Sections sec
                        ON sec.SectionID = e.SectionID

                    LEFT JOIN dbo.Assessments a
                        ON a.StudentID = e.StudentID
                       AND a.SchoolYear = e.SchoolYear

                    LEFT JOIN PaymentTotals p
                        ON p.AssessmentID = a.AssessmentID

                    WHERE e.RowNumber = 1
                )

                SELECT
                    StudentID,
                    FullName,
                    SchoolYear,
                    GradeLevel,
                    SectionName,
                    TotalAssessment,
                    AmountPaid,

                    CASE
                        WHEN TotalAssessment IS NULL
                            THEN CAST(
                                NULL AS DECIMAL(18,2)
                            )

                        WHEN TotalAssessment - AmountPaid > 0
                            THEN TotalAssessment - AmountPaid

                        ELSE CAST(0 AS DECIMAL(18,2))
                    END AS RemainingBalance,

                    CASE
                        WHEN TotalAssessment IS NULL
                            THEN CAST(
                                NULL AS DECIMAL(18,2)
                            )

                        WHEN AmountPaid > TotalAssessment
                            THEN AmountPaid - TotalAssessment

                        ELSE CAST(0 AS DECIMAL(18,2))
                    END AS CreditBalance

                FROM StudentAccounts

                WHERE
                    FullName LIKE @SearchPattern
                    OR CONVERT(
                        NVARCHAR(20), StudentID
                    ) LIKE @SearchPattern

                ORDER BY
                    FullName ASC,
                    SchoolYear DESC;";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(
                        DatabaseConnection.ConnectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@SearchPattern",
                        SqlDbType.NVarChar,
                        300
                    ).Value = searchPattern;

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    allResults = table;
                }

                currentPage = 0;
                DisplayPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search student accounts:\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ===========================================
        // PAGINATION
        // ===========================================

        private int GetTotalPages()
        {
            if (allResults.Rows.Count == 0)
                return 0;

            return (allResults.Rows.Count
                    + PageSize - 1) / PageSize;
        }

        private void DisplayPage()
        {
            loadingGrid = true;

            try
            {
                DataTable pageTable = allResults.Clone();

                int startIndex = currentPage * PageSize;

                int endIndex = Math.Min(
                    startIndex + PageSize,
                    allResults.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    pageTable.ImportRow(allResults.Rows[i]);
                }

                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = pageTable;

                ConfigureGridColumns();

                dgvAccounts.ClearSelection();

                int totalPages = GetTotalPages();

                lblPage.Text = totalPages == 0
                    ? "No records found"
                    : "Page " + (currentPage + 1)
                      + " of " + totalPages
                      + " | " + allResults.Rows.Count
                      + " account(s)";

                btnPrevious.Enabled =
                    CanViewAccounts() && currentPage > 0;

                btnNext.Enabled =
                    CanViewAccounts()
                    && currentPage + 1 < totalPages;

                ClearAccountDetails();

                if (dgvAccounts.Rows.Count > 0)
                {
                    dgvAccounts.CurrentCell =
                        dgvAccounts.Rows[0]
                        .Cells["FullName"];

                    dgvAccounts.Rows[0].Selected = true;
                }
            }
            finally
            {
                loadingGrid = false;
            }

            DisplaySelectedStudent();
        }

        // ===========================================
        // DATAGRIDVIEW DISPLAY
        // ===========================================

        private void ConfigureGridColumns()
        {
            if (dgvAccounts.Columns.Count == 0)
                return;

            SetColumn("StudentID", "Student ID");
            SetColumn("FullName", "Student Name");
            SetColumn("SchoolYear", "School Year");
            SetColumn("GradeLevel", "Grade Level");
            SetColumn("SectionName", "Section");
            SetColumn("TotalAssessment", "Total Assessment");
            SetColumn("AmountPaid", "Amount Paid");
            SetColumn("RemainingBalance", "Remaining Balance");

            if (dgvAccounts.Columns.Contains("CreditBalance"))
            {
                dgvAccounts.Columns["CreditBalance"].Visible = false;
            }

            SetMoneyColumn("TotalAssessment");
            SetMoneyColumn("AmountPaid");
            SetMoneyColumn("RemainingBalance");

            dgvAccounts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetColumn(
            string columnName,
            string headerText)
        {
            if (dgvAccounts.Columns.Contains(columnName))
            {
                dgvAccounts.Columns[columnName].HeaderText =
                    headerText;

                dgvAccounts.Columns[columnName].MinimumWidth =
                    90;
            }
        }

        private void SetMoneyColumn(string columnName)
        {
            if (dgvAccounts.Columns.Contains(columnName))
            {
                dgvAccounts.Columns[columnName]
                    .DefaultCellStyle.Format = "N2";

                dgvAccounts.Columns[columnName]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        // ===========================================
        // SHOW SELECTED STUDENT
        // ===========================================

        private void DisplaySelectedStudent()
        {
            if (!CanViewAccounts())
                return;

            DataGridViewRow selectedRow =
                dgvAccounts.CurrentRow;

            if (selectedRow == null)
            {
                ClearAccountDetails();
                return;
            }

            DataRowView row =
                selectedRow.DataBoundItem as DataRowView;

            if (row == null)
            {
                ClearAccountDetails();
                return;
            }

            txtStudentName.Text =
                Convert.ToString(row["FullName"]);

            txtStudentID.Text =
                Convert.ToString(row["StudentID"]);

            txtGradeLevel.Text =
                Convert.ToString(row["GradeLevel"]);

            txtSection.Text =
                Convert.ToString(row["SectionName"]);

            txtSchoolYear.Text =
                Convert.ToString(row["SchoolYear"]);

            // No saved assessment yet
            if (row["TotalAssessment"] == DBNull.Value)
            {
                txtTotalAssessment.Text = "Not assessed";
                txtAmountPaid.Text = "—";
                txtRemainingBalance.Text = "—";
                txtCreditBalance.Text = "—";

                lblAccountStatus.Text =
                    "No assessment saved for this school year.";

                lblAccountStatus.ForeColor =
                    Color.DarkOrange;

                return;
            }

            decimal assessment =
                Convert.ToDecimal(row["TotalAssessment"]);

            decimal paid =
                Convert.ToDecimal(row["AmountPaid"]);

            decimal remaining =
                Convert.ToDecimal(row["RemainingBalance"]);

            decimal credit =
                Convert.ToDecimal(row["CreditBalance"]);

            txtTotalAssessment.Text =
                FormatMoney(assessment);

            txtAmountPaid.Text =
                FormatMoney(paid);

            txtRemainingBalance.Text =
                FormatMoney(remaining);

            txtCreditBalance.Text =
                FormatMoney(credit);

            if (credit > 0)
            {
                lblAccountStatus.Text =
                    "Overpayment recorded. Account has credit.";

                lblAccountStatus.ForeColor =
                    Color.DarkGreen;
            }
            else if (remaining == 0)
            {
                lblAccountStatus.Text =
                    "Fully paid. No remaining balance.";

                lblAccountStatus.ForeColor =
                    Color.DarkGreen;
            }
            else
            {
                lblAccountStatus.Text =
                    "Outstanding balance: "
                    + FormatMoney(remaining);

                lblAccountStatus.ForeColor =
                    Color.DarkRed;
            }
        }

        // ===========================================
        // CURRENCY FORMAT
        // ===========================================

        private string FormatMoney(decimal amount)
        {
            return "₱ " + amount.ToString("N2");
        }

        // ===========================================
        // CLEAR DETAILS
        // ===========================================

        private void ClearAccountDetails()
        {
            txtStudentName.Clear();
            txtStudentID.Clear();
            txtGradeLevel.Clear();
            txtSection.Clear();
            txtSchoolYear.Clear();

            txtTotalAssessment.Clear();
            txtAmountPaid.Clear();
            txtRemainingBalance.Clear();
            txtCreditBalance.Clear();

            lblAccountStatus.Text =
                "Select a student to view their balance.";

            lblAccountStatus.ForeColor =
                Color.DimGray;
        }
    }
}
