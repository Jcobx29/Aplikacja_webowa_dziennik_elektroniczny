using dziennik_elektroniczny.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacja_webowa_dziennik_elektroniczny.Controllers;

public class TeacherController : Controller
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
        return View(model);
    }
    [HttpPost]
    public IActionResult Index(int pageSize, int? pageNo)
    {
        if (!pageNo.HasValue)
        {
            pageNo = 1;
        }
        var model = _studentsService.GetAllTeachersForList(pageSize, pageNo.Value);
        return View(model);
    }
    [HttpGet]
    public IActionResult TeacherAddresses()
    {
        var model = _studentsService.GetAllTeachersAddressesForList(10,1);
        return View(model);
    }
    [HttpPost]
    public IActionResult TeacherAddresses(int pageSize, int? pageNo)
    {
        if (!pageNo.HasValue)
        {
            pageNo = 1;
        }
        var model = _studentsService.GetAllTeachersAddressesForList(pageSize, pageNo.Value);
        return View(model);
    }
}