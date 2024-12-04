using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.StudentInfo
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassId { get; set; }
        public ContactStudentInfo ContactStudentInfo { get; set; }
        public ICollection<Grades> Grades { get; set; }
    }
}
