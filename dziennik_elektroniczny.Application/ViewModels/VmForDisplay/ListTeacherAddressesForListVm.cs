namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay;

public class ListTeacherAddressesForListVm
{
    public List<TeacherAddressesForListVm> TeacherAddresses { get; set; }
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int Count { get; set; }
}