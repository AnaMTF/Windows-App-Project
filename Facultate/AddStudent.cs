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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Facultate
{
    public partial class AddStudent : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private readonly BindingList<Student> _students;

        public AddStudent()
        {
            InitializeComponent();
            _students = new BindingList<Student>();
        }

        private void LoadStudentsFunction()
        {
            var query = "SELECT * FROM Students";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long Id = reader.GetInt64(reader.GetOrdinal("Id"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string gender = reader.GetString(reader.GetOrdinal("Gender"));
                        DateTime dateOfBirth = DateTime.Parse(reader.GetString(reader.GetOrdinal("DateOfBirth")));

                        string email = reader.GetString(reader.GetOrdinal("Email"));
                        string phoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        string yearOfStudy = reader.GetString(reader.GetOrdinal("YearOfStudy"));

                        Student student = new Student(Id, lastName, firstName, gender, dateOfBirth, email, phoneNumber, yearOfStudy);

                        _students.Add(student);
                    }
                }
            }
        }

        private void AddStudentFunction(Student student)
        {
            var query = "INSERT INTO Students (Id, LastName, FirstName, Gender, DateOfBirth, Email, PhoneNumber, YearOfStudy) " +
                "VALUES (@Id, @LastName, @FirstName, @Gender, @DateOfBirth, @Email, @PhoneNumber, @YearOfStudy); " +
                "SELECT last_insert_rowid()";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();
                
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                command.Parameters.AddWithValue("@YearOfStudy", student.YearOfStudy.Year);

                student.Id = (long?)command.ExecuteScalar();

                _students.Add(student);
            }
        }

        private void DisplayStudentsFunction()
        {
            studentsListview.Items.Clear();

            foreach (Student student in _students)
            {
                var listViewItem = new ListViewItem(student.Id.ToString());
                listViewItem.SubItems.Add(student.LastName);
                listViewItem.SubItems.Add(student.FirstName);
                listViewItem.SubItems.Add(student.Gender);
                listViewItem.SubItems.Add(student.DateOfBirth.ToString());
                listViewItem.SubItems.Add(student.Email);
                listViewItem.SubItems.Add(student.PhoneNumber);
                listViewItem.SubItems.Add(student.YearOfStudy.Year);

                listViewItem.Tag = student;

                studentsListview.Items.Add(listViewItem);
            }
        }   

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStudentsFunction();
                DisplayStudentsFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var lastName = lastNameTextBox.Text;
            if (lastName.Length == 0)
            {
                MessageBox.Show("Last name cannot be empty.", "Error: Invalid Name Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var firstName = firstNameTextBox.Text;
            if (firstName.Length == 0)
            {
                MessageBox.Show("First name cannot be empty.", "Error: Invalid Name Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var gender = genderComboBox.Text;

            var dateOfBirth = dateOfBirthTimePicker.Value;
            if (dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot be in the future.", "Error: Invalid Age Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(dateOfBirth.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("Student must be at least 18 years old.", "Error: Invalid Age Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var email = emailTextBox.Text;
            if(!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid email address.", "Error: Invalid Email Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var phoneNumber = phoneNumberTextBox.Text;
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must have 10 digits.", "Error: Invalid Phone Number Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var yearOfStudy = yearOfStudyComboBox.Text;

            var student = new Student(lastName, firstName, gender, dateOfBirth, email, phoneNumber, yearOfStudy);

            try
            {
                AddStudentFunction(student);
                DisplayStudentsFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStudent(Student student)
        {
            var query = "UPDATE Students SET LastName = @LastName, FirstName = @FirstName, Gender = @Gender, DateOfBirth = @DateOfBirth, Email = @Email, PhoneNumber = @PhoneNumber, YearOfStudy = @YearOfStudy WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Id);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    command.Parameters.AddWithValue("@YearOfStudy", student.YearOfStudy.Year);

                    command.ExecuteNonQuery();
                }
            }

            var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.LastName = student.LastName;
                existingStudent.FirstName = student.FirstName;
                existingStudent.Gender = student.Gender;
                existingStudent.DateOfBirth = student.DateOfBirth;
                existingStudent.Email = student.Email;
                existingStudent.PhoneNumber = student.PhoneNumber;
                existingStudent.YearOfStudy = student.YearOfStudy;
            }
        }

        private void studentEditButton_Click(object sender, EventArgs e)
        {
            if (studentsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "Error: No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedStudent = studentsListview.SelectedItems[0];
            var student = (Student)selectedStudent.Tag;

            lastNameTextBox.Text = student.LastName;
            firstNameTextBox.Text = student.FirstName;
            genderComboBox.Text = student.Gender;
            dateOfBirthTimePicker.Value = student.DateOfBirth;
            emailTextBox.Text = student.Email;
            phoneNumberTextBox.Text = student.PhoneNumber;
            yearOfStudyComboBox.Text = student.YearOfStudy.Year;

            saveEditButton.Enabled = true;
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            if (studentsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "Error: No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to edit this student?", "Edit Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedStudent = studentsListview.SelectedItems[0];
                var student = (Student)selectedStudent.Tag;

                student.LastName = lastNameTextBox.Text;
                student.FirstName = firstNameTextBox.Text;
                student.Gender = genderComboBox.Text;
                student.DateOfBirth = dateOfBirthTimePicker.Value;
                student.Email = emailTextBox.Text;
                student.PhoneNumber = phoneNumberTextBox.Text;
                student.YearOfStudy.Year = yearOfStudyComboBox.Text;

                try
                {
                    EditStudent(student);
                    DisplayStudentsFunction();
                    saveEditButton.Enabled = false;

                    MessageBox.Show("Student details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteStudent (Student student)
        {
            const string query = "DELETE FROM Students WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);

                command.ExecuteNonQuery();

                _students.Remove(student);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (studentsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.", "Error: No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var selectedStudent = studentsListview.SelectedItems[0];
                    var student = (Student)selectedStudent.Tag;

                    DeleteStudent(student);
                    DisplayStudentsFunction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewSubjectsButton_Click(object sender, EventArgs e)
        {
            if (studentsListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to view subjects.", "Error: No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedStudent = (Student)studentsListview.SelectedItems[0].Tag;

            this.Hide();
            StudentSubjects studentSubjects = new StudentSubjects(selectedStudent);
            studentSubjects.Show();
        }

        //functions for the form topbar

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
