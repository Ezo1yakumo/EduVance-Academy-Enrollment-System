
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
            this.layoutRoot = new TableLayoutPanel();
            this.pnlSidebar = new Panel();
            this.pnlDashboardHome = new Panel();
            this.tblContent = new TableLayoutPanel();
            this.pnlHeader = new Panel();
            this.tblCards = new TableLayoutPanel();
            this.pnlStudentCard = new Panel();
            this.pnlEnrollmentCard = new Panel();
            this.pnlSectionCard = new Panel();
            this.pnlOverview = new Panel();
            this.tblOverview = new TableLayoutPanel();

            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();

            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.lblTotalStudentsValue = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.label12 = new Label();
            this.label13 = new Label();
            this.lblTotalEnrollmentsValue = new Label();
            this.label15 = new Label();
            this.label16 = new Label();
            this.label17 = new Label();
            this.lblActiveSectionsValue = new Label();
            this.label19 = new Label();
            this.label20 = new Label();

            this.dgvEnrollmentOverview = new DataGridView();
            this.Enrolled = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvEnrollmentOverview)).BeginInit();

            this.SuspendLayout();

            // ======================================
            // MAIN RESPONSIVE LAYOUT
            // ======================================

            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.Dock = DockStyle.Fill;
            this.layoutRoot.Margin = new Padding(0);
            this.layoutRoot.Padding = new Padding(0);

            this.layoutRoot.ColumnCount = 2;
            this.layoutRoot.RowCount = 1;

            this.layoutRoot.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 150F));

            this.layoutRoot.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            this.layoutRoot.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.layoutRoot.Controls.Add(
                this.pnlSidebar, 0, 0);

            this.layoutRoot.Controls.Add(
                this.pnlDashboardHome, 1, 0);

            // ======================================
            // BLUE SIDEBAR
            // ======================================

            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Dock = DockStyle.Fill;
            this.pnlSidebar.Margin = new Padding(0);
            this.pnlSidebar.BackColor = Color.CornflowerBlue;

            // Old background label (not needed)
            this.label1.Name = "label1";
            this.label1.Visible = false;

            // EduVance title
            this.label2.Name = "label2";
            this.label2.Text = "EduVance";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Montserrat", 15F);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(10, 15);

            // Subtitle
            this.label3.Name = "label3";
            this.label3.Text = "Enrollment Form";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Montserrat", 8F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(12, 48);

            // Dashboard button
            this.button1.Name = "button1";
            this.button1.Text = "Dashboard";
            this.button1.Location = new Point(0, 115);
            this.button1.Size = new Size(150, 42);
            this.button1.BackColor = Color.CornflowerBlue;
            this.button1.ForeColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new Font("Montserrat", 10F);
            this.button1.TextAlign = ContentAlignment.MiddleLeft;
            this.button1.Padding = new Padding(10, 0, 0, 0);
            this.button1.Click +=
                new System.EventHandler(this.button1_Click);

            // Students button
            this.button2.Name = "button2";
            this.button2.Text = "Students";
            this.button2.Location = new Point(0, 157);
            this.button2.Size = new Size(150, 42);
            this.button2.BackColor = Color.CornflowerBlue;
            this.button2.ForeColor = Color.White;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new Font("Montserrat", 10F);
            this.button2.TextAlign = ContentAlignment.MiddleLeft;
            this.button2.Padding = new Padding(10, 0, 0, 0);
            this.button2.Click +=
                new System.EventHandler(this.button2_Click);

            // Enrollment button
            this.button3.Name = "button3";
            this.button3.Text = "Enrollment";
            this.button3.Location = new Point(0, 199);
            this.button3.Size = new Size(150, 42);
            this.button3.BackColor = Color.CornflowerBlue;
            this.button3.ForeColor = Color.White;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new Font("Montserrat", 10F);
            this.button3.TextAlign = ContentAlignment.MiddleLeft;
            this.button3.Padding = new Padding(10, 0, 0, 0);
            this.button3.Click +=
                new System.EventHandler(this.button3_Click);

            // Assessment button
            this.button4.Name = "button4";
            this.button4.Text = "Assessment";
            this.button4.Location = new Point(0, 241);
            this.button4.Size = new Size(150, 42);
            this.button4.BackColor = Color.CornflowerBlue;
            this.button4.ForeColor = Color.White;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new Font("Montserrat", 10F);
            this.button4.TextAlign = ContentAlignment.MiddleLeft;
            this.button4.Padding = new Padding(10, 0, 0, 0);
            this.button4.Click +=
                new System.EventHandler(this.button4_Click);

            // Payments button
            this.button5.Name = "button5";
            this.button5.Text = "Student Balance";
            this.button5.Location = new Point(0, 283);
            this.button5.Size = new Size(150, 42);
            this.button5.BackColor = Color.CornflowerBlue;
            this.button5.ForeColor = Color.White;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new Font("Montserrat", 10F);
            this.button5.TextAlign = ContentAlignment.MiddleLeft;
            this.button5.Padding = new Padding(10, 0, 0, 0);
            this.button5.Click +=
                new System.EventHandler(this.button5_Click);

            // Reports button
            this.button6.Name = "button6";
            this.button6.Text = "Reports";
            this.button6.Location = new Point(0, 325);
            this.button6.Size = new Size(150, 42);
            this.button6.BackColor = Color.CornflowerBlue;
            this.button6.ForeColor = Color.White;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new Font("Montserrat", 10F);
            this.button6.TextAlign = ContentAlignment.MiddleLeft;
            this.button6.Padding = new Padding(10, 0, 0, 0);
            this.button6.Click +=
                new System.EventHandler(this.button6_Click);

            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.button2);
            this.pnlSidebar.Controls.Add(this.button3);
            this.pnlSidebar.Controls.Add(this.button4);
            this.pnlSidebar.Controls.Add(this.button5);
            this.pnlSidebar.Controls.Add(this.button6);

            // ======================================
            // DASHBOARD CONTENT
            // ======================================

            this.pnlDashboardHome.Name = "pnlDashboardHome";
            this.pnlDashboardHome.Dock = DockStyle.Fill;
            this.pnlDashboardHome.Margin = new Padding(0);
            this.pnlDashboardHome.BackColor =
                Color.FromArgb(245, 246, 249);

            this.pnlDashboardHome.Controls.Add(
                this.tblContent);

            // ======================================
            // CONTENT TABLE
            // ======================================

            this.tblContent.Name = "tblContent";
            this.tblContent.Dock = DockStyle.Fill;
            this.tblContent.Padding = new Padding(20);
            this.tblContent.Margin = new Padding(0);

            this.tblContent.ColumnCount = 1;
            this.tblContent.RowCount = 3;

            this.tblContent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            // Dashboard title
            this.tblContent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 75F));

            // Three summary cards
            this.tblContent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 140F));

            // Records table fills remaining space
            this.tblContent.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.tblContent.Controls.Add(
                this.pnlHeader, 0, 0);

            this.tblContent.Controls.Add(
                this.tblCards, 0, 1);

            this.tblContent.Controls.Add(
                this.pnlOverview, 0, 2);

            // ======================================
            // DASHBOARD HEADER
            // ======================================

            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = DockStyle.Fill;

            this.label4.Name = "label4";
            this.label4.Text = "Dashboard";
            this.label4.AutoSize = true;
            this.label4.Font = new Font(
                "Montserrat", 20F, FontStyle.Bold);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(0, 0);

            this.label5.Name = "label5";
            this.label5.Text =
                "Welcome back, User. Here's your academy overview";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Montserrat", 9F);
            this.label5.Location = new Point(2, 42);

            this.label6.Name = "label6";
            this.label6.Visible = false;

            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.label6);

            // ======================================
            // THREE RESPONSIVE SUMMARY CARDS
            // ======================================

            this.tblCards.Name = "tblCards";
            this.tblCards.Dock = DockStyle.Fill;
            this.tblCards.Margin = new Padding(0);

            this.tblCards.ColumnCount = 3;
            this.tblCards.RowCount = 1;

            this.tblCards.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.33F));

            this.tblCards.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.33F));

            this.tblCards.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 33.34F));

            this.tblCards.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            this.tblCards.Controls.Add(
                this.pnlStudentCard, 0, 0);

            this.tblCards.Controls.Add(
                this.pnlEnrollmentCard, 1, 0);

            this.tblCards.Controls.Add(
                this.pnlSectionCard, 2, 0);

            // ======================================
            // TOTAL STUDENTS CARD
            // ======================================

            this.pnlStudentCard.Name = "pnlStudentCard";
            this.pnlStudentCard.Dock = DockStyle.Fill;
            this.pnlStudentCard.Margin = new Padding(0, 0, 12, 10);
            this.pnlStudentCard.BackColor = Color.Gainsboro;

            this.label7.Name = "label7";
            this.label7.Text = "Total Students";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Montserrat", 10F);
            this.label7.Location = new Point(18, 12);

            this.lblTotalStudentsValue.Name =
                "lblTotalStudentsValue";
            this.lblTotalStudentsValue.Text = "-";
            this.lblTotalStudentsValue.AutoSize = true;
            this.lblTotalStudentsValue.Font =
                new Font("Montserrat", 22F, FontStyle.Bold);
            this.lblTotalStudentsValue.Location =
                new Point(18, 37);

            this.label10.Name = "label10";
            this.label10.Text = "Current records";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Montserrat", 8F);
            this.label10.Location = new Point(18, 92);

            this.label8.Name = "label8";
            this.label8.Visible = false;

            this.pnlStudentCard.Controls.Add(this.label7);
            this.pnlStudentCard.Controls.Add(
                this.lblTotalStudentsValue);
            this.pnlStudentCard.Controls.Add(this.label10);
            this.pnlStudentCard.Controls.Add(this.label8);

            // ======================================
            // ENROLLMENTS CARD
            // ======================================

            this.pnlEnrollmentCard.Name = "pnlEnrollmentCard";
            this.pnlEnrollmentCard.Dock = DockStyle.Fill;
            this.pnlEnrollmentCard.Margin =
                new Padding(0, 0, 12, 10);
            this.pnlEnrollmentCard.BackColor = Color.Gainsboro;

            this.label12.Name = "label12";
            this.label12.Text = "Enrollments";
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Montserrat", 10F);
            this.label12.Location = new Point(18, 12);

            this.lblTotalEnrollmentsValue.Name =
                "lblTotalEnrollmentsValue";
            this.lblTotalEnrollmentsValue.Text = "-";
            this.lblTotalEnrollmentsValue.AutoSize = true;
            this.lblTotalEnrollmentsValue.Font =
                new Font("Montserrat", 22F, FontStyle.Bold);
            this.lblTotalEnrollmentsValue.Location =
                new Point(18, 37);

            this.label13.Name = "label13";
            this.label13.Text = "Selected school year";
            this.label13.AutoSize = true;
            this.label13.Font = new Font("Montserrat", 8F);
            this.label13.Location = new Point(18, 92);

            this.label11.Name = "label11";
            this.label11.Visible = false;

            this.pnlEnrollmentCard.Controls.Add(this.label12);
            this.pnlEnrollmentCard.Controls.Add(
                this.lblTotalEnrollmentsValue);
            this.pnlEnrollmentCard.Controls.Add(this.label13);
            this.pnlEnrollmentCard.Controls.Add(this.label11);

            // ======================================
            // ACTIVE SECTIONS CARD
            // ======================================

            this.pnlSectionCard.Name = "pnlSectionCard";
            this.pnlSectionCard.Dock = DockStyle.Fill;
            this.pnlSectionCard.Margin =
                new Padding(0, 0, 0, 10);
            this.pnlSectionCard.BackColor = Color.Gainsboro;

            this.label16.Name = "label16";
            this.label16.Text = "Active Sections";
            this.label16.AutoSize = true;
            this.label16.Font = new Font("Montserrat", 10F);
            this.label16.Location = new Point(18, 12);

            this.lblActiveSectionsValue.Name =
                "lblActiveSectionsValue";
            this.lblActiveSectionsValue.Text = "-";
            this.lblActiveSectionsValue.AutoSize = true;
            this.lblActiveSectionsValue.Font =
                new Font("Montserrat", 22F, FontStyle.Bold);
            this.lblActiveSectionsValue.Location =
                new Point(18, 37);

            this.label17.Name = "label17";
            this.label17.Text = "Currently available";
            this.label17.AutoSize = true;
            this.label17.Font = new Font("Montserrat", 8F);
            this.label17.Location = new Point(18, 92);

            this.label15.Name = "label15";
            this.label15.Visible = false;

            this.pnlSectionCard.Controls.Add(this.label16);
            this.pnlSectionCard.Controls.Add(
                this.lblActiveSectionsValue);
            this.pnlSectionCard.Controls.Add(this.label17);
            this.pnlSectionCard.Controls.Add(this.label15);

            // ======================================
            // RESPONSIVE RECORDS AREA
            // ======================================

            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Dock = DockStyle.Fill;
            this.pnlOverview.Margin = new Padding(0, 5, 0, 0);
            this.pnlOverview.Padding = new Padding(14);
            this.pnlOverview.BackColor = Color.Gainsboro;

            this.tblOverview.Name = "tblOverview";
            this.tblOverview.Dock = DockStyle.Fill;
            this.tblOverview.Margin = new Padding(0);

            this.tblOverview.ColumnCount = 1;
            this.tblOverview.RowCount = 2;

            this.tblOverview.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            this.tblOverview.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 35F));

            this.tblOverview.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // Overview title
            this.label20.Name = "label20";
            this.label20.Text = "Enrollment Overview";
            this.label20.AutoSize = false;
            this.label20.Dock = DockStyle.Fill;
            this.label20.Font =
                new Font("Montserrat", 11F, FontStyle.Bold);

            this.label19.Name = "label19";
            this.label19.Visible = false;

            // ======================================
            // STUDENT RECORDS DATAGRIDVIEW
            // ======================================

            this.dgvEnrollmentOverview.Name =
                "dgvEnrollmentOverview";

            this.dgvEnrollmentOverview.Dock = DockStyle.Fill;
            this.dgvEnrollmentOverview.Margin = new Padding(0);

            this.dgvEnrollmentOverview.BackgroundColor =
                Color.White;

            this.dgvEnrollmentOverview.BorderStyle =
                BorderStyle.None;

            this.dgvEnrollmentOverview.AutoGenerateColumns =
                true;

            this.dgvEnrollmentOverview.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvEnrollmentOverview.ReadOnly = true;

            this.dgvEnrollmentOverview.AllowUserToAddRows =
                false;

            this.dgvEnrollmentOverview.AllowUserToDeleteRows =
                false;

            this.dgvEnrollmentOverview.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvEnrollmentOverview.CellContentClick +=
                new DataGridViewCellEventHandler(
                    this.dgvEnrollmentOverview_CellContentClick);

            this.Enrolled.Name = "Enrolled";
            this.Enrolled.HeaderText = "Column1";

            this.dgvEnrollmentOverview.Columns.AddRange(
                new DataGridViewColumn[] { this.Enrolled });

            this.tblOverview.Controls.Add(
                this.label20, 0, 0);

            this.tblOverview.Controls.Add(
                this.dgvEnrollmentOverview, 0, 1);

            this.pnlOverview.Controls.Add(this.tblOverview);
            this.pnlOverview.Controls.Add(this.label19);

            // ======================================
            // DASHBOARD FORM
            // ======================================

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;

            this.ClientSize = new Size(1366, 768);
            this.MinimumSize = new Size(950, 600);

            this.Controls.Add(this.layoutRoot);

            this.Name = "Dashboard";
            this.Text = "Dashboard";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.WindowState =
                FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvEnrollmentOverview)).EndInit();

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
    }
}
