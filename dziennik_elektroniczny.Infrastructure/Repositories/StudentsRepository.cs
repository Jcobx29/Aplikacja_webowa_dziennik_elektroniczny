using dziennik_elektroniczny.Domain.Interfaces;
using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;
using Microsoft.EntityFrameworkCore;

namespace dziennik_elektroniczny.Infrastructure.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly DataContext _dataContext;
        public StudentsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Student> GetAllStudentsInfo(string classId)
        {            
            return _dataContext.Students.Where(p => p.ClassId == classId).Include(s => s.Grades);
        }
        public IQueryable<Grades> GetAllGrades()
        {
            return _dataContext.Grades;
        }
        public IQueryable<Grades> GetAllGradesDetails(string classId, int subjectId)
        {
            return _dataContext.Grades.Where(p => p.Student.ClassId == classId && p.SubjectId == subjectId);
        }
        public Grades GetSingleGrade(int studentId, int subjectId)
        {
            return _dataContext.Grades.FirstOrDefault(p => p.StudentId == studentId && p.SubjectId == subjectId);
        }
        public void UpdateSingleGrade(Grades grade)
        {
            _dataContext.Attach(grade);
            _dataContext.Entry(grade).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(grade).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(grade).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }
        public IQueryable<Teacher> GetAllTeachersInfo()
        {
            return _dataContext.Teachers;
        }
    }
}
