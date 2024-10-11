using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model.StudentInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay
{
    public class StudentForListVm : IMapFrom<Student>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Avarage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Student, StudentForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Avarage, opt => opt.MapFrom(s => (((s.Biology.HomeworkAvarage + s.Biology.TestAvarage + s.Biology.ShortQuizAvarage) / 3) +
                ((s.Chemistry.HomeworkAvarage + s.Chemistry.TestAvarage + s.Chemistry.ShortQuizAvarage) / 3) +
                ((s.English.HomeworkAvarage + s.English.TestAvarage + s.English.ShortQuizAvarage) / 3) +
                ((s.Geography.HomeworkAvarage + s.Geography.TestAvarage + s.Geography.ShortQuizAvarage) / 3) +
                ((s.German.HomeworkAvarage + s.German.TestAvarage + s.German.ShortQuizAvarage) / 3) +
                ((s.History.HomeworkAvarage + s.History.TestAvarage + s.History.ShortQuizAvarage) / 3) +
                ((s.Maths.HomeworkAvarage + s.Maths.TestAvarage + s.Maths.ShortQuizAvarage) / 3)) / 7));
        }
    }
}
