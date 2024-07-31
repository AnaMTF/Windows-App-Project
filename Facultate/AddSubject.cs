using Facultate.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Facultate
{
    public partial class AddSubject : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private readonly BindingList<Subject> _subjects;
        public AddSubject()
        {
            InitializeComponent();
            _subjects = new BindingList<Subject>();
        }

        private void LoadSubjectsFunction()
        {
            var query = "SELECT * FROM Subjects";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long Id = reader.GetInt64(reader.GetOrdinal("Id"));
                        string Name = reader.GetString(reader.GetOrdinal("Name"));
                        bool isOptional = reader.GetBoolean(reader.GetOrdinal("IsOptional"));
                        int Credits = reader.GetInt32(reader.GetOrdinal("Credits"));
                        string Semester = reader.GetString(reader.GetOrdinal("Semester"));
                        string yearOfStudy = reader.GetString(reader.GetOrdinal("YearOfStudy"));
                        
                        Subject subject = new Subject(Id, Name, isOptional, Credits, Semester, yearOfStudy);

                        _subjects.Add(subject);
                    }
                }
            }
        }

        private void AddSubjectFunction(Subject subject)
        {
            var query = "INSERT INTO Subjects (Id, Name, IsOptional, Credits, Semester, YearOfStudy)" +
                "VALUES (@Id, @Name, @IsOptional, @Credits, @Semester, @YearOfStudy);" +
                "SELECT last_insert_rowid()";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", subject.SubjectId);
                command.Parameters.AddWithValue("@Name", subject.Name);
                command.Parameters.AddWithValue("@IsOptional", Convert.ToInt32(subject.IsOptional));
                command.Parameters.AddWithValue("@Credits", subject.Credits);
                command.Parameters.AddWithValue("@Semester", subject.Semester);
                command.Parameters.AddWithValue("@YearOfStudy", subject.YearOfStudy.Year);
                
                subject.SubjectId = (long?)command.ExecuteScalar();

                _subjects.Add(subject);
            }

            
        }

        private void DisplaySubjectsFunction()
        {
            subjectsListview.Items.Clear();

            foreach (Subject subject in _subjects)
            {
                var listViewItem = new ListViewItem(subject.SubjectId.ToString());
                listViewItem.SubItems.Add(subject.Name);
                listViewItem.SubItems.Add(subject.IsOptional.ToString());
                listViewItem.SubItems.Add(subject.Credits.ToString());
                listViewItem.SubItems.Add(subject.Semester);
                listViewItem.SubItems.Add(subject.YearOfStudy.Year);
                
                listViewItem.Tag = subject;

                subjectsListview.Items.Add(listViewItem);
            }
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSubjectsFunction();
                DisplaySubjectsFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required");
                return;
            }
            var isOptional = isOptionalCheckBox.Checked;
            var credits = int.Parse(creditsTextBox.Text);
            if (credits < 0)
            {
                MessageBox.Show("Credits must be a positive number", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (credits > 10)
            {
                MessageBox.Show("Credits must be less than 10", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var semester = semesterComboBox.Text;
            var yearOfStudy = yearOfStudyComboBox.Text;


            var subject = new Subject(name, isOptional, credits, semester, yearOfStudy );

            try
            {
                AddSubjectFunction(subject);
                DisplaySubjectsFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditSubject(Subject subject)
        {
            var query = "UPDATE Subjects SET Name = @Name, IsOptional = @IsOptional, Credits = @Credits, Semester = @Semester, YearOfStudy = @YearOfStudy WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", subject.SubjectId);
                    command.Parameters.AddWithValue("@Name", subject.Name);
                    command.Parameters.AddWithValue("@IsOptional", subject.IsOptional);
                    command.Parameters.AddWithValue("@Credits", subject.Credits);
                    command.Parameters.AddWithValue("@Semester", subject.Semester);
                    command.Parameters.AddWithValue("@YearOfStudy", subject.YearOfStudy.Year);

                    command.ExecuteNonQuery();
                }
            }

            var existingSubject = _subjects.FirstOrDefault(s => s.SubjectId == subject.SubjectId);
            if (existingSubject != null)
            {
                existingSubject.Name = subject.Name;
                existingSubject.IsOptional = subject.IsOptional;
                existingSubject.Credits = subject.Credits;
                existingSubject.Semester = subject.Semester;
                existingSubject.YearOfStudy = subject.YearOfStudy;
            }
        }

        private void subjectEditButton_Click(object sender, EventArgs e)
        {
            if (subjectsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to edit.", "Error: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedSubject = subjectsListview.SelectedItems[0];
            var subject = (Subject)selectedSubject.Tag;

            nameTextBox.Text = subject.Name;
            isOptionalCheckBox.Checked = subject.IsOptional;
            creditsTextBox.Text = subject.Credits.ToString();
            semesterComboBox.Text = subject.Semester;
            yearOfStudyComboBox.Text = subject.YearOfStudy.Year;

            saveEditButton.Enabled = true;
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            if (subjectsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to edit.", "Error: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to edit this subject?", "Edit Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedSubject = subjectsListview.SelectedItems[0];
                var subject = (Subject)selectedSubject.Tag;

                subject.Name = nameTextBox.Text;
                subject.IsOptional = isOptionalCheckBox.Checked;
                subject.Credits = int.Parse(creditsTextBox.Text);
                subject.Semester = semesterComboBox.Text;
                subject.YearOfStudy = new YearOfStudy(yearOfStudyComboBox.Text);

                try
                {
                    EditSubject(subject);
                    DisplaySubjectsFunction();
                    saveEditButton.Enabled = false;

                    MessageBox.Show("Subject details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSubject(Subject subject)
        {
            var query = "DELETE FROM Subjects WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", subject.SubjectId);

                command.ExecuteNonQuery();
                _subjects.Remove(subject);
            }
        }

        private void subjectDeleteButton_Click(object sender, EventArgs e)
        {
            if (subjectsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.", "Error: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Are you sure you want to delete this subject?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var selectedSubject = subjectsListview.SelectedItems[0];
                    var subject = (Subject)selectedSubject.Tag;

                    DeleteSubject(subject);
                    DisplaySubjectsFunction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            if (subjectsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a suject to view its students.", "Error: No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedSubject = (Subject)subjectsListview.SelectedItems[0].Tag;

            this.Hide();
            SubjectsStudents subjectStudents = new SubjectsStudents(selectedSubject);
            subjectStudents.Show();
        }


        //functions for form topbar
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void TopBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}
