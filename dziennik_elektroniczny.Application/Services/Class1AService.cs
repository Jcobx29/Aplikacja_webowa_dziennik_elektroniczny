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

        public ListAvarageGrades1AForListVm GetAllAvarageGradesForList(int pageSize, int pageNo)
        {
            var studentsAvarages = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<AvarageGrades1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsAvaragesToShow = studentsAvarages.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AList = new ListAvarageGrades1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                AvarageGrades1A = studentsAvaragesToShow,
                Count = studentsAvarages.Count
            };
            return student1AList;
        }

        public ListStudentsContactInfo1AForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo)
        {
            var studentsContactInfo = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<StudentsContactInfo1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsContactInfoToShow = studentsContactInfo.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AContactInfoList = new ListStudentsContactInfo1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                StudentsContactInfo1A = studentsContactInfoToShow,
                Count = studentsContactInfo.Count
            };
            return student1AContactInfoList;
        }

        public ListStudentForList1AVm GetAllStudentsForList(int pageSize, int pageNo)
        {
            var students = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<StudentForList1AVm>(_mapper.ConfigurationProvider).ToList();
            var studentsToShow = students.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AList = new ListStudentForList1AVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Students1A = studentsToShow,
                Count = students.Count
            };
            return student1AList;
        }
        public ListBiology1AForListVm GetAllBiologyForList(int pageSize, int pageNo)
        {
            var biology = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Biology1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var biologyToShow = biology.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var biology1AList = new ListBiology1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Biology1A = biologyToShow,
                Count = biology.Count
            };
            return biology1AList;
        }
        public ListChemistry1AForListVm GetAllChemistryForList(int pageSize, int pageNo)
        {
            var chemistry = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Chemistry1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var chemistryToShow = chemistry.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var chemistry1AList = new ListChemistry1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Chemistry1A = chemistryToShow,
                Count = chemistry.Count
            };
            return chemistry1AList;
        }
        public ListEnglish1AForListVm GetAllEnglishForList(int pageSize, int pageNo)
        {
            var english = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<English1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var englishToShow = english.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var english1AList = new ListEnglish1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                English1A = englishToShow,
                Count = english.Count
            };
            return english1AList;
        }
        public ListGeography1AForListVm GetAllGeographyForList(int pageSize, int pageNo)
        {
            var geography = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Geography1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var geographyToShow = geography.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var geography1AList = new ListGeography1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Geography1A = geographyToShow,
                Count = geography.Count
            };
            return geography1AList;
        }
        public ListGerman1AForListVm GetAllGermanForList(int pageSize, int pageNo)
        {
            var german = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<German1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var germanToShow = german.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var german1AList = new ListGerman1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                German1A = germanToShow,
                Count = german.Count
            };
            return german1AList;
        }
        public ListHistory1AForListVm GetAllHistoryForList(int pageSize, int pageNo)
        {
            var history = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<History1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var historyToShow = history.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var history1AList = new ListHistory1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                History1A = historyToShow,
                Count = history.Count
            };
            return history1AList;
        }
        public ListMath1AForListVm GetAllMathForList(int pageSize, int pageNo)
        {
            var math = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Math1AForListVm>(_mapper.ConfigurationProvider).ToList();
            var mathToShow = math.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var math1AList = new ListMath1AForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Math1A = mathToShow,
                Count = math.Count
            };
            return math1AList;
        }


        public EditBiology1AVm GetBiologyGradeForEdit(int id)
        {
            var biologyGrade = _class1ARepository.GetBiologyGrade(id);
            var biologyGradeVm = _mapper.Map<EditBiology1AVm>(biologyGrade);
            return biologyGradeVm;
        }

        public void UpdateBiologyGrade(EditBiology1AVm model)
        {
            var biologyGrade = _mapper.Map<_1ABiology>(model);
            _class1ARepository.UpdateBiologyGrade(biologyGrade);
        }

        public EditChemistry1AVm GetChemistryGradeForEdit(int id)
        {
            var chemistryGrade = _class1ARepository.GetChemistryGrade(id);
            var chemistryGradeVm = _mapper.Map<EditChemistry1AVm>(chemistryGrade);
            return chemistryGradeVm;
        }

        public void UpdateChemistryGrade(EditChemistry1AVm model)
        {
            var chemistryGrade = _mapper.Map<_1AChemistry>(model);
            _class1ARepository.UpdateChemistryGrade(chemistryGrade);
        }

        public EditEnglish1AVm GetEnglishGradeForEdit(int id)
        {
            var englishGrade = _class1ARepository.GetEnglishGrade(id);
            var englishGradeVm = _mapper.Map<EditEnglish1AVm>(englishGrade);
            return englishGradeVm;
        }

        public void UpdateEnglishGrade(EditEnglish1AVm model)
        {
            var englishGrade = _mapper.Map<_1AEnglish>(model);
            _class1ARepository.UpdateEnglishGrade(englishGrade);
        }

        public EditGeography1AVm GetGeographyGradeForEdit(int id)
        {
            var geographyGrade = _class1ARepository.GetGeographyGrade(id);
            var geographyGradeVm = _mapper.Map<EditGeography1AVm>(geographyGrade);
            return geographyGradeVm;
        }

        public void UpdateGeographyGrade(EditGeography1AVm model)
        {
            var geographyGrade = _mapper.Map<_1AGeography>(model);
            _class1ARepository.UpdateGeographyGrade(geographyGrade);
        }

        public EditGerman1AVm GetGermanGradeForEdit(int id)
        {
            var germanGrade = _class1ARepository.GetGermanGrade(id);
            var germanGradeVm = _mapper.Map<EditGerman1AVm>(germanGrade);
            return germanGradeVm;
        }

        public void UpdateGermanGrade(EditGerman1AVm model)
        {
            var germanGrade = _mapper.Map<_1AGerman>(model);
            _class1ARepository.UpdateGermanGrade(germanGrade);
        }

        public EditHistory1AVm GetHistoryGradeForEdit(int id)
        {
            var historyGrade = _class1ARepository.GetHistoryGrade(id);
            var historyGradeVm = _mapper.Map<EditHistory1AVm>(historyGrade);
            return historyGradeVm;
        }

        public void UpdateHistoryGrade(EditHistory1AVm model)
        {
            var historyGrade = _mapper.Map<_1AHistory>(model);
            _class1ARepository.UpdateHistoryGrade(historyGrade);
        }

        public EditMath1AVm GetMathGradeForEdit(int id)
        {
            var mathGrade = _class1ARepository.GetMathGrade(id);
            var mathGradeVm = _mapper.Map<EditMath1AVm>(mathGrade);
            return mathGradeVm;
        }

        public void UpdateMathGrade(EditMath1AVm model)
        {
            var mathGrade = _mapper.Map<_1AMath>(model);
            _class1ARepository.UpdateMathGrade(mathGrade);
        }
    }
}
