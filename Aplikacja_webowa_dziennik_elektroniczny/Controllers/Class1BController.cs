using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacja_webowa_dziennik_elektroniczny.Controllers
{
    public class Class1BController : Controller
    {
        private readonly IStudentsService _class1AService;
        public Class1BController(IStudentsService class1AService)
        {
            _class1AService = class1AService;
        }       
        [HttpGet]
        public IActionResult Index()
        {
            var model = _class1AService.GetAllStudentsForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllStudentsForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _class1AService.GetAllStudentsContanctInfoForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _class1AService.GetAllAvarageGradesForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllAvarageGradesForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _class1AService.GetAllBiologyForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllBiologyForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _class1AService.GetAllChemistryForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllChemistryForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _class1AService.GetAllEnglishForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllEnglishForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _class1AService.GetAllGeographyForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllGeographyForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _class1AService.GetAllGermanForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllGermanForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _class1AService.GetAllHistoryForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllHistoryForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _class1AService.GetAllMathForList(10, 1, "1B");
            return View(model);
        }
        [HttpPost]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1AService.GetAllMathForList(pageSize, pageNo.Value, "1B");
            return View(model);
        }

        [HttpGet]
        public IActionResult EditBiologyGrade(int id)
        {
            var biologyGrade = _class1AService.GetBiologyGradeForEdit(id);
            return View(biologyGrade);
        }
        [HttpPost]
        public IActionResult EditBiologyGrade(EditBiologyVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateBiologyGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditChemistryGrade(int id)
        {
            var chemistryGrade = _class1AService.GetChemistryGradeForEdit(id);
            return View(chemistryGrade);
        }
        [HttpPost]
        public IActionResult EditChemistryGrade(EditChemistryVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateChemistryGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEnglishGrade(int id)
        {
            var englishGrade = _class1AService.GetEnglishGradeForEdit(id);
            return View(englishGrade);
        }
        [HttpPost]
        public IActionResult EditEnglishGrade(EditEnglishVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateEnglishGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGeographyGrade(int id)
        {
            var geographyGrade = _class1AService.GetGeographyGradeForEdit(id);
            return View(geographyGrade);
        }
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGeographyVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateGeographyGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGermanGrade(int id)
        {
            var germanGrade = _class1AService.GetGermanGradeForEdit(id);
            return View(germanGrade);
        }
        [HttpPost]
        public IActionResult EditGermanGrade(EditGermanVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateGermanGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditHistoryGrade(int id)
        {
            var historyGrade = _class1AService.GetHistoryGradeForEdit(id);
            return View(historyGrade);
        }
        [HttpPost]
        public IActionResult EditHistoryGrade(EditHistoryVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateHistoryGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditMathGrade(int id)
        {
            var mathGrade = _class1AService.GetMathGradeForEdit(id);
            return View(mathGrade);
        }
        [HttpPost]
        public IActionResult EditMathGrade(EditMathVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateMathGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }
    }
}
