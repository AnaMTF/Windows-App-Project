using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Entities
{
    public abstract class Person
    {
        public long? Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        protected Person(string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        protected Person(long id, string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber)
            : this(lastName, firstName, gender, dateOfBirth, email, phoneNumber)
        {
            Id = id;
        }
    }
}
