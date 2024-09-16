using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay
{
    public class StudentForList1AVm : IMapFrom<_1AStudent>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Avarage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1AStudent, StudentForList1AVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Avarage, opt => opt.MapFrom(s => (((s._1ABiology.HomeworkAvarage + s._1ABiology.TestAvarage + s._1ABiology.ShortQuizAvarage) / 3) +
                ((s._1AChemistry.HomeworkAvarage + s._1AChemistry.TestAvarage + s._1AChemistry.ShortQuizAvarage) / 3) +
                ((s._1AEnglish.HomeworkAvarage + s._1AEnglish.TestAvarage + s._1AEnglish.ShortQuizAvarage) / 3) +
                ((s._1AGeography.HomeworkAvarage + s._1AGeography.TestAvarage + s._1AGeography.ShortQuizAvarage) / 3) +
                ((s._1AGerman.HomeworkAvarage + s._1AGerman.TestAvarage + s._1AGerman.ShortQuizAvarage) / 3) +
                ((s._1AHistory.HomeworkAvarage + s._1AHistory.TestAvarage + s._1AHistory.ShortQuizAvarage) / 3) +
                ((s._1AMath.HomeworkAvarage + s._1AMath.TestAvarage + s._1AMath.ShortQuizAvarage) / 3)) / 7));
        }
    }
}
