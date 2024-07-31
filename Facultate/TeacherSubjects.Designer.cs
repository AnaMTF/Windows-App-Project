namespace Facultate
{
    partial class TeacherSubjects
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectsTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.subjectChoiceLabel = new System.Windows.Forms.Label();
            this.subjectChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.teacherSubjectsListView = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isOptionalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SemesterHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirmButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.subjectsTitleLabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 42);
            this.panel2.TabIndex = 37;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // subjectsTitleLabel
            // 
            this.subjectsTitleLabel.AutoSize = true;
            this.subjectsTitleLabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectsTitleLabel.Location = new System.Drawing.Point(115, 14);
            this.subjectsTitleLabel.Name = "subjectsTitleLabel";
            this.subjectsTitleLabel.Size = new System.Drawing.Size(128, 17);
            this.subjectsTitleLabel.TabIndex = 2;
            this.subjectsTitleLabel.Text = "Subjects for";
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
            // subjectChoiceLabel
            // 
            this.subjectChoiceLabel.AutoSize = true;
            this.subjectChoiceLabel.Location = new System.Drawing.Point(9, 71);
            this.subjectChoiceLabel.Name = "subjectChoiceLabel";
            this.subjectChoiceLabel.Size = new System.Drawing.Size(194, 13);
            this.subjectChoiceLabel.TabIndex = 36;
            this.subjectChoiceLabel.Text = "Choose a subject to assign a teacher to";
            // 
            // subjectChoiceComboBox
            // 
            this.subjectChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectChoiceComboBox.FormattingEnabled = true;
            this.subjectChoiceComboBox.Location = new System.Drawing.Point(12, 99);
            this.subjectChoiceComboBox.Name = "subjectChoiceComboBox";
            this.subjectChoiceComboBox.Size = new System.Drawing.Size(443, 21);
            this.subjectChoiceComboBox.TabIndex = 35;
            // 
            // teacherSubjectsListView
            // 
            this.teacherSubjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.NameHeader,
            this.isOptionalHeader,
            this.CreditsHeader,
            this.SemesterHeader,
            this.YearHeader});
            this.teacherSubjectsListView.FullRowSelect = true;
            this.teacherSubjectsListView.GridLines = true;
            this.teacherSubjectsListView.HideSelection = false;
            this.teacherSubjectsListView.Location = new System.Drawing.Point(12, 128);
            this.teacherSubjectsListView.Name = "teacherSubjectsListView";
            this.teacherSubjectsListView.Size = new System.Drawing.Size(524, 310);
            this.teacherSubjectsListView.TabIndex = 34;
            this.teacherSubjectsListView.UseCompatibleStateImageBehavior = false;
            this.teacherSubjectsListView.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "ID";
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Subject Name";
            this.NameHeader.Width = 90;
            // 
            // isOptionalHeader
            // 
            this.isOptionalHeader.Text = "Is Optional?";
            this.isOptionalHeader.Width = 84;
            // 
            // CreditsHeader
            // 
            this.CreditsHeader.Text = "No. of Credits";
            this.CreditsHeader.Width = 93;
            // 
            // SemesterHeader
            // 
            this.SemesterHeader.Text = "Semester";
            // 
            // YearHeader
            // 
            this.YearHeader.Text = "Year";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(461, 99);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 38;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // TeacherSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectChoiceLabel);
            this.Controls.Add(this.subjectChoiceComboBox);
            this.Controls.Add(this.teacherSubjectsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherSubjects";
            this.Load += new System.EventHandler(this.TeacherSubjects_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label subjectsTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label subjectChoiceLabel;
        private System.Windows.Forms.ComboBox subjectChoiceComboBox;
        private System.Windows.Forms.ListView teacherSubjectsListView;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader isOptionalHeader;
        private System.Windows.Forms.ColumnHeader CreditsHeader;
        private System.Windows.Forms.ColumnHeader SemesterHeader;
        private System.Windows.Forms.ColumnHeader YearHeader;
    }
}