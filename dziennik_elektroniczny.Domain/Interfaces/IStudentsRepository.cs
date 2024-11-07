using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Interfaces
{
    public interface IStudentsRepository
    {
        IQueryable<Student> GetAll1AStudentsInfo(string classId);
        IQueryable<Grades> GetAllGrades(string? subjectId, string classId);
        Grades GetGrade(string subjectName, int studentId);
        void UpdateGrade(Grades grades);
    }
}
