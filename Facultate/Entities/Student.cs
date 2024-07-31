using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Entities
{
    public class Student : Person
    {
        public YearOfStudy YearOfStudy { get; set; }

        public Student(string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber, string yearOfStudy_no)
            : base(lastName, firstName, gender, dateOfBirth, email, phoneNumber)
        {
            YearOfStudy = new YearOfStudy(yearOfStudy_no);
        }

        public Student(long id, string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber, string yearOfStudy_no)
            : base(id, lastName, firstName, gender, dateOfBirth, email, phoneNumber)
        {
            YearOfStudy = new YearOfStudy(yearOfStudy_no);
        }
    }
}
