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

namespace Facultate
{
    public partial class TeacherSubjects : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private Teacher _teacher;
        private readonly BindingList<Subject> _allSubjects;
        private readonly BindingList<Subject> _enrolledSubjects;
        public TeacherSubjects()
        {
            InitializeComponent();
        }

        public TeacherSubjects(Teacher teacher) : this()
        {
            _teacher = teacher;

            _allSubjects = new BindingList<Subject>();
            _enrolledSubjects = new BindingList<Subject>();

            subjectsTitleLabel.Text += " " + teacher.LastName + " " + teacher.FirstName;
        }

        private void populateListView()
        {
            teacherSubjectsListView.Items.Clear();

            foreach (Subject subject in _enrolledSubjects)
            {
                var listViewItem = new ListViewItem(subject.SubjectId.ToString());
                listViewItem.SubItems.Add(subject.Name);
                listViewItem.SubItems.Add(subject.IsOptional.ToString());
                listViewItem.SubItems.Add(subject.Credits.ToString());
                listViewItem.SubItems.Add(subject.Semester);
                listViewItem.SubItems.Add(subject.YearOfStudy.Year);

                listViewItem.Tag = subject;

                teacherSubjectsListView.Items.Add(listViewItem);
            }
        }

        private void populateComboBox()
        {
            foreach (Subject subject in _allSubjects)
            {
                subjectChoiceComboBox.Items.Add(subject.Name);
            }
        }

        private void loadAllSubjects()
        {
            var query = "SELECT * FROM Subjects ORDER BY Subjects.Name";

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

                        _allSubjects.Add(subject);
                    }
                }
            }
        }

        private void loadEnrolledSubjects(Teacher teacher)
        {
            var query = "SELECT * FROM Subjects " +
                "INNER JOIN TeachersSubjects ON TeachersSubjects.SubjectId = Subjects.Id " +
                "WHERE TeachersSubjects.TeacherId = @id " +
                "ORDER BY Subjects.Name";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", teacher.Id);

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

                        _enrolledSubjects.Add(subject);
                    }
                }
            }
        }

        private void TeacherSubjects_Load(object sender, EventArgs e)
        {
            try
            {
                loadAllSubjects();
                loadEnrolledSubjects(_teacher);

                populateListView();
                populateComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO TeachersSubjects (TeacherId, SubjectId) VALUES (@teacherId, @subjectId)";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var selectedSubject = _allSubjects[subjectChoiceComboBox.SelectedIndex];
                if (selectedSubject != null)
                {
                    try
                    {
                        var command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@teacherId", _teacher.Id);
                        command.Parameters.AddWithValue("@subjectId", selectedSubject.SubjectId);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The teacher is already teaching this subject.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _enrolledSubjects.Add(selectedSubject);
                    teacherSubjectsListView.Items.Clear();
                    populateListView();
                }
            }
        }

        // functions for the form
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

        private void TopBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddTeacher().Show();
        }
    }
}
