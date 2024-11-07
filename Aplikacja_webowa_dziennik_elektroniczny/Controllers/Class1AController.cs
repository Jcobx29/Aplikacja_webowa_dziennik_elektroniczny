using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using Microsoft.AspNetCore.Mvc;


namespace OnlineGradeBookMVC.Controllers
{
    public class Class1AController : Controller
    {
        private readonly IStudentsService _studentsService;
        public Class1AController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentsService.GetAllStudentsForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _studentsService.GetAllStudentsContanctInfoForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _studentsService.GetAllAvarageGradesForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllAvarageGradesForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _studentsService.GetAllBiologyForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllBiologyForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _studentsService.GetAllChemistryForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllChemistryForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _studentsService.GetAllEnglishForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllEnglishForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _studentsService.GetAllGeographyForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGeographyForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _studentsService.GetAllGermanForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGermanForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _studentsService.GetAllHistoryForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllHistoryForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _studentsService.GetAllMathForList(10, 1, "1A");
            return View(model);
        }
        [HttpPost]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllMathForList(pageSize, pageNo.Value, "1A");
            return View(model);
        }

        [HttpGet]
        public IActionResult EditBiologyGrade(int id)
        {
            var biologyGrade = _studentsService.GetBiologyGradeForEdit(id);
            return View(biologyGrade);
        }
        [HttpPost]
        public IActionResult EditBiologyGrade(EditBiologyVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateBiologyGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditChemistryGrade(int id)
        {
            var chemistryGrade = _studentsService.GetChemistryGradeForEdit(id);
            return View(chemistryGrade);
        }
        [HttpPost]
        public IActionResult EditChemistryGrade(EditChemistryVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateChemistryGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEnglishGrade(int id)
        {
            var englishGrade = _studentsService.GetEnglishGradeForEdit(id);
            return View(englishGrade);
        }
        [HttpPost]
        public IActionResult EditEnglishGrade(EditEnglishVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateEnglishGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGeographyGrade(int id)
        {
            var geographyGrade = _studentsService.GetGeographyGradeForEdit(id);
            return View(geographyGrade);
        }
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGeographyVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateGeographyGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGermanGrade(int id)
        {
            var germanGrade = _studentsService.GetGermanGradeForEdit(id);
            return View(germanGrade);
        }
        [HttpPost]
        public IActionResult EditGermanGrade(EditGermanVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateGermanGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditHistoryGrade(int id)
        {
            var historyGrade = _studentsService.GetHistoryGradeForEdit(id);
            return View(historyGrade);
        }
        [HttpPost]
        public IActionResult EditHistoryGrade(EditHistoryVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateHistoryGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditMathGrade(int id)
        {
            var mathGrade = _studentsService.GetMathGradeForEdit(id);
            return View(mathGrade);
        }
        [HttpPost]
        public IActionResult EditMathGrade(EditMathVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateMathGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }
    }
}
