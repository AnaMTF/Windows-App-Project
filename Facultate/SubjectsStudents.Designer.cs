namespace Facultate
{
    partial class SubjectsStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsStudents));
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentsTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.subjectsStudentsListView = new System.Windows.Forms.ListView();
            this.StudentIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printMenuStrip = new System.Windows.Forms.MenuStrip();
            this.cacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printStudentsDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printStudentsPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printStudentsDialog = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.printMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.studentsTitleLabel);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 42);
            this.panel2.TabIndex = 41;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // studentsTitleLabel
            // 
            this.studentsTitleLabel.AutoSize = true;
            this.studentsTitleLabel.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.studentsTitleLabel.Location = new System.Drawing.Point(179, 14);
            this.studentsTitleLabel.Name = "studentsTitleLabel";
            this.studentsTitleLabel.Size = new System.Drawing.Size(118, 17);
            this.studentsTitleLabel.TabIndex = 2;
            this.studentsTitleLabel.Text = "Students in";
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
            // subjectsStudentsListView
            // 
            this.subjectsStudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentIdHeader,
            this.FirstNameHeader,
            this.LastNameHeader,
            this.AgeHeader,
            this.GenderHeader,
            this.emailHeader,
            this.phoneHeader,
            this.YearHeader});
            this.subjectsStudentsListView.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsStudentsListView.FullRowSelect = true;
            this.subjectsStudentsListView.GridLines = true;
            this.subjectsStudentsListView.HideSelection = false;
            this.subjectsStudentsListView.Location = new System.Drawing.Point(12, 60);
            this.subjectsStudentsListView.Name = "subjectsStudentsListView";
            this.subjectsStudentsListView.Size = new System.Drawing.Size(616, 329);
            this.subjectsStudentsListView.TabIndex = 38;
            this.subjectsStudentsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsStudentsListView.View = System.Windows.Forms.View.Details;
            // 
            // StudentIdHeader
            // 
            this.StudentIdHeader.Text = "ID";
            // 
            // FirstNameHeader
            // 
            this.FirstNameHeader.Text = "First Name";
            this.FirstNameHeader.Width = 93;
            // 
            // LastNameHeader
            // 
            this.LastNameHeader.Text = "Last Name";
            this.LastNameHeader.Width = 79;
            // 
            // AgeHeader
            // 
            this.AgeHeader.Text = "Age";
            // 
            // GenderHeader
            // 
            this.GenderHeader.Text = "Gender";
            // 
            // emailHeader
            // 
            this.emailHeader.DisplayIndex = 6;
            this.emailHeader.Text = "Email";
            // 
            // phoneHeader
            // 
            this.phoneHeader.DisplayIndex = 7;
            this.phoneHeader.Text = "Phone Number";
            this.phoneHeader.Width = 98;
            // 
            // YearHeader
            // 
            this.YearHeader.DisplayIndex = 5;
            this.YearHeader.Text = "Year";
            // 
            // printMenuStrip
            // 
            this.printMenuStrip.BackColor = System.Drawing.Color.White;
            this.printMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.printMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cacaToolStripMenuItem});
            this.printMenuStrip.Location = new System.Drawing.Point(0, 426);
            this.printMenuStrip.Name = "printMenuStrip";
            this.printMenuStrip.Size = new System.Drawing.Size(640, 24);
            this.printMenuStrip.TabIndex = 42;
            this.printMenuStrip.Text = "menuStrip1";
            // 
            // cacaToolStripMenuItem
            // 
            this.cacaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.cacaToolStripMenuItem.Name = "cacaToolStripMenuItem";
            this.cacaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.cacaToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printStudentsDocument
            // 
            this.printStudentsDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStudentsDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printStudentsDocument;
            // 
            // printStudentsPreviewDialog
            // 
            this.printStudentsPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printStudentsPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printStudentsPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printStudentsPreviewDialog.Document = this.printStudentsDocument;
            this.printStudentsPreviewDialog.Enabled = true;
            this.printStudentsPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printStudentsPreviewDialog.Icon")));
            this.printStudentsPreviewDialog.Name = "printStudentsPreviewDialog";
            this.printStudentsPreviewDialog.Visible = false;
            // 
            // printStudentsDialog
            // 
            this.printStudentsDialog.Document = this.printStudentsDocument;
            this.printStudentsDialog.UseEXDialog = true;
            // 
            // SubjectsStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.printMenuStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectsStudentsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.printMenuStrip;
            this.Name = "SubjectsStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectsStudents";
            this.Load += new System.EventHandler(this.SubjectsStudents_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.printMenuStrip.ResumeLayout(false);
            this.printMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studentsTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView subjectsStudentsListView;
        private System.Windows.Forms.ColumnHeader StudentIdHeader;
        private System.Windows.Forms.ColumnHeader FirstNameHeader;
        private System.Windows.Forms.ColumnHeader LastNameHeader;
        private System.Windows.Forms.ColumnHeader YearHeader;
        private System.Windows.Forms.ColumnHeader AgeHeader;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader phoneHeader;
        private System.Windows.Forms.ColumnHeader GenderHeader;
        private System.Windows.Forms.MenuStrip printMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printStudentsDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printStudentsPreviewDialog;
        private System.Windows.Forms.PrintDialog printStudentsDialog;
    }
}