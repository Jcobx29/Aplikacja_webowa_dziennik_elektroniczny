using dziennik_elektroniczny.Application.ViewModels.VmForDisplay;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.Interfaces
{
    public interface IStudentsService
    {
        ListStudentForListVm GetAllStudentsForList(int pageSize, int pageNo, string classId);
        ListAvarageGradesForListVm GetAllAvarageGradesForList(int pageSize, int pageNo, string classId);
        ListStudentsContactInfoForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo, string classId);
        ListBiologyForListVm GetAllBiologyForList(int pageSize, int pageNo);
        ListChemistryForListVm GetAllChemistryForList(int pageSize, int pageNo, string classId);
        ListEnglishForListVm GetAllEnglishForList(int pageSize, int pageNo, string classId);
        ListGeographyForListVm GetAllGeographyForList(int pageSize, int pageNo, string classId);
        ListGermanForListVm GetAllGermanForList(int pageSize, int pageNo, string classId);
        ListHistoryForListVm GetAllHistoryForList(int pageSize, int pageNo, string classId);
        ListMathForListVm GetAllMathForList(int pageSize, int pageNo, string classId);
        EditBiologyVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(EditBiologyVm model);
        EditChemistryVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(EditChemistryVm model);
        EditEnglishVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(EditEnglishVm model);
        EditGeographyVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(EditGeographyVm model);
        EditGermanVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(EditGermanVm model);
        EditHistoryVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(EditHistoryVm model);
        EditMathVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(EditMathVm model);
    }
}
