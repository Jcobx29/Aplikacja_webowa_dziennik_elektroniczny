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
        ListStudentForListVm GetAllStudentsForList(int pageSize, int pageNo);

    }
}
