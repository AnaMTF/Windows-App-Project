using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Entities
{
    public class Subject
    {
        public long? SubjectId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Semester { get; set; }
        public YearOfStudy YearOfStudy { get; set; }
        public bool IsOptional { get; set; }

        public Subject( string name, bool isOptional, int credits, string semester, string yearOfStudy_no)
        {
            Name = name;
            Credits = credits;
            Semester = semester;
            YearOfStudy = new YearOfStudy(yearOfStudy_no);
            IsOptional = isOptional;
        }

        public Subject(long id,string name, bool isOptional, int credits, string semester, string yearOfStudy_no)
            : this(name, isOptional, credits, semester, yearOfStudy_no)
        {
            SubjectId = id;
            YearOfStudy = new YearOfStudy(yearOfStudy_no);
        }
    }
}
