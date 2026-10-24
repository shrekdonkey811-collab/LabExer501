namespace LabExer501
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtStuNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            Registration = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F);
            label1.Location = new Point(1, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F);
            label2.Location = new Point(8, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F);
            label3.Location = new Point(53, 115);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 11.25F);
            label4.Location = new Point(23, 144);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 11.25F);
            label5.Location = new Point(332, 57);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 11.25F);
            label6.Location = new Point(315, 86);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 11.25F);
            label7.Location = new Point(340, 114);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 11.25F);
            label8.Location = new Point(310, 144);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 7;
            label8.Text = "Contact No.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 11.25F);
            label9.Location = new Point(608, 90);
            label9.Name = "label9";
            label9.Size = new Size(30, 20);
            label9.TabIndex = 8;
            label9.Text = "M.I";
            // 
            // txtStuNo
            // 
            txtStuNo.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtStuNo.Location = new Point(92, 57);
            txtStuNo.Name = "txtStuNo";
            txtStuNo.Size = new Size(213, 22);
            txtStuNo.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtLastName.Location = new Point(92, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(213, 22);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFirstName.Location = new Point(401, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 22);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtMiddleName.Location = new Point(640, 85);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(56, 22);
            txtMiddleName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAge.Location = new Point(91, 115);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(56, 22);
            txtAge.TabIndex = 13;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Microsoft Sans Serif", 10F);
            txtContactNo.Location = new Point(401, 141);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(200, 23);
            txtContactNo.TabIndex = 14;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Mixed Martial Arts" });
            cbProgram.Location = new Point(401, 55);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(295, 24);
            cbProgram.TabIndex = 15;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(401, 113);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 24);
            cbGender.TabIndex = 16;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Trebuchet MS", 9.25F);
            dtpBirthday.Location = new Point(91, 143);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(214, 22);
            dtpBirthday.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            btnRegister.Location = new Point(298, 186);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(108, 35);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Registration
            // 
            Registration.AutoSize = true;
            Registration.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold);
            Registration.Location = new Point(8, 10);
            Registration.Name = "Registration";
            Registration.Size = new Size(168, 35);
            Registration.TabIndex = 20;
            Registration.Text = "Registration";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(709, 235);
            Controls.Add(Registration);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStuNo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtStuNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Label Registration;
    }
}