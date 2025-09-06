namespace OrganizationalProfile
{
    partial class OrganizationalProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(16, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(70, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(450, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(432, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(450, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(864, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "M.I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(38, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Birthday";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(516, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Contact No.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrganizationalProfile.Properties.Resources.Logo_STI;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStudentNo.Location = new System.Drawing.Point(131, 179);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(270, 30);
            this.txtStudentNo.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.Location = new System.Drawing.Point(131, 247);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 30);
            this.txtLastName.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAge.Location = new System.Drawing.Point(131, 309);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(168, 30);
            this.txtAge.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(538, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(301, 30);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiddleInitial.Location = new System.Drawing.Point(905, 247);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(92, 30);
            this.txtMiddleInitial.TabIndex = 17;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(538, 305);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(209, 33);
            this.cbGender.TabIndex = 18;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContact.Location = new System.Drawing.Point(630, 383);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(219, 30);
            this.txtContact.TabIndex = 19;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerBirthday.Location = new System.Drawing.Point(131, 391);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(338, 30);
            this.datePickerBirthday.TabIndex = 20;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Navy;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(416, 480);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(166, 51);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPrograms
            // 
            this.cbPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPrograms.FormattingEnabled = true;
            this.cbPrograms.Location = new System.Drawing.Point(538, 176);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(361, 33);
            this.cbPrograms.TabIndex = 22;
            // 
            // OrganizationalProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1009, 568);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrganizationalProfile";
            this.Text = "Organizational Profile";
            this.Load += new System.EventHandler(this.OrganizationalProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbPrograms;
    }
}

