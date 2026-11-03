
namespace Login_UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginCenterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loginFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Labellogin = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.loginButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.loginCenterLayout.SuspendLayout();
            this.loginFieldsLayout.SuspendLayout();
            this.loginButtonLayout.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.White;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainLayout.Controls.Add(this.leftLayout, 0, 0);
            this.mainLayout.Controls.Add(this.pictureBox1, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1366, 768);
            this.mainLayout.TabIndex = 0;
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.Controls.Add(this.headerPanel, 0, 0);
            this.leftLayout.Controls.Add(this.loginCenterLayout, 0, 1);
            this.leftLayout.Controls.Add(this.footerPanel, 0, 2);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(0, 0);
            this.leftLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 3;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.leftLayout.Size = new System.Drawing.Size(614, 768);
            this.leftLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(608, 186);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "EduVance\r\nAcademy";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // loginCenterLayout
            // 
            this.loginCenterLayout.ColumnCount = 3;
            this.loginCenterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.loginCenterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.loginCenterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.loginCenterLayout.Controls.Add(this.loginFieldsLayout, 1, 1);
            this.loginCenterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginCenterLayout.Location = new System.Drawing.Point(0, 192);
            this.loginCenterLayout.Margin = new System.Windows.Forms.Padding(0);
            this.loginCenterLayout.Name = "loginCenterLayout";
            this.loginCenterLayout.RowCount = 3;
            this.loginCenterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginCenterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.loginCenterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginCenterLayout.Size = new System.Drawing.Size(614, 422);
            this.loginCenterLayout.TabIndex = 1;
            // 
            // loginFieldsLayout
            // 
            this.loginFieldsLayout.ColumnCount = 1;
            this.loginFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginFieldsLayout.Controls.Add(this.Labellogin, 0, 0);
            this.loginFieldsLayout.Controls.Add(this.txtusername, 0, 1);
            this.loginFieldsLayout.Controls.Add(this.txtpassword, 0, 3);
            this.loginFieldsLayout.Controls.Add(this.loginButtonLayout, 0, 5);
            this.loginFieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFieldsLayout.Location = new System.Drawing.Point(73, 42);
            this.loginFieldsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.loginFieldsLayout.Name = "loginFieldsLayout";
            this.loginFieldsLayout.RowCount = 7;
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loginFieldsLayout.Size = new System.Drawing.Size(466, 337);
            this.loginFieldsLayout.TabIndex = 0;
            // 
            // Labellogin
            // 
            this.Labellogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Labellogin.Font = new System.Drawing.Font("Montserrat", 25F);
            this.Labellogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Labellogin.Location = new System.Drawing.Point(3, 0);
            this.Labellogin.Name = "Labellogin";
            this.Labellogin.Size = new System.Drawing.Size(460, 94);
            this.Labellogin.TabIndex = 0;
            this.Labellogin.Text = "Log in";
            this.Labellogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtusername
            // 
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtusername.Location = new System.Drawing.Point(0, 97);
            this.txtusername.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(466, 29);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpassword.Location = new System.Drawing.Point(0, 163);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(466, 29);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // loginButtonLayout
            // 
            this.loginButtonLayout.ColumnCount = 3;
            this.loginButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.loginButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginButtonLayout.Controls.Add(this.btnlogin, 1, 0);
            this.loginButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButtonLayout.Location = new System.Drawing.Point(3, 236);
            this.loginButtonLayout.Name = "loginButtonLayout";
            this.loginButtonLayout.RowCount = 1;
            this.loginButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginButtonLayout.Size = new System.Drawing.Size(460, 61);
            this.loginButtonLayout.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(140)))), ((int)(((byte)(226)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(138, 3);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(184, 55);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.label4);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(3, 617);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(608, 148);
            this.footerPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(883, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "“Every lesson you learn today opens a door for tomorrow.”";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduVance Academy - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.loginCenterLayout.ResumeLayout(false);
            this.loginFieldsLayout.ResumeLayout(false);
            this.loginFieldsLayout.PerformLayout();
            this.loginButtonLayout.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.TableLayoutPanel loginCenterLayout;
        private System.Windows.Forms.TableLayoutPanel loginFieldsLayout;
        private System.Windows.Forms.TableLayoutPanel loginButtonLayout;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Labellogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label4;
    }
}
