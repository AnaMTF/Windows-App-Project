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
    public partial class SubjectsStudents : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private Subject _subject;
        private readonly BindingList<Student> _allStudents;
        private readonly BindingList<Student> _enrolledStudents;
        public SubjectsStudents()
        {
            InitializeComponent();
        }

        public SubjectsStudents(Subject subject) : this()
        {
            _subject = subject;

            _allStudents = new BindingList<Student>();
            _enrolledStudents = new BindingList<Student>();

            studentsTitleLabel.Text += " " + subject.Name;
        }

        private void populateListView()
        {
            subjectsStudentsListView.Items.Clear();

            foreach (Student student in _enrolledStudents)
            {
                var listViewItem = new ListViewItem(student.Id.ToString());
                listViewItem.SubItems.Add(student.LastName);
                listViewItem.SubItems.Add(student.FirstName);
                listViewItem.SubItems.Add(student.Age.ToString());
                listViewItem.SubItems.Add(student.Gender);
                listViewItem.SubItems.Add(student.Email);
                listViewItem.SubItems.Add(student.PhoneNumber);
                listViewItem.SubItems.Add(student.YearOfStudy.Year);

                listViewItem.Tag = student;

                subjectsStudentsListView.Items.Add(listViewItem);
            }
        }

        private void loadAllStudents()
        {
            var query = "SELECT * FROM Students ORDER BY Students.LastName, Students.FirstName";

            using(var connection = new SQLiteConnection(Database.ConnectionString))
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
                        _allStudents.Add(student);
                    }
                }
            }
        }

        private void loadEnrolledStudents(Subject subject)
        {
            var query = "SELECT Students.* FROM Students " +
                        "INNER JOIN StudentsSubjects ON Students.Id = StudentsSubjects.StudentId " +
                        "WHERE StudentsSubjects.SubjectId = @subjectId " +
                        "ORDER BY Students.LastName, Students.FirstName";

            using (var connection = new SQLiteConnection(Database.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@subjectId", subject.SubjectId);

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

                        _enrolledStudents.Add(student);
                    }
                }
            }
        }

        private void SubjectsStudents_Load(object sender, EventArgs e)
        {
            try
            {
                loadAllStudents();
                loadEnrolledStudents(_subject);

                populateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //for printing

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printStudentsDocument.DefaultPageSettings;
            if(pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printStudentsDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printStudentsPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printStudentsDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Comic Sans MS", 15);
            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            format.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            var currentX = marginLeft;

            // for the header
            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight
            );

            e.Graphics.DrawString(
                "Last Name",
                font,Brushes.Black,
                new RectangleF(currentX, currentY, columnWidth, rowHeight),
                format
            );

            currentX += columnWidth;

            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight
            );

            e.Graphics.DrawString(
                "First Name",
                font, Brushes.Black,
                new RectangleF(currentX, currentY, columnWidth, rowHeight),
                format
            );

            currentX += columnWidth;

            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight
            );

            e.Graphics.DrawString(
                "Date of Birth",
                font, Brushes.Black,
                new RectangleF(currentX, currentY, columnWidth, rowHeight),
                format
            );

            currentY += rowHeight;

            foreach (Student student in _enrolledStudents)
            {
                currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    student.LastName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    format);

                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    student.FirstName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    format);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    student.DateOfBirth.ToShortDateString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    format);

                currentY += rowHeight;

                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(printStudentsDialog.ShowDialog() == DialogResult.OK)
            {
                printStudentsDocument.Print();
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
            new AddSubject().Show();
        }
    }
}
