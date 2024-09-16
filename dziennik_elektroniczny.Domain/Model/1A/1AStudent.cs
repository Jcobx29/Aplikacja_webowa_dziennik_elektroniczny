using dziennik_elektroniczny.Domain.Model._1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model
{
    public class _1AStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo1A ContactStudentInfo1A { get; set; }
        public _1ABiology _1ABiology { get; set; }
        public _1AChemistry _1AChemistry { get; set; }
        public _1AEnglish _1AEnglish { get; set; }
        public _1AGeography _1AGeography { get; set; }
        public _1AGerman _1AGerman { get; set; }
        public _1AHistory _1AHistory { get; set; }
        public _1AMath _1AMath { get; set; }
    }
}
