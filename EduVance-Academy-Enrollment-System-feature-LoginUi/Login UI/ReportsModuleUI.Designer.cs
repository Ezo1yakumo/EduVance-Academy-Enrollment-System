namespace Login_UI
{
    partial class ReportsModuleUI
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel filterLayout;
        private System.Windows.Forms.TableLayoutPanel filterActions;
        private System.Windows.Forms.TableLayoutPanel contentLayout;
        private System.Windows.Forms.TableLayoutPanel historyLayout;
        private System.Windows.Forms.Panel historyHeader;
        private System.Windows.Forms.TableLayoutPanel pageLayout;
        private System.Windows.Forms.TableLayoutPanel previewLayout;
        private System.Windows.Forms.TableLayoutPanel previewPaper;
        private System.Windows.Forms.TableLayoutPanel previewButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTypeFilter;
        private System.Windows.Forms.Label lblYearFilter;
        private System.Windows.Forms.Label lblGradeFilter;
        private System.Windows.Forms.Label lblSectionFilter;
        private System.Windows.Forms.Label lblIdFilter;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.Label lblActionsFilter;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblPreviewHeader;
        private System.Windows.Forms.Label lblPreviewType;
        private System.Windows.Forms.Label lblPreviewFilters;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.filterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTypeFilter = new System.Windows.Forms.Label();
            this.lblYearFilter = new System.Windows.Forms.Label();
            this.lblGradeFilter = new System.Windows.Forms.Label();
            this.lblSectionFilter = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblIdFilter = new System.Windows.Forms.Label();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.lblActionsFilter = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.filterActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.historyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.historyHeader = new System.Windows.Forms.Panel();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.previewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPreviewHeader = new System.Windows.Forms.Label();
            this.previewPaper = new System.Windows.Forms.TableLayoutPanel();
            this.lblPreviewType = new System.Windows.Forms.Label();
            this.lblPreviewFilters = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.previewButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.rootLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.filterLayout.SuspendLayout();
            this.filterActions.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.historyLayout.SuspendLayout();
            this.historyHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pageLayout.SuspendLayout();
            this.previewLayout.SuspendLayout();
            this.previewPaper.SuspendLayout();
            this.previewButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Controls.Add(this.headerPanel, 0, 0);
            this.rootLayout.Controls.Add(this.filterLayout, 0, 1);
            this.rootLayout.Controls.Add(this.contentLayout, 0, 2);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.Padding = new System.Windows.Forms.Padding(12);
            this.rootLayout.RowCount = 3;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Size = new System.Drawing.Size(1180, 760);
            this.rootLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Controls.Add(this.lblRole);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(12, 12);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.headerPanel.Size = new System.Drawing.Size(1156, 66);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REPORTS MODULE";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(18, 43);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(407, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "US-12  Generate Student Report  |  Enrollment, Section and Payment Reports";
            // 
            // lblRole
            // 
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblRole.Location = new System.Drawing.Point(896, 8);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(150, 48);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "READ ONLY";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnRefresh.Location = new System.Drawing.Point(1046, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 48);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // filterLayout
            // 
            this.filterLayout.BackColor = System.Drawing.Color.White;
            this.filterLayout.ColumnCount = 4;
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.filterLayout.Controls.Add(this.lblTypeFilter, 0, 0);
            this.filterLayout.Controls.Add(this.lblYearFilter, 1, 0);
            this.filterLayout.Controls.Add(this.lblGradeFilter, 2, 0);
            this.filterLayout.Controls.Add(this.lblSectionFilter, 3, 0);
            this.filterLayout.Controls.Add(this.cmbReportType, 0, 1);
            this.filterLayout.Controls.Add(this.cmbSchoolYear, 1, 1);
            this.filterLayout.Controls.Add(this.cmbGrade, 2, 1);
            this.filterLayout.Controls.Add(this.cmbSection, 3, 1);
            this.filterLayout.Controls.Add(this.lblIdFilter, 0, 2);
            this.filterLayout.Controls.Add(this.lblNameFilter, 1, 2);
            this.filterLayout.Controls.Add(this.lblActionsFilter, 2, 2);
            this.filterLayout.Controls.Add(this.txtStudentId, 0, 3);
            this.filterLayout.Controls.Add(this.txtStudentName, 1, 3);
            this.filterLayout.Controls.Add(this.filterActions, 2, 3);
            this.filterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterLayout.Location = new System.Drawing.Point(12, 88);
            this.filterLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.filterLayout.Name = "filterLayout";
            this.filterLayout.Padding = new System.Windows.Forms.Padding(13, 6, 13, 8);
            this.filterLayout.RowCount = 4;
            this.filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterLayout.Size = new System.Drawing.Size(1156, 147);
            this.filterLayout.TabIndex = 1;
            // 
            // lblTypeFilter
            // 
            this.lblTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTypeFilter.Location = new System.Drawing.Point(16, 6);
            this.lblTypeFilter.Name = "lblTypeFilter";
            this.lblTypeFilter.Size = new System.Drawing.Size(276, 23);
            this.lblTypeFilter.TabIndex = 0;
            this.lblTypeFilter.Text = "Report Type *";
            this.lblTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYearFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYearFilter.Location = new System.Drawing.Point(298, 6);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(276, 23);
            this.lblYearFilter.TabIndex = 1;
            this.lblYearFilter.Text = "School Year *";
            this.lblYearFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGradeFilter
            // 
            this.lblGradeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGradeFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradeFilter.Location = new System.Drawing.Point(580, 6);
            this.lblGradeFilter.Name = "lblGradeFilter";
            this.lblGradeFilter.Size = new System.Drawing.Size(276, 23);
            this.lblGradeFilter.TabIndex = 2;
            this.lblGradeFilter.Text = "Grade Level";
            this.lblGradeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSectionFilter
            // 
            this.lblSectionFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionFilter.Location = new System.Drawing.Point(862, 6);
            this.lblSectionFilter.Name = "lblSectionFilter";
            this.lblSectionFilter.Size = new System.Drawing.Size(278, 23);
            this.lblSectionFilter.TabIndex = 3;
            this.lblSectionFilter.Text = "Section";
            this.lblSectionFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbReportType
            // 
            this.cmbReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Location = new System.Drawing.Point(16, 33);
            this.cmbReportType.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(270, 23);
            this.cmbReportType.TabIndex = 4;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.Location = new System.Drawing.Point(298, 33);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(270, 23);
            this.cmbSchoolYear.TabIndex = 5;
            // 
            // cmbGrade
            // 
            this.cmbGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Location = new System.Drawing.Point(580, 33);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(270, 23);
            this.cmbGrade.TabIndex = 6;
            // 
            // cmbSection
            // 
            this.cmbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Location = new System.Drawing.Point(862, 33);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(272, 23);
            this.cmbSection.TabIndex = 7;
            // 
            // lblIdFilter
            // 
            this.lblIdFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdFilter.Location = new System.Drawing.Point(16, 67);
            this.lblIdFilter.Name = "lblIdFilter";
            this.lblIdFilter.Size = new System.Drawing.Size(276, 23);
            this.lblIdFilter.TabIndex = 8;
            this.lblIdFilter.Text = "Student ID";
            this.lblIdFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNameFilter.Location = new System.Drawing.Point(298, 67);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(276, 23);
            this.lblNameFilter.TabIndex = 9;
            this.lblNameFilter.Text = "Student Name";
            this.lblNameFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActionsFilter
            // 
            this.filterLayout.SetColumnSpan(this.lblActionsFilter, 2);
            this.lblActionsFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActionsFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActionsFilter.Location = new System.Drawing.Point(580, 67);
            this.lblActionsFilter.Name = "lblActionsFilter";
            this.lblActionsFilter.Size = new System.Drawing.Size(560, 23);
            this.lblActionsFilter.TabIndex = 10;
            this.lblActionsFilter.Text = "Actions";
            this.lblActionsFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentId.Location = new System.Drawing.Point(16, 94);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(270, 25);
            this.txtStudentId.TabIndex = 11;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(298, 94);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 9, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(270, 25);
            this.txtStudentName.TabIndex = 12;
            // 
            // filterActions
            // 
            this.filterActions.ColumnCount = 2;
            this.filterLayout.SetColumnSpan(this.filterActions, 2);
            this.filterActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterActions.Controls.Add(this.btnGenerate, 0, 0);
            this.filterActions.Controls.Add(this.btnClear, 1, 0);
            this.filterActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterActions.Location = new System.Drawing.Point(577, 90);
            this.filterActions.Margin = new System.Windows.Forms.Padding(0);
            this.filterActions.Name = "filterActions";
            this.filterActions.RowCount = 1;
            this.filterActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterActions.Size = new System.Drawing.Size(566, 49);
            this.filterActions.TabIndex = 13;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(192)))));
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(3, 2);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 6, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(274, 44);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(289, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 2, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(274, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // contentLayout
            // 
            this.contentLayout.ColumnCount = 2;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.contentLayout.Controls.Add(this.historyLayout, 0, 0);
            this.contentLayout.Controls.Add(this.previewLayout, 1, 0);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(12, 245);
            this.contentLayout.Margin = new System.Windows.Forms.Padding(0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowCount = 1;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.Size = new System.Drawing.Size(1156, 503);
            this.contentLayout.TabIndex = 2;
            // 
            // historyLayout
            // 
            this.historyLayout.BackColor = System.Drawing.Color.White;
            this.historyLayout.ColumnCount = 1;
            this.historyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyLayout.Controls.Add(this.historyHeader, 0, 0);
            this.historyLayout.Controls.Add(this.dgvResults, 0, 1);
            this.historyLayout.Controls.Add(this.pageLayout, 0, 2);
            this.historyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyLayout.Location = new System.Drawing.Point(0, 0);
            this.historyLayout.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.historyLayout.Name = "historyLayout";
            this.historyLayout.Padding = new System.Windows.Forms.Padding(10);
            this.historyLayout.RowCount = 3;
            this.historyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.historyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.historyLayout.Size = new System.Drawing.Size(745, 503);
            this.historyLayout.TabIndex = 0;
            // 
            // historyHeader
            // 
            this.historyHeader.Controls.Add(this.lblResultsTitle);
            this.historyHeader.Controls.Add(this.lblResults);
            this.historyHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyHeader.Location = new System.Drawing.Point(13, 13);
            this.historyHeader.Name = "historyHeader";
            this.historyHeader.Size = new System.Drawing.Size(719, 38);
            this.historyHeader.TabIndex = 0;
            // 
            // lblResultsTitle
            // 
            this.lblResultsTitle.AutoSize = true;
            this.lblResultsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultsTitle.Location = new System.Drawing.Point(2, 5);
            this.lblResultsTitle.Name = "lblResultsTitle";
            this.lblResultsTitle.Size = new System.Drawing.Size(119, 21);
            this.lblResultsTitle.TabIndex = 0;
            this.lblResultsTitle.Text = "Report Results";
            // 
            // lblResults
            // 
            this.lblResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResults.ForeColor = System.Drawing.Color.DimGray;
            this.lblResults.Location = new System.Drawing.Point(529, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(190, 38);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "No report generated";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeight = 39;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(10, 54);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(0);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowTemplate.Height = 32;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(725, 393);
            this.dgvResults.TabIndex = 1;
            // 
            // pageLayout
            // 
            this.pageLayout.ColumnCount = 3;
            this.pageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pageLayout.Controls.Add(this.btnPrevious, 0, 0);
            this.pageLayout.Controls.Add(this.lblPage, 1, 0);
            this.pageLayout.Controls.Add(this.btnNext, 2, 0);
            this.pageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageLayout.Location = new System.Drawing.Point(13, 450);
            this.pageLayout.Name = "pageLayout";
            this.pageLayout.RowCount = 1;
            this.pageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pageLayout.Size = new System.Drawing.Size(719, 40);
            this.pageLayout.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrevious.Location = new System.Drawing.Point(131, 7);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0, 7, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 28);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "< Previous";
            // 
            // lblPage
            // 
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPage.Location = new System.Drawing.Point(254, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(209, 40);
            this.lblPage.TabIndex = 1;
            this.lblPage.Text = "Page 1 of 1";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Location = new System.Drawing.Point(470, 7);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 7, 0, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >";
            // 
            // previewLayout
            // 
            this.previewLayout.BackColor = System.Drawing.Color.White;
            this.previewLayout.ColumnCount = 1;
            this.previewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewLayout.Controls.Add(this.lblPreviewHeader, 0, 0);
            this.previewLayout.Controls.Add(this.previewPaper, 0, 1);
            this.previewLayout.Controls.Add(this.previewButtons, 0, 2);
            this.previewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLayout.Location = new System.Drawing.Point(757, 0);
            this.previewLayout.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Padding = new System.Windows.Forms.Padding(11);
            this.previewLayout.RowCount = 3;
            this.previewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.previewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.previewLayout.Size = new System.Drawing.Size(399, 503);
            this.previewLayout.TabIndex = 1;
            // 
            // lblPreviewHeader
            // 
            this.lblPreviewHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreviewHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreviewHeader.Location = new System.Drawing.Point(14, 11);
            this.lblPreviewHeader.Name = "lblPreviewHeader";
            this.lblPreviewHeader.Size = new System.Drawing.Size(371, 44);
            this.lblPreviewHeader.TabIndex = 0;
            this.lblPreviewHeader.Text = "Report Preview";
            this.lblPreviewHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previewPaper
            // 
            this.previewPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.previewPaper.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.previewPaper.ColumnCount = 1;
            this.previewPaper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewPaper.Controls.Add(this.lblPreviewType, 0, 0);
            this.previewPaper.Controls.Add(this.lblPreviewFilters, 0, 1);
            this.previewPaper.Controls.Add(this.txtPreview, 0, 2);
            this.previewPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPaper.Location = new System.Drawing.Point(11, 55);
            this.previewPaper.Margin = new System.Windows.Forms.Padding(0);
            this.previewPaper.Name = "previewPaper";
            this.previewPaper.Padding = new System.Windows.Forms.Padding(9);
            this.previewPaper.RowCount = 3;
            this.previewPaper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.previewPaper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.previewPaper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewPaper.Size = new System.Drawing.Size(377, 385);
            this.previewPaper.TabIndex = 1;
            // 
            // lblPreviewType
            // 
            this.lblPreviewType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreviewType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPreviewType.Location = new System.Drawing.Point(13, 10);
            this.lblPreviewType.Name = "lblPreviewType";
            this.lblPreviewType.Size = new System.Drawing.Size(351, 44);
            this.lblPreviewType.TabIndex = 0;
            this.lblPreviewType.Text = "Report Preview";
            this.lblPreviewType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewFilters
            // 
            this.lblPreviewFilters.AutoEllipsis = true;
            this.lblPreviewFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreviewFilters.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreviewFilters.Location = new System.Drawing.Point(13, 55);
            this.lblPreviewFilters.Name = "lblPreviewFilters";
            this.lblPreviewFilters.Size = new System.Drawing.Size(351, 59);
            this.lblPreviewFilters.TabIndex = 1;
            this.lblPreviewFilters.Text = "Select a report type and school year.";
            this.lblPreviewFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.White;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtPreview.Location = new System.Drawing.Point(13, 118);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreview.Size = new System.Drawing.Size(351, 254);
            this.txtPreview.TabIndex = 2;
            this.txtPreview.Text = "Generate a report to preview its records here.";
            // 
            // previewButtons
            // 
            this.previewButtons.ColumnCount = 3;
            this.previewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.previewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.previewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.previewButtons.Controls.Add(this.btnPrintPreview, 0, 0);
            this.previewButtons.Controls.Add(this.btnPrint, 1, 0);
            this.previewButtons.Controls.Add(this.btnExport, 2, 0);
            this.previewButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewButtons.Location = new System.Drawing.Point(11, 440);
            this.previewButtons.Margin = new System.Windows.Forms.Padding(0);
            this.previewButtons.Name = "previewButtons";
            this.previewButtons.RowCount = 1;
            this.previewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewButtons.Size = new System.Drawing.Size(377, 52);
            this.previewButtons.TabIndex = 2;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 9);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(2, 9, 4, 3);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(118, 40);
            this.btnPrintPreview.TabIndex = 0;
            this.btnPrintPreview.Text = "Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(128, 9);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 9, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(192)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(252, 9);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 9, 2, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(123, 40);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Save CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // ReportsModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.rootLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 560);
            this.Name = "ReportsModuleUI";
            this.Text = "Reports Module";
            this.rootLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.filterLayout.ResumeLayout(false);
            this.filterLayout.PerformLayout();
            this.filterActions.ResumeLayout(false);
            this.contentLayout.ResumeLayout(false);
            this.historyLayout.ResumeLayout(false);
            this.historyHeader.ResumeLayout(false);
            this.historyHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pageLayout.ResumeLayout(false);
            this.previewLayout.ResumeLayout(false);
            this.previewPaper.ResumeLayout(false);
            this.previewPaper.PerformLayout();
            this.previewButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
