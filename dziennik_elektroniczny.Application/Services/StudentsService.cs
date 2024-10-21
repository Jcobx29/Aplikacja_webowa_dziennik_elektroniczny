using AutoMapper;
using dziennik_elektroniczny.Application.ViewModels.VmForDisplay;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using dziennik_elektroniczny.Domain.Model.StudentInfo;
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
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IMapper _mapper;

        public StudentsService(IStudentsRepository studentsRepository, IMapper mapper)
        {
            _studentsRepository = studentsRepository;
            _mapper = mapper;
        }

        public ListStudentForListVm GetAllStudentsForList(int pageSize, int pageNo, string classId)
        {
            var students = _studentsRepository.GetAll1AStudentsInfo(classId)
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
        public ListAvarageGradesForListVm GetAllAvarageGradesForList(int pageSize, int pageNo, string classId)
        {
            var studentsAvarages = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<AvarageGradesForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsAvaragesToShow = studentsAvarages.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AList = new ListAvarageGradesForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                AvarageGrades = studentsAvaragesToShow,
                Count = studentsAvarages.Count
            };
            return student1AList;
        }

        public ListStudentsContactInfoForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo, string classId)
        {
            var studentsContactInfo = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<StudentsContactInfoForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsContactInfoToShow = studentsContactInfo.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1AContactInfoList = new ListStudentsContactInfoForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                StudentsContactInfo = studentsContactInfoToShow,
                Count = studentsContactInfo.Count
            };
            return student1AContactInfoList;
        }
        public ListBiologyForListVm GetAllBiologyForList(int pageSize, int pageNo, string classId)
        {
            var biology = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<BiologyForListVm>(_mapper.ConfigurationProvider).ToList();
            var biologyToShow = biology.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var biology1AList = new ListBiologyForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Biology = biologyToShow,
                Count = biology.Count
            };
            return biology1AList;
        }
        public ListChemistryForListVm GetAllChemistryForList(int pageSize, int pageNo, string classId)
        {
            var chemistry = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<ChemistryForListVm>(_mapper.ConfigurationProvider).ToList();
            var chemistryToShow = chemistry.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var chemistry1AList = new ListChemistryForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Chemistry = chemistryToShow,
                Count = chemistry.Count
            };
            return chemistry1AList;
        }
        public ListEnglishForListVm GetAllEnglishForList(int pageSize, int pageNo, string classId)
        {
            var english = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<EnglishForListVm>(_mapper.ConfigurationProvider).ToList();
            var englishToShow = english.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var english1AList = new ListEnglishForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                English = englishToShow,
                Count = english.Count
            };
            return english1AList;
        }
        public ListGeographyForListVm GetAllGeographyForList(int pageSize, int pageNo, string classId)
        {
            var geography = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<GeographyForListVm>(_mapper.ConfigurationProvider).ToList();
            var geographyToShow = geography.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var geography1AList = new ListGeographyForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Geography = geographyToShow,
                Count = geography.Count
            };
            return geography1AList;
        }
        public ListGermanForListVm GetAllGermanForList(int pageSize, int pageNo, string classId)
        {
            var german = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<GermanForListVm>(_mapper.ConfigurationProvider).ToList();
            var germanToShow = german.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var german1AList = new ListGermanForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                German = germanToShow,
                Count = german.Count
            };
            return german1AList;
        }
        public ListHistoryForListVm GetAllHistoryForList(int pageSize, int pageNo, string classId)
        {
            var history = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<HistoryForListVm>(_mapper.ConfigurationProvider).ToList();
            var historyToShow = history.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var history1AList = new ListHistoryForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                History = historyToShow,
                Count = history.Count
            };
            return history1AList;
        }
        public ListMathForListVm GetAllMathForList(int pageSize, int pageNo, string classId)
        {
            var math = _studentsRepository.GetAll1AStudentsInfo(classId)
                .ProjectTo<MathForListVm>(_mapper.ConfigurationProvider).ToList();
            var mathToShow = math.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var math1AList = new ListMathForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Maths = mathToShow,
                Count = math.Count
            };
            return math1AList;
        }


        public EditBiologyVm GetBiologyGradeForEdit(int id)
        {
            var biologyGrade = _studentsRepository.GetBiologyGrade(id);
            var biologyGradeVm = _mapper.Map<EditBiologyVm>(biologyGrade);
            return biologyGradeVm;
        }

        public void UpdateBiologyGrade(EditBiologyVm model)
        {
            var biologyGrade = _mapper.Map<Biology>(model);
            _studentsRepository.UpdateBiologyGrade(biologyGrade);
        }

        public EditChemistryVm GetChemistryGradeForEdit(int id)
        {
            var chemistryGrade = _studentsRepository.GetChemistryGrade(id);
            var chemistryGradeVm = _mapper.Map<EditChemistryVm>(chemistryGrade);
            return chemistryGradeVm;
        }

        public void UpdateChemistryGrade(EditChemistryVm model)
        {
            var chemistryGrade = _mapper.Map<Chemistry>(model);
            _studentsRepository.UpdateChemistryGrade(chemistryGrade);
        }

        public EditEnglishVm GetEnglishGradeForEdit(int id)
        {
            var englishGrade = _studentsRepository.GetEnglishGrade(id);
            var englishGradeVm = _mapper.Map<EditEnglishVm>(englishGrade);
            return englishGradeVm;
        }

        public void UpdateEnglishGrade(EditEnglishVm model)
        {
            var englishGrade = _mapper.Map<English>(model);
            _studentsRepository.UpdateEnglishGrade(englishGrade);
        }

        public EditGeographyVm GetGeographyGradeForEdit(int id)
        {
            var geographyGrade = _studentsRepository.GetGeographyGrade(id);
            var geographyGradeVm = _mapper.Map<EditGeographyVm>(geographyGrade);
            return geographyGradeVm;
        }

        public void UpdateGeographyGrade(EditGeographyVm model)
        {
            var geographyGrade = _mapper.Map<Geography>(model);
            _studentsRepository.UpdateGeographyGrade(geographyGrade);
        }

        public EditGermanVm GetGermanGradeForEdit(int id)
        {
            var germanGrade = _studentsRepository.GetGermanGrade(id);
            var germanGradeVm = _mapper.Map<EditGermanVm>(germanGrade);
            return germanGradeVm;
        }

        public void UpdateGermanGrade(EditGermanVm model)
        {
            var germanGrade = _mapper.Map<German>(model);
            _studentsRepository.UpdateGermanGrade(germanGrade);
        }

        public EditHistoryVm GetHistoryGradeForEdit(int id)
        {
            var historyGrade = _studentsRepository.GetHistoryGrade(id);
            var historyGradeVm = _mapper.Map<EditHistoryVm>(historyGrade);
            return historyGradeVm;
        }

        public void UpdateHistoryGrade(EditHistoryVm model)
        {
            var historyGrade = _mapper.Map<History>(model);
            _studentsRepository.UpdateHistoryGrade(historyGrade);
        }

        public EditMathVm GetMathGradeForEdit(int id)
        {
            var mathGrade = _studentsRepository.GetMathGrade(id);
            var mathGradeVm = _mapper.Map<EditMathVm>(mathGrade);
            return mathGradeVm;
        }

        public void UpdateMathGrade(EditMathVm model)
        {
            var mathGrade = _mapper.Map<Maths>(model);
            _studentsRepository.UpdateMathGrade(mathGrade);
        }
    }
}
