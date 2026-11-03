
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class EnrollmentModuleUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRecords = new System.Windows.Forms.GroupBox();
            this.tblRecords = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.labelSearchID = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.cmbFilterGrade = new System.Windows.Forms.ComboBox();
            this.cmbFilterSection = new System.Windows.Forms.ComboBox();
            this.dgvEnrollmentRecords = new System.Windows.Forms.DataGridView();
            this.tblPager = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBoxConfirm = new System.Windows.Forms.GroupBox();
            this.tblConfirm = new System.Windows.Forms.TableLayoutPanel();
            this.labelConfirmText = new System.Windows.Forms.Label();
            this.tblConfirmButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.tblFind = new System.Windows.Forms.TableLayoutPanel();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.labelGradeLevel = new System.Windows.Forms.Label();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.labelEnrollmentDate = new System.Windows.Forms.Label();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.labelEnrollmentType = new System.Windows.Forms.Label();
            this.cmbEnrollmentType = new System.Windows.Forms.ComboBox();
            this.labelEnrollmentStatus = new System.Windows.Forms.Label();
            this.cmbEnrollmentStatus = new System.Windows.Forms.ComboBox();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tblBody.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.groupBoxRecords.SuspendLayout();
            this.tblRecords.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentRecords)).BeginInit();
            this.tblPager.SuspendLayout();
            this.groupBoxConfirm.SuspendLayout();
            this.tblConfirm.SuspendLayout();
            this.tblConfirmButtons.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.tblForm.SuspendLayout();
            this.tblFind.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblBody, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(20);
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1200, 720);
            this.tblMain.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Controls.Add(this.labelWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(301, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enrollment Module";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.labelWelcome.Location = new System.Drawing.Point(3, 49);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(255, 19);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Manage student enrollment information";
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 2;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tblBody.Controls.Add(this.tblLeft, 0, 0);
            this.tblBody.Controls.Add(this.groupBoxForm, 1, 0);
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(20, 105);
            this.tblBody.Margin = new System.Windows.Forms.Padding(0);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 1;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Size = new System.Drawing.Size(1160, 595);
            this.tblBody.TabIndex = 1;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.groupBoxRecords, 0, 0);
            this.tblLeft.Controls.Add(this.groupBoxConfirm, 0, 1);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(0, 0);
            this.tblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 2;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tblLeft.Size = new System.Drawing.Size(672, 595);
            this.tblLeft.TabIndex = 0;
            // 
            // groupBoxRecords
            // 
            this.groupBoxRecords.Controls.Add(this.tblRecords);
            this.groupBoxRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRecords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxRecords.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRecords.Margin = new System.Windows.Forms.Padding(0, 0, 12, 10);
            this.groupBoxRecords.Name = "groupBoxRecords";
            this.groupBoxRecords.Size = new System.Drawing.Size(660, 430);
            this.groupBoxRecords.TabIndex = 0;
            this.groupBoxRecords.TabStop = false;
            this.groupBoxRecords.Text = "Enrollment Records";
            // 
            // tblRecords
            // 
            this.tblRecords.ColumnCount = 1;
            this.tblRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecords.Controls.Add(this.tblSearch, 0, 0);
            this.tblRecords.Controls.Add(this.dgvEnrollmentRecords, 0, 1);
            this.tblRecords.Controls.Add(this.tblPager, 0, 2);
            this.tblRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecords.Location = new System.Drawing.Point(3, 21);
            this.tblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.tblRecords.Name = "tblRecords";
            this.tblRecords.Padding = new System.Windows.Forms.Padding(12);
            this.tblRecords.RowCount = 3;
            this.tblRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblRecords.Size = new System.Drawing.Size(654, 406);
            this.tblRecords.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearch.Controls.Add(this.labelSearchStudent, 0, 0);
            this.tblSearch.Controls.Add(this.labelSearchID, 1, 0);
            this.tblSearch.Controls.Add(this.txtSearchStudent, 0, 1);
            this.tblSearch.Controls.Add(this.txtSearchID, 1, 1);
            this.tblSearch.Controls.Add(this.cmbFilterGrade, 2, 1);
            this.tblSearch.Controls.Add(this.cmbFilterSection, 3, 1);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(12, 12);
            this.tblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 2;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(630, 85);
            this.tblSearch.TabIndex = 0;
            // 
            // labelSearchStudent
            // 
            this.labelSearchStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSearchStudent.Location = new System.Drawing.Point(3, 0);
            this.labelSearchStudent.Name = "labelSearchStudent";
            this.labelSearchStudent.Size = new System.Drawing.Size(151, 30);
            this.labelSearchStudent.TabIndex = 0;
            this.labelSearchStudent.Text = "Search Student";
            this.labelSearchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSearchID
            // 
            this.labelSearchID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSearchID.Location = new System.Drawing.Point(160, 0);
            this.labelSearchID.Name = "labelSearchID";
            this.labelSearchID.Size = new System.Drawing.Size(151, 30);
            this.labelSearchID.TabIndex = 1;
            this.labelSearchID.Text = "Search ID";
            this.labelSearchID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchStudent.Location = new System.Drawing.Point(0, 38);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(149, 25);
            this.txtSearchStudent.TabIndex = 2;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchID.Location = new System.Drawing.Point(157, 38);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(149, 25);
            this.txtSearchID.TabIndex = 3;
            // 
            // cmbFilterGrade
            // 
            this.cmbFilterGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbFilterGrade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterGrade.Location = new System.Drawing.Point(314, 38);
            this.cmbFilterGrade.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.cmbFilterGrade.Name = "cmbFilterGrade";
            this.cmbFilterGrade.Size = new System.Drawing.Size(149, 25);
            this.cmbFilterGrade.TabIndex = 4;
            // 
            // cmbFilterSection
            // 
            this.cmbFilterSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbFilterSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterSection.Location = new System.Drawing.Point(471, 38);
            this.cmbFilterSection.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.cmbFilterSection.Name = "cmbFilterSection";
            this.cmbFilterSection.Size = new System.Drawing.Size(159, 25);
            this.cmbFilterSection.TabIndex = 5;
            // 
            // dgvEnrollmentRecords
            // 
            this.dgvEnrollmentRecords.AllowUserToAddRows = false;
            this.dgvEnrollmentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollmentRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnrollmentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollmentRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollmentRecords.Location = new System.Drawing.Point(12, 97);
            this.dgvEnrollmentRecords.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEnrollmentRecords.Name = "dgvEnrollmentRecords";
            this.dgvEnrollmentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollmentRecords.Size = new System.Drawing.Size(630, 252);
            this.dgvEnrollmentRecords.TabIndex = 1;
            // 
            // tblPager
            // 
            this.tblPager.ColumnCount = 3;
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblPager.Controls.Add(this.btnPrev, 1, 0);
            this.tblPager.Controls.Add(this.btnNext, 2, 0);
            this.tblPager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPager.Location = new System.Drawing.Point(12, 349);
            this.tblPager.Margin = new System.Windows.Forms.Padding(0);
            this.tblPager.Name = "tblPager";
            this.tblPager.RowCount = 1;
            this.tblPager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPager.Size = new System.Drawing.Size(630, 45);
            this.tblPager.TabIndex = 2;
            // 
            // btnPrev
            // 
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrev.Location = new System.Drawing.Point(538, 4);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 32);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<";
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.Location = new System.Drawing.Point(586, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 32);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            // 
            // groupBoxConfirm
            // 
            this.groupBoxConfirm.Controls.Add(this.tblConfirm);
            this.groupBoxConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxConfirm.Location = new System.Drawing.Point(0, 440);
            this.groupBoxConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.groupBoxConfirm.Name = "groupBoxConfirm";
            this.groupBoxConfirm.Size = new System.Drawing.Size(660, 155);
            this.groupBoxConfirm.TabIndex = 1;
            this.groupBoxConfirm.TabStop = false;
            this.groupBoxConfirm.Text = "Confirm Submission";
            // 
            // tblConfirm
            // 
            this.tblConfirm.ColumnCount = 1;
            this.tblConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblConfirm.Controls.Add(this.labelConfirmText, 0, 0);
            this.tblConfirm.Controls.Add(this.tblConfirmButtons, 0, 1);
            this.tblConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConfirm.Location = new System.Drawing.Point(3, 21);
            this.tblConfirm.Name = "tblConfirm";
            this.tblConfirm.Padding = new System.Windows.Forms.Padding(12);
            this.tblConfirm.RowCount = 3;
            this.tblConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblConfirm.Size = new System.Drawing.Size(654, 131);
            this.tblConfirm.TabIndex = 0;
            // 
            // labelConfirmText
            // 
            this.labelConfirmText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConfirmText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelConfirmText.Location = new System.Drawing.Point(15, 12);
            this.labelConfirmText.Name = "labelConfirmText";
            this.labelConfirmText.Size = new System.Drawing.Size(624, 45);
            this.labelConfirmText.TabIndex = 0;
            this.labelConfirmText.Text = "Are you sure you want to submit this enrollment information?";
            this.labelConfirmText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblConfirmButtons
            // 
            this.tblConfirmButtons.ColumnCount = 4;
            this.tblConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblConfirmButtons.Controls.Add(this.btnYes, 1, 0);
            this.tblConfirmButtons.Controls.Add(this.btnNo, 2, 0);
            this.tblConfirmButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConfirmButtons.Location = new System.Drawing.Point(15, 60);
            this.tblConfirmButtons.Name = "tblConfirmButtons";
            this.tblConfirmButtons.RowCount = 1;
            this.tblConfirmButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblConfirmButtons.Size = new System.Drawing.Size(624, 49);
            this.tblConfirmButtons.TabIndex = 1;
            // 
            // btnYes
            // 
            this.btnYes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYes.Location = new System.Drawing.Point(192, 5);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(114, 36);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNo.Location = new System.Drawing.Point(316, 5);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(114, 36);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.tblForm);
            this.groupBoxForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxForm.Location = new System.Drawing.Point(684, 0);
            this.groupBoxForm.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(476, 595);
            this.groupBoxForm.TabIndex = 1;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Enrollment Form";
            // 
            // tblForm
            // 
            this.tblForm.ColumnCount = 2;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblForm.Controls.Add(this.labelStudentID, 0, 0);
            this.tblForm.Controls.Add(this.tblFind, 1, 0);
            this.tblForm.Controls.Add(this.labelSchoolYear, 0, 1);
            this.tblForm.Controls.Add(this.cmbSchoolYear, 1, 1);
            this.tblForm.Controls.Add(this.labelGradeLevel, 0, 2);
            this.tblForm.Controls.Add(this.cmbGradeLevel, 1, 2);
            this.tblForm.Controls.Add(this.labelSection, 0, 3);
            this.tblForm.Controls.Add(this.cmbSection, 1, 3);
            this.tblForm.Controls.Add(this.labelEnrollmentDate, 0, 4);
            this.tblForm.Controls.Add(this.dtpEnrollmentDate, 1, 4);
            this.tblForm.Controls.Add(this.labelEnrollmentType, 0, 5);
            this.tblForm.Controls.Add(this.cmbEnrollmentType, 1, 5);
            this.tblForm.Controls.Add(this.labelEnrollmentStatus, 0, 6);
            this.tblForm.Controls.Add(this.cmbEnrollmentStatus, 1, 6);
            this.tblForm.Controls.Add(this.tblActions, 0, 8);
            this.tblForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblForm.Location = new System.Drawing.Point(3, 21);
            this.tblForm.Margin = new System.Windows.Forms.Padding(0);
            this.tblForm.Name = "tblForm";
            this.tblForm.Padding = new System.Windows.Forms.Padding(16);
            this.tblForm.RowCount = 9;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblForm.Size = new System.Drawing.Size(470, 571);
            this.tblForm.TabIndex = 0;
            // 
            // labelStudentID
            // 
            this.labelStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStudentID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelStudentID.Location = new System.Drawing.Point(19, 16);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(125, 65);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID:";
            this.labelStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblFind
            // 
            this.tblFind.ColumnCount = 2;
            this.tblFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tblFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblFind.Controls.Add(this.txtStudentID, 0, 0);
            this.tblFind.Controls.Add(this.btnFindStudent, 1, 0);
            this.tblFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFind.Location = new System.Drawing.Point(147, 16);
            this.tblFind.Margin = new System.Windows.Forms.Padding(0);
            this.tblFind.Name = "tblFind";
            this.tblFind.RowCount = 1;
            this.tblFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFind.Size = new System.Drawing.Size(307, 65);
            this.tblFind.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStudentID.Location = new System.Drawing.Point(5, 17);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(5, 17, 8, 0);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(195, 27);
            this.txtStudentID.TabIndex = 0;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindStudent.Location = new System.Drawing.Point(208, 13);
            this.btnFindStudent.Margin = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(99, 32);
            this.btnFindStudent.TabIndex = 1;
            this.btnFindStudent.Text = "Find";
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // labelSchoolYear
            // 
            this.labelSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSchoolYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSchoolYear.Location = new System.Drawing.Point(19, 81);
            this.labelSchoolYear.Name = "labelSchoolYear";
            this.labelSchoolYear.Size = new System.Drawing.Size(125, 65);
            this.labelSchoolYear.TabIndex = 2;
            this.labelSchoolYear.Text = "School Year:";
            this.labelSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbSchoolYear.Location = new System.Drawing.Point(152, 99);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(297, 28);
            this.cmbSchoolYear.TabIndex = 3;
            // 
            // labelGradeLevel
            // 
            this.labelGradeLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGradeLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGradeLevel.Location = new System.Drawing.Point(19, 146);
            this.labelGradeLevel.Name = "labelGradeLevel";
            this.labelGradeLevel.Size = new System.Drawing.Size(125, 65);
            this.labelGradeLevel.TabIndex = 4;
            this.labelGradeLevel.Text = "Grade Level:";
            this.labelGradeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGradeLevel.Location = new System.Drawing.Point(152, 164);
            this.cmbGradeLevel.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(297, 28);
            this.cmbGradeLevel.TabIndex = 5;
            // 
            // labelSection
            // 
            this.labelSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSection.Location = new System.Drawing.Point(19, 211);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(125, 65);
            this.labelSection.TabIndex = 6;
            this.labelSection.Text = "Section:";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSection
            // 
            this.cmbSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbSection.Location = new System.Drawing.Point(152, 229);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(297, 28);
            this.cmbSection.TabIndex = 7;
            // 
            // labelEnrollmentDate
            // 
            this.labelEnrollmentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnrollmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEnrollmentDate.Location = new System.Drawing.Point(19, 276);
            this.labelEnrollmentDate.Name = "labelEnrollmentDate";
            this.labelEnrollmentDate.Size = new System.Drawing.Size(125, 65);
            this.labelEnrollmentDate.TabIndex = 8;
            this.labelEnrollmentDate.Text = "Enrollment Date:";
            this.labelEnrollmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEnrollmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(152, 294);
            this.dtpEnrollmentDate.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(297, 25);
            this.dtpEnrollmentDate.TabIndex = 9;
            // 
            // labelEnrollmentType
            // 
            this.labelEnrollmentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnrollmentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEnrollmentType.Location = new System.Drawing.Point(19, 341);
            this.labelEnrollmentType.Name = "labelEnrollmentType";
            this.labelEnrollmentType.Size = new System.Drawing.Size(125, 65);
            this.labelEnrollmentType.TabIndex = 10;
            this.labelEnrollmentType.Text = "Enrollment Type:";
            this.labelEnrollmentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEnrollmentType
            // 
            this.cmbEnrollmentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEnrollmentType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbEnrollmentType.Location = new System.Drawing.Point(152, 359);
            this.cmbEnrollmentType.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.cmbEnrollmentType.Name = "cmbEnrollmentType";
            this.cmbEnrollmentType.Size = new System.Drawing.Size(297, 28);
            this.cmbEnrollmentType.TabIndex = 11;
            // 
            // labelEnrollmentStatus
            // 
            this.labelEnrollmentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnrollmentStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEnrollmentStatus.Location = new System.Drawing.Point(19, 406);
            this.labelEnrollmentStatus.Name = "labelEnrollmentStatus";
            this.labelEnrollmentStatus.Size = new System.Drawing.Size(125, 65);
            this.labelEnrollmentStatus.TabIndex = 12;
            this.labelEnrollmentStatus.Text = "Enrollment Status:";
            this.labelEnrollmentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEnrollmentStatus
            // 
            this.cmbEnrollmentStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEnrollmentStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbEnrollmentStatus.Location = new System.Drawing.Point(152, 424);
            this.cmbEnrollmentStatus.Margin = new System.Windows.Forms.Padding(5, 18, 5, 0);
            this.cmbEnrollmentStatus.Name = "cmbEnrollmentStatus";
            this.cmbEnrollmentStatus.Size = new System.Drawing.Size(297, 28);
            this.cmbEnrollmentStatus.TabIndex = 13;
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 4;
            this.tblForm.SetColumnSpan(this.tblActions, 2);
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblActions.Controls.Add(this.btnSave, 1, 0);
            this.tblActions.Controls.Add(this.btnClear, 2, 0);
            this.tblActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActions.Location = new System.Drawing.Point(16, 490);
            this.tblActions.Margin = new System.Windows.Forms.Padding(0);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(438, 65);
            this.tblActions.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(92, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(223, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSidebar.Controls.Add(this.labelSchoolName);
            this.panelSidebar.Controls.Add(this.labelSubtitle);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnStudents);
            this.panelSidebar.Controls.Add(this.btnEnrollment);
            this.panelSidebar.Controls.Add(this.btnAssessment);
            this.panelSidebar.Controls.Add(this.btnPayments);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 620);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Visible = false;
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.Location = new System.Drawing.Point(0, 0);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(100, 23);
            this.labelSchoolName.TabIndex = 0;
            this.labelSchoolName.Text = "EduVance";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Location = new System.Drawing.Point(0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(100, 23);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Enrollment Form";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(0, 0);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(75, 23);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "Students";
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.Location = new System.Drawing.Point(0, 0);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(75, 23);
            this.btnEnrollment.TabIndex = 4;
            this.btnEnrollment.Text = "Enrollment";
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.Location = new System.Drawing.Point(0, 0);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(75, 23);
            this.btnAssessment.TabIndex = 5;
            this.btnAssessment.Text = "Assessment";
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(0, 0);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(75, 23);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments";
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(0, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // EnrollmentModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.tblMain);
            this.Name = "EnrollmentModuleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblBody.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.groupBoxRecords.ResumeLayout(false);
            this.tblRecords.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentRecords)).EndInit();
            this.tblPager.ResumeLayout(false);
            this.groupBoxConfirm.ResumeLayout(false);
            this.tblConfirm.ResumeLayout(false);
            this.tblConfirmButtons.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.tblForm.ResumeLayout(false);
            this.tblFind.ResumeLayout(false);
            this.tblFind.PerformLayout();
            this.tblActions.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // RESPONSIVE LAYOUT
        private TableLayoutPanel tblMain;
        private Panel pnlHeader;
        private TableLayoutPanel tblBody;
        private TableLayoutPanel tblLeft;
        private TableLayoutPanel tblRecords;
        private TableLayoutPanel tblSearch;
        private TableLayoutPanel tblPager;
        private TableLayoutPanel tblConfirm;
        private TableLayoutPanel tblConfirmButtons;
        private TableLayoutPanel tblForm;
        private TableLayoutPanel tblFind;
        private TableLayoutPanel tblActions;

        // SIDEBAR
        private Panel panelSidebar;
        private Label labelSchoolName;
        private Label labelSubtitle;
        private Button btnDashboard;
        private Button btnStudents;
        private Button btnEnrollment;
        private Button btnAssessment;
        private Button btnPayments;
        private Button btnReports;

        // HEADER
        private Label labelTitle;
        private Label labelWelcome;

        // RECORDS
        private GroupBox groupBoxRecords;
        private Button btnNext;
        private Button btnPrev;
        private DataGridView dgvEnrollmentRecords;
        private ComboBox cmbFilterSection;
        private ComboBox cmbFilterGrade;
        private TextBox txtSearchID;
        private TextBox txtSearchStudent;
        private Label labelSearchStudent;
        private Label labelSearchID;

        // CONFIRMATION
        private GroupBox groupBoxConfirm;
        private Button btnNo;
        private Button btnYes;
        private Label labelConfirmText;

        // ENROLLMENT FORM
        private GroupBox groupBoxForm;
        private Button btnClear;
        private Button btnSave;
        private ComboBox cmbEnrollmentStatus;
        private Label labelEnrollmentStatus;
        private ComboBox cmbEnrollmentType;
        private Label labelEnrollmentType;
        private DateTimePicker dtpEnrollmentDate;
        private Label labelEnrollmentDate;
        private ComboBox cmbSection;
        private Label labelSection;
        private ComboBox cmbGradeLevel;
        private Label labelGradeLevel;
        private ComboBox cmbSchoolYear;
        private Label labelSchoolYear;
        private Button btnFindStudent;
        private TextBox txtStudentID;
        private Label labelStudentID;
    }
}
