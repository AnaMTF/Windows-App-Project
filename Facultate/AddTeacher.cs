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
    public partial class AddTeacher : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private readonly BindingList<Teacher> _teachers;

        public AddTeacher()
        {
            InitializeComponent();
            _teachers = new BindingList<Teacher>();
        }

        private void LoadTeachersFunction()
        {
            var query = "SELECT * FROM Teachers";

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

                        Teacher teacher = new Teacher(Id, lastName, firstName, gender, dateOfBirth, email, phoneNumber);

                        _teachers.Add(teacher);
                    }
                }
            }
        }

        private void AddTeacherFunction(Teacher teacher)
        {
            var query = "INSERT INTO Teachers (Id, LastName, FirstName, Gender, DateOfBirth, Email, PhoneNumber) " +
                "VALUES (@Id, @LastName, @FirstName, @Gender, @DateOfBirth, @Email, @PhoneNumber); " +
                "SELECT last_insert_rowid()";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", teacher.Id);
                command.Parameters.AddWithValue("@LastName", teacher.LastName);
                command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                command.Parameters.AddWithValue("@Gender", teacher.Gender);
                command.Parameters.AddWithValue("@DateOfBirth", teacher.DateOfBirth);
                command.Parameters.AddWithValue("@Email", teacher.Email);
                command.Parameters.AddWithValue("@PhoneNumber", teacher.PhoneNumber);

                teacher.Id = (long?)command.ExecuteScalar();

                _teachers.Add(teacher);
            }
        }

        private void DisplayTeachersFunction()
        {
            teachersListview.Items.Clear();

            foreach (Teacher teacher in _teachers)
            {
                var listViewItem = new ListViewItem(teacher.Id.ToString());
                listViewItem.SubItems.Add(teacher.LastName);
                listViewItem.SubItems.Add(teacher.FirstName);
                listViewItem.SubItems.Add(teacher.Gender);
                listViewItem.SubItems.Add(teacher.DateOfBirth.ToString());
                listViewItem.SubItems.Add(teacher.Email);
                listViewItem.SubItems.Add(teacher.PhoneNumber);

                listViewItem.Tag = teacher;

                teachersListview.Items.Add(listViewItem);
            }
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTeachersFunction();
                DisplayTeachersFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachersAddButton_Click(object sender, EventArgs e)
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
            if (dateOfBirth.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("The teacher must be at least 18 years old.", "Error: Invalid Age Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var email = emailTextBox.Text;
            if (!email.Contains("@") || !email.Contains("."))
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

            var teacher = new Teacher(lastName, firstName, gender, dateOfBirth, email, phoneNumber);

            try
            {
                AddTeacherFunction(teacher);
                DisplayTeachersFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void EditTeacher(Teacher teacher)
        {
            var query = "UPDATE Teachers SET LastName = @LastName, FirstName = @FirstName, Gender = @Gender, DateOfBirth = @DateOfBirth, Email = @Email, PhoneNumber = @PhoneNumber WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", teacher.Id);
                    command.Parameters.AddWithValue("@LastName", teacher.LastName);
                    command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                    command.Parameters.AddWithValue("@Gender", teacher.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", teacher.DateOfBirth);
                    command.Parameters.AddWithValue("@Email", teacher.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", teacher.PhoneNumber);

                    command.ExecuteNonQuery();
                }
            }

            var existingTeacher = _teachers.FirstOrDefault(s => s.Id == teacher.Id);
            if (existingTeacher != null)
            {
                existingTeacher.LastName = teacher.LastName;
                existingTeacher.FirstName = teacher.FirstName;
                existingTeacher.Gender = teacher.Gender;
                existingTeacher.DateOfBirth = teacher.DateOfBirth;
                existingTeacher.Email = teacher.Email;
                existingTeacher.PhoneNumber = teacher.PhoneNumber;
            }
        }

        private void teachersEditButton_Click(object sender, EventArgs e)
        {
            if (teachersListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher to edit.", "Error: No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedTeacher = teachersListview.SelectedItems[0];
            var teacher = (Teacher)selectedTeacher.Tag;

            lastNameTextBox.Text = teacher.LastName;
            firstNameTextBox.Text = teacher.FirstName;
            genderComboBox.Text = teacher.Gender;
            dateOfBirthTimePicker.Value = teacher.DateOfBirth;
            emailTextBox.Text = teacher.Email;
            phoneNumberTextBox.Text = teacher.PhoneNumber;

            saveEditButton.Enabled = true;
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            if (teachersListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher to edit.", "Error: No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to edit this teacher?", "Edit Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedTeacher = teachersListview.SelectedItems[0];
                var teacher = (Teacher)selectedTeacher.Tag;

                teacher.LastName = lastNameTextBox.Text;
                teacher.FirstName = firstNameTextBox.Text;
                teacher.Gender = genderComboBox.Text;
                teacher.DateOfBirth = dateOfBirthTimePicker.Value;
                teacher.Email = emailTextBox.Text;
                teacher.PhoneNumber = phoneNumberTextBox.Text;

                try
                {
                    EditTeacher(teacher);
                    DisplayTeachersFunction();
                    saveEditButton.Enabled = false;

                    MessageBox.Show("Teacher details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteTeacher (Teacher teacher)
        {
            const string query = "DELETE FROM Teachers WHERE Id = @Id";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", teacher.Id);

                command.ExecuteNonQuery();

                _teachers.Remove(teacher);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teachersListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete.", "Error: No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this teacher?", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var selectedTeacher = teachersListview.SelectedItems[0];
                    var teacher = (Teacher)selectedTeacher.Tag;

                    DeleteTeacher(teacher);
                    DisplayTeachersFunction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void viewSubjectsButton_Click(object sender, EventArgs e)
        {
            if (teachersListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher to view their subjects.", "Error: No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedTeacher = (Teacher)teachersListview.SelectedItems[0].Tag;

            this.Hide();
            TeacherSubjects teacherSubjects = new TeacherSubjects(selectedTeacher);
            teacherSubjects.Show();
        }

        //form functions

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
