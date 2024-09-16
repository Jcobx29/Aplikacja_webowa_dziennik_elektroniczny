using dziennik_elektroniczny.Application.ViewModels.VmForDisplay;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.Interfaces
{
    public interface IClass1AService
    {
        ListStudentForList1AVm GetAllStudentsForList(int pageSize, int pageNo);
        ListAvarageGrades1AForListVm GetAllAvarageGradesForList(int pageSize, int pageNo);
        ListStudentsContactInfo1AForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo);
        ListBiology1AForListVm GetAllBiologyForList(int pageSize, int pageNo);
        ListChemistry1AForListVm GetAllChemistryForList(int pageSize, int pageNo);
        ListEnglish1AForListVm GetAllEnglishForList(int pageSize, int pageNo);
        ListGeography1AForListVm GetAllGeographyForList(int pageSize, int pageNo);
        ListGerman1AForListVm GetAllGermanForList(int pageSize, int pageNo);
        ListHistory1AForListVm GetAllHistoryForList(int pageSize, int pageNo);
        ListMath1AForListVm GetAllMathForList(int pageSize, int pageNo);
        EditBiology1AVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(EditBiology1AVm model);
        EditChemistry1AVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(EditChemistry1AVm model);
        EditEnglish1AVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(EditEnglish1AVm model);
        EditGeography1AVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(EditGeography1AVm model);
        EditGerman1AVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(EditGerman1AVm model);
        EditHistory1AVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(EditHistory1AVm model);
        EditMath1AVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(EditMath1AVm model);
    }
}
