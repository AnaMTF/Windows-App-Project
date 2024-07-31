namespace Facultate
{
    partial class AddSubject
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
            this.subjectsTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.subjectGroupBox = new System.Windows.Forms.GroupBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.yearOfStudyLabel = new System.Windows.Forms.Label();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.isOptionalCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.isOptionalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subjectDeleteButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.subjectEditButton = new System.Windows.Forms.Button();
            this.subjectsListview = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsOptional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearOfStudy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewStudentsButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.subjectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.subjectsTitleLabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(0, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 42);
            this.panel2.TabIndex = 32;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // subjectsTitleLabel
            // 
            this.subjectsTitleLabel.AutoSize = true;
            this.subjectsTitleLabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectsTitleLabel.Location = new System.Drawing.Point(337, 18);
            this.subjectsTitleLabel.Name = "subjectsTitleLabel";
            this.subjectsTitleLabel.Size = new System.Drawing.Size(88, 17);
            this.subjectsTitleLabel.TabIndex = 2;
            this.subjectsTitleLabel.Text = "Subjects";
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // subjectGroupBox
            // 
            this.subjectGroupBox.BackColor = System.Drawing.Color.Lavender;
            this.subjectGroupBox.Controls.Add(this.semesterComboBox);
            this.subjectGroupBox.Controls.Add(this.yearOfStudyComboBox);
            this.subjectGroupBox.Controls.Add(this.semesterLabel);
            this.subjectGroupBox.Controls.Add(this.yearOfStudyLabel);
            this.subjectGroupBox.Controls.Add(this.creditsTextBox);
            this.subjectGroupBox.Controls.Add(this.creditsLabel);
            this.subjectGroupBox.Controls.Add(this.isOptionalCheckBox);
            this.subjectGroupBox.Controls.Add(this.nameTextBox);
            this.subjectGroupBox.Controls.Add(this.isOptionalLabel);
            this.subjectGroupBox.Controls.Add(this.nameLabel);
            this.subjectGroupBox.Controls.Add(this.subjectDeleteButton);
            this.subjectGroupBox.Controls.Add(this.addSubjectButton);
            this.subjectGroupBox.Controls.Add(this.subjectEditButton);
            this.subjectGroupBox.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectGroupBox.Location = new System.Drawing.Point(0, 37);
            this.subjectGroupBox.Name = "subjectGroupBox";
            this.subjectGroupBox.Size = new System.Drawing.Size(334, 414);
            this.subjectGroupBox.TabIndex = 33;
            this.subjectGroupBox.TabStop = false;
            this.subjectGroupBox.Text = "Add a New Subject";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "I",
            "II"});
            this.semesterComboBox.Location = new System.Drawing.Point(138, 153);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(168, 21);
            this.semesterComboBox.TabIndex = 46;
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
            this.yearOfStudyComboBox.Location = new System.Drawing.Point(138, 192);
            this.yearOfStudyComboBox.Name = "yearOfStudyComboBox";
            this.yearOfStudyComboBox.Size = new System.Drawing.Size(170, 21);
            this.yearOfStudyComboBox.TabIndex = 45;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.Location = new System.Drawing.Point(15, 153);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(63, 13);
            this.semesterLabel.TabIndex = 44;
            this.semesterLabel.Text = "Semester";
            // 
            // yearOfStudyLabel
            // 
            this.yearOfStudyLabel.AutoSize = true;
            this.yearOfStudyLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfStudyLabel.Location = new System.Drawing.Point(15, 195);
            this.yearOfStudyLabel.Name = "yearOfStudyLabel";
            this.yearOfStudyLabel.Size = new System.Drawing.Size(98, 13);
            this.yearOfStudyLabel.TabIndex = 42;
            this.yearOfStudyLabel.Text = "Year of Study";
            // 
            // creditsTextBox
            // 
            this.creditsTextBox.Location = new System.Drawing.Point(138, 112);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(170, 20);
            this.creditsTextBox.TabIndex = 41;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(15, 112);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(105, 13);
            this.creditsLabel.TabIndex = 40;
            this.creditsLabel.Text = "No. of Credits";
            // 
            // isOptionalCheckBox
            // 
            this.isOptionalCheckBox.AutoSize = true;
            this.isOptionalCheckBox.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isOptionalCheckBox.Location = new System.Drawing.Point(164, 77);
            this.isOptionalCheckBox.Name = "isOptionalCheckBox";
            this.isOptionalCheckBox.Size = new System.Drawing.Size(47, 17);
            this.isOptionalCheckBox.TabIndex = 39;
            this.isOptionalCheckBox.Text = "Yes";
            this.isOptionalCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 38;
            // 
            // isOptionalLabel
            // 
            this.isOptionalLabel.AutoSize = true;
            this.isOptionalLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isOptionalLabel.Location = new System.Drawing.Point(15, 77);
            this.isOptionalLabel.Name = "isOptionalLabel";
            this.isOptionalLabel.Size = new System.Drawing.Size(112, 13);
            this.isOptionalLabel.TabIndex = 37;
            this.isOptionalLabel.Text = "Is it Optional?";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(15, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 13);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "Subject Name";
            // 
            // subjectDeleteButton
            // 
            this.subjectDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.subjectDeleteButton.Location = new System.Drawing.Point(240, 261);
            this.subjectDeleteButton.Name = "subjectDeleteButton";
            this.subjectDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.subjectDeleteButton.TabIndex = 35;
            this.subjectDeleteButton.Text = "Delete";
            this.subjectDeleteButton.UseVisualStyleBackColor = false;
            this.subjectDeleteButton.Click += new System.EventHandler(this.subjectDeleteButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.addSubjectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addSubjectButton.Location = new System.Drawing.Point(32, 261);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.addSubjectButton.TabIndex = 34;
            this.addSubjectButton.Text = "Add";
            this.addSubjectButton.UseVisualStyleBackColor = false;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // subjectEditButton
            // 
            this.subjectEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.subjectEditButton.Location = new System.Drawing.Point(136, 261);
            this.subjectEditButton.Name = "subjectEditButton";
            this.subjectEditButton.Size = new System.Drawing.Size(75, 23);
            this.subjectEditButton.TabIndex = 33;
            this.subjectEditButton.Text = "Edit";
            this.subjectEditButton.UseVisualStyleBackColor = false;
            this.subjectEditButton.Click += new System.EventHandler(this.subjectEditButton_Click);
            // 
            // subjectsListview
            // 
            this.subjectsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NameHeader,
            this.IsOptional,
            this.Credits,
            this.Semester,
            this.YearOfStudy});
            this.subjectsListview.Cursor = System.Windows.Forms.Cursors.Default;
            this.subjectsListview.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsListview.FullRowSelect = true;
            this.subjectsListview.GridLines = true;
            this.subjectsListview.HideSelection = false;
            this.subjectsListview.Location = new System.Drawing.Point(340, 61);
            this.subjectsListview.Name = "subjectsListview";
            this.subjectsListview.Size = new System.Drawing.Size(446, 233);
            this.subjectsListview.TabIndex = 34;
            this.subjectsListview.UseCompatibleStateImageBehavior = false;
            this.subjectsListview.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "ID";
            this.IdHeader.Width = 49;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            // 
            // IsOptional
            // 
            this.IsOptional.Text = "Is Optional";
            this.IsOptional.Width = 102;
            // 
            // Credits
            // 
            this.Credits.Text = "No. of Credits";
            this.Credits.Width = 118;
            // 
            // Semester
            // 
            this.Semester.DisplayIndex = 5;
            this.Semester.Text = "Semester";
            this.Semester.Width = 71;
            // 
            // YearOfStudy
            // 
            this.YearOfStudy.DisplayIndex = 4;
            this.YearOfStudy.Text = "Year Of Study";
            this.YearOfStudy.Width = 108;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // viewStudentsButton
            // 
            this.viewStudentsButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.viewStudentsButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentsButton.Location = new System.Drawing.Point(671, 300);
            this.viewStudentsButton.Name = "viewStudentsButton";
            this.viewStudentsButton.Size = new System.Drawing.Size(115, 23);
            this.viewStudentsButton.TabIndex = 35;
            this.viewStudentsButton.Text = "View Students";
            this.viewStudentsButton.UseVisualStyleBackColor = false;
            this.viewStudentsButton.Click += new System.EventHandler(this.viewStudentsButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditButton.Location = new System.Drawing.Point(340, 300);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(110, 23);
            this.saveEditButton.TabIndex = 36;
            this.saveEditButton.Text = "Save Changes";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(804, 333);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.viewStudentsButton);
            this.Controls.Add(this.subjectsListview);
            this.Controls.Add(this.subjectGroupBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.subjectGroupBox.ResumeLayout(false);
            this.subjectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label subjectsTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox subjectGroupBox;
        private System.Windows.Forms.ListView subjectsListview;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader IsOptional;
        private System.Windows.Forms.Button subjectDeleteButton;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button subjectEditButton;
        private System.Windows.Forms.Label isOptionalLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox isOptionalCheckBox;
        private System.Windows.Forms.Label yearOfStudyLabel;
        private System.Windows.Forms.TextBox creditsTextBox;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.ColumnHeader Credits;
        private System.Windows.Forms.ColumnHeader YearOfStudy;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.ComboBox yearOfStudyComboBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.Button viewStudentsButton;
        private System.Windows.Forms.Button saveEditButton;
    }
}