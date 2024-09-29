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

        public IQueryable<Student> GetAll1AStudentsInfo()
        {
            return _dataContext._1AStudents;
        }
    }
}
