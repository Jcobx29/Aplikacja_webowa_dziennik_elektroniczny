using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using Microsoft.AspNetCore.Mvc;

namespace OnlineGradeBookApi.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class Class3CController : Controller
{
    private readonly IStudentsService _studentsService;
        public Class3CController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentsService.GetAllStudentsForList(10, 1, "3C");
            return Ok(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsForList(pageSize, pageNo.Value, "3C");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _studentsService.GetAllStudentsContanctInfoForList(10, 1, "3C");
            return Ok(model);
        }
        [HttpPost]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value, "3C");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _studentsService.GetAllAvarageGradesForList(10, 1, "3C");
            return Ok(model);
        }
        [HttpPost]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllAvarageGradesForList(pageSize, pageNo.Value, "3C");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C",1);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C",1);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 2);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 2);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 3);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 3);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 4);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 4);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 5);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 5);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 6);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 6);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "3C", 7);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "3C", 7);
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditBiologyGrade(int studentId)
        {
            var biologyGrade = _studentsService.GetSingleGradeForEdit(studentId, 1);
            return Ok(biologyGrade);
        }
        
        [HttpPost]
        public IActionResult EditBiologyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditChemistryGrade(int studentId)
        {
            var chemistryGrade = _studentsService.GetSingleGradeForEdit(studentId, 2);
            return Ok(chemistryGrade);
        }
        
        [HttpPost]
        public IActionResult EditChemistryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditEnglishGrade(int studentId)
        {
            var englishGrade = _studentsService.GetSingleGradeForEdit(studentId, 3);
            return Ok(englishGrade);
        }
        
        [HttpPost]
        public IActionResult EditEnglishGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditGeographyGrade(int studentId)
        {
            var geographyGrade = _studentsService.GetSingleGradeForEdit(studentId, 4);
            return Ok(geographyGrade);
        }
        
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditGermanGrade(int studentId)
        {
            var germanGrade = _studentsService.GetSingleGradeForEdit(studentId, 5);
            return Ok(germanGrade);
        }
        
        [HttpPost]
        public IActionResult EditGermanGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditHistoryGrade(int studentId)
        {
            var historyGrade = _studentsService.GetSingleGradeForEdit(studentId, 6);
            return Ok(historyGrade);
        }
        
        [HttpPost]
        public IActionResult EditHistoryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult EditMathGrade(int studentId)
        {
            var mathGrade = _studentsService.GetSingleGradeForEdit(studentId, 7);
            return Ok(mathGrade);
        }
        
        [HttpPost]
        public IActionResult EditMathGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return Ok(model);
        }
}