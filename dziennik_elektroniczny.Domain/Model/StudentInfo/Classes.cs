using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.StudentInfo
{
    public class Classes
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Student Student { get; set; }
    }
}
