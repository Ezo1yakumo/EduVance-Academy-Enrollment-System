
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class PaymentModuleUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.tblStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.tblSummary = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAssessment = new System.Windows.Forms.Label();
            this.txtTotalAssessment = new System.Windows.Forms.TextBox();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.lblCreditBalance = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.tblBottom = new System.Windows.Forms.TableLayoutPanel();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.tblPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.tblReceipt = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.txtReceiptDate = new System.Windows.Forms.TextBox();
            this.lblReceiptPaid = new System.Windows.Forms.Label();
            this.txtReceiptPaid = new System.Windows.Forms.TextBox();
            this.lblReceiptBalance = new System.Windows.Forms.Label();
            this.txtReceiptBalance = new System.Windows.Forms.TextBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.grpConfirm = new System.Windows.Forms.GroupBox();
            this.tblConfirm = new System.Windows.Forms.TableLayoutPanel();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tblTop.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.tblStudent.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.tblSummary.SuspendLayout();
            this.tblBottom.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.tblPayment.SuspendLayout();
            this.tblRight.SuspendLayout();
            this.grpReceipt.SuspendLayout();
            this.tblReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.grpConfirm.SuspendLayout();
            this.tblConfirm.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblTop, 0, 1);
            this.tblMain.Controls.Add(this.tblBottom, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(16);
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1240, 800);
            this.tblMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(19, 19);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1202, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Module";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 49);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(278, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Record student payments and issue receipts";
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 2;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblTop.Controls.Add(this.grpStudent, 0, 0);
            this.tblTop.Controls.Add(this.grpSummary, 1, 0);
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.Location = new System.Drawing.Point(19, 97);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTop.Size = new System.Drawing.Size(1202, 199);
            this.tblTop.TabIndex = 1;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.tblStudent);
            this.grpStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStudent.Location = new System.Drawing.Point(0, 0);
            this.grpStudent.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(665, 191);
            this.grpStudent.TabIndex = 0;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnCount = 4;
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStudent.Controls.Add(this.lblSelectStudent, 0, 0);
            this.tblStudent.Controls.Add(this.lblSchoolYear, 3, 0);
            this.tblStudent.Controls.Add(this.cmbStudent, 0, 1);
            this.tblStudent.Controls.Add(this.cmbSchoolYear, 3, 1);
            this.tblStudent.Controls.Add(this.lblStudentID, 0, 2);
            this.tblStudent.Controls.Add(this.lblStudentName, 1, 2);
            this.tblStudent.Controls.Add(this.lblGrade, 2, 2);
            this.tblStudent.Controls.Add(this.lblSection, 3, 2);
            this.tblStudent.Controls.Add(this.txtStudentID, 0, 3);
            this.tblStudent.Controls.Add(this.txtStudentName, 1, 3);
            this.tblStudent.Controls.Add(this.txtGrade, 2, 3);
            this.tblStudent.Controls.Add(this.txtSection, 3, 3);
            this.tblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudent.Location = new System.Drawing.Point(3, 21);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.Padding = new System.Windows.Forms.Padding(12, 5, 12, 8);
            this.tblStudent.RowCount = 4;
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudent.Size = new System.Drawing.Size(659, 167);
            this.tblStudent.TabIndex = 0;
            // 
            // lblSelectStudent
            // 
            this.tblStudent.SetColumnSpan(this.lblSelectStudent, 3);
            this.lblSelectStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectStudent.Location = new System.Drawing.Point(15, 5);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(468, 25);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select Student";
            this.lblSelectStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSchoolYear.Location = new System.Drawing.Point(489, 5);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(155, 25);
            this.lblSchoolYear.TabIndex = 1;
            this.lblSchoolYear.Text = "School Year";
            this.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbStudent
            // 
            this.tblStudent.SetColumnSpan(this.cmbStudent, 3);
            this.cmbStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudent.Location = new System.Drawing.Point(12, 32);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(0, 2, 12, 2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(462, 25);
            this.cmbStudent.TabIndex = 2;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSchoolYear.Location = new System.Drawing.Point(486, 32);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(161, 25);
            this.cmbSchoolYear.TabIndex = 3;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentID.Location = new System.Drawing.Point(15, 68);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(152, 26);
            this.lblStudentID.TabIndex = 4;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentName.Location = new System.Drawing.Point(173, 68);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(152, 26);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblGrade
            // 
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrade.Location = new System.Drawing.Point(331, 68);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(152, 26);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade Level";
            // 
            // lblSection
            // 
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(489, 68);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(155, 26);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Section";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentID.Location = new System.Drawing.Point(15, 97);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(152, 25);
            this.txtStudentID.TabIndex = 8;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Location = new System.Drawing.Point(173, 97);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(152, 25);
            this.txtStudentName.TabIndex = 9;
            // 
            // txtGrade
            // 
            this.txtGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrade.Location = new System.Drawing.Point(331, 97);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(152, 25);
            this.txtGrade.TabIndex = 10;
            // 
            // txtSection
            // 
            this.txtSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSection.Location = new System.Drawing.Point(489, 97);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(155, 25);
            this.txtSection.TabIndex = 11;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.tblSummary);
            this.grpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSummary.Location = new System.Drawing.Point(681, 0);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(521, 191);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Account Summary";
            // 
            // tblSummary
            // 
            this.tblSummary.ColumnCount = 2;
            this.tblSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblSummary.Controls.Add(this.lblTotalAssessment, 0, 0);
            this.tblSummary.Controls.Add(this.txtTotalAssessment, 1, 0);
            this.tblSummary.Controls.Add(this.lblTotalPaid, 0, 1);
            this.tblSummary.Controls.Add(this.txtTotalPaid, 1, 1);
            this.tblSummary.Controls.Add(this.lblRemainingBalance, 0, 2);
            this.tblSummary.Controls.Add(this.txtRemainingBalance, 1, 2);
            this.tblSummary.Controls.Add(this.lblCreditBalance, 0, 3);
            this.tblSummary.Controls.Add(this.txtCreditBalance, 1, 3);
            this.tblSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSummary.Location = new System.Drawing.Point(3, 21);
            this.tblSummary.Name = "tblSummary";
            this.tblSummary.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.tblSummary.RowCount = 4;
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummary.Size = new System.Drawing.Size(515, 167);
            this.tblSummary.TabIndex = 0;
            // 
            // lblTotalAssessment
            // 
            this.lblTotalAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAssessment.Location = new System.Drawing.Point(15, 6);
            this.lblTotalAssessment.Name = "lblTotalAssessment";
            this.lblTotalAssessment.Size = new System.Drawing.Size(214, 38);
            this.lblTotalAssessment.TabIndex = 0;
            this.lblTotalAssessment.Text = "Total Assessment";
            this.lblTotalAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalAssessment
            // 
            this.txtTotalAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalAssessment.Location = new System.Drawing.Point(235, 9);
            this.txtTotalAssessment.Name = "txtTotalAssessment";
            this.txtTotalAssessment.ReadOnly = true;
            this.txtTotalAssessment.Size = new System.Drawing.Size(265, 25);
            this.txtTotalAssessment.TabIndex = 1;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPaid.Location = new System.Drawing.Point(15, 44);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(214, 38);
            this.lblTotalPaid.TabIndex = 2;
            this.lblTotalPaid.Text = "Amount Paid";
            this.lblTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPaid.Location = new System.Drawing.Point(235, 47);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(265, 25);
            this.txtTotalPaid.TabIndex = 3;
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemainingBalance.Location = new System.Drawing.Point(15, 82);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(214, 38);
            this.lblRemainingBalance.TabIndex = 4;
            this.lblRemainingBalance.Text = "Remaining Balance";
            this.lblRemainingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemainingBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtRemainingBalance.Location = new System.Drawing.Point(235, 85);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.ReadOnly = true;
            this.txtRemainingBalance.Size = new System.Drawing.Size(265, 25);
            this.txtRemainingBalance.TabIndex = 5;
            // 
            // lblCreditBalance
            // 
            this.lblCreditBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditBalance.Location = new System.Drawing.Point(15, 120);
            this.lblCreditBalance.Name = "lblCreditBalance";
            this.lblCreditBalance.Size = new System.Drawing.Size(214, 41);
            this.lblCreditBalance.TabIndex = 6;
            this.lblCreditBalance.Text = "Credit Balance";
            this.lblCreditBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreditBalance.Location = new System.Drawing.Point(235, 123);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.ReadOnly = true;
            this.txtCreditBalance.Size = new System.Drawing.Size(265, 25);
            this.txtCreditBalance.TabIndex = 7;
            // 
            // tblBottom
            // 
            this.tblBottom.ColumnCount = 2;
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tblBottom.Controls.Add(this.grpPayment, 0, 0);
            this.tblBottom.Controls.Add(this.tblRight, 1, 0);
            this.tblBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBottom.Location = new System.Drawing.Point(19, 302);
            this.tblBottom.Name = "tblBottom";
            this.tblBottom.RowCount = 1;
            this.tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottom.Size = new System.Drawing.Size(1202, 479);
            this.tblBottom.TabIndex = 2;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.tblPayment);
            this.grpPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPayment.Location = new System.Drawing.Point(0, 0);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(617, 479);
            this.grpPayment.TabIndex = 0;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Information";
            // 
            // tblPayment
            // 
            this.tblPayment.ColumnCount = 2;
            this.tblPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tblPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tblPayment.Controls.Add(this.lblPaymentDate, 0, 0);
            this.tblPayment.Controls.Add(this.dtpPaymentDate, 1, 0);
            this.tblPayment.Controls.Add(this.lblAmount, 0, 1);
            this.tblPayment.Controls.Add(this.txtAmount, 1, 1);
            this.tblPayment.Controls.Add(this.lblMethod, 0, 2);
            this.tblPayment.Controls.Add(this.cmbMethod, 1, 2);
            this.tblPayment.Controls.Add(this.lblReference, 0, 3);
            this.tblPayment.Controls.Add(this.txtReference, 1, 3);
            this.tblPayment.Controls.Add(this.lblDescription, 0, 4);
            this.tblPayment.Controls.Add(this.txtDescription, 1, 4);
            this.tblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPayment.Location = new System.Drawing.Point(3, 21);
            this.tblPayment.Name = "tblPayment";
            this.tblPayment.Padding = new System.Windows.Forms.Padding(15);
            this.tblPayment.RowCount = 5;
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPayment.Size = new System.Drawing.Size(611, 455);
            this.tblPayment.TabIndex = 0;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDate.Location = new System.Drawing.Point(18, 15);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(203, 54);
            this.lblPaymentDate.TabIndex = 0;
            this.lblPaymentDate.Text = "Payment Date";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(229, 28);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(5, 13, 5, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(362, 25);
            this.dtpPaymentDate.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(18, 69);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(203, 54);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount Paid";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.Location = new System.Drawing.Point(229, 82);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 13, 5, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(362, 27);
            this.txtAmount.TabIndex = 3;
            // 
            // lblMethod
            // 
            this.lblMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMethod.Location = new System.Drawing.Point(18, 123);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(203, 54);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Payment Method";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMethod
            // 
            this.cmbMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethod.Location = new System.Drawing.Point(229, 136);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(5, 13, 5, 0);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(362, 25);
            this.cmbMethod.TabIndex = 5;
            // 
            // lblReference
            // 
            this.lblReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReference.Location = new System.Drawing.Point(18, 177);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(203, 54);
            this.lblReference.TabIndex = 6;
            this.lblReference.Text = "Reference Number";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReference
            // 
            this.txtReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReference.Location = new System.Drawing.Point(229, 190);
            this.txtReference.Margin = new System.Windows.Forms.Padding(5, 13, 5, 0);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(362, 25);
            this.txtReference.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(18, 231);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(203, 209);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Payment Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(229, 237);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(362, 199);
            this.txtDescription.TabIndex = 9;
            // 
            // tblRight
            // 
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.Controls.Add(this.grpReceipt, 0, 0);
            this.tblRight.Controls.Add(this.grpConfirm, 0, 1);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.Location = new System.Drawing.Point(628, 3);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 2;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblRight.Size = new System.Drawing.Size(571, 473);
            this.tblRight.TabIndex = 1;
            // 
            // grpReceipt
            // 
            this.grpReceipt.Controls.Add(this.tblReceipt);
            this.grpReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpReceipt.Location = new System.Drawing.Point(8, 0);
            this.grpReceipt.Margin = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(563, 313);
            this.grpReceipt.TabIndex = 0;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Receipt Information / Payment History";
            // 
            // tblReceipt
            // 
            this.tblReceipt.ColumnCount = 2;
            this.tblReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblReceipt.Controls.Add(this.lblReceiptNumber, 0, 0);
            this.tblReceipt.Controls.Add(this.txtReceiptNumber, 1, 0);
            this.tblReceipt.Controls.Add(this.lblReceiptDate, 0, 1);
            this.tblReceipt.Controls.Add(this.txtReceiptDate, 1, 1);
            this.tblReceipt.Controls.Add(this.lblReceiptPaid, 0, 2);
            this.tblReceipt.Controls.Add(this.txtReceiptPaid, 1, 2);
            this.tblReceipt.Controls.Add(this.lblReceiptBalance, 0, 3);
            this.tblReceipt.Controls.Add(this.txtReceiptBalance, 1, 3);
            this.tblReceipt.Controls.Add(this.dgvPayments, 0, 4);
            this.tblReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblReceipt.Location = new System.Drawing.Point(3, 21);
            this.tblReceipt.Name = "tblReceipt";
            this.tblReceipt.Padding = new System.Windows.Forms.Padding(12, 5, 12, 8);
            this.tblReceipt.RowCount = 5;
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReceipt.Size = new System.Drawing.Size(557, 289);
            this.tblReceipt.TabIndex = 0;
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptNumber.Location = new System.Drawing.Point(15, 5);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(207, 36);
            this.lblReceiptNumber.TabIndex = 0;
            this.lblReceiptNumber.Text = "Receipt Number";
            this.lblReceiptNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptNumber.Location = new System.Drawing.Point(228, 8);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.ReadOnly = true;
            this.txtReceiptNumber.Size = new System.Drawing.Size(314, 25);
            this.txtReceiptNumber.TabIndex = 1;
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptDate.Location = new System.Drawing.Point(15, 41);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(207, 36);
            this.lblReceiptDate.TabIndex = 2;
            this.lblReceiptDate.Text = "Receipt Date";
            this.lblReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiptDate
            // 
            this.txtReceiptDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptDate.Location = new System.Drawing.Point(228, 44);
            this.txtReceiptDate.Name = "txtReceiptDate";
            this.txtReceiptDate.ReadOnly = true;
            this.txtReceiptDate.Size = new System.Drawing.Size(314, 25);
            this.txtReceiptDate.TabIndex = 3;
            // 
            // lblReceiptPaid
            // 
            this.lblReceiptPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptPaid.Location = new System.Drawing.Point(15, 77);
            this.lblReceiptPaid.Name = "lblReceiptPaid";
            this.lblReceiptPaid.Size = new System.Drawing.Size(207, 36);
            this.lblReceiptPaid.TabIndex = 4;
            this.lblReceiptPaid.Text = "Total Amount Paid";
            this.lblReceiptPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiptPaid
            // 
            this.txtReceiptPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptPaid.Location = new System.Drawing.Point(228, 80);
            this.txtReceiptPaid.Name = "txtReceiptPaid";
            this.txtReceiptPaid.ReadOnly = true;
            this.txtReceiptPaid.Size = new System.Drawing.Size(314, 25);
            this.txtReceiptPaid.TabIndex = 5;
            // 
            // lblReceiptBalance
            // 
            this.lblReceiptBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptBalance.Location = new System.Drawing.Point(15, 113);
            this.lblReceiptBalance.Name = "lblReceiptBalance";
            this.lblReceiptBalance.Size = new System.Drawing.Size(207, 36);
            this.lblReceiptBalance.TabIndex = 6;
            this.lblReceiptBalance.Text = "Remaining Balance";
            this.lblReceiptBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiptBalance
            // 
            this.txtReceiptBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptBalance.Location = new System.Drawing.Point(228, 116);
            this.txtReceiptBalance.Name = "txtReceiptBalance";
            this.txtReceiptBalance.ReadOnly = true;
            this.txtReceiptBalance.Size = new System.Drawing.Size(314, 25);
            this.txtReceiptBalance.TabIndex = 7;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.tblReceipt.SetColumnSpan(this.dgvPayments, 2);
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(12, 155);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(533, 126);
            this.dgvPayments.TabIndex = 8;
            // 
            // grpConfirm
            // 
            this.grpConfirm.Controls.Add(this.tblConfirm);
            this.grpConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpConfirm.Location = new System.Drawing.Point(8, 321);
            this.grpConfirm.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.grpConfirm.Name = "grpConfirm";
            this.grpConfirm.Size = new System.Drawing.Size(563, 152);
            this.grpConfirm.TabIndex = 1;
            this.grpConfirm.TabStop = false;
            this.grpConfirm.Text = "Payment Confirmation";
            // 
            // tblConfirm
            // 
            this.tblConfirm.ColumnCount = 1;
            this.tblConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblConfirm.Controls.Add(this.lblConfirm, 0, 0);
            this.tblConfirm.Controls.Add(this.tblButtons, 0, 1);
            this.tblConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConfirm.Location = new System.Drawing.Point(3, 21);
            this.tblConfirm.Name = "tblConfirm";
            this.tblConfirm.Padding = new System.Windows.Forms.Padding(12, 5, 12, 8);
            this.tblConfirm.RowCount = 2;
            this.tblConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblConfirm.Size = new System.Drawing.Size(557, 128);
            this.tblConfirm.TabIndex = 0;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirm.Location = new System.Drawing.Point(15, 5);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(527, 63);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Select a student assessment before recording payment.";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 4;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButtons.Controls.Add(this.btnRecord, 0, 0);
            this.tblButtons.Controls.Add(this.btnClear, 1, 0);
            this.tblButtons.Controls.Add(this.btnPrint, 2, 0);
            this.tblButtons.Controls.Add(this.btnReverse, 3, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(15, 71);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(527, 46);
            this.tblButtons.TabIndex = 1;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(3, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(152, 40);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record Payment";
            this.btnRecord.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(161, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Location = new System.Drawing.Point(250, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(141, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Receipt";
            // 
            // btnReverse
            // 
            this.btnReverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReverse.Location = new System.Drawing.Point(397, 3);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(127, 40);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Reverse";
            // 
            // PaymentModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1240, 800);
            this.Controls.Add(this.tblMain);
            this.MinimumSize = new System.Drawing.Size(980, 680);
            this.Name = "PaymentModuleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Module";
            this.tblMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblTop.ResumeLayout(false);
            this.grpStudent.ResumeLayout(false);
            this.tblStudent.ResumeLayout(false);
            this.tblStudent.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.tblSummary.ResumeLayout(false);
            this.tblSummary.PerformLayout();
            this.tblBottom.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.tblPayment.ResumeLayout(false);
            this.tblPayment.PerformLayout();
            this.tblRight.ResumeLayout(false);
            this.grpReceipt.ResumeLayout(false);
            this.tblReceipt.ResumeLayout(false);
            this.tblReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.grpConfirm.ResumeLayout(false);
            this.tblConfirm.ResumeLayout(false);
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // MAIN LAYOUT
        private TableLayoutPanel tblMain;
        private Panel pnlHeader;
        private TableLayoutPanel tblTop;
        private TableLayoutPanel tblBottom;
        private TableLayoutPanel tblRight;

        private GroupBox grpStudent;
        private GroupBox grpSummary;
        private GroupBox grpPayment;
        private GroupBox grpReceipt;
        private GroupBox grpConfirm;

        private TableLayoutPanel tblStudent;
        private TableLayoutPanel tblSummary;
        private TableLayoutPanel tblPayment;
        private TableLayoutPanel tblReceipt;
        private TableLayoutPanel tblConfirm;
        private TableLayoutPanel tblButtons;

        // HEADER
        private Label lblTitle;
        private Label lblSubtitle;

        // STUDENT INFORMATION
        private Label lblSelectStudent;
        private Label lblSchoolYear;
        private Label lblStudentID;
        private Label lblStudentName;
        private Label lblGrade;
        private Label lblSection;

        private ComboBox cmbStudent;
        private ComboBox cmbSchoolYear;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtGrade;
        private TextBox txtSection;

        // ACCOUNT SUMMARY
        private Label lblTotalAssessment;
        private Label lblTotalPaid;
        private Label lblRemainingBalance;
        private Label lblCreditBalance;

        private TextBox txtTotalAssessment;
        private TextBox txtTotalPaid;
        private TextBox txtRemainingBalance;
        private TextBox txtCreditBalance;

        // PAYMENT INFORMATION
        private Label lblPaymentDate;
        private Label lblAmount;
        private Label lblMethod;
        private Label lblReference;
        private Label lblDescription;

        private DateTimePicker dtpPaymentDate;
        private TextBox txtAmount;
        private ComboBox cmbMethod;
        private TextBox txtReference;
        private TextBox txtDescription;

        // RECEIPT INFORMATION
        private Label lblReceiptNumber;
        private Label lblReceiptDate;
        private Label lblReceiptPaid;
        private Label lblReceiptBalance;

        private TextBox txtReceiptNumber;
        private TextBox txtReceiptDate;
        private TextBox txtReceiptPaid;
        private TextBox txtReceiptBalance;

        private DataGridView dgvPayments;

        // CONFIRMATION
        private Label lblConfirm;
        private Button btnRecord;
        private Button btnClear;
        private Button btnPrint;
        private Button btnReverse;
    }
}
