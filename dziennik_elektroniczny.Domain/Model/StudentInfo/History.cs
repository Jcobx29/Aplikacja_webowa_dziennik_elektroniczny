using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.StudentInfo
{
    public class History
    {
        public int Id { get; set; }
        public double TestAvarage { get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public Student Student { get; set; }
        public int StudentRef { get; set; }
    }
}
