using System;
using System.Data;
using EduVance.BusinessLogic.Controller;
using EduVance.Models;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class StudentModuleUI : Form
    {
        private readonly StudentController studentController =
            new StudentController(DatabaseConnection.ConnectionString);

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

        // The UI delegates data access to StudentController -> StudentRepository.
        private void LoadStudents(string nameFilter = "", string idFilter = "")
        {
            try
            {
                loadingStudents = true;
                DataTable table = studentController.SearchStudents(nameFilter, idFilter);
                dgvStudents.DataSource = table;
                dgvStudents.ClearSelection();
                dgvStudents.CurrentCell = null;
                selectedStudentId = 0;
                pendingDeleteStudentId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students:\n" + ex.Message);
            }
            finally
            {
                loadingStudents = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool addingNew = selectedStudentId == 0;
            StudentRecord student = new StudentRecord
            {
                StudentID = selectedStudentId,
                FullName = txtFullName.Text,
                Gender = cmbGender.Text,
                DateOfBirth = dtpDateOfBirth.Value.Date,
                Address = txtaddress.Text,
                ContactNumber = txtContactNumber.Text,
                EmailAddress = txtEmailAddress.Text
            };

            try
            {
                int affected = studentController.SaveStudent(student);
                if (affected == 0)
                {
                    MessageBox.Show("No student record was changed.");
                    return;
                }

                MessageBox.Show(addingNew
                    ? "Student saved successfully!"
                    : "Student updated successfully!");

                ClearStudentFields();
                ResetFiltersAndReload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student:\n" + ex.Message);
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
                int affected = studentController.DeleteStudent(studentId);
                if (affected == 0)
                {
                    MessageBox.Show("Student was not found.");
                    return;
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
