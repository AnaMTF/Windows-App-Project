namespace Facultate
{
    partial class AddStudent
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
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentEditButton = new System.Windows.Forms.Button();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.yearOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfStudyLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentTitleLlabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.studentsListview = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOBHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewSubjectsButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.addStudentGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary",
            "Other",
            "Prefer not to say"});
            this.genderComboBox.Location = new System.Drawing.Point(102, 95);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(203, 21);
            this.genderComboBox.TabIndex = 29;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(19, 98);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(49, 13);
            this.genderLabel.TabIndex = 28;
            this.genderLabel.Text = "Gender";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(106, 219);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.phoneNumberTextBox.TabIndex = 27;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(9, 222);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.phoneNumberLabel.TabIndex = 26;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(106, 180);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 20);
            this.emailTextBox.TabIndex = 25;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(22, 183);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 13);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.addStudentButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addStudentButton.Location = new System.Drawing.Point(22, 299);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 23;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentEditButton
            // 
            this.studentEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentEditButton.Location = new System.Drawing.Point(126, 299);
            this.studentEditButton.Name = "studentEditButton";
            this.studentEditButton.Size = new System.Drawing.Size(75, 23);
            this.studentEditButton.TabIndex = 22;
            this.studentEditButton.Text = "Edit";
            this.studentEditButton.UseVisualStyleBackColor = false;
            this.studentEditButton.Click += new System.EventHandler(this.studentEditButton_Click);
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(102, 139);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(204, 20);
            this.dateOfBirthTimePicker.TabIndex = 21;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(-1, 145);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(98, 13);
            this.dateOfBirthLabel.TabIndex = 20;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(19, 61);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(77, 13);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 58);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(19, 26);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 13);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 20);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 16;
            // 
            // addStudentGroupBox
            // 
            this.addStudentGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.addStudentGroupBox.Controls.Add(this.yearOfStudyComboBox);
            this.addStudentGroupBox.Controls.Add(this.yearOfStudyLabel);
            this.addStudentGroupBox.Controls.Add(this.lastNameLabel);
            this.addStudentGroupBox.Controls.Add(this.deleteButton);
            this.addStudentGroupBox.Controls.Add(this.genderComboBox);
            this.addStudentGroupBox.Controls.Add(this.addStudentButton);
            this.addStudentGroupBox.Controls.Add(this.lastNameTextBox);
            this.addStudentGroupBox.Controls.Add(this.studentEditButton);
            this.addStudentGroupBox.Controls.Add(this.genderLabel);
            this.addStudentGroupBox.Controls.Add(this.firstNameTextBox);
            this.addStudentGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.addStudentGroupBox.Controls.Add(this.firstNameLabel);
            this.addStudentGroupBox.Controls.Add(this.phoneNumberLabel);
            this.addStudentGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.addStudentGroupBox.Controls.Add(this.emailTextBox);
            this.addStudentGroupBox.Controls.Add(this.dateOfBirthTimePicker);
            this.addStudentGroupBox.Controls.Add(this.emailLabel);
            this.addStudentGroupBox.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGroupBox.Location = new System.Drawing.Point(1, 39);
            this.addStudentGroupBox.Name = "addStudentGroupBox";
            this.addStudentGroupBox.Size = new System.Drawing.Size(313, 334);
            this.addStudentGroupBox.TabIndex = 30;
            this.addStudentGroupBox.TabStop = false;
            this.addStudentGroupBox.Text = "Add a new Student";
            // 
            // yearOfStudyComboBox
            // 
            this.yearOfStudyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearOfStudyComboBox.FormattingEnabled = true;
            this.yearOfStudyComboBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "An suplementar"});
            this.yearOfStudyComboBox.Location = new System.Drawing.Point(114, 270);
            this.yearOfStudyComboBox.Name = "yearOfStudyComboBox";
            this.yearOfStudyComboBox.Size = new System.Drawing.Size(191, 21);
            this.yearOfStudyComboBox.TabIndex = 34;
            // 
            // yearOfStudyLabel
            // 
            this.yearOfStudyLabel.AutoSize = true;
            this.yearOfStudyLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfStudyLabel.Location = new System.Drawing.Point(9, 270);
            this.yearOfStudyLabel.Name = "yearOfStudyLabel";
            this.yearOfStudyLabel.Size = new System.Drawing.Size(98, 13);
            this.yearOfStudyLabel.TabIndex = 33;
            this.yearOfStudyLabel.Text = "Year of Study";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.deleteButton.Location = new System.Drawing.Point(230, 299);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.studentTitleLlabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(-1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 42);
            this.panel2.TabIndex = 31;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // studentTitleLlabel
            // 
            this.studentTitleLlabel.AutoSize = true;
            this.studentTitleLlabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTitleLlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentTitleLlabel.Location = new System.Drawing.Point(355, 17);
            this.studentTitleLlabel.Name = "studentTitleLlabel";
            this.studentTitleLlabel.Size = new System.Drawing.Size(88, 17);
            this.studentTitleLlabel.TabIndex = 2;
            this.studentTitleLlabel.Text = "Students";
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Location = new System.Drawing.Point(13, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // studentsListview
            // 
            this.studentsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.LastNameHeader,
            this.FirstNameHeader,
            this.GenderHeader,
            this.DOBHeader,
            this.EmailHeader,
            this.PhoneNumberHeader,
            this.yearHeader});
            this.studentsListview.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentsListview.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListview.FullRowSelect = true;
            this.studentsListview.GridLines = true;
            this.studentsListview.HideSelection = false;
            this.studentsListview.Location = new System.Drawing.Point(320, 59);
            this.studentsListview.Name = "studentsListview";
            this.studentsListview.Size = new System.Drawing.Size(550, 273);
            this.studentsListview.TabIndex = 33;
            this.studentsListview.UseCompatibleStateImageBehavior = false;
            this.studentsListview.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "ID";
            this.IdHeader.Width = 49;
            // 
            // LastNameHeader
            // 
            this.LastNameHeader.Text = "Last Name";
            this.LastNameHeader.Width = 70;
            // 
            // FirstNameHeader
            // 
            this.FirstNameHeader.Text = "First Name";
            this.FirstNameHeader.Width = 67;
            // 
            // GenderHeader
            // 
            this.GenderHeader.Text = "Gender";
            // 
            // DOBHeader
            // 
            this.DOBHeader.Text = "Date of Birth";
            this.DOBHeader.Width = 75;
            // 
            // EmailHeader
            // 
            this.EmailHeader.Text = "Email";
            // 
            // PhoneNumberHeader
            // 
            this.PhoneNumberHeader.Text = "Phone Number";
            this.PhoneNumberHeader.Width = 92;
            // 
            // yearHeader
            // 
            this.yearHeader.Text = "Year of Study";
            // 
            // viewSubjectsButton
            // 
            this.viewSubjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.viewSubjectsButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSubjectsButton.Location = new System.Drawing.Point(740, 338);
            this.viewSubjectsButton.Name = "viewSubjectsButton";
            this.viewSubjectsButton.Size = new System.Drawing.Size(130, 23);
            this.viewSubjectsButton.TabIndex = 34;
            this.viewSubjectsButton.Text = "View Subjects";
            this.viewSubjectsButton.UseVisualStyleBackColor = false;
            this.viewSubjectsButton.Click += new System.EventHandler(this.viewSubjectsButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditButton.Location = new System.Drawing.Point(320, 338);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(110, 23);
            this.saveEditButton.TabIndex = 35;
            this.saveEditButton.Text = "Save Changes";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 373);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.viewSubjectsButton);
            this.Controls.Add(this.studentsListview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addStudentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.addStudentGroupBox.ResumeLayout(false);
            this.addStudentGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button studentEditButton;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox addStudentGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListView studentsListview;
        private System.Windows.Forms.ColumnHeader LastNameHeader;
        private System.Windows.Forms.ColumnHeader FirstNameHeader;
        private System.Windows.Forms.ColumnHeader GenderHeader;
        private System.Windows.Forms.ColumnHeader DOBHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberHeader;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.Label studentTitleLlabel;
        private System.Windows.Forms.Label yearOfStudyLabel;
        private System.Windows.Forms.ComboBox yearOfStudyComboBox;
        private System.Windows.Forms.ColumnHeader yearHeader;
        private System.Windows.Forms.Button viewSubjectsButton;
        private System.Windows.Forms.Button saveEditButton;
    }
}