using AutoMapper;
using dziennik_elektroniczny.Application.Mapping;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;

namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay;

public class TeacherAddressesForListVm : IMapFrom<Teacher>
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HomeNumber { get; set; }
    public string ZipCode { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Teacher, TeacherAddressesForListVm>()
            .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
            .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
            .ForMember(d => d.City, opt => opt.MapFrom(s => s.TeacherAddress.City))
            .ForMember(d => d.Street, opt => opt.MapFrom(s => s.TeacherAddress.Street))
            .ForMember(d => d.HomeNumber, opt => opt.MapFrom(s => s.TeacherAddress.HomeNumber))
            .ForMember(d => d.ZipCode, opt => opt.MapFrom(s => s.TeacherAddress.ZipCode));
    }
}