using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;

namespace dziennik_elektroniczny.Domain.Interfaces
{
    public interface IStudentsRepository
    {
        IQueryable<Student> GetAllStudentsInfo(string classId);
        IQueryable<Grades> GetAllGrades();
        IQueryable<Grades> GetAllGradesDetails(string classId, int subjectId);
        Grades GetSingleGrade(int studentId, int subjectId);
        void UpdateSingleGrade(Grades grades);
        public IQueryable<Teacher> GetAllTeachersInfo();
    }
}
