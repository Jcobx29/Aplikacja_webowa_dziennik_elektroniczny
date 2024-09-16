using dziennik_elektroniczny.Domain.Model._1A;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Interfaces
{
    public interface IClass1ARepository
    {
        IQueryable<_1AStudent> GetAll1AStudentsInfo();
        _1ABiology GetBiologyGrade(int gradeid);
        void UpdateBiologyGrade(_1ABiology biology);
        _1AChemistry GetChemistryGrade(int gradeid);
        void UpdateChemistryGrade(_1AChemistry chemistry);
        _1AEnglish GetEnglishGrade(int gradeid);
        void UpdateEnglishGrade(_1AEnglish english);
        _1AGeography GetGeographyGrade(int gradeid);
        void UpdateGeographyGrade(_1AGeography geography);
        _1AGerman GetGermanGrade(int gradeid);
        void UpdateGermanGrade(_1AGerman german);
        _1AHistory GetHistoryGrade(int gradeid);
        void UpdateHistoryGrade(_1AHistory history);
        _1AMath GetMathGrade(int gradeid);
        void UpdateMathGrade(_1AMath math);
    }
}
