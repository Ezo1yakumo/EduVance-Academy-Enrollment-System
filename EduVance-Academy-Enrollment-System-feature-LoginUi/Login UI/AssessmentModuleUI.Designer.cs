
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class AssessmentModuleUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.layoutRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.tblStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.tblStudentDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.tblMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.grpAssessment = new System.Windows.Forms.GroupBox();
            this.tblFees = new System.Windows.Forms.TableLayoutPanel();
            this.lblTuition = new System.Windows.Forms.Label();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.lblMisc = new System.Windows.Forms.Label();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.tblPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblPaymentNote = new System.Windows.Forms.Label();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.layoutRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.tblStudent.SuspendLayout();
            this.tblStudentDetails.SuspendLayout();
            this.tblMiddle.SuspendLayout();
            this.grpAssessment.SuspendLayout();
            this.tblFees.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.tblPayment.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutRoot
            // 
            this.layoutRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.layoutRoot.ColumnCount = 1;
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutRoot.Controls.Add(this.grpStudent, 0, 1);
            this.layoutRoot.Controls.Add(this.tblMiddle, 0, 2);
            this.layoutRoot.Controls.Add(this.tblFooter, 0, 3);
            this.layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutRoot.Margin = new System.Windows.Forms.Padding(0);
            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.Padding = new System.Windows.Forms.Padding(20);
            this.layoutRoot.RowCount = 4;
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.layoutRoot.Size = new System.Drawing.Size(1200, 720);
            this.layoutRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assessment Module";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(354, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage student fees, discounts, and remaining balances";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.tblStudent);
            this.grpStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStudent.Location = new System.Drawing.Point(20, 105);
            this.grpStudent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(1160, 163);
            this.grpStudent.TabIndex = 1;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnCount = 2;
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblStudent.Controls.Add(this.lblSelectStudent, 0, 0);
            this.tblStudent.Controls.Add(this.lblSchoolYear, 1, 0);
            this.tblStudent.Controls.Add(this.cmbStudent, 0, 1);
            this.tblStudent.Controls.Add(this.cmbSchoolYear, 1, 1);
            this.tblStudent.Controls.Add(this.tblStudentDetails, 0, 2);
            this.tblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudent.Location = new System.Drawing.Point(3, 21);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.Padding = new System.Windows.Forms.Padding(15, 8, 15, 10);
            this.tblStudent.RowCount = 3;
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudent.Size = new System.Drawing.Size(1154, 139);
            this.tblStudent.TabIndex = 0;
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectStudent.Location = new System.Drawing.Point(18, 8);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(724, 25);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select Enrolled Student";
            this.lblSelectStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSchoolYear.Location = new System.Drawing.Point(748, 8);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(388, 25);
            this.lblSchoolYear.TabIndex = 1;
            this.lblSchoolYear.Text = "School Year";
            this.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbStudent
            // 
            this.cmbStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStudent.Location = new System.Drawing.Point(15, 36);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(715, 28);
            this.cmbStudent.TabIndex = 2;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbSchoolYear.Location = new System.Drawing.Point(745, 36);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(394, 28);
            this.cmbSchoolYear.TabIndex = 3;
            // 
            // tblStudentDetails
            // 
            this.tblStudentDetails.ColumnCount = 3;
            this.tblStudent.SetColumnSpan(this.tblStudentDetails, 2);
            this.tblStudentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblStudentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStudentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblStudentDetails.Controls.Add(this.lblName, 0, 0);
            this.tblStudentDetails.Controls.Add(this.lblGrade, 1, 0);
            this.tblStudentDetails.Controls.Add(this.lblSection, 2, 0);
            this.tblStudentDetails.Controls.Add(this.txtStudentName, 0, 1);
            this.tblStudentDetails.Controls.Add(this.txtGrade, 1, 1);
            this.tblStudentDetails.Controls.Add(this.txtSection, 2, 1);
            this.tblStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudentDetails.Location = new System.Drawing.Point(18, 76);
            this.tblStudentDetails.Name = "tblStudentDetails";
            this.tblStudentDetails.RowCount = 2;
            this.tblStudentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblStudentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudentDetails.Size = new System.Drawing.Size(1118, 50);
            this.tblStudentDetails.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(497, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // lblGrade
            // 
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrade.Location = new System.Drawing.Point(506, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(273, 23);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade Level";
            // 
            // lblSection
            // 
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(785, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(330, 23);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(0, 23);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(0, 0, 12, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(491, 25);
            this.txtStudentName.TabIndex = 3;
            // 
            // txtGrade
            // 
            this.txtGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGrade.Location = new System.Drawing.Point(503, 23);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(0, 0, 12, 2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(267, 25);
            this.txtGrade.TabIndex = 4;
            // 
            // txtSection
            // 
            this.txtSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSection.Location = new System.Drawing.Point(782, 23);
            this.txtSection.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(336, 25);
            this.txtSection.TabIndex = 5;
            // 
            // tblMiddle
            // 
            this.tblMiddle.ColumnCount = 2;
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMiddle.Controls.Add(this.grpAssessment, 0, 0);
            this.tblMiddle.Controls.Add(this.grpPayment, 1, 0);
            this.tblMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMiddle.Location = new System.Drawing.Point(20, 280);
            this.tblMiddle.Margin = new System.Windows.Forms.Padding(0);
            this.tblMiddle.Name = "tblMiddle";
            this.tblMiddle.RowCount = 1;
            this.tblMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMiddle.Size = new System.Drawing.Size(1160, 345);
            this.tblMiddle.TabIndex = 2;
            // 
            // grpAssessment
            // 
            this.grpAssessment.Controls.Add(this.tblFees);
            this.grpAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAssessment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAssessment.Location = new System.Drawing.Point(0, 0);
            this.grpAssessment.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.grpAssessment.Name = "grpAssessment";
            this.grpAssessment.Size = new System.Drawing.Size(684, 345);
            this.grpAssessment.TabIndex = 0;
            this.grpAssessment.TabStop = false;
            this.grpAssessment.Text = "Assessment Details";
            // 
            // tblFees
            // 
            this.tblFees.ColumnCount = 2;
            this.tblFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tblFees.Controls.Add(this.lblTuition, 0, 0);
            this.tblFees.Controls.Add(this.txtTuition, 1, 0);
            this.tblFees.Controls.Add(this.lblMisc, 0, 1);
            this.tblFees.Controls.Add(this.txtMisc, 1, 1);
            this.tblFees.Controls.Add(this.lblOther, 0, 2);
            this.tblFees.Controls.Add(this.txtOther, 1, 2);
            this.tblFees.Controls.Add(this.lblDiscount, 0, 3);
            this.tblFees.Controls.Add(this.txtDiscount, 1, 3);
            this.tblFees.Controls.Add(this.lblTotal, 0, 4);
            this.tblFees.Controls.Add(this.txtTotal, 1, 4);
            this.tblFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFees.Location = new System.Drawing.Point(3, 21);
            this.tblFees.Name = "tblFees";
            this.tblFees.Padding = new System.Windows.Forms.Padding(16);
            this.tblFees.RowCount = 6;
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFees.Size = new System.Drawing.Size(678, 321);
            this.tblFees.TabIndex = 0;
            // 
            // lblTuition
            // 
            this.lblTuition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTuition.Location = new System.Drawing.Point(19, 16);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(278, 55);
            this.lblTuition.TabIndex = 0;
            this.lblTuition.Text = "Tuition Fee";
            this.lblTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTuition
            // 
            this.txtTuition.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTuition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTuition.Location = new System.Drawing.Point(308, 28);
            this.txtTuition.Margin = new System.Windows.Forms.Padding(8, 12, 8, 0);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(346, 29);
            this.txtTuition.TabIndex = 1;
            this.txtTuition.Text = "0.00";
            // 
            // lblMisc
            // 
            this.lblMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMisc.Location = new System.Drawing.Point(19, 71);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(278, 55);
            this.lblMisc.TabIndex = 2;
            this.lblMisc.Text = "Miscellaneous Fees";
            this.lblMisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMisc
            // 
            this.txtMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMisc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMisc.Location = new System.Drawing.Point(308, 83);
            this.txtMisc.Margin = new System.Windows.Forms.Padding(8, 12, 8, 0);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(346, 29);
            this.txtMisc.TabIndex = 3;
            this.txtMisc.Text = "0.00";
            // 
            // lblOther
            // 
            this.lblOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOther.Location = new System.Drawing.Point(19, 126);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(278, 55);
            this.lblOther.TabIndex = 4;
            this.lblOther.Text = "Other Fees";
            this.lblOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOther
            // 
            this.txtOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOther.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOther.Location = new System.Drawing.Point(308, 138);
            this.txtOther.Margin = new System.Windows.Forms.Padding(8, 12, 8, 0);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(346, 29);
            this.txtOther.TabIndex = 5;
            this.txtOther.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Location = new System.Drawing.Point(19, 181);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(278, 55);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(308, 193);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(8, 12, 8, 0);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(346, 29);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(19, 236);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(278, 65);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total Assessment";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(308, 248);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(8, 12, 8, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(346, 31);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0.00";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.tblPayment);
            this.grpPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPayment.Location = new System.Drawing.Point(696, 0);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(0);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(464, 345);
            this.grpPayment.TabIndex = 1;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Summary";
            // 
            // tblPayment
            // 
            this.tblPayment.ColumnCount = 2;
            this.tblPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblPayment.Controls.Add(this.lblPaid, 0, 0);
            this.tblPayment.Controls.Add(this.txtAmountPaid, 1, 0);
            this.tblPayment.Controls.Add(this.lblBalance, 0, 1);
            this.tblPayment.Controls.Add(this.txtRemainingBalance, 1, 1);
            this.tblPayment.Controls.Add(this.lblCredit, 0, 2);
            this.tblPayment.Controls.Add(this.lblPaymentNote, 0, 3);
            this.tblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPayment.Location = new System.Drawing.Point(3, 21);
            this.tblPayment.Name = "tblPayment";
            this.tblPayment.Padding = new System.Windows.Forms.Padding(15);
            this.tblPayment.RowCount = 4;
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPayment.Size = new System.Drawing.Size(458, 321);
            this.tblPayment.TabIndex = 0;
            // 
            // lblPaid
            // 
            this.lblPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaid.Location = new System.Drawing.Point(18, 15);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(186, 65);
            this.lblPaid.TabIndex = 0;
            this.lblPaid.Text = "Amount Paid";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmountPaid.Location = new System.Drawing.Point(212, 30);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(5, 15, 5, 0);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(226, 29);
            this.txtAmountPaid.TabIndex = 1;
            this.txtAmountPaid.Text = "0.00";
            // 
            // lblBalance
            // 
            this.lblBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBalance.Location = new System.Drawing.Point(18, 80);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(186, 65);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Remaining Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemainingBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtRemainingBalance.Location = new System.Drawing.Point(212, 95);
            this.txtRemainingBalance.Margin = new System.Windows.Forms.Padding(5, 15, 5, 0);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.ReadOnly = true;
            this.txtRemainingBalance.Size = new System.Drawing.Size(226, 29);
            this.txtRemainingBalance.TabIndex = 3;
            this.txtRemainingBalance.Text = "0.00";
            // 
            // lblCredit
            // 
            this.tblPayment.SetColumnSpan(this.lblCredit, 2);
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCredit.Location = new System.Drawing.Point(18, 145);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(422, 60);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "Credit Balance: 0.00";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentNote
            // 
            this.tblPayment.SetColumnSpan(this.lblPaymentNote, 2);
            this.lblPaymentNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblPaymentNote.Location = new System.Drawing.Point(18, 205);
            this.lblPaymentNote.Name = "lblPaymentNote";
            this.lblPaymentNote.Size = new System.Drawing.Size(422, 101);
            this.lblPaymentNote.TabIndex = 5;
            this.lblPaymentNote.Text = "Payment totals are retrieved from recorded transactions.";
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 4;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tblFooter.Controls.Add(this.lblStatus, 0, 0);
            this.tblFooter.Controls.Add(this.btnRefresh, 1, 0);
            this.tblFooter.Controls.Add(this.btnSave, 2, 0);
            this.tblFooter.Controls.Add(this.btnClear, 3, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(20, 625);
            this.tblFooter.Margin = new System.Windows.Forms.Padding(0);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(1160, 75);
            this.tblFooter.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(779, 75);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Select an enrolled student to begin.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(790, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 51);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(905, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Assessment";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(1050, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 51);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // AssessmentModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.layoutRoot);
            this.Name = "AssessmentModuleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment Module";
            this.layoutRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.tblStudent.ResumeLayout(false);
            this.tblStudentDetails.ResumeLayout(false);
            this.tblStudentDetails.PerformLayout();
            this.tblMiddle.ResumeLayout(false);
            this.grpAssessment.ResumeLayout(false);
            this.tblFees.ResumeLayout(false);
            this.tblFees.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.tblPayment.ResumeLayout(false);
            this.tblPayment.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // MAIN LAYOUT
        private TableLayoutPanel layoutRoot;
        private Panel pnlHeader;
        private TableLayoutPanel tblMiddle;
        private TableLayoutPanel tblFooter;

        // STUDENT INFORMATION
        private GroupBox grpStudent;
        private TableLayoutPanel tblStudent;
        private TableLayoutPanel tblStudentDetails;

        // ASSESSMENT
        private GroupBox grpAssessment;
        private TableLayoutPanel tblFees;

        // PAYMENT
        private GroupBox grpPayment;
        private TableLayoutPanel tblPayment;

        // HEADER
        private Label lblTitle;
        private Label lblSubtitle;

        // STUDENT LABELS
        private Label lblSelectStudent;
        private Label lblSchoolYear;
        private Label lblName;
        private Label lblGrade;
        private Label lblSection;

        // STUDENT CONTROLS
        private ComboBox cmbStudent;
        private ComboBox cmbSchoolYear;
        private TextBox txtStudentName;
        private TextBox txtGrade;
        private TextBox txtSection;

        // ASSESSMENT LABELS
        private Label lblTuition;
        private Label lblMisc;
        private Label lblOther;
        private Label lblDiscount;
        private Label lblTotal;

        // ASSESSMENT CONTROLS
        private TextBox txtTuition;
        private TextBox txtMisc;
        private TextBox txtOther;
        private TextBox txtDiscount;
        private TextBox txtTotal;

        // PAYMENT LABELS
        private Label lblPaid;
        private Label lblBalance;
        private Label lblCredit;
        private Label lblPaymentNote;

        // PAYMENT CONTROLS
        private TextBox txtAmountPaid;
        private TextBox txtRemainingBalance;

        // FOOTER
        private Label lblStatus;
        private Button btnRefresh;
        private Button btnSave;
        private Button btnClear;
    }
}
