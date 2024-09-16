using dziennik_elektroniczny.Domain.Interfaces;
using dziennik_elektroniczny.Domain.Model._1A;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Infrastructure.Repositories
{
    public class Class1ARepository : IClass1ARepository
    {
        private readonly DataContext _dataContext;
        public Class1ARepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<_1AStudent> GetAll1AStudentsInfo()
        {
            return _dataContext._1AStudents;
        }

        public _1ABiology GetBiologyGrade(int gradeId)
        {
            return _dataContext._1ABiology.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AChemistry GetChemistryGrade(int gradeId)
        {
            return _dataContext._1AChemistry.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AEnglish GetEnglishGrade(int gradeId)
        {
            return _dataContext._1AEnglish.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AGeography GetGeographyGrade(int gradeId)
        {
            return _dataContext._1AGeography.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AGerman GetGermanGrade(int gradeId)
        {
            return _dataContext._1AGerman.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AHistory GetHistoryGrade(int gradeId)
        {
            return _dataContext._1AHistory.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1AMath GetMathGrade(int gradeId)
        {
            return _dataContext._1AMath.FirstOrDefault(p => p.Id == gradeId);
        }

        public void UpdateBiologyGrade(_1ABiology biology)
        {
            _dataContext.Attach(biology);
            _dataContext.Entry(biology).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateChemistryGrade(_1AChemistry chemistry)
        {
            _dataContext.Attach(chemistry);
            _dataContext.Entry(chemistry).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateEnglishGrade(_1AEnglish english)
        {
            _dataContext.Attach(english);
            _dataContext.Entry(english).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(english).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(english).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGeographyGrade(_1AGeography geography)
        {
            _dataContext.Attach(geography);
            _dataContext.Entry(geography).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGermanGrade(_1AGerman german)
        {
            _dataContext.Attach(german);
            _dataContext.Entry(german).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(german).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(german).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateHistoryGrade(_1AHistory history)
        {
            _dataContext.Attach(history);
            _dataContext.Entry(history).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(history).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(history).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateMathGrade(_1AMath math)
        {
            _dataContext.Attach(math);
            _dataContext.Entry(math).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(math).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(math).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }
    }
}
