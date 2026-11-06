
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class AssessmentModuleUI : Form
    {
        private readonly Timer paymentTimer = new Timer();

        private bool isLoading = false;
        private bool hasEnrollment = false;

        private int assessmentId = 0;
        private decimal amountPaid = 0m;

        private string currentRole = "";
        private int? ownStudentId = null;

        private const decimal MaxAmount =
            9999999999999999.99m;

        // =====================================
        // CONSTRUCTOR
        // =====================================

        public AssessmentModuleUI()
        {
            InitializeComponent();

            ResetFeeInputs();
            UpdateTotals();

            // Student and school year selection
            cmbStudent.SelectedIndexChanged +=
                (s, e) => LoadSchoolYears();

            cmbSchoolYear.SelectedIndexChanged +=
                (s, e) => LoadEnrollment();

            // Automatic calculations
            txtTuition.TextChanged +=
                (s, e) => UpdateTotals();

            txtMisc.TextChanged +=
                (s, e) => UpdateTotals();

            txtOther.TextChanged +=
                (s, e) => UpdateTotals();

            txtDiscount.TextChanged +=
                (s, e) => UpdateTotals();

            // Button events
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;

            // Automatically refresh payment totals
            paymentTimer.Interval = 5000;

            paymentTimer.Tick +=
                (s, e) => LoadPayments();

            this.Shown += (s, e) =>
            {
                LoadStudents();

                if (CanView())
                    paymentTimer.Start();
            };

            this.FormClosed += (s, e) =>
            {
                paymentTimer.Stop();
                paymentTimer.Dispose();
            };

            ApplyPermissions();
        }

        // =====================================
        // USER ROLE AND PERMISSIONS
        // =====================================

        public void SetUserContext(
            string authenticatedRole,
            int? studentId = null)
        {
            currentRole =
                (authenticatedRole ?? "").Trim();

            ownStudentId = studentId;

            ApplyPermissions();

            if (this.Visible)
                LoadStudents();
        }

        private bool IsStudentRole()
        {
            return currentRole.Equals(
                "Student",
                StringComparison.OrdinalIgnoreCase);
        }

        private bool CanEdit()
        {
            return currentRole.Equals(
                "Admin",
                StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                "Administrator",
                StringComparison.OrdinalIgnoreCase)
                || currentRole.Equals(
                "Registrar",
                StringComparison.OrdinalIgnoreCase);
        }

        private bool CanView()
        {
            if (CanEdit())
                return true;

            if (currentRole.Equals(
                "Cashier",
                StringComparison.OrdinalIgnoreCase))
                return true;

            if (currentRole.Equals(
                "Staff",
                StringComparison.OrdinalIgnoreCase))
                return true;

            if (IsStudentRole() && ownStudentId.HasValue)
                return true;

            return false;
        }

        private void ApplyPermissions()
        {
            bool canEdit = CanEdit();
            bool canView = CanView();

            // Only authorized users can change fees
            txtTuition.ReadOnly = !canEdit;
            txtMisc.ReadOnly = !canEdit;
            txtOther.ReadOnly = !canEdit;
            txtDiscount.ReadOnly = !canEdit;

            // These fields are always read-only
            txtStudentName.ReadOnly = true;
            txtGrade.ReadOnly = true;
            txtSection.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtAmountPaid.ReadOnly = true;
            txtRemainingBalance.ReadOnly = true;

            btnSave.Enabled = canEdit;
            btnClear.Enabled = canEdit;
            btnRefresh.Enabled = canView;

            cmbStudent.Enabled =
                canView && !IsStudentRole();

            cmbSchoolYear.Enabled = canView;

            lblStatus.Text = canView
                ? "Logged in as: " + currentRole
                : "Access denied. Valid login role required.";
        }

        // =====================================
        // DATABASE CONNECTION
        // =====================================

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                DatabaseConnection.ConnectionString);
        }

        private bool GetSelectedStudentId(out int studentId)
        {
            studentId = 0;

            if (cmbStudent.SelectedIndex < 0)
                return false;

            return int.TryParse(
                Convert.ToString(cmbStudent.SelectedValue),
                out studentId);
        }

        private void AddMoneyParameter(
            SqlCommand command,
            string parameterName,
            decimal value)
        {
            SqlParameter parameter =
                command.Parameters.Add(
                    parameterName,
                    SqlDbType.Decimal);

            parameter.Precision = 18;
            parameter.Scale = 2;
            parameter.Value = value;
        }

        // =====================================
        // LOAD STUDENTS FROM SQL
        // =====================================

        private void LoadStudents()
        {
            isLoading = true;

            bool selectOwnAccount = false;

            try
            {
                cmbStudent.DataSource = null;
                cmbSchoolYear.Items.Clear();

                ClearStudentDetails();

                if (!CanView())
                {
                    lblStatus.Text =
                        "You do not have permission to view assessments.";
                    return;
                }

                string sql = @"
                    SELECT
                        s.StudentID,
                        s.FullName
                    FROM dbo.Students s
                    WHERE EXISTS
                    (
                        SELECT 1
                        FROM dbo.Enrollments e
                        WHERE e.StudentID = s.StudentID
                    )
                    AND
                    (
                        @StudentID IS NULL
                        OR s.StudentID = @StudentID
                    )
                    ORDER BY s.FullName;";

                DataTable table = new DataTable();

                using (SqlConnection connection =
                    GetConnection())
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@StudentID",
                        SqlDbType.Int).Value =
                        IsStudentRole()
                        ? (object)ownStudentId.Value
                        : DBNull.Value;

                    adapter.Fill(table);
                }

                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentID";
                cmbStudent.DataSource = table;

                cmbStudent.SelectedIndex = -1;

                selectOwnAccount =
                    IsStudentRole() && table.Rows.Count > 0;

                lblStatus.Text = table.Rows.Count > 0
                    ? "Select an enrolled student."
                    : "No enrolled students found.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load students:\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }

            if (selectOwnAccount)
            {
                cmbStudent.SelectedIndex = 0;
                cmbStudent.Enabled = false;
            }
        }

        // =====================================
        // LOAD SCHOOL YEARS
        // =====================================

        private void LoadSchoolYears()
        {
            if (isLoading || !CanView())
                return;

            int studentId;

            if (!GetSelectedStudentId(out studentId))
                return;

            isLoading = true;

            cmbSchoolYear.Items.Clear();
            ClearStudentDetails();

            try
            {
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
                        "@StudentID",
                        SqlDbType.Int).Value = studentId;

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
                    "Unable to load school years:\n"
                    + ex.Message);
            }
            finally
            {
                isLoading = false;
            }

            if (cmbSchoolYear.Items.Count > 0)
                cmbSchoolYear.SelectedIndex = 0;
        }

        // =====================================
        // LOAD ENROLLMENT INFORMATION
        // =====================================

        private void LoadEnrollment()
        {
            if (isLoading || !CanView())
                return;

            ClearStudentDetails();

            int studentId;

            if (!GetSelectedStudentId(out studentId))
                return;

            string schoolYear = cmbSchoolYear.Text.Trim();

            if (schoolYear == "")
                return;

            try
            {
                using (SqlConnection connection =
                    GetConnection())
                {
                    connection.Open();

                    // Check whether the GradeLevel
                    // column exists in Enrollments.
                    bool hasGradeColumn = false;

                    using (SqlCommand checkCommand =
                        new SqlCommand(
                            @"SELECT COL_LENGTH(
                                'dbo.Enrollments',
                                'GradeLevel');",
                            connection))
                    {
                        object result =
                            checkCommand.ExecuteScalar();

                        hasGradeColumn =
                            result != null &&
                            result != DBNull.Value;
                    }

                    string gradeColumn = hasGradeColumn
                        ? "e.GradeLevel"
                        : "CAST(NULL AS NVARCHAR(30))";

                    string sql = @"
                        SELECT TOP (1)
                            s.FullName,
                            " + gradeColumn + @" AS GradeLevel,
                            sec.SectionName

                        FROM dbo.Enrollments e

                        INNER JOIN dbo.Students s
                            ON s.StudentID = e.StudentID

                        LEFT JOIN dbo.Sections sec
                            ON sec.SectionID = e.SectionID

                        WHERE
                            e.StudentID = @StudentID
                            AND e.SchoolYear = @SchoolYear

                        ORDER BY e.EnrollmentDate DESC;";

                    using (SqlCommand command =
                        new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add(
                            "@StudentID",
                            SqlDbType.Int).Value = studentId;

                        command.Parameters.Add(
                            "@SchoolYear",
                            SqlDbType.NVarChar, 20).Value =
                            schoolYear;

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hasEnrollment = true;

                                txtStudentName.Text =
                                    Convert.ToString(
                                        reader["FullName"]);

                                txtGrade.Text =
                                    reader["GradeLevel"] ==
                                    DBNull.Value
                                    ? "Not recorded"
                                    : Convert.ToString(
                                        reader["GradeLevel"]);

                                txtSection.Text =
                                    reader["SectionName"] ==
                                    DBNull.Value
                                    ? "Not assigned"
                                    : Convert.ToString(
                                        reader["SectionName"]);
                            }
                        }
                    }
                }

                if (!hasEnrollment)
                {
                    lblStatus.Text =
                        "No valid enrollment found.";
                    return;
                }

                LoadSavedAssessment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load enrollment:\n"
                    + ex.Message,
                    "Enrollment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // LOAD EXISTING ASSESSMENT
        // =====================================

        private void LoadSavedAssessment()
        {
            assessmentId = 0;
            amountPaid = 0m;

            ResetFeeInputs();
            UpdateTotals();

            int studentId;

            if (!hasEnrollment ||
                !GetSelectedStudentId(out studentId))
                return;

            string sql = @"
                SELECT
                    AssessmentID,
                    TuitionFee,
                    MiscellaneousFee,
                    OtherFee,
                    Discount
                FROM dbo.Assessments
                WHERE
                    StudentID = @StudentID
                    AND SchoolYear = @SchoolYear;";

            try
            {
                using (SqlConnection connection =
                    GetConnection())
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@StudentID",
                        SqlDbType.Int).Value = studentId;

                    command.Parameters.Add(
                        "@SchoolYear",
                        SqlDbType.NVarChar, 20).Value =
                        cmbSchoolYear.Text;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            assessmentId =
                                Convert.ToInt32(
                                    reader["AssessmentID"]);

                            txtTuition.Text =
                                Convert.ToDecimal(
                                    reader["TuitionFee"])
                                .ToString(
                                    "N2",
                                    CultureInfo.InvariantCulture);

                            txtMisc.Text =
                                Convert.ToDecimal(
                                    reader["MiscellaneousFee"])
                                .ToString(
                                    "N2",
                                    CultureInfo.InvariantCulture);

                            txtOther.Text =
                                Convert.ToDecimal(
                                    reader["OtherFee"])
                                .ToString(
                                    "N2",
                                    CultureInfo.InvariantCulture);

                            txtDiscount.Text =
                                Convert.ToDecimal(
                                    reader["Discount"])
                                .ToString(
                                    "N2",
                                    CultureInfo.InvariantCulture);
                        }
                    }
                }

                LoadPayments();
                UpdateTotals();

                lblStatus.Text = assessmentId > 0
                    ? "Saved assessment loaded."
                    : "No saved assessment. Enter the fees.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load assessment:\n"
                    + ex.Message,
                    "Assessment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // AUTOMATIC PAYMENT REFRESH
        // =====================================

        private void LoadPayments()
        {
            if (!CanView())
                return;

            if (!hasEnrollment || assessmentId <= 0)
            {
                amountPaid = 0m;
                UpdateTotals();
                return;
            }

            string sql = @"
                SELECT
                    COALESCE(SUM(AmountChange), 0)
                FROM dbo.AssessmentPayments
                WHERE AssessmentID = @AssessmentID;";

            try
            {
                using (SqlConnection connection =
                    GetConnection())
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@AssessmentID",
                        SqlDbType.Int).Value = assessmentId;

                    connection.Open();

                    decimal netPayments =
                        Convert.ToDecimal(
                            command.ExecuteScalar());

                    // A negative net total means the payment
                    // ledger needs correction.
                    amountPaid = Math.Max(0m, netPayments);

                    if (netPayments < 0m)
                    {
                        lblStatus.Text =
                            "Warning: payment reversals exceed payments.";
                    }
                }

                UpdateTotals();
            }
            catch (Exception ex)
            {
                paymentTimer.Stop();

                MessageBox.Show(
                    "Unable to refresh payments:\n"
                    + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // LIVE CALCULATION
        // =====================================

        private decimal ReadAmount(TextBox textbox)
        {
            decimal value;

            if (decimal.TryParse(
                textbox.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out value))
            {
                return value;
            }

            return 0m;
        }

        private void UpdateTotals()
        {
            decimal tuition = ReadAmount(txtTuition);
            decimal misc = ReadAmount(txtMisc);
            decimal other = ReadAmount(txtOther);
            decimal discount = ReadAmount(txtDiscount);

            decimal total =
                tuition + misc + other - discount;

            decimal difference = total - amountPaid;

            decimal remaining =
                Math.Max(0m, difference);

            decimal credit =
                Math.Max(0m, -difference);

            txtTotal.Text = total.ToString(
                "N2", CultureInfo.InvariantCulture);

            txtAmountPaid.Text = amountPaid.ToString(
                "N2", CultureInfo.InvariantCulture);

            txtRemainingBalance.Text =
                remaining.ToString(
                    "N2", CultureInfo.InvariantCulture);

            lblCredit.Text =
                "Credit Balance: " +
                credit.ToString(
                    "N2", CultureInfo.InvariantCulture);
        }

        // =====================================
        // VALIDATE FEE INPUTS
        // =====================================

        private bool ValidateMoney(
            TextBox textbox,
            string fieldName,
            out decimal value)
        {
            bool valid = decimal.TryParse(
                textbox.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out value);

            if (!valid ||
                value < 0m ||
                value > MaxAmount ||
                decimal.Round(value, 2) != value)
            {
                MessageBox.Show(
                    fieldName +
                    " must be a valid nonnegative amount " +
                    "with up to 2 decimal places.",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textbox.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // SAVE ASSESSMENT
        // =====================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!CanEdit())
            {
                MessageBox.Show(
                    "You are not authorized to save assessments.");
                return;
            }

            int studentId;

            if (!hasEnrollment ||
                !GetSelectedStudentId(out studentId) ||
                string.IsNullOrWhiteSpace(
                    cmbSchoolYear.Text))
            {
                MessageBox.Show(
                    "Please select a valid enrolled student.");
                return;
            }

            decimal tuition;
            decimal misc;
            decimal other;
            decimal discount;

            if (!ValidateMoney(
                txtTuition, "Tuition Fee", out tuition))
                return;

            if (!ValidateMoney(
                txtMisc, "Miscellaneous Fees", out misc))
                return;

            if (!ValidateMoney(
                txtOther, "Other Fees", out other))
                return;

            if (!ValidateMoney(
                txtDiscount, "Discount", out discount))
                return;

            decimal totalFees =
                tuition + misc + other;

            if (totalFees > MaxAmount)
            {
                MessageBox.Show(
                    "Total fees are too large.");
                return;
            }

            if (discount > totalFees)
            {
                MessageBox.Show(
                    "Discount cannot exceed total fees.");
                txtDiscount.Focus();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Save this student's assessment?",
                "Confirm Assessment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            string schoolYear = cmbSchoolYear.Text.Trim();

            string sql = @"
                UPDATE dbo.Assessments
                SET
                    TuitionFee = @Tuition,
                    MiscellaneousFee = @Misc,
                    OtherFee = @Other,
                    Discount = @Discount,
                    LastUpdated = SYSDATETIME()
                WHERE
                    StudentID = @StudentID
                    AND SchoolYear = @SchoolYear;

                IF @@ROWCOUNT = 0
                BEGIN
                    INSERT INTO dbo.Assessments
                    (
                        StudentID,
                        SchoolYear,
                        TuitionFee,
                        MiscellaneousFee,
                        OtherFee,
                        Discount
                    )
                    VALUES
                    (
                        @StudentID,
                        @SchoolYear,
                        @Tuition,
                        @Misc,
                        @Other,
                        @Discount
                    );
                END;";

            try
            {
                using (SqlConnection connection =
                    GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction(
                            IsolationLevel.Serializable))
                    {
                        // Check enrollment before saving.
                        string checkSql = @"
                            SELECT COUNT(*)
                            FROM dbo.Enrollments
                            WHERE
                                StudentID = @StudentID
                                AND SchoolYear = @SchoolYear;";

                        using (SqlCommand check =
                            new SqlCommand(
                                checkSql,
                                connection,
                                transaction))
                        {
                            check.Parameters.Add(
                                "@StudentID",
                                SqlDbType.Int).Value = studentId;

                            check.Parameters.Add(
                                "@SchoolYear",
                                SqlDbType.NVarChar, 20).Value =
                                schoolYear;

                            int count = Convert.ToInt32(
                                check.ExecuteScalar());

                            if (count == 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "Student enrollment is no longer valid.");
                                return;
                            }
                        }

                        // Save or update the assessment.
                        using (SqlCommand command =
                            new SqlCommand(
                                sql,
                                connection,
                                transaction))
                        {
                            command.Parameters.Add(
                                "@StudentID",
                                SqlDbType.Int).Value = studentId;

                            command.Parameters.Add(
                                "@SchoolYear",
                                SqlDbType.NVarChar, 20).Value =
                                schoolYear;

                            AddMoneyParameter(
                                command, "@Tuition", tuition);

                            AddMoneyParameter(
                                command, "@Misc", misc);

                            AddMoneyParameter(
                                command, "@Other", other);

                            AddMoneyParameter(
                                command, "@Discount", discount);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                MessageBox.Show(
                    "Assessment saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadSavedAssessment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save assessment:\n"
                    + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // CLEAR INPUTS
        // =====================================

        private void ResetFeeInputs()
        {
            txtTuition.Text = "0.00";
            txtMisc.Text = "0.00";
            txtOther.Text = "0.00";
            txtDiscount.Text = "0.00";
        }

        private void ClearStudentDetails()
        {
            hasEnrollment = false;
            assessmentId = 0;
            amountPaid = 0m;

            txtStudentName.Clear();
            txtGrade.Clear();
            txtSection.Clear();

            ResetFeeInputs();
            UpdateTotals();
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            if (!CanEdit())
                return;

            ResetFeeInputs();
            UpdateTotals();

            lblStatus.Text =
                "Inputs cleared. Saved assessment unchanged.";
        }

        // =====================================
        // REFRESH DATA
        // =====================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            if (!CanView())
                return;

            if (hasEnrollment)
            {
                LoadEnrollment();
            }
            else
            {
                LoadStudents();
            }

            paymentTimer.Start();
        }
    }
}
