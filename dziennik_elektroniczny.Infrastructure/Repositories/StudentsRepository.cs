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

        public Biology GetBiologyGrade(int gradeId)
        {
            return _dataContext.Biology.FirstOrDefault(p => p.Id == gradeId);
        }

        public Chemistry GetChemistryGrade(int gradeId)
        {
            return _dataContext.Chemistry.FirstOrDefault(p => p.Id == gradeId);
        }

        public English GetEnglishGrade(int gradeId)
        {
            return _dataContext.English.FirstOrDefault(p => p.Id == gradeId);
        }

        public Geography GetGeographyGrade(int gradeId)
        {
            return _dataContext.Geography.FirstOrDefault(p => p.Id == gradeId);
        }

        public German GetGermanGrade(int gradeId)
        {
            return _dataContext.German.FirstOrDefault(p => p.Id == gradeId);
        }

        public History GetHistoryGrade(int gradeId)
        {
            return _dataContext.History.FirstOrDefault(p => p.Id == gradeId);
        }

        public Maths GetMathGrade(int gradeId)
        {
            return _dataContext.Maths.FirstOrDefault(p => p.Id == gradeId);
        }

        public void UpdateBiologyGrade(Biology biology)
        {
            _dataContext.Attach(biology);
            _dataContext.Entry(biology).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateChemistryGrade(Chemistry chemistry)
        {
            _dataContext.Attach(chemistry);
            _dataContext.Entry(chemistry).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateEnglishGrade(English english)
        {
            _dataContext.Attach(english);
            _dataContext.Entry(english).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(english).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(english).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGeographyGrade(Geography geography)
        {
            _dataContext.Attach(geography);
            _dataContext.Entry(geography).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGermanGrade(German german)
        {
            _dataContext.Attach(german);
            _dataContext.Entry(german).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(german).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(german).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateHistoryGrade(History history)
        {
            _dataContext.Attach(history);
            _dataContext.Entry(history).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(history).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(history).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateMathGrade(Maths math)
        {
            _dataContext.Attach(math);
            _dataContext.Entry(math).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(math).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(math).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }
    }
}
