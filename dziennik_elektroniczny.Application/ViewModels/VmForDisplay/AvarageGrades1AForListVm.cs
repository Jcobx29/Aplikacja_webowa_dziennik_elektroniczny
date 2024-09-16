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
    public class AvarageGrades1AForListVm : IMapFrom<_1AStudent>
    {
        public int Id { get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public bool Passed => BiologyAvarage > 2 || ChemistryAvarage > 2 || EnglishAvarage > 2 ||
            GeographyAvarage > 2 || GermanAvarage > 2 || HistoryAvarage > 2 || MathAvarage > 2 ||
            ((BiologyAvarage + ChemistryAvarage + EnglishAvarage + GeographyAvarage + GermanAvarage + HistoryAvarage + MathAvarage) / 7 > 2);

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1AStudent, AvarageGrades1AForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.BiologyAvarage, opt => opt.MapFrom(s => (s._1ABiology.ShortQuizAvarage + s._1ABiology.HomeworkAvarage + s._1ABiology.TestAvarage) / 3))
                .ForMember(d => d.ChemistryAvarage, opt => opt.MapFrom(s => (s._1AChemistry.ShortQuizAvarage + s._1AChemistry.HomeworkAvarage + s._1AChemistry.TestAvarage) / 3))
                .ForMember(d => d.EnglishAvarage, opt => opt.MapFrom(s => (s._1AEnglish.ShortQuizAvarage + s._1AEnglish.HomeworkAvarage + s._1AEnglish.TestAvarage) / 3))
                .ForMember(d => d.GeographyAvarage, opt => opt.MapFrom(s => (s._1AGeography.ShortQuizAvarage + s._1AGeography.HomeworkAvarage + s._1AGeography.TestAvarage) / 3))
                .ForMember(d => d.GermanAvarage, opt => opt.MapFrom(s => (s._1AGerman.ShortQuizAvarage + s._1AGerman.HomeworkAvarage + s._1AGerman.TestAvarage) / 3))
                .ForMember(d => d.HistoryAvarage, opt => opt.MapFrom(s => (s._1AHistory.ShortQuizAvarage + s._1AHistory.HomeworkAvarage + s._1AHistory.TestAvarage) / 3))
                .ForMember(d => d.MathAvarage, opt => opt.MapFrom(s => (s._1AMath.ShortQuizAvarage + s._1AMath.HomeworkAvarage + s._1AMath.TestAvarage) / 3));
        }
    }
}
