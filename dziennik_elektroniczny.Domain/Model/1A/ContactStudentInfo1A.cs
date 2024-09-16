using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model
{
    public class ContactStudentInfo1A
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int StudentRef { get; set; }
        public _1AStudent _1AStudent { get; set; }
    }
}
