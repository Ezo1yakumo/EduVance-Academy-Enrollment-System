
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class PaymentModuleUI : Form
    {
        private bool loading = false;
        private bool loadingHistory = false;

        private int assessmentId = 0;
        private decimal totalAssessment = 0m;
        private decimal totalPaid = 0m;

        private string currentRole = "";
        private string currentUsername = "";

        private readonly CultureInfo moneyCulture =
            CultureInfo.InvariantCulture;

        private ReceiptData selectedReceipt = null;

        private class ReceiptData
        {
            public string Number;
            public DateTime Date;
            public string Student;
            public string StudentID;
            public string SchoolYear;
            public string Method;
            public string Reference;
            public string Description;
            public string RecordedBy;

            public decimal Payment;
            public decimal AssessmentTotal;
            public decimal PaidAfter;
            public decimal BalanceAfter;
        }

        public PaymentModuleUI()
        {
            InitializeComponent();

            cmbMethod.Items.AddRange(new object[]
            {
                "Cash",
                "GCash",
                "Bank Transfer",
                "Check",
                "Other"
            });

            cmbMethod.SelectedIndex = 0;

            cmbStudent.SelectedIndexChanged +=
                (s, e) => LoadSchoolYears();

            cmbSchoolYear.SelectedIndexChanged +=
                (s, e) => LoadAccount();

            btnRecord.Click += btnRecord_Click;
            btnClear.Click += btnClear_Click;
            btnPrint.Click += btnPrint_Click;
            btnReverse.Click += btnReverse_Click;

            dgvPayments.SelectionChanged +=
                (s, e) => ShowSelectedPayment();

            dtpPaymentDate.Value = DateTime.Today;

            Shown += (s, e) => LoadStudents();

            ClearAccount();
            ApplyPermissions();
        }

        // =====================================
        // USER ROLES
        // =====================================

        public void SetUserContext(
            string role,
            string username)
        {
            currentRole = (role ?? "").Trim();
            currentUsername = (username ?? "").Trim();

            ApplyPermissions();

            if (Visible)
                LoadStudents();
        }

        private bool IsAdmin()
        {
            return currentRole.Equals(
                       "Admin",
                       StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                       "Administrator",
                       StringComparison.OrdinalIgnoreCase);
        }

        private bool CanProcessPayment()
        {
            return IsAdmin()
                || currentRole.Equals(
                       "Cashier",
                       StringComparison.OrdinalIgnoreCase);
        }

        private bool CanView()
        {
            return CanProcessPayment()
                || currentRole.Equals(
                       "Registrar",
                       StringComparison.OrdinalIgnoreCase);
        }

        private void ApplyPermissions()
        {
            bool canView = CanView();
            bool canProcess = CanProcessPayment();

            cmbStudent.Enabled = canView;
            cmbSchoolYear.Enabled = canView;

            dtpPaymentDate.Enabled = canProcess;
            txtAmount.ReadOnly = !canProcess;
            txtReference.ReadOnly = !canProcess;
            txtDescription.ReadOnly = !canProcess;
            cmbMethod.Enabled = canProcess;

            btnRecord.Enabled =
                canProcess && assessmentId > 0;

            btnClear.Enabled = canProcess;
            btnReverse.Visible = IsAdmin();

            UpdateHistoryButtons();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                DatabaseConnection.ConnectionString);
        }

        private string Money(decimal value)
        {
            return "₱" + value.ToString(
                "N2", moneyCulture);
        }

        private bool GetStudentId(out int studentId)
        {
            studentId = 0;

            if (cmbStudent.SelectedIndex < 0)
                return false;

            return int.TryParse(
                Convert.ToString(cmbStudent.SelectedValue),
                out studentId);
        }

        private void AddAmount(
            SqlCommand command,
            string name,
            decimal value)
        {
            SqlParameter parameter =
                command.Parameters.Add(
                    name, SqlDbType.Decimal);

            parameter.Precision = 18;
            parameter.Scale = 2;
            parameter.Value = value;
        }

        // =====================================
        // STUDENT SELECTION
        // =====================================

        private void LoadStudents()
        {
            loading = true;

            try
            {
                cmbStudent.DataSource = null;
                cmbSchoolYear.Items.Clear();
                ClearAccount();

                if (!CanView())
                {
                    lblConfirm.Text =
                        "Access denied. Cashier, Admin, or Registrar role required.";
                    return;
                }

                string sql = @"
                    SELECT s.StudentID, s.FullName
                    FROM dbo.Students s
                    WHERE EXISTS
                    (
                        SELECT 1
                        FROM dbo.Enrollments e
                        WHERE e.StudentID = s.StudentID
                    )
                    ORDER BY s.FullName;";

                DataTable students = new DataTable();

                using (SqlConnection connection =
                    GetConnection())
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.Fill(students);
                }

                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentID";
                cmbStudent.DataSource = students;

                cmbStudent.SelectedIndex = -1;

                lblConfirm.Text = students.Rows.Count == 0
                    ? "No enrolled students found."
                    : "Select a student and school year.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load students:\n" + ex.Message);
            }
            finally
            {
                loading = false;
            }

            if (cmbStudent.Items.Count > 0)
                cmbStudent.SelectedIndex = 0;
        }

        private void LoadSchoolYears()
        {
            if (loading || !CanView())
                return;

            int studentId;

            loading = true;
            cmbSchoolYear.Items.Clear();
            ClearAccount();

            try
            {
                if (!GetStudentId(out studentId))
                    return;

                string sql = @"
                    SELECT DISTINCT SchoolYear
                    FROM dbo.Enrollments
                    WHERE StudentID = @StudentID
                    ORDER BY SchoolYear DESC;";

                using (SqlConnection connection =
                    GetConnection())
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@StudentID", SqlDbType.Int)
                        .Value = studentId;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbSchoolYear.Items.Add(
                                Convert.ToString(
                                    reader["SchoolYear"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load school years:\n"
                    + ex.Message);
            }
            finally
            {
                loading = false;
            }

            if (cmbSchoolYear.Items.Count > 0)
                cmbSchoolYear.SelectedIndex = 0;
        }

        // =====================================
        // ACCOUNT INFORMATION
        // =====================================

        private void ClearAccount()
        {
            assessmentId = 0;
            totalAssessment = 0m;
            totalPaid = 0m;
            selectedReceipt = null;

            txtStudentID.Clear();
            txtStudentName.Clear();
            txtGrade.Clear();
            txtSection.Clear();

            txtTotalAssessment.Clear();
            txtTotalPaid.Clear();
            txtRemainingBalance.Clear();
            txtCreditBalance.Clear();

            ClearReceipt();

            loadingHistory = true;
            dgvPayments.DataSource = null;
            loadingHistory = false;

            ApplyPermissions();
        }

        private void LoadAccount()
        {
            if (loading || !CanView())
                return;

            ClearAccount();

            int studentId;

            if (!GetStudentId(out studentId) ||
                string.IsNullOrWhiteSpace(
                    cmbSchoolYear.Text))
                return;

            string sql = @"
                SELECT TOP (1)
                    s.StudentID,
                    s.FullName,
                    e.GradeLevel,
                    sec.SectionName,

                    a.AssessmentID,

                    (a.TuitionFee
                     + a.MiscellaneousFee
                     + a.OtherFee
                     - a.Discount) AS TotalAssessment,

                    ISNULL
                    (
                        (
                            SELECT SUM(p.AmountChange)
                            FROM dbo.AssessmentPayments p
                            WHERE p.AssessmentID = a.AssessmentID
                        ), 0
                    ) AS AmountPaid

                FROM dbo.Enrollments e

                INNER JOIN dbo.Students s
                    ON s.StudentID = e.StudentID

                LEFT JOIN dbo.Sections sec
                    ON sec.SectionID = e.SectionID

                LEFT JOIN dbo.Assessments a
                    ON a.StudentID = e.StudentID
                   AND a.SchoolYear = e.SchoolYear

                WHERE e.StudentID = @StudentID
                  AND e.SchoolYear = @SchoolYear

                ORDER BY e.EnrollmentDate DESC,
                         e.EnrollmentID DESC;";

            try
            {
                using (SqlConnection connection =
                    GetConnection())
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@StudentID", SqlDbType.Int)
                        .Value = studentId;

                    command.Parameters.Add(
                        "@SchoolYear",
                        SqlDbType.NVarChar, 20)
                        .Value = cmbSchoolYear.Text;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            lblConfirm.Text =
                                "No valid enrollment found.";
                            return;
                        }

                        txtStudentID.Text =
                            Convert.ToString(reader["StudentID"]);

                        txtStudentName.Text =
                            Convert.ToString(reader["FullName"]);

                        txtGrade.Text =
                            reader["GradeLevel"] == DBNull.Value
                            ? "Not recorded"
                            : Convert.ToString(
                                reader["GradeLevel"]);

                        txtSection.Text =
                            reader["SectionName"] == DBNull.Value
                            ? "Not assigned"
                            : Convert.ToString(
                                reader["SectionName"]);

                        if (reader["AssessmentID"] != DBNull.Value)
                        {
                            assessmentId = Convert.ToInt32(
                                reader["AssessmentID"]);

                            totalAssessment = Convert.ToDecimal(
                                reader["TotalAssessment"]);

                            totalPaid = Convert.ToDecimal(
                                reader["AmountPaid"]);
                        }
                    }
                }

                if (assessmentId == 0)
                {
                    txtTotalAssessment.Text = "Not assessed";
                    txtTotalPaid.Text = "—";
                    txtRemainingBalance.Text = "—";

                    lblConfirm.Text =
                        "Create and save an Assessment first.";

                    ApplyPermissions();
                    return;
                }

                decimal remaining = Math.Max(
                    0m, totalAssessment - totalPaid);

                decimal credit = Math.Max(
                    0m, totalPaid - totalAssessment);

                txtTotalAssessment.Text =
                    Money(totalAssessment);

                txtTotalPaid.Text = Money(totalPaid);

                txtRemainingBalance.Text =
                    Money(remaining);

                txtCreditBalance.Text =
                    Money(credit);

                lblConfirm.Text = totalPaid < 0m
                    ? "Payment ledger needs correction. Recording is blocked."
                    : remaining <= 0m
                        ? "Account is fully paid or has a credit balance."
                        : "Outstanding balance: " + Money(remaining);

                LoadPaymentHistory();
                ApplyPermissions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load account:\n" + ex.Message);
            }
        }

        // =====================================
        // PAYMENT HISTORY
        // =====================================

        private void LoadPaymentHistory()
        {
            string sql = @"
                SELECT
                    p.PaymentID,
                    p.PaymentDate,
                    p.AmountChange,
                    p.PaymentMethod,
                    p.ReferenceNumber,
                    p.PaymentDescription,
                    p.RecordedBy,
                    p.ReceiptNumber,
                    p.ReceiptDate,
                    p.AssessmentTotalAtPayment,
                    p.TotalPaidAfter,
                    p.RemainingBalanceAfter,
                    p.ReversesPaymentID,

                    CASE WHEN EXISTS
                    (
                        SELECT 1
                        FROM dbo.AssessmentPayments r
                        WHERE r.ReversesPaymentID = p.PaymentID
                    )
                    THEN 1 ELSE 0 END AS IsReversed

                FROM dbo.AssessmentPayments p
                WHERE p.AssessmentID = @AssessmentID
                ORDER BY p.PaymentID DESC;";

            try
            {
                DataTable history = new DataTable();

                using (SqlConnection connection =
                    GetConnection())
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@AssessmentID", SqlDbType.Int)
                        .Value = assessmentId;

                    adapter.Fill(history);
                }

                loadingHistory = true;

                dgvPayments.DataSource = history;

                string[] hidden =
                {
                    "PaymentID",
                    "PaymentDescription",
                    "RecordedBy",
                    "ReceiptDate",
                    "AssessmentTotalAtPayment",
                    "TotalPaidAfter",
                    "RemainingBalanceAfter",
                    "ReversesPaymentID",
                    "IsReversed"
                };

                foreach (string column in hidden)
                {
                    if (dgvPayments.Columns.Contains(column))
                        dgvPayments.Columns[column].Visible = false;
                }

                if (dgvPayments.Columns.Contains("PaymentDate"))
                {
                    dgvPayments.Columns["PaymentDate"]
                        .HeaderText = "Date";
                    dgvPayments.Columns["PaymentDate"]
                        .DefaultCellStyle.Format = "MMM dd, yyyy";
                }

                if (dgvPayments.Columns.Contains("AmountChange"))
                {
                    dgvPayments.Columns["AmountChange"]
                        .HeaderText = "Amount";
                    dgvPayments.Columns["AmountChange"]
                        .DefaultCellStyle.Format = "N2";
                }

                if (dgvPayments.Columns.Contains("PaymentMethod"))
                    dgvPayments.Columns["PaymentMethod"]
                        .HeaderText = "Method";

                if (dgvPayments.Columns.Contains("ReferenceNumber"))
                    dgvPayments.Columns["ReferenceNumber"]
                        .HeaderText = "Reference";

                if (dgvPayments.Columns.Contains("ReceiptNumber"))
                    dgvPayments.Columns["ReceiptNumber"]
                        .HeaderText = "Receipt No.";

                dgvPayments.ClearSelection();
                dgvPayments.CurrentCell = null;

                ClearReceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load payment history:\n"
                    + ex.Message);
            }
            finally
            {
                loadingHistory = false;
            }

            UpdateHistoryButtons();
        }

        private DataRowView GetSelectedHistoryRow()
        {
            if (dgvPayments.SelectedRows.Count != 1 ||
                dgvPayments.CurrentRow == null)
                return null;

            return dgvPayments.CurrentRow.DataBoundItem
                as DataRowView;
        }

        private void ClearReceipt()
        {
            selectedReceipt = null;

            txtReceiptNumber.Clear();
            txtReceiptDate.Clear();
            txtReceiptPaid.Clear();
            txtReceiptBalance.Clear();

            UpdateHistoryButtons();
        }

        private void ShowSelectedPayment()
        {
            if (loadingHistory)
                return;

            ClearReceipt();

            DataRowView row = GetSelectedHistoryRow();

            if (row == null)
                return;

            decimal amount = Convert.ToDecimal(
                row["AmountChange"]);

            bool reversed =
                Convert.ToInt32(row["IsReversed"]) == 1;

            if (amount <= 0m)
            {
                lblConfirm.Text =
                    "Selected record is a payment reversal.";
                UpdateHistoryButtons();
                return;
            }

            if (reversed)
            {
                lblConfirm.Text =
                    "This payment was reversed. Its receipt is void.";
                UpdateHistoryButtons();
                return;
            }

            if (row["ReceiptNumber"] == DBNull.Value ||
                row["ReceiptDate"] == DBNull.Value ||
                row["TotalPaidAfter"] == DBNull.Value ||
                row["RemainingBalanceAfter"] == DBNull.Value ||
                row["AssessmentTotalAtPayment"] == DBNull.Value)
            {
                lblConfirm.Text =
                    "This older payment has no printable receipt snapshot.";
                UpdateHistoryButtons();
                return;
            }

            selectedReceipt = new ReceiptData
            {
                Number = Convert.ToString(
                    row["ReceiptNumber"]),

                Date = Convert.ToDateTime(
                    row["ReceiptDate"]),

                Student = txtStudentName.Text,
                StudentID = txtStudentID.Text,
                SchoolYear = cmbSchoolYear.Text,

                Method = Convert.ToString(
                    row["PaymentMethod"]),

                Reference = Convert.ToString(
                    row["ReferenceNumber"]),

                Description = Convert.ToString(
                    row["PaymentDescription"]),

                RecordedBy = Convert.ToString(
                    row["RecordedBy"]),

                Payment = amount,

                AssessmentTotal = Convert.ToDecimal(
                    row["AssessmentTotalAtPayment"]),

                PaidAfter = Convert.ToDecimal(
                    row["TotalPaidAfter"]),

                BalanceAfter = Convert.ToDecimal(
                    row["RemainingBalanceAfter"])
            };

            txtReceiptNumber.Text = selectedReceipt.Number;

            txtReceiptDate.Text =
                selectedReceipt.Date.ToString(
                    "MMM dd, yyyy hh:mm tt");

            txtReceiptPaid.Text =
                Money(selectedReceipt.PaidAfter);

            txtReceiptBalance.Text =
                Money(selectedReceipt.BalanceAfter);

            lblConfirm.Text =
                "Select Print Receipt to preview the transaction.";

            UpdateHistoryButtons();
        }

        private void SelectHistoryPayment(int paymentId)
        {
            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                if (Convert.ToInt32(
                    row.Cells["PaymentID"].Value) == paymentId)
                {
                    dgvPayments.ClearSelection();

                    dgvPayments.CurrentCell =
                        row.Cells["PaymentDate"];

                    row.Selected = true;

                    ShowSelectedPayment();
                    break;
                }
            }
        }

        private void UpdateHistoryButtons()
        {
            if (btnPrint == null || btnReverse == null)
                return;

            btnPrint.Enabled =
                CanView() && selectedReceipt != null;

            DataRowView row = GetSelectedHistoryRow();

            bool reversible = false;

            if (row != null)
            {
                decimal amount = Convert.ToDecimal(
                    row["AmountChange"]);

                int reversed = Convert.ToInt32(
                    row["IsReversed"]);

                reversible = amount > 0m && reversed == 0;
            }

            btnReverse.Enabled =
                IsAdmin() && reversible;
        }

        // =====================================
        // TRANSACTION BALANCE HELPERS
        // =====================================

        private decimal GetLockedAssessmentTotal(
            SqlConnection connection,
            SqlTransaction transaction)
        {
            string sql = @"
                SELECT TuitionFee
                     + MiscellaneousFee
                     + OtherFee
                     - Discount
                FROM dbo.Assessments WITH (UPDLOCK, HOLDLOCK)
                WHERE AssessmentID = @AssessmentID
                  AND StudentID = @StudentID
                  AND SchoolYear = @SchoolYear;";

            using (SqlCommand command =
                new SqlCommand(sql, connection, transaction))
            {
                int studentId;

                if (!GetStudentId(out studentId))
                    throw new InvalidOperationException(
                        "No student selected.");

                command.Parameters.Add(
                    "@AssessmentID", SqlDbType.Int)
                    .Value = assessmentId;

                command.Parameters.Add(
                    "@StudentID", SqlDbType.Int)
                    .Value = studentId;

                command.Parameters.Add(
                    "@SchoolYear",
                    SqlDbType.NVarChar, 20)
                    .Value = cmbSchoolYear.Text;

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    throw new InvalidOperationException(
                        "Assessment no longer exists.");

                return Convert.ToDecimal(result);
            }
        }

        private decimal GetLockedPaidTotal(
            SqlConnection connection,
            SqlTransaction transaction)
        {
            string sql = @"
                SELECT ISNULL(SUM(AmountChange), 0)
                FROM dbo.AssessmentPayments
                    WITH (UPDLOCK, HOLDLOCK)
                WHERE AssessmentID = @AssessmentID;";

            using (SqlCommand command =
                new SqlCommand(sql, connection, transaction))
            {
                command.Parameters.Add(
                    "@AssessmentID", SqlDbType.Int)
                    .Value = assessmentId;

                return Convert.ToDecimal(
                    command.ExecuteScalar());
            }
        }

        // =====================================
        // PROCESS PAYMENT
        // =====================================

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!CanProcessPayment())
            {
                MessageBox.Show(
                    "Only authorized users can record payments.");
                return;
            }

            if (assessmentId <= 0)
            {
                MessageBox.Show(
                    "Select a student with a saved assessment.");
                return;
            }

            decimal amount;

            if (!decimal.TryParse(
                    txtAmount.Text.Trim(),
                    NumberStyles.Number,
                    moneyCulture,
                    out amount)
                || amount <= 0m
                || decimal.Round(amount, 2) != amount
                || amount > 9999999999999999.99m)
            {
                MessageBox.Show(
                    "Enter a positive payment amount with up to 2 decimal places.");
                return;
            }

            string method = cmbMethod.Text.Trim();
            string reference = txtReference.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (method == "" ||
                reference == "" ||
                description == "")
            {
                MessageBox.Show(
                    "Complete the payment method, reference number, and description.");
                return;
            }

            if (reference.Length > 100 ||
                description.Length > 250)
            {
                MessageBox.Show(
                    "Reference number or description is too long.");
                return;
            }

            if (dtpPaymentDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Payment date cannot be in the future.");
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Record a payment of " + Money(amount) +
                " for " + txtStudentName.Text + "?\n\n" +
                "Reference: " + reference,
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            int newPaymentId = 0;

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction(
                            IsolationLevel.Serializable))
                    {
                        decimal assessmentTotal =
                            GetLockedAssessmentTotal(
                                connection, transaction);

                        decimal paid =
                            GetLockedPaidTotal(
                                connection, transaction);

                        if (paid < 0m)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "Payment ledger requires correction.");
                            return;
                        }

                        decimal remaining =
                            assessmentTotal - paid;

                        if (remaining <= 0m ||
                            amount > remaining)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "Payment exceeds the remaining balance of " +
                                Money(Math.Max(0m, remaining)) + ".");
                            return;
                        }

                        decimal paidAfter = paid + amount;
                        decimal balanceAfter =
                            assessmentTotal - paidAfter;

                        string insertSql = @"
                            INSERT INTO dbo.AssessmentPayments
                            (
                                AssessmentID,
                                AmountChange,
                                PaymentDate,
                                PaymentMethod,
                                ReferenceNumber,
                                PaymentDescription,
                                RecordedBy,
                                Remarks,
                                AssessmentTotalAtPayment,
                                TotalPaidAfter,
                                RemainingBalanceAfter
                            )
                            OUTPUT INSERTED.PaymentID
                            VALUES
                            (
                                @AssessmentID,
                                @Amount,
                                @PaymentDate,
                                @Method,
                                @Reference,
                                @Description,
                                @RecordedBy,
                                @Remarks,
                                @TotalAssessment,
                                @PaidAfter,
                                @BalanceAfter
                            );";

                        using (SqlCommand command =
                            new SqlCommand(
                                insertSql, connection, transaction))
                        {
                            command.Parameters.Add(
                                "@AssessmentID", SqlDbType.Int)
                                .Value = assessmentId;

                            AddAmount(
                                command, "@Amount", amount);

                            command.Parameters.Add(
                                "@PaymentDate",
                                SqlDbType.DateTime2)
                                .Value = dtpPaymentDate.Value.Date;

                            command.Parameters.Add(
                                "@Method",
                                SqlDbType.NVarChar, 30)
                                .Value = method;

                            command.Parameters.Add(
                                "@Reference",
                                SqlDbType.NVarChar, 100)
                                .Value = reference;

                            command.Parameters.Add(
                                "@Description",
                                SqlDbType.NVarChar, 250)
                                .Value = description;

                            command.Parameters.Add(
                                "@RecordedBy",
                                SqlDbType.NVarChar, 100)
                                .Value = currentUsername;

                            command.Parameters.Add(
                                "@Remarks",
                                SqlDbType.NVarChar, 250)
                                .Value = description;

                            AddAmount(
                                command, "@TotalAssessment",
                                assessmentTotal);

                            AddAmount(
                                command, "@PaidAfter", paidAfter);

                            AddAmount(
                                command, "@BalanceAfter",
                                balanceAfter);

                            newPaymentId = Convert.ToInt32(
                                command.ExecuteScalar());
                        }

                        // Generate unique receipt number
                        // using the saved payment ID.
                        string receiptNumber =
                            "EDV-" +
                            DateTime.Now.ToString("yyyyMMdd") +
                            "-" +
                            newPaymentId.ToString("D7");

                        string receiptSql = @"
                            UPDATE dbo.AssessmentPayments
                            SET ReceiptNumber = @ReceiptNumber,
                                ReceiptDate = SYSDATETIME()
                            WHERE PaymentID = @PaymentID;";

                        using (SqlCommand command =
                            new SqlCommand(
                                receiptSql, connection, transaction))
                        {
                            command.Parameters.Add(
                                "@ReceiptNumber",
                                SqlDbType.NVarChar, 50)
                                .Value = receiptNumber;

                            command.Parameters.Add(
                                "@PaymentID", SqlDbType.Int)
                                .Value = newPaymentId;

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                // Refresh account and select new receipt.
                LoadAccount();
                SelectHistoryPayment(newPaymentId);

                txtAmount.Clear();
                txtReference.Clear();
                txtDescription.Clear();

                DialogResult print = MessageBox.Show(
                    "Payment recorded successfully!\n\n" +
                    "Would you like to preview the receipt?",
                    "Payment Saved",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (print == DialogResult.Yes)
                    PreviewReceipt();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "This transaction reference or receipt number already exists.");
                }
                else
                {
                    MessageBox.Show(
                        "Payment database error:\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to record payment:\n" + ex.Message);
            }
        }

        // =====================================
        // ADMINISTRATOR PAYMENT REVERSAL
        // =====================================

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show(
                    "Only an Administrator can reverse payments.");
                return;
            }

            DataRowView row = GetSelectedHistoryRow();

            if (row == null || assessmentId <= 0)
                return;

            int originalId = Convert.ToInt32(
                row["PaymentID"]);

            if (Convert.ToDecimal(row["AmountChange"]) <= 0m ||
                Convert.ToInt32(row["IsReversed"]) != 0)
            {
                MessageBox.Show(
                    "This transaction cannot be reversed.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Reverse Payment #" + originalId + "?\n\n" +
                "The original transaction will remain in history.",
                "Confirm Reversal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction(
                            IsolationLevel.Serializable))
                    {
                        decimal assessmentTotal =
                            GetLockedAssessmentTotal(
                                connection, transaction);

                        string findSql = @"
                            SELECT AmountChange
                            FROM dbo.AssessmentPayments
                                 WITH (UPDLOCK, HOLDLOCK)
                            WHERE PaymentID = @PaymentID
                              AND AssessmentID = @AssessmentID
                              AND AmountChange > 0
                              AND NOT EXISTS
                              (
                                  SELECT 1
                                  FROM dbo.AssessmentPayments r
                                  WHERE r.ReversesPaymentID =
                                      @PaymentID
                              );";

                        object originalAmount;

                        using (SqlCommand command =
                            new SqlCommand(
                                findSql, connection, transaction))
                        {
                            command.Parameters.Add(
                                "@PaymentID", SqlDbType.Int)
                                .Value = originalId;

                            command.Parameters.Add(
                                "@AssessmentID", SqlDbType.Int)
                                .Value = assessmentId;

                            originalAmount = command.ExecuteScalar();
                        }

                        if (originalAmount == null)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "Payment already reversed or no longer valid.");
                            return;
                        }

                        decimal amount = Convert.ToDecimal(
                            originalAmount);

                        decimal paid =
                            GetLockedPaidTotal(
                                connection, transaction);

                        decimal paidAfter = paid - amount;

                        if (paidAfter < 0m)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "Reversal would create a negative payment total.");
                            return;
                        }

                        decimal balanceAfter =
                            Math.Max(0m,
                                assessmentTotal - paidAfter);

                        string sql = @"
                            INSERT INTO dbo.AssessmentPayments
                            (
                                AssessmentID,
                                AmountChange,
                                PaymentDate,
                                PaymentMethod,
                                ReferenceNumber,
                                PaymentDescription,
                                RecordedBy,
                                Remarks,
                                AssessmentTotalAtPayment,
                                TotalPaidAfter,
                                RemainingBalanceAfter,
                                ReversesPaymentID
                            )
                            VALUES
                            (
                                @AssessmentID,
                                @Amount,
                                SYSDATETIME(),
                                'Adjustment',
                                @Reference,
                                @Description,
                                @RecordedBy,
                                @Remarks,
                                @TotalAssessment,
                                @PaidAfter,
                                @BalanceAfter,
                                @OriginalPaymentID
                            );";

                        using (SqlCommand command =
                            new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.Add(
                                "@AssessmentID", SqlDbType.Int)
                                .Value = assessmentId;

                            AddAmount(command, "@Amount", -amount);

                            string reversalReference =
                                "REV-" + originalId;

                            command.Parameters.Add(
                                "@Reference",
                                SqlDbType.NVarChar, 100)
                                .Value = reversalReference;

                            string description =
                                "Reversal of Payment #" + originalId;

                            command.Parameters.Add(
                                "@Description",
                                SqlDbType.NVarChar, 250)
                                .Value = description;

                            command.Parameters.Add(
                                "@RecordedBy",
                                SqlDbType.NVarChar, 100)
                                .Value = currentUsername;

                            command.Parameters.Add(
                                "@Remarks",
                                SqlDbType.NVarChar, 250)
                                .Value = description;

                            AddAmount(
                                command, "@TotalAssessment",
                                assessmentTotal);

                            AddAmount(
                                command, "@PaidAfter",
                                paidAfter);

                            AddAmount(
                                command, "@BalanceAfter",
                                balanceAfter);

                            command.Parameters.Add(
                                "@OriginalPaymentID",
                                SqlDbType.Int)
                                .Value = originalId;

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                LoadAccount();

                MessageBox.Show(
                    "Payment reversed. The original record was preserved.",
                    "Reversal Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to reverse payment:\n" +
                    ex.Message);
            }
        }

        // =====================================
        // CLEAR PAYMENT INPUTS
        // =====================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtReference.Clear();
            txtDescription.Clear();

            dtpPaymentDate.Value = DateTime.Today;
            cmbMethod.SelectedIndex = 0;
        }

        // =====================================
        // PRINT RECEIPT
        // =====================================

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PreviewReceipt();
        }

        private void PreviewReceipt()
        {
            if (!CanView() || selectedReceipt == null)
            {
                MessageBox.Show(
                    "Select a valid receipt from payment history.");
                return;
            }

            ReceiptData receipt = selectedReceipt;

            using (PrintDocument document = new PrintDocument())
            {
                document.DocumentName =
                    "EduVance Receipt " + receipt.Number;

                document.PrintPage += (s, e) =>
                {
                    float x = e.MarginBounds.Left;
                    float y = e.MarginBounds.Top;

                    using (Font titleFont =
                        new Font("Segoe UI", 17F, FontStyle.Bold))
                    using (Font normalFont =
                        new Font("Segoe UI", 11F))
                    using (Font boldFont =
                        new Font("Segoe UI", 11F, FontStyle.Bold))
                    {
                        e.Graphics.DrawString(
                            "EduVance Academy",
                            titleFont, Brushes.Black, x, y);
                        y += 42;

                        e.Graphics.DrawString(
                            "OFFICIAL PAYMENT RECEIPT",
                            boldFont, Brushes.Black, x, y);
                        y += 38;

                        e.Graphics.DrawString(
                            "Receipt No.: " + receipt.Number,
                            normalFont, Brushes.Black, x, y);
                        y += 28;

                        e.Graphics.DrawString(
                            "Receipt Date: " +
                            receipt.Date.ToString(
                                "MMMM dd, yyyy hh:mm tt"),
                            normalFont, Brushes.Black, x, y);
                        y += 36;

                        e.Graphics.DrawString(
                            "Student: " + receipt.Student,
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "Student ID: " + receipt.StudentID,
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "School Year: " + receipt.SchoolYear,
                            normalFont, Brushes.Black, x, y);
                        y += 38;

                        e.Graphics.DrawString(
                            "Payment Method: " + receipt.Method,
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "Reference: " + receipt.Reference,
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "Description: " + receipt.Description,
                            normalFont, Brushes.Black, x, y);
                        y += 40;

                        e.Graphics.DrawString(
                            "Payment Received: " +
                            Money(receipt.Payment),
                            boldFont, Brushes.Black, x, y);
                        y += 35;

                        e.Graphics.DrawString(
                            "Total Assessment: " +
                            Money(receipt.AssessmentTotal),
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "Total Paid After Payment: " +
                            Money(receipt.PaidAfter),
                            normalFont, Brushes.Black, x, y);
                        y += 27;

                        e.Graphics.DrawString(
                            "Remaining Balance: " +
                            Money(receipt.BalanceAfter),
                            boldFont, Brushes.Black, x, y);
                        y += 45;

                        e.Graphics.DrawString(
                            "Recorded by: " + receipt.RecordedBy,
                            normalFont, Brushes.Black, x, y);
                        y += 38;

                        e.Graphics.DrawString(
                            "Thank you for your payment!",
                            normalFont, Brushes.Black, x, y);
                    }

                    e.HasMorePages = false;
                };
                using (PrintPreviewDialog dialog =
                    new PrintPreviewDialog())
                {
                    dialog.Document = document;
                    dialog.Width = 900;
                    dialog.Height = 720;
                    dialog.ShowDialog(this);
                }
            }
        }
    }
}
