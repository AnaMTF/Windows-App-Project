using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Entities
{
    public class Teacher : Person
    {
        public Teacher(string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber)
            : base(lastName, firstName, gender, dateOfBirth, email, phoneNumber)
        {
        }

        public Teacher(long id, string lastName, string firstName, string gender, DateTime dateOfBirth, string email, string phoneNumber)
            : base(id, lastName, firstName, gender, dateOfBirth, email, phoneNumber)
        {
        }
    }
}
