using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;

namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay;

public class TeacherForListVm : IMapFrom<Teacher>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Category { get; set; }
    public string YearsOfTeaching { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Teacher, TeacherForListVm>()
            .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
            .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
            .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
            .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
            .ForMember(d => d.YearsOfTeaching, opt => opt.MapFrom(s => s.YearsOfTeaching));
    }
}