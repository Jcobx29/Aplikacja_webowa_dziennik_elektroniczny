using dziennik_elektroniczny.Domain.Model.StudentInfo;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Interfaces
{
    public interface IStudentsRepository
    {
        IQueryable<Student> GetAllStudentsInfo(string classId);
        IQueryable<Grades> GetAllGrades();
        IQueryable<Grades> GetAllGradesDetails(string classId, int subjectId);
        Grades GetSingleGrade(int studentId, int subjectId);
        void UpdateSingleGrade(Grades grades);
        Chemistry GetChemistryGrade(int gradeid);
        void UpdateChemistryGrade(Chemistry chemistry);
        English GetEnglishGrade(int gradeid);
        void UpdateEnglishGrade(English english);
        Geography GetGeographyGrade(int gradeid);
        void UpdateGeographyGrade(Geography geography);
        German GetGermanGrade(int gradeid);
        void UpdateGermanGrade(German german);
        History GetHistoryGrade(int gradeid);
        void UpdateHistoryGrade(History history);
        Maths GetMathGrade(int gradeid);
        void UpdateMathGrade(Maths math);
    }
}
