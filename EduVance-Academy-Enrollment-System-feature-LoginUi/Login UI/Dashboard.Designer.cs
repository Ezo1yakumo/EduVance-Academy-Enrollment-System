
using System.Drawing;
using System.Windows.Forms;

namespace Login_UI
{
    partial class Dashboard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlDashboardHome = new System.Windows.Forms.Panel();
            this.tblContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStudentCard = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalStudentsValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlEnrollmentCard = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalEnrollmentsValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSectionCard = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblActiveSectionsValue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.tblOverview = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvEnrollmentOverview = new System.Windows.Forms.DataGridView();
            this.Enrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPayments = new System.Windows.Forms.Button();
            this.layoutRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlDashboardHome.SuspendLayout();
            this.tblContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tblCards.SuspendLayout();
            this.pnlStudentCard.SuspendLayout();
            this.pnlEnrollmentCard.SuspendLayout();
            this.pnlSectionCard.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.tblOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutRoot
            // 
            this.layoutRoot.ColumnCount = 2;
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Controls.Add(this.pnlSidebar, 0, 0);
            this.layoutRoot.Controls.Add(this.pnlDashboardHome, 1, 0);
            this.layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutRoot.Margin = new System.Windows.Forms.Padding(0);
            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.RowCount = 1;
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Size = new System.Drawing.Size(1366, 768);
            this.layoutRoot.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlSidebar.Controls.Add(this.btnPayments);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.button2);
            this.pnlSidebar.Controls.Add(this.button3);
            this.pnlSidebar.Controls.Add(this.button4);
            this.pnlSidebar.Controls.Add(this.button5);
            this.pnlSidebar.Controls.Add(this.button6);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(150, 768);
            this.pnlSidebar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "EduVance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enrollment Form";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 115);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 157);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Students";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 199);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(150, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Enrollment";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 241);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(150, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Assessment";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 283);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(150, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Student Balance";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 379);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(150, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Reports";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnlDashboardHome
            // 
            this.pnlDashboardHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlDashboardHome.Controls.Add(this.tblContent);
            this.pnlDashboardHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardHome.Location = new System.Drawing.Point(150, 0);
            this.pnlDashboardHome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboardHome.Name = "pnlDashboardHome";
            this.pnlDashboardHome.Size = new System.Drawing.Size(1216, 768);
            this.pnlDashboardHome.TabIndex = 1;
            // 
            // tblContent
            // 
            this.tblContent.ColumnCount = 1;
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContent.Controls.Add(this.pnlHeader, 0, 0);
            this.tblContent.Controls.Add(this.tblCards, 0, 1);
            this.tblContent.Controls.Add(this.pnlOverview, 0, 2);
            this.tblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContent.Location = new System.Drawing.Point(0, 0);
            this.tblContent.Margin = new System.Windows.Forms.Padding(0);
            this.tblContent.Name = "tblContent";
            this.tblContent.Padding = new System.Windows.Forms.Padding(20);
            this.tblContent.RowCount = 3;
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContent.Size = new System.Drawing.Size(1216, 768);
            this.tblContent.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(23, 23);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1170, 69);
            this.pnlHeader.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label5.Location = new System.Drawing.Point(2, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Welcome back, User. Here\'s your academy overview";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Visible = false;
            // 
            // tblCards
            // 
            this.tblCards.ColumnCount = 3;
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblCards.Controls.Add(this.pnlStudentCard, 0, 0);
            this.tblCards.Controls.Add(this.pnlEnrollmentCard, 1, 0);
            this.tblCards.Controls.Add(this.pnlSectionCard, 2, 0);
            this.tblCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCards.Location = new System.Drawing.Point(20, 95);
            this.tblCards.Margin = new System.Windows.Forms.Padding(0);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 1;
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCards.Size = new System.Drawing.Size(1176, 140);
            this.tblCards.TabIndex = 1;
            // 
            // pnlStudentCard
            // 
            this.pnlStudentCard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlStudentCard.Controls.Add(this.label7);
            this.pnlStudentCard.Controls.Add(this.lblTotalStudentsValue);
            this.pnlStudentCard.Controls.Add(this.label10);
            this.pnlStudentCard.Controls.Add(this.label8);
            this.pnlStudentCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentCard.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 10);
            this.pnlStudentCard.Name = "pnlStudentCard";
            this.pnlStudentCard.Size = new System.Drawing.Size(379, 130);
            this.pnlStudentCard.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label7.Location = new System.Drawing.Point(18, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Students";
            // 
            // lblTotalStudentsValue
            // 
            this.lblTotalStudentsValue.AutoSize = true;
            this.lblTotalStudentsValue.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentsValue.Location = new System.Drawing.Point(18, 37);
            this.lblTotalStudentsValue.Name = "lblTotalStudentsValue";
            this.lblTotalStudentsValue.Size = new System.Drawing.Size(32, 47);
            this.lblTotalStudentsValue.TabIndex = 1;
            this.lblTotalStudentsValue.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Current records";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 3;
            this.label8.Visible = false;
            // 
            // pnlEnrollmentCard
            // 
            this.pnlEnrollmentCard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEnrollmentCard.Controls.Add(this.label12);
            this.pnlEnrollmentCard.Controls.Add(this.lblTotalEnrollmentsValue);
            this.pnlEnrollmentCard.Controls.Add(this.label13);
            this.pnlEnrollmentCard.Controls.Add(this.label11);
            this.pnlEnrollmentCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnrollmentCard.Location = new System.Drawing.Point(391, 0);
            this.pnlEnrollmentCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 10);
            this.pnlEnrollmentCard.Name = "pnlEnrollmentCard";
            this.pnlEnrollmentCard.Size = new System.Drawing.Size(379, 130);
            this.pnlEnrollmentCard.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label12.Location = new System.Drawing.Point(18, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Enrollments";
            // 
            // lblTotalEnrollmentsValue
            // 
            this.lblTotalEnrollmentsValue.AutoSize = true;
            this.lblTotalEnrollmentsValue.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalEnrollmentsValue.Location = new System.Drawing.Point(18, 37);
            this.lblTotalEnrollmentsValue.Name = "lblTotalEnrollmentsValue";
            this.lblTotalEnrollmentsValue.Size = new System.Drawing.Size(32, 47);
            this.lblTotalEnrollmentsValue.TabIndex = 1;
            this.lblTotalEnrollmentsValue.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label13.Location = new System.Drawing.Point(18, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Selected school year";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 3;
            this.label11.Visible = false;
            // 
            // pnlSectionCard
            // 
            this.pnlSectionCard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSectionCard.Controls.Add(this.label16);
            this.pnlSectionCard.Controls.Add(this.lblActiveSectionsValue);
            this.pnlSectionCard.Controls.Add(this.label17);
            this.pnlSectionCard.Controls.Add(this.label15);
            this.pnlSectionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSectionCard.Location = new System.Drawing.Point(782, 0);
            this.pnlSectionCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSectionCard.Name = "pnlSectionCard";
            this.pnlSectionCard.Size = new System.Drawing.Size(394, 130);
            this.pnlSectionCard.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label16.Location = new System.Drawing.Point(18, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "Active Sections";
            // 
            // lblActiveSectionsValue
            // 
            this.lblActiveSectionsValue.AutoSize = true;
            this.lblActiveSectionsValue.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblActiveSectionsValue.Location = new System.Drawing.Point(18, 37);
            this.lblActiveSectionsValue.Name = "lblActiveSectionsValue";
            this.lblActiveSectionsValue.Size = new System.Drawing.Size(32, 47);
            this.lblActiveSectionsValue.TabIndex = 1;
            this.lblActiveSectionsValue.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label17.Location = new System.Drawing.Point(18, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Currently available";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 3;
            this.label15.Visible = false;
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlOverview.Controls.Add(this.tblOverview);
            this.pnlOverview.Controls.Add(this.label19);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(20, 240);
            this.pnlOverview.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Padding = new System.Windows.Forms.Padding(14);
            this.pnlOverview.Size = new System.Drawing.Size(1176, 508);
            this.pnlOverview.TabIndex = 2;
            // 
            // tblOverview
            // 
            this.tblOverview.ColumnCount = 1;
            this.tblOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOverview.Controls.Add(this.label20, 0, 0);
            this.tblOverview.Controls.Add(this.dgvEnrollmentOverview, 0, 1);
            this.tblOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOverview.Location = new System.Drawing.Point(14, 14);
            this.tblOverview.Margin = new System.Windows.Forms.Padding(0);
            this.tblOverview.Name = "tblOverview";
            this.tblOverview.RowCount = 2;
            this.tblOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOverview.Size = new System.Drawing.Size(1148, 480);
            this.tblOverview.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1142, 35);
            this.label20.TabIndex = 0;
            this.label20.Text = "Enrollment Overview";
            // 
            // dgvEnrollmentOverview
            // 
            this.dgvEnrollmentOverview.AllowUserToAddRows = false;
            this.dgvEnrollmentOverview.AllowUserToDeleteRows = false;
            this.dgvEnrollmentOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollmentOverview.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnrollmentOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEnrollmentOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enrolled});
            this.dgvEnrollmentOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollmentOverview.Location = new System.Drawing.Point(0, 35);
            this.dgvEnrollmentOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEnrollmentOverview.Name = "dgvEnrollmentOverview";
            this.dgvEnrollmentOverview.ReadOnly = true;
            this.dgvEnrollmentOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollmentOverview.Size = new System.Drawing.Size(1148, 445);
            this.dgvEnrollmentOverview.TabIndex = 1;
            this.dgvEnrollmentOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollmentOverview_CellContentClick);
            // 
            // Enrolled
            // 
            this.Enrolled.HeaderText = "Column1";
            this.Enrolled.Name = "Enrolled";
            this.Enrolled.ReadOnly = true;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 1;
            this.label19.Visible = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(0, 331);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(150, 42);
            this.btnPayments.TabIndex = 9;
            this.btnPayments.Text = "Payment";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.layoutRoot);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.layoutRoot.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlDashboardHome.ResumeLayout(false);
            this.tblContent.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblCards.ResumeLayout(false);
            this.pnlStudentCard.ResumeLayout(false);
            this.pnlStudentCard.PerformLayout();
            this.pnlEnrollmentCard.ResumeLayout(false);
            this.pnlEnrollmentCard.PerformLayout();
            this.pnlSectionCard.ResumeLayout(false);
            this.pnlSectionCard.PerformLayout();
            this.pnlOverview.ResumeLayout(false);
            this.tblOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollmentOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layoutRoot;
        private Panel pnlSidebar;
        private Panel pnlDashboardHome;
        private TableLayoutPanel tblContent;
        private Panel pnlHeader;
        private TableLayoutPanel tblCards;
        private Panel pnlStudentCard;
        private Panel pnlEnrollmentCard;
        private Panel pnlSectionCard;
        private Panel pnlOverview;
        private TableLayoutPanel tblOverview;

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTotalStudentsValue;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblTotalEnrollmentsValue;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lblActiveSectionsValue;
        private Label label19;
        private Label label20;

        private DataGridView dgvEnrollmentOverview;
        private DataGridViewTextBoxColumn Enrolled;
        private Button btnPayments;
    }
}
