
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
            // Containers
            this.tblMain = new TableLayoutPanel();
            this.pnlHeader = new Panel();
            this.tblTop = new TableLayoutPanel();
            this.tblBottom = new TableLayoutPanel();
            this.tblRight = new TableLayoutPanel();

            this.grpStudent = new GroupBox();
            this.grpSummary = new GroupBox();
            this.grpPayment = new GroupBox();
            this.grpReceipt = new GroupBox();
            this.grpConfirm = new GroupBox();

            this.tblStudent = new TableLayoutPanel();
            this.tblSummary = new TableLayoutPanel();
            this.tblPayment = new TableLayoutPanel();
            this.tblReceipt = new TableLayoutPanel();
            this.tblConfirm = new TableLayoutPanel();
            this.tblButtons = new TableLayoutPanel();

            // Header
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            // Student information
            this.lblSelectStudent = new Label();
            this.lblSchoolYear = new Label();
            this.lblStudentID = new Label();
            this.lblStudentName = new Label();
            this.lblGrade = new Label();
            this.lblSection = new Label();

            this.cmbStudent = new ComboBox();
            this.cmbSchoolYear = new ComboBox();

            this.txtStudentID = new TextBox();
            this.txtStudentName = new TextBox();
            this.txtGrade = new TextBox();
            this.txtSection = new TextBox();

            // Account summary
            this.lblTotalAssessment = new Label();
            this.lblTotalPaid = new Label();
            this.lblRemainingBalance = new Label();
            this.lblCreditBalance = new Label();

            this.txtTotalAssessment = new TextBox();
            this.txtTotalPaid = new TextBox();
            this.txtRemainingBalance = new TextBox();
            this.txtCreditBalance = new TextBox();

            // Payment fields
            this.lblPaymentDate = new Label();
            this.lblAmount = new Label();
            this.lblMethod = new Label();
            this.lblReference = new Label();
            this.lblDescription = new Label();

            this.dtpPaymentDate = new DateTimePicker();
            this.txtAmount = new TextBox();
            this.cmbMethod = new ComboBox();
            this.txtReference = new TextBox();
            this.txtDescription = new TextBox();

            // Receipt information
            this.lblReceiptNumber = new Label();
            this.lblReceiptDate = new Label();
            this.lblReceiptPaid = new Label();
            this.lblReceiptBalance = new Label();

            this.txtReceiptNumber = new TextBox();
            this.txtReceiptDate = new TextBox();
            this.txtReceiptPaid = new TextBox();
            this.txtReceiptBalance = new TextBox();

            this.dgvPayments = new DataGridView();

            // Confirmation and buttons
            this.lblConfirm = new Label();
            this.btnRecord = new Button();
            this.btnClear = new Button();
            this.btnPrint = new Button();
            this.btnReverse = new Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPayments)).BeginInit();

            this.SuspendLayout();

            // =====================================
            // MAIN LAYOUT
            // =====================================

            this.tblMain.Name = "tblMain";
            this.tblMain.Dock = DockStyle.Fill;
            this.tblMain.Padding = new Padding(16);
            this.tblMain.Margin = new Padding(0);
            this.tblMain.BackColor =
                Color.FromArgb(245, 246, 249);

            this.tblMain.ColumnCount = 1;
            this.tblMain.RowCount = 3;

            this.tblMain.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            this.tblMain.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 78F));

            this.tblMain.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 205F));

            this.tblMain.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.tblMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblTop, 0, 1);
            this.tblMain.Controls.Add(this.tblBottom, 0, 2);

            // =====================================
            // HEADER
            // =====================================

            this.pnlHeader.Dock = DockStyle.Fill;

            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Payment Module";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new Font("Segoe UI", 23F, FontStyle.Bold);
            this.lblTitle.Location = new Point(0, 0);

            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text =
                "Record student payments and issue receipts";
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font =
                new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.DimGray;
            this.lblSubtitle.Location = new Point(3, 49);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            // =====================================
            // TOP SECTION
            // =====================================

            this.tblTop.Dock = DockStyle.Fill;
            this.tblTop.ColumnCount = 2;
            this.tblTop.RowCount = 1;

            this.tblTop.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 56F));
            this.tblTop.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 44F));
            this.tblTop.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.tblTop.Controls.Add(this.grpStudent, 0, 0);
            this.tblTop.Controls.Add(this.grpSummary, 1, 0);

            // =====================================
            // STUDENT INFORMATION
            // =====================================

            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Text = "Student Information";
            this.grpStudent.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpStudent.Dock = DockStyle.Fill;
            this.grpStudent.Margin = new Padding(0, 0, 8, 8);
            this.grpStudent.Controls.Add(this.tblStudent);

            this.tblStudent.Dock = DockStyle.Fill;
            this.tblStudent.Padding = new Padding(12, 5, 12, 8);
            this.tblStudent.ColumnCount = 4;
            this.tblStudent.RowCount = 4;

            this.tblStudent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));
            this.tblStudent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            this.tblStudent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 25F));
            this.tblStudent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 38F));
            this.tblStudent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 26F));
            this.tblStudent.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.lblSelectStudent.Text = "Select Student";
            this.lblSelectStudent.Dock = DockStyle.Fill;
            this.lblSelectStudent.TextAlign =
                ContentAlignment.MiddleLeft;

            this.lblSchoolYear.Text = "School Year";
            this.lblSchoolYear.Dock = DockStyle.Fill;
            this.lblSchoolYear.TextAlign =
                ContentAlignment.MiddleLeft;

            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Dock = DockStyle.Fill;
            this.cmbStudent.Font =
                new Font("Segoe UI", 10F);
            this.cmbStudent.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbStudent.Margin =
                new Padding(0, 2, 12, 2);

            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Dock = DockStyle.Fill;
            this.cmbSchoolYear.Font =
                new Font("Segoe UI", 10F);
            this.cmbSchoolYear.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.Margin =
                new Padding(0, 2, 0, 2);

            this.lblStudentID.Text = "Student ID";
            this.lblStudentName.Text = "Student Name";
            this.lblGrade.Text = "Grade Level";
            this.lblSection.Text = "Section";

            this.lblStudentID.Dock = DockStyle.Fill;
            this.lblStudentName.Dock = DockStyle.Fill;
            this.lblGrade.Dock = DockStyle.Fill;
            this.lblSection.Dock = DockStyle.Fill;

            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentName.Name = "txtStudentName";
            this.txtGrade.Name = "txtGrade";
            this.txtSection.Name = "txtSection";

            this.txtStudentID.ReadOnly = true;
            this.txtStudentName.ReadOnly = true;
            this.txtGrade.ReadOnly = true;
            this.txtSection.ReadOnly = true;

            this.txtStudentID.Dock = DockStyle.Fill;
            this.txtStudentName.Dock = DockStyle.Fill;
            this.txtGrade.Dock = DockStyle.Fill;
            this.txtSection.Dock = DockStyle.Fill;

            this.tblStudent.Controls.Add(
                this.lblSelectStudent, 0, 0);
            this.tblStudent.SetColumnSpan(
                this.lblSelectStudent, 3);

            this.tblStudent.Controls.Add(
                this.lblSchoolYear, 3, 0);

            this.tblStudent.Controls.Add(
                this.cmbStudent, 0, 1);
            this.tblStudent.SetColumnSpan(
                this.cmbStudent, 3);

            this.tblStudent.Controls.Add(
                this.cmbSchoolYear, 3, 1);

            this.tblStudent.Controls.Add(
                this.lblStudentID, 0, 2);
            this.tblStudent.Controls.Add(
                this.lblStudentName, 1, 2);
            this.tblStudent.Controls.Add(
                this.lblGrade, 2, 2);
            this.tblStudent.Controls.Add(
                this.lblSection, 3, 2);

            this.tblStudent.Controls.Add(
                this.txtStudentID, 0, 3);
            this.tblStudent.Controls.Add(
                this.txtStudentName, 1, 3);
            this.tblStudent.Controls.Add(
                this.txtGrade, 2, 3);
            this.tblStudent.Controls.Add(
                this.txtSection, 3, 3);

            // =====================================
            // ACCOUNT SUMMARY
            // =====================================

            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Text = "Account Summary";
            this.grpSummary.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpSummary.Dock = DockStyle.Fill;
            this.grpSummary.Margin = new Padding(8, 0, 0, 8);
            this.grpSummary.Controls.Add(this.tblSummary);

            this.tblSummary.Dock = DockStyle.Fill;
            this.tblSummary.Padding = new Padding(12, 6, 12, 6);
            this.tblSummary.ColumnCount = 2;
            this.tblSummary.RowCount = 4;

            this.tblSummary.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 45F));
            this.tblSummary.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 55F));

            this.tblSummary.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            this.tblSummary.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            this.lblTotalAssessment.Text = "Total Assessment";
            this.lblTotalPaid.Text = "Amount Paid";
            this.lblRemainingBalance.Text = "Remaining Balance";
            this.lblCreditBalance.Text = "Credit Balance";

            this.lblTotalAssessment.Dock = DockStyle.Fill;
            this.lblTotalPaid.Dock = DockStyle.Fill;
            this.lblRemainingBalance.Dock = DockStyle.Fill;
            this.lblCreditBalance.Dock = DockStyle.Fill;

            this.lblTotalAssessment.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblTotalPaid.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblRemainingBalance.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblCreditBalance.TextAlign =
                ContentAlignment.MiddleLeft;

            this.txtTotalAssessment.Name =
                "txtTotalAssessment";
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtRemainingBalance.Name =
                "txtRemainingBalance";
            this.txtCreditBalance.Name = "txtCreditBalance";

            this.txtTotalAssessment.ReadOnly = true;
            this.txtTotalPaid.ReadOnly = true;
            this.txtRemainingBalance.ReadOnly = true;
            this.txtCreditBalance.ReadOnly = true;

            this.txtTotalAssessment.Dock = DockStyle.Fill;
            this.txtTotalPaid.Dock = DockStyle.Fill;
            this.txtRemainingBalance.Dock = DockStyle.Fill;
            this.txtCreditBalance.Dock = DockStyle.Fill;

            this.txtRemainingBalance.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.tblSummary.Controls.Add(
                this.lblTotalAssessment, 0, 0);
            this.tblSummary.Controls.Add(
                this.txtTotalAssessment, 1, 0);
            this.tblSummary.Controls.Add(
                this.lblTotalPaid, 0, 1);
            this.tblSummary.Controls.Add(
                this.txtTotalPaid, 1, 1);
            this.tblSummary.Controls.Add(
                this.lblRemainingBalance, 0, 2);
            this.tblSummary.Controls.Add(
                this.txtRemainingBalance, 1, 2);
            this.tblSummary.Controls.Add(
                this.lblCreditBalance, 0, 3);
            this.tblSummary.Controls.Add(
                this.txtCreditBalance, 1, 3);

            // =====================================
            // BOTTOM SECTION
            // =====================================

            this.tblBottom.Dock = DockStyle.Fill;
            this.tblBottom.ColumnCount = 2;
            this.tblBottom.RowCount = 1;

            this.tblBottom.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 52F));
            this.tblBottom.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 48F));
            this.tblBottom.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.tblBottom.Controls.Add(
                this.grpPayment, 0, 0);
            this.tblBottom.Controls.Add(
                this.tblRight, 1, 0);

            // =====================================
            // PAYMENT INFORMATION
            // =====================================

            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Text = "Payment Information";
            this.grpPayment.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpPayment.Dock = DockStyle.Fill;
            this.grpPayment.Margin =
                new Padding(0, 0, 8, 0);
            this.grpPayment.Controls.Add(this.tblPayment);

            this.tblPayment.Dock = DockStyle.Fill;
            this.tblPayment.Padding = new Padding(15);
            this.tblPayment.ColumnCount = 2;
            this.tblPayment.RowCount = 5;

            this.tblPayment.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 36F));
            this.tblPayment.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 64F));

            this.tblPayment.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 54F));
            this.tblPayment.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.lblPaymentDate.Text = "Payment Date";
            this.lblAmount.Text = "Amount Paid";
            this.lblMethod.Text = "Payment Method";
            this.lblReference.Text = "Reference Number";
            this.lblDescription.Text = "Payment Description";

            this.lblPaymentDate.Dock = DockStyle.Fill;
            this.lblAmount.Dock = DockStyle.Fill;
            this.lblMethod.Dock = DockStyle.Fill;
            this.lblReference.Dock = DockStyle.Fill;
            this.lblDescription.Dock = DockStyle.Fill;

            this.lblPaymentDate.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblAmount.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblMethod.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblReference.TextAlign =
                ContentAlignment.MiddleLeft;

            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Format =
                DateTimePickerFormat.Short;
            this.dtpPaymentDate.Dock = DockStyle.Top;
            this.dtpPaymentDate.Margin =
                new Padding(5, 13, 5, 0);

            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Font =
                new Font("Segoe UI", 11F);
            this.txtAmount.Dock = DockStyle.Top;
            this.txtAmount.Margin =
                new Padding(5, 13, 5, 0);

            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbMethod.Font =
                new Font("Segoe UI", 10F);
            this.cmbMethod.Dock = DockStyle.Top;
            this.cmbMethod.Margin =
                new Padding(5, 13, 5, 0);

            this.txtReference.Name = "txtReference";
            this.txtReference.Font =
                new Font("Segoe UI", 10F);
            this.txtReference.Dock = DockStyle.Top;
            this.txtReference.Margin =
                new Padding(5, 13, 5, 0);

            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars =
                ScrollBars.Vertical;
            this.txtDescription.Dock = DockStyle.Fill;
            this.txtDescription.Margin =
                new Padding(5, 6, 5, 4);

            this.tblPayment.Controls.Add(
                this.lblPaymentDate, 0, 0);
            this.tblPayment.Controls.Add(
                this.dtpPaymentDate, 1, 0);
            this.tblPayment.Controls.Add(
                this.lblAmount, 0, 1);
            this.tblPayment.Controls.Add(
                this.txtAmount, 1, 1);
            this.tblPayment.Controls.Add(
                this.lblMethod, 0, 2);
            this.tblPayment.Controls.Add(
                this.cmbMethod, 1, 2);
            this.tblPayment.Controls.Add(
                this.lblReference, 0, 3);
            this.tblPayment.Controls.Add(
                this.txtReference, 1, 3);
            this.tblPayment.Controls.Add(
                this.lblDescription, 0, 4);
            this.tblPayment.Controls.Add(
                this.txtDescription, 1, 4);

            // =====================================
            // RIGHT SIDE LAYOUT
            // =====================================

            this.tblRight.Dock = DockStyle.Fill;
            this.tblRight.ColumnCount = 1;
            this.tblRight.RowCount = 2;

            this.tblRight.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            this.tblRight.RowStyles.Add(
                new RowStyle(SizeType.Percent, 68F));
            this.tblRight.RowStyles.Add(
                new RowStyle(SizeType.Percent, 32F));

            this.tblRight.Controls.Add(
                this.grpReceipt, 0, 0);
            this.tblRight.Controls.Add(
                this.grpConfirm, 0, 1);

            // =====================================
            // RECEIPT INFORMATION / HISTORY
            // =====================================

            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Text =
                "Receipt Information / Payment History";
            this.grpReceipt.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpReceipt.Dock = DockStyle.Fill;
            this.grpReceipt.Margin =
                new Padding(8, 0, 0, 8);
            this.grpReceipt.Controls.Add(this.tblReceipt);

            this.tblReceipt.Dock = DockStyle.Fill;
            this.tblReceipt.Padding = new Padding(12, 5, 12, 8);
            this.tblReceipt.ColumnCount = 2;
            this.tblReceipt.RowCount = 5;

            this.tblReceipt.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 40F));
            this.tblReceipt.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 60F));

            this.tblReceipt.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 36F));
            this.tblReceipt.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.lblReceiptNumber.Text = "Receipt Number";
            this.lblReceiptDate.Text = "Receipt Date";
            this.lblReceiptPaid.Text = "Total Amount Paid";
            this.lblReceiptBalance.Text = "Remaining Balance";

            this.lblReceiptNumber.Dock = DockStyle.Fill;
            this.lblReceiptDate.Dock = DockStyle.Fill;
            this.lblReceiptPaid.Dock = DockStyle.Fill;
            this.lblReceiptBalance.Dock = DockStyle.Fill;

            this.lblReceiptNumber.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblReceiptDate.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblReceiptPaid.TextAlign =
                ContentAlignment.MiddleLeft;
            this.lblReceiptBalance.TextAlign =
                ContentAlignment.MiddleLeft;

            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptDate.Name = "txtReceiptDate";
            this.txtReceiptPaid.Name = "txtReceiptPaid";
            this.txtReceiptBalance.Name = "txtReceiptBalance";

            this.txtReceiptNumber.ReadOnly = true;
            this.txtReceiptDate.ReadOnly = true;
            this.txtReceiptPaid.ReadOnly = true;
            this.txtReceiptBalance.ReadOnly = true;

            this.txtReceiptNumber.Dock = DockStyle.Fill;
            this.txtReceiptDate.Dock = DockStyle.Fill;
            this.txtReceiptPaid.Dock = DockStyle.Fill;
            this.txtReceiptBalance.Dock = DockStyle.Fill;

            this.tblReceipt.Controls.Add(
                this.lblReceiptNumber, 0, 0);
            this.tblReceipt.Controls.Add(
                this.txtReceiptNumber, 1, 0);
            this.tblReceipt.Controls.Add(
                this.lblReceiptDate, 0, 1);
            this.tblReceipt.Controls.Add(
                this.txtReceiptDate, 1, 1);
            this.tblReceipt.Controls.Add(
                this.lblReceiptPaid, 0, 2);
            this.tblReceipt.Controls.Add(
                this.txtReceiptPaid, 1, 2);
            this.tblReceipt.Controls.Add(
                this.lblReceiptBalance, 0, 3);
            this.tblReceipt.Controls.Add(
                this.txtReceiptBalance, 1, 3);

            // PAYMENT HISTORY GRID
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Dock = DockStyle.Fill;
            this.dgvPayments.BackgroundColor = Color.White;
            this.dgvPayments.ReadOnly = true;

            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.RowHeadersVisible = false;

            this.dgvPayments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPayments.Margin =
                new Padding(0, 6, 0, 0);

            this.tblReceipt.Controls.Add(
                this.dgvPayments, 0, 4);
            this.tblReceipt.SetColumnSpan(
                this.dgvPayments, 2);

            // =====================================
            // PAYMENT CONFIRMATION
            // =====================================

            this.grpConfirm.Name = "grpConfirm";
            this.grpConfirm.Text = "Payment Confirmation";
            this.grpConfirm.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpConfirm.Dock = DockStyle.Fill;
            this.grpConfirm.Margin = new Padding(8, 0, 0, 0);
            this.grpConfirm.Controls.Add(this.tblConfirm);

            this.tblConfirm.Dock = DockStyle.Fill;
            this.tblConfirm.Padding = new Padding(12, 5, 12, 8);
            this.tblConfirm.ColumnCount = 1;
            this.tblConfirm.RowCount = 2;

            this.tblConfirm.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            this.tblConfirm.RowStyles.Add(
                new RowStyle(SizeType.Percent, 55F));
            this.tblConfirm.RowStyles.Add(
                new RowStyle(SizeType.Percent, 45F));

            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text =
                "Select a student assessment before recording payment.";
            this.lblConfirm.Dock = DockStyle.Fill;
            this.lblConfirm.ForeColor = Color.DimGray;
            this.lblConfirm.TextAlign =
                ContentAlignment.MiddleLeft;

            this.tblButtons.Dock = DockStyle.Fill;
            this.tblButtons.ColumnCount = 4;
            this.tblButtons.RowCount = 1;

            this.tblButtons.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 30F));
            this.tblButtons.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 17F));
            this.tblButtons.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 28F));
            this.tblButtons.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            this.tblButtons.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Text = "Record Payment";
            this.btnRecord.Dock = DockStyle.Fill;
            this.btnRecord.Margin = new Padding(3);
            this.btnRecord.BackColor = Color.CornflowerBlue;
            this.btnRecord.ForeColor = Color.White;
            this.btnRecord.FlatStyle = FlatStyle.Flat;

            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "Clear";
            this.btnClear.Dock = DockStyle.Fill;
            this.btnClear.Margin = new Padding(3);

            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.Dock = DockStyle.Fill;
            this.btnPrint.Margin = new Padding(3);

            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Text = "Reverse";
            this.btnReverse.Dock = DockStyle.Fill;
            this.btnReverse.Margin = new Padding(3);

            this.tblButtons.Controls.Add(
                this.btnRecord, 0, 0);
            this.tblButtons.Controls.Add(
                this.btnClear, 1, 0);
            this.tblButtons.Controls.Add(
                this.btnPrint, 2, 0);
            this.tblButtons.Controls.Add(
                this.btnReverse, 3, 0);

            this.tblConfirm.Controls.Add(
                this.lblConfirm, 0, 0);
            this.tblConfirm.Controls.Add(
                this.tblButtons, 0, 1);

            // =====================================
            // FORM SETTINGS
            // =====================================

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;

            this.ClientSize = new Size(1240, 800);
            this.MinimumSize = new Size(980, 680);
            this.AutoScroll = true;

            this.Controls.Add(this.tblMain);

            this.Name = "PaymentModuleUI";
            this.Text = "Payment Module";
            this.BackColor =
                Color.FromArgb(245, 246, 249);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPayments)).EndInit();

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
