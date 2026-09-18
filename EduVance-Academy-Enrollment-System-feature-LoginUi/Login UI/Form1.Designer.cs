namespace Login_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EduVance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Academy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(72, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Log in";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(78, 194);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(203, 20);
            this.txtusername.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(385, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(79, 232);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(203, 20);
            this.txtpassword.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(139, 268);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "“Every lesson you learn today opens a door for tomorrow.”";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label4;
    }
}

