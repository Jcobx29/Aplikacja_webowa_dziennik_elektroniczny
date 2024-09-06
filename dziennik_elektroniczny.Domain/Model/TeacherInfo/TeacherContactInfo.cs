using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Infrastructure.Model.TeacherInfo
{
    public class TeacherContactInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TeacherRef { get; set; }
        public Teacher Teacher { get; set; }
    }
}
