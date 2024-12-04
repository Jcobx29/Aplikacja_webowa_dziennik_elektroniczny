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
            var students = _studentsRepository.GetAllStudentsInfo(classId);
            ListStudentForListVm result = new ListStudentForListVm();
            result.Students = new List<StudentForListVm>();
            double avarage = 0;
            foreach (var student in students)
            {                
                var grade = student.Grades.Where(s => s.StudentId == student.Id);
                int subjectCount = 0;
                bool passed = false;
                foreach (var grades in grade)
                {                    
                    double subjectAvarage = (grades.ShortQuizAvarage + grades.HomeworkAvarage + grades.TestAvarage)/3;
                    avarage += subjectAvarage;
                    subjectCount++;
                }
                avarage = avarage / subjectCount;
                if(avarage >= 2)
                {
                    passed = true;
                }
                var studentVm = new StudentForListVm()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Avarage = avarage,
                    Passed = passed
                };
                result.Students.Add(studentVm);
                avarage = 0;
                subjectCount = 0;
            }
            result.PageSize = pageSize;
            result.CurrentPage = pageNo;
            result.Count = result.Students.Count;
            return result;
        }
        public ListAvarageGradesForListVm GetAllAvarageGradesForList(int pageSize, int pageNo, string classId)
        {
            var avarageGrades = _studentsRepository.GetAllStudentsInfo(classId);
            ListAvarageGradesForListVm result = new ListAvarageGradesForListVm();
            result.AvarageGrades = new List<AvarageGradesForListVm>();         
            foreach (var avarageGrade in avarageGrades)
            {
                double[] subjectAvaragesArray = new double[7];
                var grade = avarageGrade.Grades.Where(s => s.StudentId == avarageGrade.Id);
                int i = 0;
                foreach (var grades in grade)
                {
                    double subjectAvarage = (grades.ShortQuizAvarage + grades.HomeworkAvarage + grades.TestAvarage) / 3;
                    subjectAvaragesArray[i] = subjectAvarage;
                    i++;
                }
                var avarageVm = new AvarageGradesForListVm()
                {
                    Id = avarageGrade.Id,
                    BiologyAvarage = subjectAvaragesArray[0],
                    ChemistryAvarage = subjectAvaragesArray[1],
                    EnglishAvarage = subjectAvaragesArray[2],
                    GeographyAvarage = subjectAvaragesArray[3],
                    GermanAvarage = subjectAvaragesArray[4],
                    HistoryAvarage = subjectAvaragesArray[5],
                    MathAvarage = subjectAvaragesArray[6]
                };
                result.AvarageGrades.Add(avarageVm);
            }
            result.PageSize = pageSize;
            result.CurrentPage = pageNo;
            result.Count = result.AvarageGrades.Count;
            return result;
        }

        public ListStudentsContactInfoForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo, string classId)
        {
            var studentsContactInfo = _studentsRepository.GetAllStudentsInfo(classId)
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
        public ListGradesForListVm GetAllGradesForList(int pageSize, int pageNo, string classId, int subjectId)
        {
            var grades = _studentsRepository.GetAllGradesDetails(classId, subjectId)
                .ProjectTo<GradesForListVm>(_mapper.ConfigurationProvider).ToList();
            var gradesToShow = grades.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var gradesList = new ListGradesForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Grades = gradesToShow,
                Count = grades.Count
            };
            return gradesList;
        }      
        public EditGradesVm GetSingleGradeForEdit(int studentId, int subjectId)
        {
            var singleGrade = _studentsRepository.GetSingleGrade(studentId, subjectId);
            var singleGradeVm = _mapper.Map<EditGradesVm>(singleGrade);
            return singleGradeVm;
        }

        public void UpdateSingleGrade(EditGradesVm model)
        {
            var singleGrade = _mapper.Map<Grades>(model);
            _studentsRepository.UpdateSingleGrade(singleGrade);
        }
    }
}
