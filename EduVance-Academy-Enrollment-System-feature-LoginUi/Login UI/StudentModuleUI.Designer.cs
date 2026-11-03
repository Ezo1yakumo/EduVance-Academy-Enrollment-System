
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class StudentModuleUI
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
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblRecords = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tblDelete = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.btnYesDelete = new System.Windows.Forms.Button();
            this.btnNoDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblEditor = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblRecords.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tblDelete.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tblEditor.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblMain.Controls.Add(this.tblLeft, 0, 0);
            this.tblMain.Controls.Add(this.groupBox2, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(8);
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1200, 700);
            this.tblMain.TabIndex = 0;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.groupBox1, 0, 0);
            this.tblLeft.Controls.Add(this.groupBox3, 0, 1);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(8, 8);
            this.tblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 2;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblLeft.Size = new System.Drawing.Size(663, 684);
            this.tblLeft.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblRecords);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Records";
            // 
            // tblRecords
            // 
            this.tblRecords.ColumnCount = 1;
            this.tblRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecords.Controls.Add(this.tblSearch, 0, 0);
            this.tblRecords.Controls.Add(this.dgvStudents, 0, 1);
            this.tblRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecords.Location = new System.Drawing.Point(3, 21);
            this.tblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.tblRecords.Name = "tblRecords";
            this.tblRecords.Padding = new System.Windows.Forms.Padding(8);
            this.tblRecords.RowCount = 2;
            this.tblRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecords.Size = new System.Drawing.Size(644, 458);
            this.tblRecords.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblSearch.Controls.Add(this.label1, 0, 0);
            this.tblSearch.Controls.Add(this.label2, 1, 0);
            this.tblSearch.Controls.Add(this.txtSearchName, 0, 1);
            this.tblSearch.Controls.Add(this.txtSearchId, 1, 1);
            this.tblSearch.Controls.Add(this.btnClearFilter, 2, 1);
            this.tblSearch.Controls.Add(this.btnAddNewStudent, 3, 1);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(8, 8);
            this.tblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 2;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblSearch.Size = new System.Drawing.Size(628, 80);
            this.tblSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchName.Location = new System.Drawing.Point(2, 37);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(2, 5, 8, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(140, 25);
            this.txtSearchName.TabIndex = 2;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchId.Location = new System.Drawing.Point(152, 37);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(2, 5, 8, 5);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(140, 25);
            this.txtSearchId.TabIndex = 3;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearFilter.Location = new System.Drawing.Point(304, 36);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(117, 40);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "Clear Filter";
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewStudent.Location = new System.Drawing.Point(429, 36);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(195, 40);
            this.btnAddNewStudent.TabIndex = 5;
            this.btnAddNewStudent.Text = "Add New Student";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(10, 90);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 25;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(624, 358);
            this.dgvStudents.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tblDelete);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(5, 497);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Confirmation";
            // 
            // tblDelete
            // 
            this.tblDelete.ColumnCount = 4;
            this.tblDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDelete.Controls.Add(this.lblDeleteMessage, 0, 0);
            this.tblDelete.Controls.Add(this.btnYesDelete, 1, 1);
            this.tblDelete.Controls.Add(this.btnNoDelete, 2, 1);
            this.tblDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDelete.Location = new System.Drawing.Point(3, 21);
            this.tblDelete.Name = "tblDelete";
            this.tblDelete.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.tblDelete.RowCount = 2;
            this.tblDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDelete.Size = new System.Drawing.Size(644, 158);
            this.tblDelete.TabIndex = 0;
            // 
            // lblDeleteMessage
            // 
            this.tblDelete.SetColumnSpan(this.lblDeleteMessage, 4);
            this.lblDeleteMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeleteMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeleteMessage.Location = new System.Drawing.Point(15, 10);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(614, 50);
            this.lblDeleteMessage.TabIndex = 0;
            this.lblDeleteMessage.Text = "Select a student record before deleting.";
            this.lblDeleteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYesDelete
            // 
            this.btnYesDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYesDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesDelete.Location = new System.Drawing.Point(172, 65);
            this.btnYesDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnYesDelete.Name = "btnYesDelete";
            this.btnYesDelete.Size = new System.Drawing.Size(145, 38);
            this.btnYesDelete.TabIndex = 1;
            this.btnYesDelete.Text = "Yes, Delete";
            // 
            // btnNoDelete
            // 
            this.btnNoDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNoDelete.Location = new System.Drawing.Point(327, 65);
            this.btnNoDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnNoDelete.Name = "btnNoDelete";
            this.btnNoDelete.Size = new System.Drawing.Size(145, 38);
            this.btnNoDelete.TabIndex = 2;
            this.btnNoDelete.Text = "No, Cancel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblEditor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(679, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 674);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Edit Student";
            // 
            // tblEditor
            // 
            this.tblEditor.ColumnCount = 2;
            this.tblEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tblEditor.Controls.Add(this.label3, 0, 0);
            this.tblEditor.Controls.Add(this.txtFullName, 1, 0);
            this.tblEditor.Controls.Add(this.label4, 0, 1);
            this.tblEditor.Controls.Add(this.cmbGender, 1, 1);
            this.tblEditor.Controls.Add(this.label5, 0, 2);
            this.tblEditor.Controls.Add(this.dtpDateOfBirth, 1, 2);
            this.tblEditor.Controls.Add(this.label6, 0, 3);
            this.tblEditor.Controls.Add(this.txtaddress, 1, 3);
            this.tblEditor.Controls.Add(this.label7, 0, 4);
            this.tblEditor.Controls.Add(this.txtContactNumber, 1, 4);
            this.tblEditor.Controls.Add(this.label8, 0, 5);
            this.tblEditor.Controls.Add(this.txtEmailAddress, 1, 5);
            this.tblEditor.Controls.Add(this.tblActions, 0, 7);
            this.tblEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEditor.Location = new System.Drawing.Point(3, 21);
            this.tblEditor.Margin = new System.Windows.Forms.Padding(0);
            this.tblEditor.Name = "tblEditor";
            this.tblEditor.Padding = new System.Windows.Forms.Padding(12, 14, 16, 12);
            this.tblEditor.RowCount = 8;
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblEditor.Size = new System.Drawing.Size(502, 650);
            this.tblEditor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(178, 24);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(303, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(178, 74);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(303, 28);
            this.cmbGender.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(178, 124);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(303, 25);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 180);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtaddress.Location = new System.Drawing.Point(178, 169);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(303, 165);
            this.txtaddress.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(15, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContactNumber.Location = new System.Drawing.Point(178, 354);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(303, 27);
            this.txtContactNumber.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(15, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 50);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email Address:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmailAddress.Location = new System.Drawing.Point(178, 404);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(303, 27);
            this.txtEmailAddress.TabIndex = 11;
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 4;
            this.tblEditor.SetColumnSpan(this.tblActions, 2);
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblActions.Controls.Add(this.btnSave, 1, 0);
            this.tblActions.Controls.Add(this.btnCancel, 2, 0);
            this.tblActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActions.Location = new System.Drawing.Point(12, 568);
            this.tblActions.Margin = new System.Windows.Forms.Padding(0);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(474, 70);
            this.tblActions.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(102, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 12, 8, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(244, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 12, 8, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            // 
            // StudentModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tblMain);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "StudentModuleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblMain.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tblRecords.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tblDelete.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tblEditor.ResumeLayout(false);
            this.tblEditor.PerformLayout();
            this.tblActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // MAIN LAYOUT
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLeft;
        private TableLayoutPanel tblRecords;
        private TableLayoutPanel tblSearch;
        private TableLayoutPanel tblEditor;
        private TableLayoutPanel tblActions;
        private TableLayoutPanel tblDelete;

        // GROUP BOXES
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;

        // STUDENT RECORDS
        private DataGridView dgvStudents;
        private Button btnAddNewStudent;
        private Button btnClearFilter;
        private TextBox txtSearchId;
        private TextBox txtSearchName;
        private Label label1;
        private Label label2;

        // STUDENT INFORMATION
        private TextBox txtFullName;
        private ComboBox cmbGender;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtaddress;
        private TextBox txtContactNumber;
        private TextBox txtEmailAddress;

        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        // ACTION BUTTONS
        private Button btnSave;
        private Button btnCancel;
        private Button btnYesDelete;
        private Button btnNoDelete;
        private Label lblDeleteMessage;
    }
}
