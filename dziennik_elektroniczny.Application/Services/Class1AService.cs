using AutoMapper;
using dziennik_elektroniczny.Application.ViewModels.VmForDisplay;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using dziennik_elektroniczny.Domain.Model._1A;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Domain.Interfaces;
using AutoMapper.QueryableExtensions;

namespace dziennik_elektroniczny.Application.Services
{
    public class Class1AService : IClass1AService
    {
        private readonly IClass1ARepository _class1ARepository;
        private readonly IMapper _mapper;

        public Class1AService(IClass1ARepository class1ARepository, IMapper mapper)
        {
            _class1ARepository = class1ARepository;
            _mapper = mapper;
        }

        public ListStudentForListVm GetAllStudentsForList(int pageSize, int pageNo)
        {
            var students = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<StudentForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsToShow = students.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AList = new ListStudentForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Students = studentsToShow,
                Count = students.Count
            };
            return student1AList;
        }
    }
}
