
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class DataBase_Module_UI : Form
    {
        private int selectedSectionId = 0;
        private bool loadingSections = false;

        public DataBase_Module_UI()
        {
            InitializeComponent();

            btnSaveSection.Click += SaveSection_Click;
            btnClearSection.Click += ClearSection_Click;
            btnAddNewSection.Click += ClearSection_Click;
            btnYesDeactivate.Click += DeactivateSection_Click;
            dgvSections.SelectionChanged += SectionSelected;

            dgvSections.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSections.MultiSelect = false;
            dgvSections.ReadOnly = true;
            dgvSections.AllowUserToAddRows = false;
            dgvSections.AutoGenerateColumns = true;
            dgvSections.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.Shown += (s, e) => LoadSections();
        }

        // Keep existing Designer event compatible
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // SAVE NEW SECTION OR UPDATE EXISTING
        private void SaveSection_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string schoolYear = cmbSchoolYear.Text.Trim();
            string gradeLevel = cmbGradeLevel.Text.Trim();
            string sectionName = txtSectionName.Text.Trim();

            if (firstName == "" || lastName == "" ||
                schoolYear == "" || gradeLevel == "" ||
                sectionName == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            string sql;

            if (selectedSectionId == 0)
            {
                sql = @"
                    INSERT INTO dbo.Sections
                    (SectionName, FirstName, LastName,
                     SchoolYear, GradeLevel, IsActive)
                    VALUES
                    (@SectionName, @FirstName, @LastName,
                     @SchoolYear, @GradeLevel, 1)";
            }
            else
            {
                sql = @"
                    UPDATE dbo.Sections
                    SET SectionName = @SectionName,
                        FirstName = @FirstName,
                        LastName = @LastName,
                        SchoolYear = @SchoolYear,
                        GradeLevel = @GradeLevel
                    WHERE SectionID = @SectionID";
            }

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@SectionName",
                        SqlDbType.NVarChar, 100).Value = sectionName;

                    command.Parameters.Add("@FirstName",
                        SqlDbType.NVarChar, 100).Value = firstName;

                    command.Parameters.Add("@LastName",
                        SqlDbType.NVarChar, 100).Value = lastName;

                    command.Parameters.Add("@SchoolYear",
                        SqlDbType.NVarChar, 20).Value = schoolYear;

                    command.Parameters.Add("@GradeLevel",
                        SqlDbType.NVarChar, 30).Value = gradeLevel;

                    if (selectedSectionId != 0)
                    {
                        command.Parameters.Add("@SectionID",
                            SqlDbType.Int).Value = selectedSectionId;
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Section saved successfully!");

                ClearFields();
                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed:\n" + ex.Message);
            }
        }

        // DISPLAY SECTIONS FROM DATABASE
        private void LoadSections()
        {
            string sql = @"
                SELECT
                    SectionID,
                    'SEC-' + CONVERT(VARCHAR(20), SectionID)
                        AS [Section Code],
                    SectionName,
                    SchoolYear,
                    GradeLevel,
                    FirstName,
                    LastName,
                    CASE WHEN IsActive = 1
                         THEN 'Active'
                         ELSE 'Inactive'
                    END AS Status
                FROM dbo.Sections
                ORDER BY SectionID DESC";

            try
            {
                loadingSections = true;

                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvSections.DataSource = null;
                    dgvSections.Columns.Clear();
                    dgvSections.DataSource = table;
                    dgvSections.Columns["SectionID"].Visible = false;
                    dgvSections.ClearSelection();
                }

                selectedSectionId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed:\n" + ex.Message);
            }
            finally
            {
                loadingSections = false;
            }
        }

        // SELECT SECTION TO EDIT
        private void SectionSelected(object sender, EventArgs e)
        {
            if (loadingSections ||
                dgvSections.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvSections.SelectedRows[0];

            if (row.IsNewRow)
                return;

            selectedSectionId =
                Convert.ToInt32(row.Cells["SectionID"].Value);

            txtFirstName.Text =
                Convert.ToString(row.Cells["FirstName"].Value);

            txtLastName.Text =
                Convert.ToString(row.Cells["LastName"].Value);

            cmbSchoolYear.Text =
                Convert.ToString(row.Cells["SchoolYear"].Value);

            cmbGradeLevel.Text =
                Convert.ToString(row.Cells["GradeLevel"].Value);

            txtSectionName.Text =
                Convert.ToString(row.Cells["SectionName"].Value);
        }

        // CLEAR OR ADD NEW
        private void ClearSection_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedSectionId = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbSchoolYear.SelectedIndex = -1;
            cmbSchoolYear.Text = "";
            cmbGradeLevel.SelectedIndex = -1;
            cmbGradeLevel.Text = "";
            txtSectionName.Clear();
            dgvSections.ClearSelection();
        }

        // DEACTIVATE SELECTED SECTION
        private void DeactivateSection_Click(object sender, EventArgs e)
        {
            if (selectedSectionId == 0)
            {
                MessageBox.Show("Select a section first.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Deactivate this section?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                using (SqlCommand command = new SqlCommand(
                    "UPDATE dbo.Sections SET IsActive = 0 WHERE SectionID = @ID",
                    connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int)
                        .Value = selectedSectionId;

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                ClearFields();
                LoadSections();
                MessageBox.Show("Section deactivated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed:\n" + ex.Message);
            }
        }
    }
}
