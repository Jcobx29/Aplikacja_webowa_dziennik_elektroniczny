namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay;

public class ListTeachersForListVm
{
    public List<TeacherForListVm> Teachers { get; set; }
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int Count { get; set; }
}