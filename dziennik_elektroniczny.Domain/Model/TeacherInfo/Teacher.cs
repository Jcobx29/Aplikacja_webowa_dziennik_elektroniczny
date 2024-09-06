using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Infrastructure.Model.TeacherInfo
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Category { get; set; }
        public string YearsOfTeaching { get; set; }
        public TeacherContactInfo TeacherContactInfo { get; set; }
        public TeacherAddress TeacherAddress { get; set; }
    }
}
