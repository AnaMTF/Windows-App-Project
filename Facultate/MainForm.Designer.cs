namespace Facultate
{
    partial class MainForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewStudentsButton = new System.Windows.Forms.Button();
            this.viewSubjectsButton = new System.Windows.Forms.Button();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.subjectPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teachersPictureBox = new System.Windows.Forms.PictureBox();
            this.viewTeachersButton = new System.Windows.Forms.Button();
            this.subjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // viewStudentsButton
            // 
            this.viewStudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.viewStudentsButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentsButton.Location = new System.Drawing.Point(50, 154);
            this.viewStudentsButton.Name = "viewStudentsButton";
            this.viewStudentsButton.Size = new System.Drawing.Size(86, 36);
            this.viewStudentsButton.TabIndex = 14;
            this.viewStudentsButton.Text = "View Students";
            this.viewStudentsButton.UseVisualStyleBackColor = false;
            this.viewStudentsButton.Click += new System.EventHandler(this.viewStudentsButton_Click);
            // 
            // viewSubjectsButton
            // 
            this.viewSubjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.viewSubjectsButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSubjectsButton.Location = new System.Drawing.Point(37, 154);
            this.viewSubjectsButton.Name = "viewSubjectsButton";
            this.viewSubjectsButton.Size = new System.Drawing.Size(86, 36);
            this.viewSubjectsButton.TabIndex = 15;
            this.viewSubjectsButton.Text = "View Subjects";
            this.viewSubjectsButton.UseVisualStyleBackColor = false;
            this.viewSubjectsButton.Click += new System.EventHandler(this.viewSubjectsButton_Click);
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.BackColor = System.Drawing.Color.Lavender;
            this.subjectsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subjectsPanel.Controls.Add(this.viewSubjectsButton);
            this.subjectsPanel.Controls.Add(this.subjectPictureBox);
            this.subjectsPanel.Location = new System.Drawing.Point(12, 75);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(170, 229);
            this.subjectsPanel.TabIndex = 16;
            // 
            // subjectPictureBox
            // 
            this.subjectPictureBox.Image = global::Facultate.Properties.Resources.book;
            this.subjectPictureBox.Location = new System.Drawing.Point(37, 46);
            this.subjectPictureBox.Name = "subjectPictureBox";
            this.subjectPictureBox.Size = new System.Drawing.Size(86, 65);
            this.subjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subjectPictureBox.TabIndex = 18;
            this.subjectPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Location = new System.Drawing.Point(-6, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 42);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarMouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("72 Monospace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(243, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Menu";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(515, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.StudentPictureBox);
            this.panel1.Controls.Add(this.viewStudentsButton);
            this.panel1.Location = new System.Drawing.Point(188, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 229);
            this.panel1.TabIndex = 20;
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.Image = global::Facultate.Properties.Resources.student;
            this.StudentPictureBox.Location = new System.Drawing.Point(50, 46);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(86, 65);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 19;
            this.StudentPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please select what you would like to see";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.teachersPictureBox);
            this.panel3.Controls.Add(this.viewTeachersButton);
            this.panel3.Location = new System.Drawing.Point(374, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 229);
            this.panel3.TabIndex = 21;
            // 
            // teachersPictureBox
            // 
            this.teachersPictureBox.Image = global::Facultate.Properties.Resources.chalkboard_user;
            this.teachersPictureBox.Location = new System.Drawing.Point(50, 46);
            this.teachersPictureBox.Name = "teachersPictureBox";
            this.teachersPictureBox.Size = new System.Drawing.Size(86, 65);
            this.teachersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teachersPictureBox.TabIndex = 19;
            this.teachersPictureBox.TabStop = false;
            // 
            // viewTeachersButton
            // 
            this.viewTeachersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewTeachersButton.Font = new System.Drawing.Font("72 Monospace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeachersButton.Location = new System.Drawing.Point(50, 154);
            this.viewTeachersButton.Name = "viewTeachersButton";
            this.viewTeachersButton.Size = new System.Drawing.Size(86, 36);
            this.viewTeachersButton.TabIndex = 14;
            this.viewTeachersButton.Text = "View Teachers";
            this.viewTeachersButton.UseVisualStyleBackColor = false;
            this.viewTeachersButton.Click += new System.EventHandler(this.viewTeachersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(564, 316);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.subjectsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button viewStudentsButton;
        private System.Windows.Forms.Button viewSubjectsButton;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox subjectPictureBox;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox teachersPictureBox;
        private System.Windows.Forms.Button viewTeachersButton;
    }
}

