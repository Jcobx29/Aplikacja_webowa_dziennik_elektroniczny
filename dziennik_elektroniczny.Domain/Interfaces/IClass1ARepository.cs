using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Interfaces
{
    public interface IClass1ARepository
    {
        IQueryable<Student> GetAll1AStudentsInfo();
    }
}
