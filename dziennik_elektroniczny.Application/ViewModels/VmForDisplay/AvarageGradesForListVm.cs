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
    public class AvarageGradesForListVm : IMapFrom<Student>
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
            profile.CreateMap<Student, AvarageGradesForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.BiologyAvarage, opt => opt.MapFrom(s => (s.Biology.ShortQuizAvarage + s.Biology.HomeworkAvarage + s.Biology.TestAvarage) / 3))
                .ForMember(d => d.ChemistryAvarage, opt => opt.MapFrom(s => (s.Chemistry.ShortQuizAvarage + s.Chemistry.HomeworkAvarage + s.Chemistry.TestAvarage) / 3))
                .ForMember(d => d.EnglishAvarage, opt => opt.MapFrom(s => (s.English.ShortQuizAvarage + s.English.HomeworkAvarage + s.English.TestAvarage) / 3))
                .ForMember(d => d.GeographyAvarage, opt => opt.MapFrom(s => (s.Geography.ShortQuizAvarage + s.Geography.HomeworkAvarage + s.Geography.TestAvarage) / 3))
                .ForMember(d => d.GermanAvarage, opt => opt.MapFrom(s => (s.German.ShortQuizAvarage + s.German.HomeworkAvarage + s.German.TestAvarage) / 3))
                .ForMember(d => d.HistoryAvarage, opt => opt.MapFrom(s => (s.History.ShortQuizAvarage + s.History.HomeworkAvarage + s.History.TestAvarage) / 3))
                .ForMember(d => d.MathAvarage, opt => opt.MapFrom(s => (s.Math.ShortQuizAvarage + s.Math.HomeworkAvarage + s.Math.TestAvarage) / 3));
        }
    }
}
