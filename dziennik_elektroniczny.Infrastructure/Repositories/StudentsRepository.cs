using dziennik_elektroniczny.Domain.Interfaces;
using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IQueryable<Student> GetAll1AStudentsInfo(string classId)
        {
            return _dataContext.Students.Where(p => p.ClassId == classId);
        }
        public IQueryable<Grades> GetAllGrades(string? subjectName, string classId)
        {
            return _dataContext.Grades.Where(i => i.Subject.SubjectName == subjectName && i.Student.ClassId == classId);
        }

        public Grades GetGrade(string subjectName, int studentId)
        {
            return _dataContext.Grades.FirstOrDefault(p => p.StudentId == studentId && p.Subject.SubjectName == subjectName);
        }      

        public void UpdateGrade(Grades grades)
        {
            _dataContext.Attach(grades);
            _dataContext.Entry(grades).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(grades).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(grades).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }        
    }
}
