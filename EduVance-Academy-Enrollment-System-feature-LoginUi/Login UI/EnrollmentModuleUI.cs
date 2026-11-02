using System;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class EnrollmentModuleUI : Form
    {
        public EnrollmentModuleUI()
        {
            InitializeComponent();
           
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
            MessageBox.Show("Find student function here.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save enrollment function here.");
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