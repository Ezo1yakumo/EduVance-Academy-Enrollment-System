namespace Login_UI
{
    partial class EnrollmentModuleUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupBoxRecords = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dgvEnrollmentRecords = new System.Windows.Forms.DataGridView();
            this.cmbFilterSection = new System.Windows.Forms.ComboBox();
            this.cmbFilterGrade = new System.Windows.Forms.ComboBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.labelSearchID = new System.Windows.Forms.Label();
            this.groupBoxConfirm = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.labelConfirmText = new System.Windows.Forms.Label();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbEnrollmentStatus = new System.Windows.Forms.ComboBox();
            this.labelEnrollmentStatus = new System.Windows.Forms.Label();
            this.cmbEnrollmentType = new System.Windows.Forms.ComboBox();
            this.labelEnrollmentType = new System.Windows.Forms.Label();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.labelEnrollmentDate = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.groupBoxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentRecords)).BeginInit();
            this.groupBoxConfirm.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSidebar.Controls.Add(this.labelSchoolName);
            this.panelSidebar.Controls.Add(this.labelSubtitle);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnPayments);
            this.panelSidebar.Controls.Add(this.btnAssessment);
            this.panelSidebar.Controls.Add(this.btnEnrollment);
            this.panelSidebar.Controls.Add(this.btnStudents);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 620);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelSchoolName.ForeColor = System.Drawing.Color.White;
            this.labelSchoolName.Location = new System.Drawing.Point(24, 23);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(123, 29);
            this.labelSchoolName.TabIndex = 7;
            this.labelSchoolName.Text = "EduVance";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.ForeColor = System.Drawing.Color.White;
            this.labelSubtitle.Location = new System.Drawing.Point(26, 56);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(82, 13);
            this.labelSubtitle.TabIndex = 6;
            this.labelSubtitle.Text = "Enrollment Form";
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 404);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(156, 40);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(12, 364);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(156, 40);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.FlatAppearance.BorderSize = 0;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAssessment.Location = new System.Drawing.Point(12, 324);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(156, 40);
            this.btnAssessment.TabIndex = 3;
            this.btnAssessment.Text = "Assessment";
            this.btnAssessment.UseVisualStyleBackColor = true;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.FlatAppearance.BorderSize = 0;
            this.btnEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnEnrollment.Location = new System.Drawing.Point(12, 284);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(156, 40);
            this.btnEnrollment.TabIndex = 2;
            this.btnEnrollment.Text = "Enrollment";
            this.btnEnrollment.UseVisualStyleBackColor = true;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(12, 244);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(156, 40);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 204);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(211, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(281, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Enrollment Module";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWelcome.Location = new System.Drawing.Point(214, 65);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(254, 17);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Manage student enrollment information";
            // 
            // groupBoxRecords
            // 
            this.groupBoxRecords.Controls.Add(this.btnNext);
            this.groupBoxRecords.Controls.Add(this.btnPrev);
            this.groupBoxRecords.Controls.Add(this.dgvEnrollmentRecords);
            this.groupBoxRecords.Controls.Add(this.cmbFilterSection);
            this.groupBoxRecords.Controls.Add(this.cmbFilterGrade);
            this.groupBoxRecords.Controls.Add(this.txtSearchID);
            this.groupBoxRecords.Controls.Add(this.txtSearchStudent);
            this.groupBoxRecords.Controls.Add(this.labelSearchStudent);
            this.groupBoxRecords.Controls.Add(this.labelSearchID);
            this.groupBoxRecords.Location = new System.Drawing.Point(217, 102);
            this.groupBoxRecords.Name = "groupBoxRecords";
            this.groupBoxRecords.Size = new System.Drawing.Size(500, 300);
            this.groupBoxRecords.TabIndex = 3;
            this.groupBoxRecords.TabStop = false;
            this.groupBoxRecords.Text = "Enrollment Records";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(446, 262);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(405, 262);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 23);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // dgvEnrollmentRecords
            // 
            this.dgvEnrollmentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollmentRecords.Location = new System.Drawing.Point(20, 92);
            this.dgvEnrollmentRecords.Name = "dgvEnrollmentRecords";
            this.dgvEnrollmentRecords.Size = new System.Drawing.Size(461, 159);
            this.dgvEnrollmentRecords.TabIndex = 6;
            // 
            // cmbFilterSection
            // 
            this.cmbFilterSection.FormattingEnabled = true;
            this.cmbFilterSection.Location = new System.Drawing.Point(362, 48);
            this.cmbFilterSection.Name = "cmbFilterSection";
            this.cmbFilterSection.Size = new System.Drawing.Size(119, 21);
            this.cmbFilterSection.TabIndex = 5;
            // 
            // cmbFilterGrade
            // 
            this.cmbFilterGrade.FormattingEnabled = true;
            this.cmbFilterGrade.Location = new System.Drawing.Point(237, 48);
            this.cmbFilterGrade.Name = "cmbFilterGrade";
            this.cmbFilterGrade.Size = new System.Drawing.Size(119, 21);
            this.cmbFilterGrade.TabIndex = 4;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(128, 49);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchID.TabIndex = 3;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(20, 49);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(100, 20);
            this.txtSearchStudent.TabIndex = 2;
            // 
            // labelSearchStudent
            // 
            this.labelSearchStudent.AutoSize = true;
            this.labelSearchStudent.Location = new System.Drawing.Point(17, 30);
            this.labelSearchStudent.Name = "labelSearchStudent";
            this.labelSearchStudent.Size = new System.Drawing.Size(81, 13);
            this.labelSearchStudent.TabIndex = 1;
            this.labelSearchStudent.Text = "Search Student";
            // 
            // labelSearchID
            // 
            this.labelSearchID.AutoSize = true;
            this.labelSearchID.Location = new System.Drawing.Point(125, 30);
            this.labelSearchID.Name = "labelSearchID";
            this.labelSearchID.Size = new System.Drawing.Size(55, 13);
            this.labelSearchID.TabIndex = 0;
            this.labelSearchID.Text = "Search ID";
            // 
            // groupBoxConfirm
            // 
            this.groupBoxConfirm.Controls.Add(this.btnNo);
            this.groupBoxConfirm.Controls.Add(this.btnYes);
            this.groupBoxConfirm.Controls.Add(this.labelConfirmText);
            this.groupBoxConfirm.Location = new System.Drawing.Point(217, 420);
            this.groupBoxConfirm.Name = "groupBoxConfirm";
            this.groupBoxConfirm.Size = new System.Drawing.Size(500, 125);
            this.groupBoxConfirm.TabIndex = 4;
            this.groupBoxConfirm.TabStop = false;
            this.groupBoxConfirm.Text = "Confirm Submission";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(258, 83);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 28);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(151, 83);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(90, 28);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // labelConfirmText
            // 
            this.labelConfirmText.Location = new System.Drawing.Point(18, 31);
            this.labelConfirmText.Name = "labelConfirmText";
            this.labelConfirmText.Size = new System.Drawing.Size(449, 35);
            this.labelConfirmText.TabIndex = 0;
            this.labelConfirmText.Text = "Are you sure you want to submit this enrollment information?";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.btnClear);
            this.groupBoxForm.Controls.Add(this.btnSave);
            this.groupBoxForm.Controls.Add(this.cmbEnrollmentStatus);
            this.groupBoxForm.Controls.Add(this.labelEnrollmentStatus);
            this.groupBoxForm.Controls.Add(this.cmbEnrollmentType);
            this.groupBoxForm.Controls.Add(this.labelEnrollmentType);
            this.groupBoxForm.Controls.Add(this.dtpEnrollmentDate);
            this.groupBoxForm.Controls.Add(this.labelEnrollmentDate);
            this.groupBoxForm.Controls.Add(this.cmbSection);
            this.groupBoxForm.Controls.Add(this.labelSection);
            this.groupBoxForm.Controls.Add(this.cmbGradeLevel);
            this.groupBoxForm.Controls.Add(this.labelGradeLevel);
            this.groupBoxForm.Controls.Add(this.cmbSchoolYear);
            this.groupBoxForm.Controls.Add(this.labelSchoolYear);
            this.groupBoxForm.Controls.Add(this.btnFindStudent);
            this.groupBoxForm.Controls.Add(this.txtStudentID);
            this.groupBoxForm.Controls.Add(this.labelStudentID);
            this.groupBoxForm.Location = new System.Drawing.Point(737, 102);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(318, 443);
            this.groupBoxForm.TabIndex = 5;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Enrollment Form";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbEnrollmentStatus
            // 
            this.cmbEnrollmentStatus.FormattingEnabled = true;
            this.cmbEnrollmentStatus.Location = new System.Drawing.Point(48, 343);
            this.cmbEnrollmentStatus.Name = "cmbEnrollmentStatus";
            this.cmbEnrollmentStatus.Size = new System.Drawing.Size(229, 21);
            this.cmbEnrollmentStatus.TabIndex = 14;
            // 
            // labelEnrollmentStatus
            // 
            this.labelEnrollmentStatus.AutoSize = true;
            this.labelEnrollmentStatus.Location = new System.Drawing.Point(45, 324);
            this.labelEnrollmentStatus.Name = "labelEnrollmentStatus";
            this.labelEnrollmentStatus.Size = new System.Drawing.Size(89, 13);
            this.labelEnrollmentStatus.TabIndex = 13;
            this.labelEnrollmentStatus.Text = "Enrollment Status";
            // 
            // cmbEnrollmentType
            // 
            this.cmbEnrollmentType.FormattingEnabled = true;
            this.cmbEnrollmentType.Location = new System.Drawing.Point(48, 288);
            this.cmbEnrollmentType.Name = "cmbEnrollmentType";
            this.cmbEnrollmentType.Size = new System.Drawing.Size(229, 21);
            this.cmbEnrollmentType.TabIndex = 12;
            // 
            // labelEnrollmentType
            // 
            this.labelEnrollmentType.AutoSize = true;
            this.labelEnrollmentType.Location = new System.Drawing.Point(45, 269);
            this.labelEnrollmentType.Name = "labelEnrollmentType";
            this.labelEnrollmentType.Size = new System.Drawing.Size(83, 13);
            this.labelEnrollmentType.TabIndex = 11;
            this.labelEnrollmentType.Text = "Enrollment Type";
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(48, 233);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(229, 20);
            this.dtpEnrollmentDate.TabIndex = 10;
            // 
            // labelEnrollmentDate
            // 
            this.labelEnrollmentDate.AutoSize = true;
            this.labelEnrollmentDate.Location = new System.Drawing.Point(45, 214);
            this.labelEnrollmentDate.Name = "labelEnrollmentDate";
            this.labelEnrollmentDate.Size = new System.Drawing.Size(82, 13);
            this.labelEnrollmentDate.TabIndex = 9;
            this.labelEnrollmentDate.Text = "Enrollment Date";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(48, 178);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(229, 21);
            this.cmbSection.TabIndex = 8;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(45, 159);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(43, 13);
            this.labelSection.TabIndex = 7;
            this.labelSection.Text = "Section";
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Location = new System.Drawing.Point(48, 123);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(229, 21);
            this.cmbGradeLevel.TabIndex = 6;
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.AutoSize = true;
            this.labelGradeLevel.Location = new System.Drawing.Point(45, 104);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(65, 13);
            this.labelGradeLevel.TabIndex = 5;
            this.labelGradeLevel.Text = "Grade Level";
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(48, 68);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(229, 21);
            this.cmbSchoolYear.TabIndex = 4;
            // 
            // labelSchoolYear
            // 
            this.labelSchoolYear.AutoSize = true;
            this.labelSchoolYear.Location = new System.Drawing.Point(45, 49);
            this.labelSchoolYear.Name = "labelSchoolYear";
            this.labelSchoolYear.Size = new System.Drawing.Size(65, 13);
            this.labelSchoolYear.TabIndex = 3;
            this.labelSchoolYear.Text = "School Year";
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(202, 20);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFindStudent.TabIndex = 2;
            this.btnFindStudent.Text = "Find";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(48, 22);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(141, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(93, 6);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID";
            // 
            // EnrollmentModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.groupBoxConfirm);
            this.Controls.Add(this.groupBoxRecords);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnrollmentModuleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Module";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.groupBoxRecords.ResumeLayout(false);
            this.groupBoxRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentRecords)).EndInit();
            this.groupBoxConfirm.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupBoxRecords;
        private System.Windows.Forms.Label labelSearchStudent;
        private System.Windows.Forms.Label labelSearchID;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.ComboBox cmbFilterGrade;
        private System.Windows.Forms.ComboBox cmbFilterSection;
        private System.Windows.Forms.DataGridView dgvEnrollmentRecords;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBoxConfirm;
        private System.Windows.Forms.Label labelConfirmText;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.Label labelSchoolYear;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Label labelGradeLevel;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.Label labelEnrollmentDate;
        private System.Windows.Forms.ComboBox cmbEnrollmentType;
        private System.Windows.Forms.Label labelEnrollmentType;
        private System.Windows.Forms.ComboBox cmbEnrollmentStatus;
        private System.Windows.Forms.Label labelEnrollmentStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}