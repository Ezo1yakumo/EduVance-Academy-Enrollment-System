using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Login_UI
{
    public partial class EnrollmentModuleUI : Form
    {
        public EnrollmentModuleUI()
        {
            InitializeComponent();

            SetupEnrollmentRecords();

            // Keep your other existing constructor code here.
        
        // sample dropdown values
        cmbSchoolYear.Items.AddRange(new object[]
            {
                "2026-2027",
                "2027-2028",
                "2028-2029"
            });

            cmbGradeLevel.Items.AddRange(new object[]
            {
                "Grade 7",
                "Grade 8",
                "Grade 9",
                "Grade 10",
                "Grade 11",
                "Grade 12"
            });

            cmbSection.Items.AddRange(new object[]
            {
                "Section A",
                "Section B",
                "Section C"
            });

            cmbEnrollmentType.Items.AddRange(new object[]
            {
                "New Student",
                "Old Student",
                "Transferee"
            });

            cmbEnrollmentStatus.Items.AddRange(new object[]
            {
                "Pending",
                "Approved",
                "Rejected"
            });

            if (cmbSchoolYear.Items.Count > 0) cmbSchoolYear.SelectedIndex = 0;
            if (cmbGradeLevel.Items.Count > 0) cmbGradeLevel.SelectedIndex = 0;
            if (cmbSection.Items.Count > 0) cmbSection.SelectedIndex = 0;
            if (cmbEnrollmentType.Items.Count > 0) cmbEnrollmentType.SelectedIndex = 0;
            if (cmbEnrollmentStatus.Items.Count > 0) cmbEnrollmentStatus.SelectedIndex = 0;
        }


        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            int studentId;

            // Check if Student ID is valid
            if (!int.TryParse(txtStudentID.Text.Trim(), out studentId)
                || studentId <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid Student ID.");
                return;
            }

            try
            {
                // Search student from EduVance database
                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    connection.Open();

                    string sql = @"
                SELECT FullName
                FROM dbo.Students
                WHERE StudentID = @StudentID";

                    using (SqlCommand command =
                        new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add(
                            "@StudentID", System.Data.SqlDbType.Int)
                            .Value = studentId;

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            string fullName = result.ToString();

                            // Display the selected student in the form
                            groupBoxForm.Text =
                                "Enrollment Form - " + fullName;

                            MessageBox.Show(
                                "Student Found!\n\n" +
                                "Student ID: " + studentId + "\n" +
                                "Full Name: " + fullName,
                                "Student Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            groupBoxForm.Text = "Enrollment Form";

                            MessageBox.Show(
                                "Student ID not found in the database.",
                                "Student Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int studentId;

            if (!int.TryParse(txtStudentID.Text.Trim(), out studentId)
                || studentId <= 0)
            {
                MessageBox.Show("Enter a valid Student ID.");
                return;
            }

            string schoolYear = cmbSchoolYear.Text.Trim();
            string gradeLevel = cmbGradeLevel.Text.Trim();
            string section = cmbSection.Text.Trim();
            string enrollmentType = cmbEnrollmentType.Text.Trim();
            string enrollmentStatus = cmbEnrollmentStatus.Text.Trim();

            if (schoolYear == "" || gradeLevel == "" ||
                section == "" || enrollmentType == "" ||
                enrollmentStatus == "")
            {
                MessageBox.Show("Please complete all enrollment fields.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to enroll this student?",
                "Confirm Enrollment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    connection.Open();

                    // Verify Student ID
                    string checkStudent = @"
                SELECT COUNT(*)
                FROM dbo.Students
                WHERE StudentID = @StudentID";

                    using (SqlCommand command =
                        new SqlCommand(checkStudent, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StudentID", studentId);

                        if ((int)command.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("Student ID does not exist.");
                            return;
                        }
                    }

                    // Check duplicate enrollment
                    string checkDuplicate = @"
                SELECT COUNT(*)
                FROM dbo.Enrollments
                WHERE StudentID = @StudentID
                AND SchoolYear = @SchoolYear";

                    using (SqlCommand command =
                        new SqlCommand(checkDuplicate, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StudentID", studentId);

                        command.Parameters.AddWithValue(
                            "@SchoolYear", schoolYear);

                        if ((int)command.ExecuteScalar() > 0)
                        {
                            MessageBox.Show(
                                "This student is already enrolled for this school year.");
                            return;
                        }
                    }

                    // Get the Section ID
                    string findSection = @"
                SELECT TOP 1 SectionID
                FROM dbo.Sections
                WHERE SectionName = @SectionName";

                    int sectionId;

                    using (SqlCommand command =
                        new SqlCommand(findSection, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@SectionName", section);

                        object result = command.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show(
                                "The selected section was not found in the database.");
                            return;
                        }

                        sectionId = Convert.ToInt32(result);
                    }

                    // Save enrollment
                    string insertSql = @"
                INSERT INTO dbo.Enrollments
                (
                    StudentID,
                    SchoolYear,
                    GradeLevel,
                    SectionID,
                    EnrollmentDate,
                    EnrollmentType,
                    EnrollmentStatus
                )
                VALUES
                (
                    @StudentID,
                    @SchoolYear,
                    @GradeLevel,
                    @SectionID,
                    @EnrollmentDate,
                    @EnrollmentType,
                    @EnrollmentStatus
                )";

                    using (SqlCommand command =
                        new SqlCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@StudentID", studentId);

                        command.Parameters.AddWithValue(
                            "@SchoolYear", schoolYear);

                        command.Parameters.AddWithValue(
                            "@GradeLevel", gradeLevel);

                        command.Parameters.AddWithValue(
                            "@SectionID", sectionId);

                        command.Parameters.AddWithValue(
                            "@EnrollmentDate", dtpEnrollmentDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@EnrollmentType", enrollmentType);

                        command.Parameters.AddWithValue(
                            "@EnrollmentStatus", enrollmentStatus);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Student enrolled successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to save enrollment:\n" + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchStudent.Clear();
            txtSearchID.Clear();
            txtStudentID.Clear();

            if (cmbSchoolYear.Items.Count > 0) cmbSchoolYear.SelectedIndex = 0;
            if (cmbGradeLevel.Items.Count > 0) cmbGradeLevel.SelectedIndex = 0;
            if (cmbSection.Items.Count > 0) cmbSection.SelectedIndex = 0;
            if (cmbEnrollmentType.Items.Count > 0) cmbEnrollmentType.SelectedIndex = 0;
            if (cmbEnrollmentStatus.Items.Count > 0) cmbEnrollmentStatus.SelectedIndex = 0;

            dtpEnrollmentDate.Value = DateTime.Now;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmed.");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled.");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Dashboard here.");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Students here.");
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in Enrollment Module.");
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Assessment here.");
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Payments here.");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports here.");
        }
    }
}