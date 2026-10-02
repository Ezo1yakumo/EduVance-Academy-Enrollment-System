using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class StudentModuleUI : Form
    {
        private readonly string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EduVanceDB;Integrated Security=True;";

        private int selectedStudentId = 0;
        private int pendingDeleteStudentId = 0;

        public StudentModuleUI()
        {
            InitializeComponent();

            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });

            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            LoadStudents();
        }

        private void LoadStudents(string nameFilter = "", string idFilter = "")
        {
            const string sql = @"
                SELECT StudentID, FullName, Gender, DateOfBirth,
                       Address, ContactNumber, EmailAddress
                FROM dbo.Students
                WHERE (@Name = '' OR FullName LIKE '%' + @Name + '%')
                  AND (@ID = '' OR CONVERT(NVARCHAR(20), StudentID) = @ID)
                ORDER BY StudentID DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 150)
                        .Value = nameFilter;
                    adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.NVarChar, 20)
                        .Value = idFilter;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvStudents.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load student records.\n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string gender = cmbGender.Text.Trim();
            string address = txtaddress.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string email = txtEmailAddress.Text.Trim();

            if (fullName == "" || gender == "" || address == "" ||
                contact == "" || email == "")
            {
                MessageBox.Show("Please complete all student fields.");
                return;
            }

            string sql;
            if (selectedStudentId == 0)
            {
                sql = @"
                    INSERT INTO dbo.Students
                        (FullName, Gender, DateOfBirth, Address, ContactNumber, EmailAddress)
                    VALUES
                        (@FullName, @Gender, @DateOfBirth, @Address, @ContactNumber, @EmailAddress);";
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
                    WHERE StudentID = @StudentID;";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value = fullName;
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = gender;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value =
                        dtpDateOfBirth.Value.Date;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar, 300).Value = address;
                    command.Parameters.Add("@ContactNumber", SqlDbType.NVarChar, 30).Value = contact;
                    command.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 150).Value = email;

                    if (selectedStudentId != 0)
                        command.Parameters.Add("@StudentID", SqlDbType.Int).Value = selectedStudentId;

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show(selectedStudentId == 0
                    ? "Student added."
                    : "Student updated.");

                ClearForm();
                LoadStudents(txtSearchName.Text.Trim(), txtSearchId.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the student record.\n" + ex.Message);
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
                dgvStudents.CurrentRow.IsNewRow)
                return;

            DataGridViewRow row = dgvStudents.CurrentRow;

            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
            txtFullName.Text = Convert.ToString(row.Cells["FullName"].Value);
            cmbGender.Text = Convert.ToString(row.Cells["Gender"].Value);
            dtpDateOfBirth.Value =
                Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            txtaddress.Text = Convert.ToString(row.Cells["Address"].Value);
            txtContactNumber.Text = Convert.ToString(row.Cells["ContactNumber"].Value);
            txtEmailAddress.Text = Convert.ToString(row.Cells["EmailAddress"].Value);
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtFullName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchId.Clear();
            LoadStudents();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearchName.Text.Trim(), txtSearchId.Text.Trim());
        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearchName.Text.Trim(), txtSearchId.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student record first.");
                return;
            }

            pendingDeleteStudentId =
                Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);

            MessageBox.Show("Confirm deletion using the Yes, Delete button.");
        }

        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            if (pendingDeleteStudentId == 0)
            {
                MessageBox.Show("Select a student record first.");
                return;
            }

            const string sql =
                "DELETE FROM dbo.Students WHERE StudentID = @StudentID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@StudentID", SqlDbType.Int)
                        .Value = pendingDeleteStudentId;

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                pendingDeleteStudentId = 0;
                ClearForm();
                LoadStudents(txtSearchName.Text.Trim(), txtSearchId.Text.Trim());
                MessageBox.Show("Student deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the student record.\n" + ex.Message);
            }
        }

        private void btnNoDelete_Click(object sender, EventArgs e)
        {
            pendingDeleteStudentId = 0;
        }

        private void ClearForm()
        {
            selectedStudentId = 0;
            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Today;
            txtaddress.Clear();
            txtContactNumber.Clear();
            txtEmailAddress.Clear();
            dgvStudents.ClearSelection();
        }
    }
}