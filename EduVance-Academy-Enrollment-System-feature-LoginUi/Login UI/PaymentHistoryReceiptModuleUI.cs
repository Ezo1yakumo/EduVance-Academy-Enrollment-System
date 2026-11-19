
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Login_UI
{
    // US-10: Generate / reprint receipts.
    // US-11: Search and view successfully saved payments.
    // This screen never inserts, edits, reverses or recalculates payments.
    public partial class PaymentHistoryReceiptModuleUI : Form
    {
        private const int PageSize = 15;
        private int currentPage = 1;
        private int recordCount = 0;
        private bool loadingGrid = false;
        private bool formShown = false;
        private string currentRole = "";
        private string currentUsername = "";
        private ReceiptRecord selectedReceipt;

        private readonly CultureInfo moneyCulture =
            CultureInfo.GetCultureInfo("en-PH");

        private const string HistoryFromWhere = @"
            FROM dbo.AssessmentPayments p
            INNER JOIN dbo.Assessments a
                ON a.AssessmentID = p.AssessmentID
            INNER JOIN dbo.Students s
                ON s.StudentID = a.StudentID
            WHERE p.AmountChange > 0
              AND p.ReceiptNumber IS NOT NULL
              AND LTRIM(RTRIM(p.ReceiptNumber)) <> ''
              AND
              (
                  @StudentSearch = ''
                  OR CONVERT(NVARCHAR(20), s.StudentID) = @StudentSearch
                  OR s.FullName LIKE '%' + @StudentSearch + '%'
              )
              AND
              (
                  @ReceiptSearch = ''
                  OR p.ReceiptNumber LIKE '%' + @ReceiptSearch + '%'
              )
              AND (@FromEnabled = 0 OR p.PaymentDate >= @FromDate)
              AND (@ToEnabled = 0 OR p.PaymentDate < DATEADD(DAY, 1, @ToDate))";

        private sealed class ReceiptRecord
        {
            public int PaymentID;
            public string ReceiptNumber;
            public DateTime PaymentDate;
            public DateTime? ReceiptDate;
            public string StudentName;
            public string StudentID;
            public string GradeLevel;
            public string Section;
            public string SchoolYear;
            public string Method;
            public string Reference;
            public string Description;
            public string RecordedBy;
            public decimal Amount;
            public decimal? RemainingBalanceAfter;
            public decimal? AssessmentTotalAtPayment;
            public decimal? TotalPaidAfter;
            public bool IsReversed;
            public bool HasDuplicateReceiptNumber;

            public bool IsPrintable
            {
                get
                {
                    return !IsReversed
                        && !HasDuplicateReceiptNumber
                        && !String.IsNullOrWhiteSpace(ReceiptNumber)
                        && ReceiptDate.HasValue
                        && RemainingBalanceAfter.HasValue
                        && AssessmentTotalAtPayment.HasValue
                        && TotalPaidAfter.HasValue
                        && Amount > 0m;
                }
            }
        }

        public PaymentHistoryReceiptModuleUI()
        {
            InitializeComponent();
            ConfigureHistoryGrid();

            btnSearch.Click += (s, e) => SearchFromFirstPage();
            btnReset.Click += (s, e) => ResetFilters();
            btnRefresh.Click += (s, e) => LoadHistoryPage();
            btnPrevious.Click += (s, e) => ChangePage(-1);
            btnNext.Click += (s, e) => ChangePage(1);
            btnPreview.Click += (s, e) => PreviewReceipt();
            btnPrint.Click += (s, e) => PrintReceipt();
            dgvHistory.SelectionChanged += (s, e) => ShowSelectedGridRow();
            dgvHistory.CellContentClick += DgvHistory_CellContentClick;
            dgvHistory.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    ShowReceiptForGridRow(e.RowIndex);
            };

            txtStudentSearch.KeyDown += SearchOnEnter;
            txtReceiptSearch.KeyDown += SearchOnEnter;
            Shown += (s, e) =>
            {
                formShown = true;
                ApplyPermissions();
                if (CanView())
                    LoadHistoryPage();
            };

            ClearReceiptPreview();
            ApplyPermissions();
        }

        // Dashboard calls this after creating the MDI child form.
        public void SetUserContext(string role, string username)
        {
            currentRole = (role ?? "").Trim();
            currentUsername = (username ?? "").Trim();
            ApplyPermissions();

            if (formShown && CanView())
                LoadHistoryPage();
        }

        private bool IsAdmin()
        {
            return currentRole.Equals(
                    "Admin", StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                    "Administrator", StringComparison.OrdinalIgnoreCase);
        }

        private bool CanView()
        {
            return IsAdmin()
                || currentRole.Equals(
                    "Cashier", StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                    "Registrar", StringComparison.OrdinalIgnoreCase);
        }

        private bool CanPrint()
        {
            return IsAdmin()
                || currentRole.Equals(
                    "Cashier", StringComparison.OrdinalIgnoreCase);
        }

        private void ApplyPermissions()
        {
            bool canView = CanView();

            txtStudentSearch.Enabled = canView;
            txtReceiptSearch.Enabled = canView;
            dtpFrom.Enabled = canView;
            dtpTo.Enabled = canView;
            btnSearch.Enabled = canView;
            btnReset.Enabled = canView;
            btnRefresh.Enabled = canView;
            dgvHistory.Enabled = canView;

            lblRole.Text = canView
                ? currentRole.ToUpperInvariant() + "  •  READ ONLY"
                : "ACCESS RESTRICTED";

            UpdateActionButtons();

            if (!canView)
            {
                lblResults.Text = "Authorized personnel only";
                lblReceiptHelp.Text =
                    "Admin, Cashier or Registrar login required.";
            }
        }

        private void UpdateActionButtons()
        {
            int totalPages = Math.Max(
                1, (recordCount + PageSize - 1) / PageSize);

            btnPrevious.Enabled = CanView() && currentPage > 1;
            btnNext.Enabled = CanView() && currentPage < totalPages;

            btnPreview.Enabled = CanPrint()
                && selectedReceipt != null
                && selectedReceipt.IsPrintable;

            btnPrint.Enabled = CanPrint()
                && selectedReceipt != null
                && selectedReceipt.IsPrintable;
        }

        private void SearchOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SearchFromFirstPage();
            }
        }

        private void SearchFromFirstPage()
        {
            currentPage = 1;
            LoadHistoryPage();
        }

        private void ResetFilters()
        {
            if (!CanView())
                return;

            txtStudentSearch.Clear();
            txtReceiptSearch.Clear();
            dtpFrom.Checked = false;
            dtpTo.Checked = false;
            currentPage = 1;

            LoadHistoryPage();
        }

        private void ChangePage(int delta)
        {
            if (!CanView())
                return;

            int totalPages = Math.Max(
                1, (recordCount + PageSize - 1) / PageSize);

            int newPage = currentPage + delta;

            if (newPage >= 1 && newPage <= totalPages)
            {
                currentPage = newPage;
                LoadHistoryPage();
            }
        }

        private bool ValidateSearch()
        {
            if (dtpFrom.Checked && dtpTo.Checked
                && dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show(
                    this,
                    "Date From cannot be later than Date To.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                DatabaseConnection.ConnectionString);
        }

        private void AddSearchParameters(SqlCommand command)
        {
            command.Parameters.Add(
                "@StudentSearch", SqlDbType.NVarChar, 100)
                .Value = txtStudentSearch.Text.Trim();

            command.Parameters.Add(
                "@ReceiptSearch", SqlDbType.NVarChar, 100)
                .Value = txtReceiptSearch.Text.Trim();

            command.Parameters.Add(
                "@FromEnabled", SqlDbType.Bit)
                .Value = dtpFrom.Checked;

            command.Parameters.Add(
                "@ToEnabled", SqlDbType.Bit)
                .Value = dtpTo.Checked;

            command.Parameters.Add(
                "@FromDate", SqlDbType.Date)
                .Value = dtpFrom.Value.Date;

            command.Parameters.Add(
                "@ToDate", SqlDbType.Date)
                .Value = dtpTo.Value.Date;
        }

        private void ConfigureHistoryGrid()
        {
            dgvHistory.Columns.Clear();

            AddColumn(
                "PaymentDate", "Date", 17, "MMM dd, yyyy");

            AddColumn(
                "ReceiptNumber", "Receipt Number", 23, "");

            AddColumn(
                "AmountChange", "Amount Paid", 16, "#,##0.00");

            AddColumn(
                "PaymentMethod", "Method", 15, "");

            AddColumn(
                "RemainingBalanceAfter",
                "Remaining Balance", 19, "#,##0.00");

            AddColumn(
                "ReceiptStatus", "Status", 15, "");

            DataGridViewButtonColumn action =
                new DataGridViewButtonColumn();

            action.Name = "ViewReceipt";
            action.HeaderText = "Actions";
            action.Text = "View";
            action.UseColumnTextForButtonValue = true;
            action.FillWeight = 12F;
            action.MinimumWidth = 56;
            action.FlatStyle = FlatStyle.Popup;

            dgvHistory.Columns.Add(action);
        }

        private void AddColumn(
            string field,
            string header,
            int weight,
            string format)
        {
            DataGridViewTextBoxColumn column =
                new DataGridViewTextBoxColumn();

            column.Name = field;
            column.DataPropertyName = field;
            column.HeaderText = header;
            column.FillWeight = weight;
            column.MinimumWidth = 68;
            column.ReadOnly = true;

            if (!String.IsNullOrEmpty(format))
                column.DefaultCellStyle.Format = format;

            if (field == "AmountChange"
                || field == "RemainingBalanceAfter")
            {
                column.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            dgvHistory.Columns.Add(column);
        }

        private void LoadHistoryPage()
        {
            if (!CanView() || !ValidateSearch())
                return;

            const string countSql =
                "SELECT COUNT(*) " + HistoryFromWhere;

            const string pageSql = @"
                SELECT
                    p.PaymentID,
                    p.PaymentDate,
                    p.ReceiptNumber,
                    p.AmountChange,
                    COALESCE(
                        NULLIF(p.PaymentMethod, ''),
                        'Not recorded'
                    ) AS PaymentMethod,
                    p.RemainingBalanceAfter,
                    CASE
                        WHEN EXISTS
                            (
                                SELECT 1
                                FROM dbo.AssessmentPayments rv
                                WHERE rv.ReversesPaymentID =
                                    p.PaymentID
                            )
                            THEN 'VOID'

                        WHEN
                            (
                                SELECT COUNT(*)
                                FROM dbo.AssessmentPayments dup
                                WHERE dup.ReceiptNumber =
                                    p.ReceiptNumber
                            ) <> 1
                            THEN 'DUPLICATE'

                        WHEN p.ReceiptDate IS NULL
                             OR p.RemainingBalanceAfter IS NULL
                             OR p.AssessmentTotalAtPayment IS NULL
                             OR p.TotalPaidAfter IS NULL
                            THEN 'INCOMPLETE'

                        ELSE 'VALID'
                    END AS ReceiptStatus
                " + HistoryFromWhere + @"
                ORDER BY
                    p.PaymentDate DESC,
                    p.PaymentID DESC

                OFFSET @Offset ROWS
                FETCH NEXT @PageSize ROWS ONLY;";

            try
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    using (SqlCommand countCommand =
                        new SqlCommand(countSql, connection))
                    {
                        AddSearchParameters(countCommand);

                        recordCount = Convert.ToInt32(
                            countCommand.ExecuteScalar());
                    }

                    int totalPages = Math.Max(
                        1,
                        (recordCount + PageSize - 1) / PageSize);

                    currentPage = Math.Max(
                        1,
                        Math.Min(currentPage, totalPages));

                    using (SqlCommand pageCommand =
                        new SqlCommand(pageSql, connection))
                    {
                        AddSearchParameters(pageCommand);

                        pageCommand.Parameters.Add(
                            "@Offset", SqlDbType.Int)
                            .Value = (currentPage - 1) * PageSize;

                        pageCommand.Parameters.Add(
                            "@PageSize", SqlDbType.Int)
                            .Value = PageSize;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(pageCommand))
                        {
                            adapter.Fill(data);
                        }
                    }
                }

                loadingGrid = true;

                try
                {
                    dgvHistory.DataSource = data;
                    dgvHistory.ClearSelection();
                    dgvHistory.CurrentCell = null;

                    selectedReceipt = null;
                    ClearReceiptPreview();
                }
                finally
                {
                    loadingGrid = false;
                }

                int pages = Math.Max(
                    1, (recordCount + PageSize - 1) / PageSize);

                lblPage.Text = "Page "
                    + currentPage + " of " + pages;

                lblResults.Text =
                    recordCount + " saved payment(s)";

                if (recordCount == 0)
                {
                    lblReceiptHelp.Text =
                        "No matching saved payments found.";
                }

                UpdateActionButtons();
            }
            catch (SqlException ex)
            {
                ShowDataError(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Could not load payment history:\n"
                        + ex.Message,
                    "Payment History",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowDataError(SqlException ex)
        {
            MessageBox.Show(
                this,
                "Unable to read payment history from "
                    + "the EduVance database.\n\n"
                    + ex.Message + "\n\n"
                    + "Verify that the Payment Module SQL "
                    + "migration has been applied to the same "
                    + "database used by this application.",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void DgvHistory_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex ==
                dgvHistory.Columns["ViewReceipt"].Index)
            {
                ShowReceiptForGridRow(e.RowIndex);
            }
        }

        private void ShowSelectedGridRow()
        {
            if (loadingGrid
                || !CanView()
                || dgvHistory.CurrentRow == null)
            {
                return;
            }

            ShowReceiptForGridRow(
                dgvHistory.CurrentRow.Index);
        }

        private void ShowReceiptForGridRow(int rowIndex)
        {
            if (!CanView()
                || loadingGrid
                || rowIndex < 0
                || rowIndex >= dgvHistory.Rows.Count)
            {
                return;
            }

            DataRowView row =
                dgvHistory.Rows[rowIndex].DataBoundItem
                    as DataRowView;

            if (row == null
                || row["PaymentID"] == DBNull.Value)
            {
                return;
            }

            int paymentId = Convert.ToInt32(
                row["PaymentID"]);

            if (selectedReceipt != null
                && selectedReceipt.PaymentID == paymentId)
            {
                return;
            }

            LoadReceipt(paymentId);
        }

        private static string GetText(
            SqlDataReader reader,
            string field)
        {
            return reader[field] == DBNull.Value
                ? ""
                : Convert.ToString(reader[field]);
        }

        private static decimal? GetMoneyOrNull(
            SqlDataReader reader,
            string field)
        {
            return reader[field] == DBNull.Value
                ? (decimal?)null
                : Convert.ToDecimal(reader[field]);
        }

        private bool LoadReceipt(int paymentId)
        {
            if (!CanView())
                return false;

            const string sql = @"
                SELECT
                    p.PaymentID,
                    p.PaymentDate,
                    p.ReceiptDate,
                    p.ReceiptNumber,
                    p.AmountChange,
                    p.PaymentMethod,
                    p.ReferenceNumber,
                    p.PaymentDescription,
                    p.RecordedBy,
                    p.AssessmentTotalAtPayment,
                    p.TotalPaidAfter,
                    p.RemainingBalanceAfter,
                    s.StudentID,
                    s.FullName,
                    a.SchoolYear,
                    lastEnrollment.GradeLevel,
                    lastEnrollment.SectionName,
                    CASE
                        WHEN EXISTS
                            (
                                SELECT 1
                                FROM dbo.AssessmentPayments rv
                                WHERE rv.ReversesPaymentID =
                                    p.PaymentID
                            )
                        THEN 1
                        ELSE 0
                    END AS IsReversed,
                    (
                        SELECT COUNT(*)
                        FROM dbo.AssessmentPayments duplicate
                        WHERE duplicate.ReceiptNumber =
                            p.ReceiptNumber
                    ) AS ReceiptNumberCount
                FROM dbo.AssessmentPayments p
                INNER JOIN dbo.Assessments a
                    ON a.AssessmentID = p.AssessmentID
                INNER JOIN dbo.Students s
                    ON s.StudentID = a.StudentID
                OUTER APPLY
                (
                    SELECT TOP (1)
                        en.GradeLevel,
                        sec.SectionName
                    FROM dbo.Enrollments en
                    LEFT JOIN dbo.Sections sec
                        ON sec.SectionID = en.SectionID
                    WHERE en.StudentID = a.StudentID
                      AND en.SchoolYear = a.SchoolYear
                    ORDER BY
                        en.EnrollmentDate DESC,
                        en.EnrollmentID DESC
                ) lastEnrollment
                WHERE p.PaymentID = @PaymentID
                  AND p.AmountChange > 0
                  AND p.ReceiptNumber IS NOT NULL
                  AND LTRIM(RTRIM(p.ReceiptNumber)) <> '';";

            try
            {
                ReceiptRecord receipt = null;

                using (SqlConnection connection =
                    GetConnection())
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@PaymentID", SqlDbType.Int)
                        .Value = paymentId;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            receipt = new ReceiptRecord();

                            receipt.PaymentID =
                                Convert.ToInt32(
                                    reader["PaymentID"]);

                            receipt.ReceiptNumber =
                                GetText(reader, "ReceiptNumber");

                            receipt.PaymentDate =
                                Convert.ToDateTime(
                                    reader["PaymentDate"]);

                            receipt.ReceiptDate =
                                reader["ReceiptDate"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(
                                        reader["ReceiptDate"]);

                            receipt.StudentName =
                                GetText(reader, "FullName");

                            receipt.StudentID =
                                GetText(reader, "StudentID");

                            receipt.GradeLevel =
                                GetText(reader, "GradeLevel");

                            receipt.Section =
                                GetText(reader, "SectionName");

                            receipt.SchoolYear =
                                GetText(reader, "SchoolYear");

                            receipt.Method =
                                GetText(reader, "PaymentMethod");

                            receipt.Reference =
                                GetText(reader, "ReferenceNumber");

                            receipt.Description =
                                GetText(reader, "PaymentDescription");

                            receipt.RecordedBy =
                                GetText(reader, "RecordedBy");

                            receipt.Amount =
                                Convert.ToDecimal(
                                    reader["AmountChange"]);

                            receipt.AssessmentTotalAtPayment =
                                GetMoneyOrNull(
                                    reader,
                                    "AssessmentTotalAtPayment");

                            receipt.TotalPaidAfter =
                                GetMoneyOrNull(
                                    reader,
                                    "TotalPaidAfter");

                            receipt.RemainingBalanceAfter =
                                GetMoneyOrNull(
                                    reader,
                                    "RemainingBalanceAfter");

                            receipt.IsReversed =
                                Convert.ToInt32(
                                    reader["IsReversed"]) == 1;

                            receipt.HasDuplicateReceiptNumber =
                                Convert.ToInt32(
                                    reader["ReceiptNumberCount"]) != 1;
                        }
                    }
                }

                selectedReceipt = receipt;
                ShowReceiptPreview();
                UpdateActionButtons();

                return receipt != null;
            }
            catch (SqlException ex)
            {
                ShowDataError(ex);
                selectedReceipt = null;
                ClearReceiptPreview();
                UpdateActionButtons();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Unable to load receipt:\n" + ex.Message,
                    "Receipt Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                selectedReceipt = null;
                ClearReceiptPreview();
                UpdateActionButtons();

                return false;
            }
        }

        private string Money(decimal amount)
        {
            return "₱"
                + amount.ToString("N2", moneyCulture);
        }

        private static string DisplayOrDash(string value)
        {
            return String.IsNullOrWhiteSpace(value)
                ? "Not recorded"
                : value;
        }

        private void ClearReceiptPreview()
        {
            lblReceiptStatus.Text =
                "Select a saved payment";

            lblReceiptStatus.ForeColor = Color.DimGray;
            lblReceiptNumber.Text = "Receipt No.: —";
            lblReceiptDate.Text = "Payment Date: —";
            lblStudentName.Text =
                "Select a row to view details";

            lblStudentID.Text = "Student ID: —";
            lblGradeSection.Text = "Grade / Section: —";
            lblSchoolYear.Text = "School Year: —";
            lblPaymentMethod.Text = "Payment Method: —";
            lblReference.Text = "Reference: —";
            lblAmountPaid.Text = "Amount Paid: —";
            lblBalance.Text = "Balance After: —";
            lblReceiptHelp.Text =
                "Receipts come from saved Payment Module records.";
        }

        private void ShowReceiptPreview()
        {
            if (selectedReceipt == null)
            {
                ClearReceiptPreview();
                return;
            }

            ReceiptRecord receipt = selectedReceipt;

            lblReceiptNumber.Text =
                "Receipt No.: " + receipt.ReceiptNumber;

            lblReceiptDate.Text =
                "Payment Date: "
                + receipt.PaymentDate.ToString(
                    "MMM dd, yyyy");

            lblStudentName.Text =
                DisplayOrDash(receipt.StudentName);

            lblStudentID.Text =
                "Student ID: " + receipt.StudentID;

            lblGradeSection.Text =
                "Grade / Section: "
                + DisplayOrDash(receipt.GradeLevel)
                + " / "
                + DisplayOrDash(receipt.Section);

            lblSchoolYear.Text =
                "School Year: "
                + DisplayOrDash(receipt.SchoolYear);

            lblPaymentMethod.Text =
                "Payment Method: "
                + DisplayOrDash(receipt.Method);

            lblReference.Text =
                "Reference: "
                + DisplayOrDash(receipt.Reference);

            lblAmountPaid.Text =
                "Amount Paid: " + Money(receipt.Amount);

            lblBalance.Text =
                "Balance After: "
                + (
                    receipt.RemainingBalanceAfter.HasValue
                        ? Money(
                            receipt.RemainingBalanceAfter.Value)
                        : "Not recorded"
                );

            if (receipt.IsReversed)
            {
                lblReceiptStatus.Text =
                    "VOID — PAYMENT REVERSED";

                lblReceiptStatus.ForeColor =
                    Color.Firebrick;

                lblReceiptHelp.Text =
                    "Void receipts cannot be printed or reprinted.";
            }
            else if (receipt.HasDuplicateReceiptNumber)
            {
                lblReceiptStatus.Text =
                    "INVALID — DUPLICATE RECEIPT";

                lblReceiptStatus.ForeColor =
                    Color.Firebrick;

                lblReceiptHelp.Text =
                    "Resolve the duplicate receipt number in SQL.";
            }
            else if (!receipt.IsPrintable)
            {
                lblReceiptStatus.Text =
                    "INCOMPLETE RECEIPT RECORD";

                lblReceiptStatus.ForeColor =
                    Color.DarkOrange;

                lblReceiptHelp.Text =
                    "An original receipt snapshot is missing.";
            }
            else
            {
                lblReceiptStatus.Text =
                    "VALID SAVED PAYMENT";

                lblReceiptStatus.ForeColor =
                    Color.ForestGreen;

                lblReceiptHelp.Text =
                    "Original receipt data — no values can be edited here.";
            }
        }

        private bool RefreshReceiptBeforeOutput(
            bool requirePrinterAccess)
        {
            if (!CanView()
                || (requirePrinterAccess && !CanPrint()))
            {
                MessageBox.Show(
                    this,
                    "Your role is not allowed to perform this action.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (selectedReceipt == null)
            {
                MessageBox.Show(
                    this,
                    "Select a payment from history first.",
                    "Receipt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return false;
            }

            int id = selectedReceipt.PaymentID;

            if (!LoadReceipt(id)
                || selectedReceipt == null
                || !selectedReceipt.IsPrintable)
            {
                MessageBox.Show(
                    this,
                    "This payment does not have a valid "
                    + "printable receipt, or it has been reversed.",
                    "Receipt Not Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void PreviewReceipt()
        {
            if (!RefreshReceiptBeforeOutput(true))
                return;

            try
            {
                using (PrintDocument document =
                    BuildPrintDocument())
                using (PrintPreviewDialog dialog =
                    new PrintPreviewDialog())
                {
                    dialog.Document = document;
                    dialog.Width = 920;
                    dialog.Height = 740;
                    dialog.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Cannot preview receipt:\n" + ex.Message,
                    "Receipt Preview",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrintReceipt()
        {
            if (!RefreshReceiptBeforeOutput(true))
                return;

            try
            {
                using (PrintDocument document =
                    BuildPrintDocument())
                using (PrintDialog dialog =
                    new PrintDialog())
                {
                    dialog.Document = document;
                    dialog.UseEXDialog = true;

                    if (dialog.ShowDialog(this)
                        == DialogResult.OK)
                    {
                        document.PrinterSettings =
                            dialog.PrinterSettings;

                        document.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Printing failed:\n" + ex.Message,
                    "Print Receipt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private PrintDocument BuildPrintDocument()
        {
            PrintDocument document =
                new PrintDocument();

            document.DocumentName =
                "EduVance Receipt "
                + selectedReceipt.ReceiptNumber;

            document.PrintPage += PrintReceiptPage;

            return document;
        }

        private void PrintReceiptPage(
            object sender,
            PrintPageEventArgs e)
        {
            ReceiptRecord receipt = selectedReceipt;

            if (receipt == null || !receipt.IsPrintable)
            {
                e.Cancel = true;
                return;
            }

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;

            using (Font title =
                new Font("Segoe UI", 17F, FontStyle.Bold))
            using (Font heading =
                new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font normal =
                new Font("Segoe UI", 10F))
            using (Pen divider =
                new Pen(Color.Gray, 1F))
            {
                e.Graphics.DrawString(
                    "EDUVANCE ACADEMY",
                    title,
                    Brushes.Black,
                    new RectangleF(x, y, width, 35));

                y += 42;

                e.Graphics.DrawString(
                    "OFFICIAL PAYMENT RECEIPT",
                    heading,
                    Brushes.Black,
                    new RectangleF(x, y, width, 28));

                y += 40;

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Receipt Number: " + receipt.ReceiptNumber);

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Payment Date: "
                    + receipt.PaymentDate.ToString(
                        "MMMM dd, yyyy"));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Receipt Issued: "
                    + receipt.ReceiptDate.Value.ToString(
                        "MMMM dd, yyyy hh:mm tt"));

                y += 8;
                e.Graphics.DrawLine(
                    divider, x, y, x + width, y);
                y += 15;

                DrawReceiptText(
                    e.Graphics, heading, x, width, ref y,
                    "STUDENT INFORMATION");

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Student: "
                    + DisplayOrDash(receipt.StudentName));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Student ID: " + receipt.StudentID);

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Grade / Section: "
                    + DisplayOrDash(receipt.GradeLevel)
                    + " / "
                    + DisplayOrDash(receipt.Section));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "School Year: "
                    + DisplayOrDash(receipt.SchoolYear));

                y += 8;
                e.Graphics.DrawLine(
                    divider, x, y, x + width, y);
                y += 15;

                DrawReceiptText(
                    e.Graphics, heading, x, width, ref y,
                    "PAYMENT DETAILS");

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Payment Method: "
                    + DisplayOrDash(receipt.Method));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Reference: "
                    + DisplayOrDash(receipt.Reference));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Description: "
                    + DisplayOrDash(receipt.Description));

                DrawReceiptText(
                    e.Graphics, heading, x, width, ref y,
                    "AMOUNT PAID: "
                    + Money(receipt.Amount));

                y += 8;
                e.Graphics.DrawLine(
                    divider, x, y, x + width, y);
                y += 15;

                DrawReceiptText(
                    e.Graphics, heading, x, width, ref y,
                    "BALANCE SUMMARY");

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Total Assessment at Payment: "
                    + Money(
                        receipt.AssessmentTotalAtPayment.Value));

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Total Paid After Transaction: "
                    + Money(receipt.TotalPaidAfter.Value));

                DrawReceiptText(
                    e.Graphics, heading, x, width, ref y,
                    "Remaining Balance After Payment: "
                    + Money(
                        receipt.RemainingBalanceAfter.Value));

                y += 13;

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Recorded by: "
                    + DisplayOrDash(receipt.RecordedBy));

                y += 15;

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Thank you for your payment.");

                DrawReceiptText(
                    e.Graphics, normal, x, width, ref y,
                    "Reprinted from saved transaction #"
                    + receipt.PaymentID);
            }

            e.HasMorePages = false;
        }

        private static void DrawReceiptText(
            Graphics graphics,
            Font font,
            float x,
            float width,
            ref float y,
            string value)
        {
            SizeF size = graphics.MeasureString(
                value, font, (int)width);

            float height =
                Math.Max(27F, size.Height + 5F);

            graphics.DrawString(
                value,
                font,
                Brushes.Black,
                new RectangleF(x, y, width, height));

            y += height;
        }
    }
}
