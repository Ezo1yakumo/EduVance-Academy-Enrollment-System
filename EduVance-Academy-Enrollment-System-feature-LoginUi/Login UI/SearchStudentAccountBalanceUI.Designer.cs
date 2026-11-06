
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class SearchStudentAccountBalanceUI
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
            this.layoutRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.tblResults = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tblPager = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tblBottom = new System.Windows.Forms.TableLayoutPanel();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.tblStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtGradeLevel = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.txtSchoolYear = new System.Windows.Forms.TextBox();
            this.grpBalance = new System.Windows.Forms.GroupBox();
            this.tblBalance = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalAssessment = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.layoutRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.tblSearch.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.tblResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tblPager.SuspendLayout();
            this.tblBottom.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.tblStudent.SuspendLayout();
            this.grpBalance.SuspendLayout();
            this.tblBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutRoot
            // 
            this.layoutRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.layoutRoot.ColumnCount = 1;
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutRoot.Controls.Add(this.grpSearch, 0, 1);
            this.layoutRoot.Controls.Add(this.grpResults, 0, 2);
            this.layoutRoot.Controls.Add(this.tblBottom, 0, 3);
            this.layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutRoot.Margin = new System.Windows.Forms.Padding(0);
            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.Padding = new System.Windows.Forms.Padding(20);
            this.layoutRoot.RowCount = 4;
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.layoutRoot.Size = new System.Drawing.Size(1200, 760);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(497, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search Student Account and Balance";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(357, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Search enrolled students and view their account balances";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.tblSearch);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSearch.Location = new System.Drawing.Point(20, 105);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1160, 115);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Student Search";
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblSearch.Controls.Add(this.lblSearch, 0, 0);
            this.tblSearch.Controls.Add(this.txtSearch, 0, 1);
            this.tblSearch.Controls.Add(this.btnSearch, 1, 1);
            this.tblSearch.Controls.Add(this.btnClear, 2, 1);
            this.tblSearch.Controls.Add(this.btnRefresh, 3, 1);
            this.tblSearch.Controls.Add(this.lblHint, 0, 2);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(3, 21);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.Padding = new System.Windows.Forms.Padding(12, 3, 12, 6);
            this.tblSearch.RowCount = 3;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(1154, 91);
            this.tblSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.tblSearch.SetColumnSpan(this.lblSearch, 4);
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(15, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(1124, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by Student Name or Student ID";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(12, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(713, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(738, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.Location = new System.Drawing.Point(873, 28);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(1008, 28);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            // 
            // lblHint
            // 
            this.tblSearch.SetColumnSpan(this.lblHint, 4);
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(15, 64);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(1124, 21);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "Choose a student from the search results to view account details.";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.tblResults);
            this.grpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResults.Location = new System.Drawing.Point(20, 230);
            this.grpResults.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(1160, 260);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Search Results";
            // 
            // tblResults
            // 
            this.tblResults.ColumnCount = 1;
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResults.Controls.Add(this.dgvAccounts, 0, 0);
            this.tblResults.Controls.Add(this.tblPager, 0, 1);
            this.tblResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResults.Location = new System.Drawing.Point(3, 21);
            this.tblResults.Name = "tblResults";
            this.tblResults.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tblResults.RowCount = 2;
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblResults.Size = new System.Drawing.Size(1154, 236);
            this.tblResults.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(12, 8);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1130, 174);
            this.dgvAccounts.TabIndex = 0;
            // 
            // tblPager
            // 
            this.tblPager.ColumnCount = 3;
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblPager.Controls.Add(this.lblPage, 0, 0);
            this.tblPager.Controls.Add(this.btnPrevious, 1, 0);
            this.tblPager.Controls.Add(this.btnNext, 2, 0);
            this.tblPager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPager.Location = new System.Drawing.Point(15, 185);
            this.tblPager.Name = "tblPager";
            this.tblPager.RowCount = 1;
            this.tblPager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPager.Size = new System.Drawing.Size(1124, 40);
            this.tblPager.TabIndex = 1;
            // 
            // lblPage
            // 
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPage.Location = new System.Drawing.Point(3, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(908, 40);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Page 0 of 0";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Location = new System.Drawing.Point(919, 6);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 6, 5, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(95, 29);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "< Previous";
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Location = new System.Drawing.Point(1024, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >";
            // 
            // tblBottom
            // 
            this.tblBottom.ColumnCount = 2;
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottom.Controls.Add(this.grpStudent, 0, 0);
            this.tblBottom.Controls.Add(this.grpBalance, 1, 0);
            this.tblBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBottom.Location = new System.Drawing.Point(20, 500);
            this.tblBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tblBottom.Name = "tblBottom";
            this.tblBottom.RowCount = 1;
            this.tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottom.Size = new System.Drawing.Size(1160, 240);
            this.tblBottom.TabIndex = 3;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.tblStudent);
            this.grpStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpStudent.Location = new System.Drawing.Point(0, 0);
            this.grpStudent.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(572, 240);
            this.grpStudent.TabIndex = 0;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnCount = 2;
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblStudent.Controls.Add(this.lblStudentName, 0, 0);
            this.tblStudent.Controls.Add(this.txtStudentName, 1, 0);
            this.tblStudent.Controls.Add(this.lblStudentID, 0, 1);
            this.tblStudent.Controls.Add(this.txtStudentID, 1, 1);
            this.tblStudent.Controls.Add(this.lblGradeLevel, 0, 2);
            this.tblStudent.Controls.Add(this.txtGradeLevel, 1, 2);
            this.tblStudent.Controls.Add(this.lblSection, 0, 3);
            this.tblStudent.Controls.Add(this.txtSection, 1, 3);
            this.tblStudent.Controls.Add(this.lblSchoolYear, 0, 4);
            this.tblStudent.Controls.Add(this.txtSchoolYear, 1, 4);
            this.tblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudent.Location = new System.Drawing.Point(3, 21);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.Padding = new System.Windows.Forms.Padding(15, 8, 15, 10);
            this.tblStudent.RowCount = 5;
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudent.Size = new System.Drawing.Size(566, 216);
            this.tblStudent.TabIndex = 0;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentName.Location = new System.Drawing.Point(18, 8);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(181, 39);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Location = new System.Drawing.Point(207, 13);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(339, 25);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentID.Location = new System.Drawing.Point(18, 47);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(181, 39);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentID.Location = new System.Drawing.Point(207, 52);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(339, 25);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGradeLevel.Location = new System.Drawing.Point(18, 86);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(181, 39);
            this.lblGradeLevel.TabIndex = 4;
            this.lblGradeLevel.Text = "Grade Level";
            this.lblGradeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGradeLevel
            // 
            this.txtGradeLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGradeLevel.Location = new System.Drawing.Point(207, 91);
            this.txtGradeLevel.Margin = new System.Windows.Forms.Padding(5);
            this.txtGradeLevel.Name = "txtGradeLevel";
            this.txtGradeLevel.ReadOnly = true;
            this.txtGradeLevel.Size = new System.Drawing.Size(339, 25);
            this.txtGradeLevel.TabIndex = 5;
            // 
            // lblSection
            // 
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSection.Location = new System.Drawing.Point(18, 125);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(181, 39);
            this.lblSection.TabIndex = 6;
            this.lblSection.Text = "Section";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSection
            // 
            this.txtSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSection.Location = new System.Drawing.Point(207, 130);
            this.txtSection.Margin = new System.Windows.Forms.Padding(5);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(339, 25);
            this.txtSection.TabIndex = 7;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSchoolYear.Location = new System.Drawing.Point(18, 164);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(181, 42);
            this.lblSchoolYear.TabIndex = 8;
            this.lblSchoolYear.Text = "School Year";
            this.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchoolYear.Location = new System.Drawing.Point(207, 169);
            this.txtSchoolYear.Margin = new System.Windows.Forms.Padding(5);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.ReadOnly = true;
            this.txtSchoolYear.Size = new System.Drawing.Size(339, 25);
            this.txtSchoolYear.TabIndex = 9;
            // 
            // grpBalance
            // 
            this.grpBalance.Controls.Add(this.tblBalance);
            this.grpBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBalance.Location = new System.Drawing.Point(588, 0);
            this.grpBalance.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.grpBalance.Name = "grpBalance";
            this.grpBalance.Size = new System.Drawing.Size(572, 240);
            this.grpBalance.TabIndex = 1;
            this.grpBalance.TabStop = false;
            this.grpBalance.Text = "Balance Summary";
            // 
            // tblBalance
            // 
            this.tblBalance.ColumnCount = 2;
            this.tblBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblBalance.Controls.Add(this.lblTotal, 0, 0);
            this.tblBalance.Controls.Add(this.txtTotalAssessment, 1, 0);
            this.tblBalance.Controls.Add(this.lblPaid, 0, 1);
            this.tblBalance.Controls.Add(this.txtAmountPaid, 1, 1);
            this.tblBalance.Controls.Add(this.lblRemaining, 0, 2);
            this.tblBalance.Controls.Add(this.txtRemainingBalance, 1, 2);
            this.tblBalance.Controls.Add(this.lblCredit, 0, 3);
            this.tblBalance.Controls.Add(this.txtCreditBalance, 1, 3);
            this.tblBalance.Controls.Add(this.lblAccountStatus, 0, 4);
            this.tblBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBalance.Location = new System.Drawing.Point(3, 21);
            this.tblBalance.Name = "tblBalance";
            this.tblBalance.Padding = new System.Windows.Forms.Padding(15, 8, 15, 10);
            this.tblBalance.RowCount = 5;
            this.tblBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBalance.Size = new System.Drawing.Size(566, 216);
            this.tblBalance.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(18, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(208, 39);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Assessment";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalAssessment
            // 
            this.txtTotalAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalAssessment.Location = new System.Drawing.Point(234, 13);
            this.txtTotalAssessment.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalAssessment.Name = "txtTotalAssessment";
            this.txtTotalAssessment.ReadOnly = true;
            this.txtTotalAssessment.Size = new System.Drawing.Size(312, 25);
            this.txtTotalAssessment.TabIndex = 1;
            // 
            // lblPaid
            // 
            this.lblPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaid.Location = new System.Drawing.Point(18, 47);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(208, 39);
            this.lblPaid.TabIndex = 2;
            this.lblPaid.Text = "Amount Paid";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmountPaid.Location = new System.Drawing.Point(234, 52);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(312, 25);
            this.txtAmountPaid.TabIndex = 3;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemaining.Location = new System.Drawing.Point(18, 86);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(208, 39);
            this.lblRemaining.TabIndex = 4;
            this.lblRemaining.Text = "Remaining Balance";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemainingBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtRemainingBalance.Location = new System.Drawing.Point(234, 91);
            this.txtRemainingBalance.Margin = new System.Windows.Forms.Padding(5);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.ReadOnly = true;
            this.txtRemainingBalance.Size = new System.Drawing.Size(312, 25);
            this.txtRemainingBalance.TabIndex = 5;
            // 
            // lblCredit
            // 
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredit.Location = new System.Drawing.Point(18, 125);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(208, 39);
            this.lblCredit.TabIndex = 6;
            this.lblCredit.Text = "Credit Balance";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreditBalance.Location = new System.Drawing.Point(234, 130);
            this.txtCreditBalance.Margin = new System.Windows.Forms.Padding(5);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.ReadOnly = true;
            this.txtCreditBalance.Size = new System.Drawing.Size(312, 25);
            this.txtCreditBalance.TabIndex = 7;
            // 
            // lblAccountStatus
            // 
            this.tblBalance.SetColumnSpan(this.lblAccountStatus, 2);
            this.lblAccountStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccountStatus.Location = new System.Drawing.Point(18, 164);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(530, 42);
            this.lblAccountStatus.TabIndex = 8;
            this.lblAccountStatus.Text = "Select a student to view their balance.";
            this.lblAccountStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchStudentAccountBalanceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.layoutRoot);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "SearchStudentAccountBalanceUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student Account and Balance";
            this.layoutRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.tblResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tblPager.ResumeLayout(false);
            this.tblBottom.ResumeLayout(false);
            this.grpStudent.ResumeLayout(false);
            this.tblStudent.ResumeLayout(false);
            this.tblStudent.PerformLayout();
            this.grpBalance.ResumeLayout(false);
            this.tblBalance.ResumeLayout(false);
            this.tblBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // MAIN LAYOUT
        private TableLayoutPanel layoutRoot;
        private Panel pnlHeader;
        private GroupBox grpSearch;
        private TableLayoutPanel tblSearch;
        private GroupBox grpResults;
        private TableLayoutPanel tblResults;
        private TableLayoutPanel tblPager;
        private TableLayoutPanel tblBottom;
        private GroupBox grpStudent;
        private TableLayoutPanel tblStudent;
        private GroupBox grpBalance;
        private TableLayoutPanel tblBalance;

        // HEADER
        private Label lblTitle;
        private Label lblSubtitle;

        // SEARCH
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnRefresh;
        private Label lblHint;

        // RESULTS
        private DataGridView dgvAccounts;
        private Label lblPage;
        private Button btnPrevious;
        private Button btnNext;

        // STUDENT INFORMATION
        private Label lblStudentName;
        private Label lblStudentID;
        private Label lblGradeLevel;
        private Label lblSection;
        private Label lblSchoolYear;

        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private TextBox txtGradeLevel;
        private TextBox txtSection;
        private TextBox txtSchoolYear;

        // BALANCE SUMMARY
        private Label lblTotal;
        private Label lblPaid;
        private Label lblRemaining;
        private Label lblCredit;
        private Label lblAccountStatus;

        private TextBox txtTotalAssessment;
        private TextBox txtAmountPaid;
        private TextBox txtRemainingBalance;
        private TextBox txtCreditBalance;
    }
}
