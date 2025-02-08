using dziennik_elektroniczny.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OnlineGradeBookApi.Controllers;
[ApiController]
[Route("[controller]/[action]")]

public class TeacherController : ControllerBase
{
    private readonly IStudentsService _studentsService;
    public TeacherController(IStudentsService studentsService)
    {
        _studentsService = studentsService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var model = _studentsService.GetAllTeachersForList(10,1);
        return Ok(model);
    }
    [HttpPost]
    public IActionResult Index(int pageSize, int? pageNo)
    {
        if (!pageNo.HasValue)
        {
            pageNo = 1;
        }
        var model = _studentsService.GetAllTeachersForList(pageSize, pageNo.Value);
        return Ok(model);
    }
    [HttpGet]
    public IActionResult TeacherAddresses()
    {
        var model = _studentsService.GetAllTeachersAddressesForList(10,1);
        return Ok(model);
    }
    [HttpPost]
    public IActionResult TeacherAddresses(int pageSize, int? pageNo)
    {
        if (!pageNo.HasValue)
        {
            pageNo = 1;
        }
        var model = _studentsService.GetAllTeachersAddressesForList(pageSize, pageNo.Value);
        return Ok(model);
    }
}