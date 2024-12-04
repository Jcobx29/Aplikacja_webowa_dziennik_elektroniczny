using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.StudentInfo
{
    public class Grades
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public double HomeworkAvarage { get; set; }
        public double ShortQuizAvarage { get; set; }
        public double TestAvarage { get; set; }
    }
}
