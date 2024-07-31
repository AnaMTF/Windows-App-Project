using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Entities
{
    public class YearOfStudy
    {
        public string Year { get; set; }
        public bool IsSupplementary { get; set; }
        public YearOfStudy(string year)
        {
            Year = year;
            if (string.Compare(year, "An suplimentar") == 0)
            {
                IsSupplementary = true;
            }
            else
            {
                IsSupplementary = false;
            }
        }
    }
}
