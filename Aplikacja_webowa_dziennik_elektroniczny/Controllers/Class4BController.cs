using dziennik_elektroniczny.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacja_webowa_dziennik_elektroniczny.Controllers
{
    public class Class4BController : Controller
    {
        private readonly IStudentsService _studentService;
        public Class4BController(IStudentsService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
