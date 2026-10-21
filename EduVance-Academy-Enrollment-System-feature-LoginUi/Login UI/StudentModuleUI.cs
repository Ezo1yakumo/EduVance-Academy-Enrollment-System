
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class StudentModuleUI : Form
    {
        private readonly string connectionString =
            DatabaseConnection.ConnectionString;

        private int selectedStudentId = 0;
        private int pendingDeleteStudentId = 0;

        private bool loadingStudents = false;
        private bool changingSearch = false;

        public StudentModuleUI()
        {
            InitializeComponent();

            // CONNECT BUTTONS
            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;

            btnAddNewStudent.Click -= btnAddNewStudent_Click;
            btnAddNewStudent.Click += btnAddNewStudent_Click;

            btnClearFilter.Click -= btnClearFilter_Click;
            btnClearFilter.Click += btnClearFilter_Click;

            btnYesDelete.Click -= btnYesDelete_Click;
            btnYesDelete.Click += btnYesDelete_Click;

            btnNoDelete.Click -= btnNoDelete_Click;
            btnNoDelete.Click += btnNoDelete_Click;

            // CONNECT SEARCH BOXES
            txtSearchName.TextChanged -= txtSearchName_TextChanged;
            txtSearchName.TextChanged += txtSearchName_TextChanged;

            txtSearchId.TextChanged -= txtSearchId_TextChanged;
            txtSearchId.TextChanged += txtSearchId_TextChanged;

            // CONNECT STUDENT TABLE
            dgvStudents.SelectionChanged -= dgvStudents_SelectionChanged;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;

            dgvStudents.CellClick += dgvStudents_CellClick;

            // GENDER OPTIONS
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(
                new object[] { "Male", "Female", "Other" });

            // TABLE SETTINGS
            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.Columns.Clear();

            dgvStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;

            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // DISPLAY SAVED STUDENTS
            LoadStudents();
        }

        // LOAD STUDENTS FROM DATABASE
        private void LoadStudents(
            string nameFilter = "", string idFilter = "")
        {
            string sql = @"
                SELECT StudentID, FullName, Gender,
                       DateOfBirth, Address,
                       ContactNumber, EmailAddress
                FROM dbo.Students
                WHERE (@Name = ''
                    OR FullName LIKE '%' + @Name + '%')
                  AND (@ID = ''
                    OR CONVERT(NVARCHAR(20), StudentID) = @ID)
                ORDER BY StudentID DESC";

            try
            {
                loadingStudents = true;

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@Name", SqlDbType.NVarChar, 150)
                        .Value = nameFilter;

                    adapter.SelectCommand.Parameters.Add(
                        "@ID", SqlDbType.NVarChar, 20)
                        .Value = idFilter;

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStudents.DataSource = table;
                    dgvStudents.ClearSelection();
                    dgvStudents.CurrentCell = null;

                    selectedStudentId = 0;
                    pendingDeleteStudentId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students:\n" + ex.Message);
            }
            finally
            {
                loadingStudents = false;
            }
        }

        // SAVE OR UPDATE STUDENT
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string gender = cmbGender.Text.Trim();
            string address = txtaddress.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string email = txtEmailAddress.Text.Trim();

            if (fullName == "" || gender == "" ||
                address == "" || contact == "" || email == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            bool addingNew = selectedStudentId == 0;
            string sql;

            if (addingNew)
            {
                sql = @"
                    INSERT INTO dbo.Students
                    (FullName, Gender, DateOfBirth,
                     Address, ContactNumber, EmailAddress)
                    VALUES
                    (@FullName, @Gender, @DateOfBirth,
                     @Address, @ContactNumber, @EmailAddress)";
            }
            else
            {
                sql = @"
                    UPDATE dbo.Students
                    SET FullName = @FullName,
                        Gender = @Gender,
                        DateOfBirth = @DateOfBirth,
                        Address = @Address,
                        ContactNumber = @ContactNumber,
                        EmailAddress = @EmailAddress
                    WHERE StudentID = @StudentID";
            }

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(
                        "@FullName", SqlDbType.NVarChar, 150)
                        .Value = fullName;

                    command.Parameters.Add(
                        "@Gender", SqlDbType.NVarChar, 20)
                        .Value = gender;

                    command.Parameters.Add(
                        "@DateOfBirth", SqlDbType.Date)
                        .Value = dtpDateOfBirth.Value.Date;

                    command.Parameters.Add(
                        "@Address", SqlDbType.NVarChar, 300)
                        .Value = address;

                    command.Parameters.Add(
                        "@ContactNumber", SqlDbType.NVarChar, 30)
                        .Value = contact;

                    command.Parameters.Add(
                        "@EmailAddress", SqlDbType.NVarChar, 150)
                        .Value = email;

                    if (!addingNew)
                    {
                        command.Parameters.Add(
                            "@StudentID", SqlDbType.Int)
                            .Value = selectedStudentId;
                    }

                    connection.Open();

                    int affected = command.ExecuteNonQuery();

                    if (affected == 0)
                    {
                        MessageBox.Show("No student record was changed.");
                        return;
                    }
                }

                MessageBox.Show(
                    addingNew
                    ? "Student saved successfully!"
                    : "Student updated successfully!");

                ClearStudentFields();
                ResetFiltersAndReload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving student:\n" + ex.Message);
            }
        }

        // SELECT STUDENT FOR EDITING
        private void dgvStudents_SelectionChanged(
            object sender, EventArgs e)
        {
            if (loadingStudents ||
                dgvStudents.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvStudents.SelectedRows[0];

            if (row.IsNewRow)
                return;

            selectedStudentId =
                Convert.ToInt32(row.Cells["StudentID"].Value);

            pendingDeleteStudentId = selectedStudentId;

            txtFullName.Text =
                Convert.ToString(row.Cells["FullName"].Value);

            cmbGender.Text =
                Convert.ToString(row.Cells["Gender"].Value);

            dtpDateOfBirth.Value =
                Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

            txtaddress.Text =
                Convert.ToString(row.Cells["Address"].Value);

            txtContactNumber.Text =
                Convert.ToString(row.Cells["ContactNumber"].Value);

            txtEmailAddress.Text =
                Convert.ToString(row.Cells["EmailAddress"].Value);
        }

        private void dgvStudents_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgvStudents_SelectionChanged(sender, EventArgs.Empty);
        }

        // ADD NEW STUDENT
        private void btnAddNewStudent_Click(
            object sender, EventArgs e)
        {
            ClearStudentFields();
            txtFullName.Focus();
        }

        // CANCEL EDITING
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearStudentFields();
        }

        // SEARCH BY NAME
        private void txtSearchName_TextChanged(
            object sender, EventArgs e)
        {
            if (!changingSearch)
            {
                LoadStudents(
                    txtSearchName.Text.Trim(),
                    txtSearchId.Text.Trim());
            }
        }

        // SEARCH BY ID
        private void txtSearchId_TextChanged(
            object sender, EventArgs e)
        {
            if (!changingSearch)
            {
                LoadStudents(
                    txtSearchName.Text.Trim(),
                    txtSearchId.Text.Trim());
            }
        }

        // CLEAR SEARCH FILTERS
        private void btnClearFilter_Click(
            object sender, EventArgs e)
        {
            ResetFiltersAndReload();
        }

        // OPTIONAL DELETE HANDLER
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            pendingDeleteStudentId = selectedStudentId;

            MessageBox.Show(
                "Click Yes, Delete to confirm deletion.");
        }

        // DELETE SELECTED STUDENT
        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            int studentId = pendingDeleteStudentId != 0
                ? pendingDeleteStudentId
                : selectedStudentId;

            if (studentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Delete Student",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "DELETE FROM dbo.Students WHERE StudentID = @ID",
                    connection))
                {
                    command.Parameters.Add(
                        "@ID", SqlDbType.Int).Value = studentId;

                    connection.Open();

                    int affected = command.ExecuteNonQuery();

                    if (affected == 0)
                    {
                        MessageBox.Show("Student was not found.");
                        return;
                    }
                }

                MessageBox.Show("Student deleted successfully!");

                ClearStudentFields();
                ResetFiltersAndReload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot delete student:\n" + ex.Message);
            }
        }

        // CANCEL DELETION
        private void btnNoDelete_Click(object sender, EventArgs e)
        {
            pendingDeleteStudentId = 0;
        }

        // CLEAR INPUT FIELDS
        private void ClearStudentFields()
        {
            selectedStudentId = 0;
            pendingDeleteStudentId = 0;

            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            cmbGender.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            txtaddress.Clear();
            txtContactNumber.Clear();
            txtEmailAddress.Clear();

            dgvStudents.ClearSelection();
            dgvStudents.CurrentCell = null;
        }

        // RELOAD ALL RECORDS
        private void ResetFiltersAndReload()
        {
            changingSearch = true;

            txtSearchName.Clear();
            txtSearchId.Clear();

            changingSearch = false;

            LoadStudents();
        }
    }
}
