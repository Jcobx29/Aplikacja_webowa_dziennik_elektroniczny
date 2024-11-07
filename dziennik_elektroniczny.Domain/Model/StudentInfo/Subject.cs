using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.StudentInfo
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public ICollection<Grades> Grades { get; set; }
    }
}
