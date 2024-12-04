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
        ListGradesForListVm GetAllGradesForList(int pageSize, int pageNo, string classId, int subjectId);
        EditGradesVm GetSingleGradeForEdit(int studentId, int subjectId);
        void UpdateSingleGrade(EditGradesVm model);
    }
}
