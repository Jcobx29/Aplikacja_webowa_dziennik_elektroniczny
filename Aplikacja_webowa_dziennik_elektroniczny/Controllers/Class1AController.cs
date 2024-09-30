using dziennik_elektroniczny.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace OnlineGradeBookMVC.Controllers
{
    public class Class1AController : Controller
    {
        private readonly IClass1AService _class1AService;
        public Class1AController(IClass1AService class1AService)
        {
            _class1AService = class1AService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _class1AService.GetAllStudentsForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllStudentsForList(pageSize, pageNo.Value);
            return View(model);
        }        
    }
}
