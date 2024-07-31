namespace Facultate
{
    partial class StudentSubjects
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
            this.studentSubjectsListView = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semesterHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.subjectChoiceLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectsTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentSubjectsListView
            // 
            this.studentSubjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.nameHeader,
            this.optionalHeader,
            this.creditsHeader,
            this.semesterHeader,
            this.yearHeader});
            this.studentSubjectsListView.FullRowSelect = true;
            this.studentSubjectsListView.GridLines = true;
            this.studentSubjectsListView.HideSelection = false;
            this.studentSubjectsListView.Location = new System.Drawing.Point(12, 144);
            this.studentSubjectsListView.Name = "studentSubjectsListView";
            this.studentSubjectsListView.Size = new System.Drawing.Size(535, 281);
            this.studentSubjectsListView.TabIndex = 0;
            this.studentSubjectsListView.UseCompatibleStateImageBehavior = false;
            this.studentSubjectsListView.View = System.Windows.Forms.View.Details;
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Subject Name";
            this.nameHeader.Width = 96;
            // 
            // optionalHeader
            // 
            this.optionalHeader.Text = "Is Optional?";
            // 
            // creditsHeader
            // 
            this.creditsHeader.Text = "No. of Credits";
            // 
            // semesterHeader
            // 
            this.semesterHeader.Text = "Semester";
            // 
            // yearHeader
            // 
            this.yearHeader.Text = "Year of Study";
            // 
            // subjectChoiceComboBox
            // 
            this.subjectChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectChoiceComboBox.FormattingEnabled = true;
            this.subjectChoiceComboBox.Location = new System.Drawing.Point(12, 115);
            this.subjectChoiceComboBox.Name = "subjectChoiceComboBox";
            this.subjectChoiceComboBox.Size = new System.Drawing.Size(452, 21);
            this.subjectChoiceComboBox.TabIndex = 1;
            // 
            // subjectChoiceLabel
            // 
            this.subjectChoiceLabel.AutoSize = true;
            this.subjectChoiceLabel.Location = new System.Drawing.Point(12, 87);
            this.subjectChoiceLabel.Name = "subjectChoiceLabel";
            this.subjectChoiceLabel.Size = new System.Drawing.Size(199, 13);
            this.subjectChoiceLabel.TabIndex = 2;
            this.subjectChoiceLabel.Text = "Choose a subject to enroll the student in:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.subjectsTitleLabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 42);
            this.panel2.TabIndex = 33;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // subjectsTitleLabel
            // 
            this.subjectsTitleLabel.AutoSize = true;
            this.subjectsTitleLabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectsTitleLabel.Location = new System.Drawing.Point(124, 14);
            this.subjectsTitleLabel.Name = "subjectsTitleLabel";
            this.subjectsTitleLabel.Size = new System.Drawing.Size(128, 17);
            this.subjectsTitleLabel.TabIndex = 2;
            this.subjectsTitleLabel.Text = "Subjects for";
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
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(472, 115);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 34;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // StudentSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(566, 436);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectChoiceLabel);
            this.Controls.Add(this.subjectChoiceComboBox);
            this.Controls.Add(this.studentSubjectsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list";
            this.Load += new System.EventHandler(this.StudentSubjects_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentSubjectsListView;
        private System.Windows.Forms.ComboBox subjectChoiceComboBox;
        private System.Windows.Forms.Label subjectChoiceLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label subjectsTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader optionalHeader;
        private System.Windows.Forms.ColumnHeader creditsHeader;
        private System.Windows.Forms.ColumnHeader semesterHeader;
        private System.Windows.Forms.ColumnHeader yearHeader;
        private System.Windows.Forms.Button confirmButton;
    }
}