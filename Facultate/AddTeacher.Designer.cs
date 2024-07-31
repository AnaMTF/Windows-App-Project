namespace Facultate
{
    partial class AddTeacher
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teachersTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.teacherGroupBox = new System.Windows.Forms.GroupBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.teachersAddButton = new System.Windows.Forms.Button();
            this.teachersEditButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teachersListview = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOBHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewSubjectsButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.teacherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.teachersTitleLabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 42);
            this.panel2.TabIndex = 33;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // teachersTitleLabel
            // 
            this.teachersTitleLabel.AutoSize = true;
            this.teachersTitleLabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teachersTitleLabel.Location = new System.Drawing.Point(337, 18);
            this.teachersTitleLabel.Name = "teachersTitleLabel";
            this.teachersTitleLabel.Size = new System.Drawing.Size(88, 17);
            this.teachersTitleLabel.TabIndex = 2;
            this.teachersTitleLabel.Text = "Teachers";
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Location = new System.Drawing.Point(13, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // teacherGroupBox
            // 
            this.teacherGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.teacherGroupBox.Controls.Add(this.genderComboBox);
            this.teacherGroupBox.Controls.Add(this.genderLabel);
            this.teacherGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.teacherGroupBox.Controls.Add(this.phoneNumberLabel);
            this.teacherGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.teacherGroupBox.Controls.Add(this.emailTextBox);
            this.teacherGroupBox.Controls.Add(this.dateOfBirthTimePicker);
            this.teacherGroupBox.Controls.Add(this.emailLabel);
            this.teacherGroupBox.Controls.Add(this.deleteButton);
            this.teacherGroupBox.Controls.Add(this.teachersAddButton);
            this.teacherGroupBox.Controls.Add(this.teachersEditButton);
            this.teacherGroupBox.Controls.Add(this.lastNameTextBox);
            this.teacherGroupBox.Controls.Add(this.lastNameLabel);
            this.teacherGroupBox.Controls.Add(this.firstNameTextBox);
            this.teacherGroupBox.Controls.Add(this.firstNameLabel);
            this.teacherGroupBox.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGroupBox.Location = new System.Drawing.Point(-1, 42);
            this.teacherGroupBox.Name = "teacherGroupBox";
            this.teacherGroupBox.Size = new System.Drawing.Size(330, 328);
            this.teacherGroupBox.TabIndex = 34;
            this.teacherGroupBox.TabStop = false;
            this.teacherGroupBox.Text = "Add a New Teacher";
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
            this.genderComboBox.Location = new System.Drawing.Point(107, 101);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(203, 21);
            this.genderComboBox.TabIndex = 43;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(24, 104);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(49, 13);
            this.genderLabel.TabIndex = 42;
            this.genderLabel.Text = "Gender";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(111, 225);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.phoneNumberTextBox.TabIndex = 41;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(14, 228);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.phoneNumberLabel.TabIndex = 40;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(4, 151);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(98, 13);
            this.dateOfBirthLabel.TabIndex = 36;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(111, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 20);
            this.emailTextBox.TabIndex = 39;
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(107, 145);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(204, 20);
            this.dateOfBirthTimePicker.TabIndex = 37;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(27, 189);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 13);
            this.emailLabel.TabIndex = 38;
            this.emailLabel.Text = "Email";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.deleteButton.Location = new System.Drawing.Point(235, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // teachersAddButton
            // 
            this.teachersAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.teachersAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.teachersAddButton.Location = new System.Drawing.Point(17, 277);
            this.teachersAddButton.Name = "teachersAddButton";
            this.teachersAddButton.Size = new System.Drawing.Size(75, 23);
            this.teachersAddButton.TabIndex = 34;
            this.teachersAddButton.Text = "Add";
            this.teachersAddButton.UseVisualStyleBackColor = false;
            this.teachersAddButton.Click += new System.EventHandler(this.teachersAddButton_Click);
            // 
            // teachersEditButton
            // 
            this.teachersEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.teachersEditButton.Location = new System.Drawing.Point(127, 277);
            this.teachersEditButton.Name = "teachersEditButton";
            this.teachersEditButton.Size = new System.Drawing.Size(75, 23);
            this.teachersEditButton.TabIndex = 33;
            this.teachersEditButton.Text = "Edit";
            this.teachersEditButton.UseVisualStyleBackColor = false;
            this.teachersEditButton.Click += new System.EventHandler(this.teachersEditButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 29);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(12, 29);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(107, 59);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(11, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(77, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // teachersListview
            // 
            this.teachersListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.LastNameHeader,
            this.FirstNameHeader,
            this.GenderHeader,
            this.DOBHeader,
            this.EmailHeader,
            this.PhoneNumberHeader});
            this.teachersListview.Cursor = System.Windows.Forms.Cursors.Default;
            this.teachersListview.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersListview.FullRowSelect = true;
            this.teachersListview.GridLines = true;
            this.teachersListview.HideSelection = false;
            this.teachersListview.Location = new System.Drawing.Point(339, 71);
            this.teachersListview.Name = "teachersListview";
            this.teachersListview.Size = new System.Drawing.Size(567, 216);
            this.teachersListview.TabIndex = 36;
            this.teachersListview.UseCompatibleStateImageBehavior = false;
            this.teachersListview.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "ID";
            this.IdHeader.Width = 49;
            // 
            // LastNameHeader
            // 
            this.LastNameHeader.Text = "Last Name";
            this.LastNameHeader.Width = 84;
            // 
            // FirstNameHeader
            // 
            this.FirstNameHeader.Text = "First Name";
            this.FirstNameHeader.Width = 96;
            // 
            // GenderHeader
            // 
            this.GenderHeader.Text = "Gender";
            // 
            // DOBHeader
            // 
            this.DOBHeader.Text = "Date of Birth";
            this.DOBHeader.Width = 108;
            // 
            // EmailHeader
            // 
            this.EmailHeader.Text = "Email";
            // 
            // PhoneNumberHeader
            // 
            this.PhoneNumberHeader.Text = "Phone Number";
            this.PhoneNumberHeader.Width = 105;
            // 
            // viewSubjectsButton
            // 
            this.viewSubjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.viewSubjectsButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSubjectsButton.Location = new System.Drawing.Point(791, 319);
            this.viewSubjectsButton.Name = "viewSubjectsButton";
            this.viewSubjectsButton.Size = new System.Drawing.Size(115, 23);
            this.viewSubjectsButton.TabIndex = 37;
            this.viewSubjectsButton.Text = "View Subjects";
            this.viewSubjectsButton.UseVisualStyleBackColor = false;
            this.viewSubjectsButton.Click += new System.EventHandler(this.viewSubjectsButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditButton.Location = new System.Drawing.Point(339, 319);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(110, 23);
            this.saveEditButton.TabIndex = 38;
            this.saveEditButton.Text = "Save Changes";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 356);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.viewSubjectsButton);
            this.Controls.Add(this.teachersListview);
            this.Controls.Add(this.teacherGroupBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.teacherGroupBox.ResumeLayout(false);
            this.teacherGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label teachersTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox teacherGroupBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button teachersAddButton;
        private System.Windows.Forms.Button teachersEditButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListView teachersListview;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader LastNameHeader;
        private System.Windows.Forms.ColumnHeader FirstNameHeader;
        private System.Windows.Forms.ColumnHeader GenderHeader;
        private System.Windows.Forms.ColumnHeader DOBHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberHeader;
        private System.Windows.Forms.Button viewSubjectsButton;
        private System.Windows.Forms.Button saveEditButton;
    }
}