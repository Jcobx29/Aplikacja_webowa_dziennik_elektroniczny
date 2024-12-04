using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model;
using dziennik_elektroniczny.Domain.Model.StudentInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.ViewModels.VmForEdit
{
    public class EditGradesVm : IMapFrom<Grades>
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public double HomeworkAvarage { get; set; }
        public double ShortQuizAvarage { get; set; }
        public double TestAvarage { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EditGradesVm, Grades>()
                .ForMember(d => d.StudentId, opt => opt.MapFrom(s => s.StudentId))
                .ForMember(d => d.SubjectId, opt => opt.MapFrom(s => s.SubjectId))
                .ForMember(d => d.TestAvarage, opt => opt.MapFrom(s => s.TestAvarage))
                .ForMember(d => d.ShortQuizAvarage, opt => opt.MapFrom(s => s.ShortQuizAvarage))
                .ForMember(d => d.HomeworkAvarage, opt => opt.MapFrom(s => s.HomeworkAvarage))
                .ReverseMap();
        }
    }
}
