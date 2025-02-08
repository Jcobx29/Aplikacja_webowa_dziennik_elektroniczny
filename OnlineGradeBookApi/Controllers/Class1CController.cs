using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using Microsoft.AspNetCore.Mvc;

namespace OnlineGradeBookApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class Class1CController : ControllerBase
{
     private readonly IStudentsService _studentsService;
        public Class1CController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentsService.GetAllStudentsForList(10, 1, "1C");
            return Ok(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsForList(pageSize, pageNo.Value, "1C");
            return Ok(model);
        }
        [HttpGet("StudentsContactInformation")]
        public IActionResult StudentsContactInformation()
        {
            var model = _studentsService.GetAllStudentsContanctInfoForList(10, 1, "1C");
            return Ok(model);
        }
        [HttpPost("StudentsContactInformation")]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value, "1C");
            return Ok(model);
        }
        [HttpGet("StudentsAvarages")]
        public IActionResult StudentsAvarages()
        {
            var model = _studentsService.GetAllAvarageGradesForList(10, 1, "1C");
            return Ok(model);
        }
        [HttpPost("StudentsAvarages")]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllAvarageGradesForList(pageSize, pageNo.Value, "1C");
            return Ok(model);
        }
        [HttpGet("BiologyAvarages")]
        public IActionResult BiologyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 1);
            return Ok(model);
        }
        [HttpPost("BiologyAvarages")]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 1);
            return Ok(model);
        }
        [HttpGet("ChemistryAvarages")]
        public IActionResult ChemistryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 2);
            return Ok(model);
        }
        [HttpPost("ChemistryAvarages")]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 2);
            return Ok(model);
        }
        [HttpGet("EnglishAvarages")]
        public IActionResult EnglishAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 3);
            return Ok(model);
        }
        [HttpPost("EnglishAvarages")]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 3);
            return Ok(model);
        }
        [HttpGet("GeographyAvarages")]
        public IActionResult GeographyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 4);
            return Ok(model);
        }
        [HttpPost("GeographyAvarages")]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 4);
            return Ok(model);
        }
        [HttpGet("GermanAvarages")]
        public IActionResult GermanAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 5);
            return Ok(model);
        }
        [HttpPost("GermanAvarages")]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 5);
            return Ok(model);
        }
        [HttpGet("HistoryAvarages")]
        public IActionResult HistoryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 6);
            return Ok(model);
        }
        [HttpPost("HistoryAvarages")]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 6);
            return Ok(model);
        }
        [HttpGet("MathAvarages")]
        public IActionResult MathAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "1C", 7);
            return Ok(model);
        }
        [HttpPost("MathAvarages")]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "1C", 7);
            return Ok(model);
        }
        
        [HttpGet("EditBiologyGrade")]
        public IActionResult EditBiologyGrade(int studentId)
        {
            var biologyGrade = _studentsService.GetSingleGradeForEdit(studentId, 1);
            return Ok(biologyGrade);
        }
        
        [HttpPost("EditBiologyGrade")]
        public IActionResult EditBiologyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditChemistryGrade")]
        public IActionResult EditChemistryGrade(int studentId)
        {
            var chemistryGrade = _studentsService.GetSingleGradeForEdit(studentId, 2);
            return Ok(chemistryGrade);
        }
        
        [HttpPost("EditChemistryGrade")]
        public IActionResult EditChemistryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditEnglishGrade")]
        public IActionResult EditEnglishGrade(int studentId)
        {
            var englishGrade = _studentsService.GetSingleGradeForEdit(studentId, 3);
            return Ok(englishGrade);
        }
        
        [HttpPost("EditEnglishGrade")]
        public IActionResult EditEnglishGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditGeographyGrade")]
        public IActionResult EditGeographyGrade(int studentId)
        {
            var geographyGrade = _studentsService.GetSingleGradeForEdit(studentId, 4);
            return Ok(geographyGrade);
        }
        
        [HttpPost("EditGeographyGrade")]
        public IActionResult EditGeographyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditGermanGrade")]
        public IActionResult EditGermanGrade(int studentId)
        {
            var germanGrade = _studentsService.GetSingleGradeForEdit(studentId, 5);
            return Ok(germanGrade);
        }
        
        [HttpPost("EditGermanGrade")]
        public IActionResult EditGermanGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditHistoryGrade")]
        public IActionResult EditHistoryGrade(int studentId)
        {
            var historyGrade = _studentsService.GetSingleGradeForEdit(studentId, 6);
            return Ok(historyGrade);
        }
        
        [HttpPost("EditHistoryGrade")]
        public IActionResult EditHistoryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return Ok(model);
        }
        
        [HttpGet("EditMathGrade")]
        public IActionResult EditMathGrade(int studentId)
        {
            var mathGrade = _studentsService.GetSingleGradeForEdit(studentId, 7);
            return Ok(mathGrade);
        }
        
        [HttpPost("EditMathGrade")]
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