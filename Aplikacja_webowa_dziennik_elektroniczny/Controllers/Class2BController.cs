﻿using dziennik_elektroniczny.Application.Interfaces;
using dziennik_elektroniczny.Application.Services;
using dziennik_elektroniczny.Application.ViewModels.VmForEdit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacja_webowa_dziennik_elektroniczny.Controllers
{
    [Authorize(Roles = "Student2B, BiologyTeacher, ChemistryTeacher, EnglishTeacher, GeographyTeacher, GermanTeacher, HistoryTeacher, MathTeacher, HeadTeacher")]
    public class Class2BController : Controller
    {
        private readonly IStudentsService _studentsService;
        public Class2BController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentsService.GetAllStudentsForList(10, 1, "2B");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsForList(pageSize, pageNo.Value, "2B");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _studentsService.GetAllStudentsContanctInfoForList(10, 1, "2B");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value, "2B");
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _studentsService.GetAllAvarageGradesForList(10, 1, "2B");
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllAvarageGradesForList(pageSize, pageNo.Value, "2B");
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B",1);
            return View(model);
        }
        [HttpPost]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B",1);
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 2);
            return View(model);
        }
        [HttpPost]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 2);
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 3);
            return View(model);
        }
        [HttpPost]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 3);
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 4);
            return View(model);
        }
        [HttpPost]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 4);
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 5);
            return View(model);
        }
        [HttpPost]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 5);
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 6);
            return View(model);
        }
        [HttpPost]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 6);
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _studentsService.GetAllGradesForList(10, 1, "2B", 7);
            return View(model);
        }
        [HttpPost]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _studentsService.GetAllGradesForList(pageSize, pageNo.Value, "2B", 7);
            return View(model);
        }
        [Authorize(Roles = "BiologyTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditBiologyGrade(int studentId)
        {
            var biologyGrade = _studentsService.GetSingleGradeForEdit(studentId, 1);
            return View(biologyGrade);
        }
        [Authorize(Roles = "BiologyTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditBiologyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "ChemistryTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditChemistryGrade(int studentId)
        {
            var chemistryGrade = _studentsService.GetSingleGradeForEdit(studentId, 2);
            return View(chemistryGrade);
        }
        [Authorize(Roles = "ChemistryTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditChemistryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "EnglishTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditEnglishGrade(int studentId)
        {
            var englishGrade = _studentsService.GetSingleGradeForEdit(studentId, 3);
            return View(englishGrade);
        }
        [Authorize(Roles = "EnglishTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditEnglishGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "GeographyTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditGeographyGrade(int studentId)
        {
            var geographyGrade = _studentsService.GetSingleGradeForEdit(studentId, 4);
            return View(geographyGrade);
        }
        [Authorize(Roles = "GeographyTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "GermanTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditGermanGrade(int studentId)
        {
            var germanGrade = _studentsService.GetSingleGradeForEdit(studentId, 5);
            return View(germanGrade);
        }
        [Authorize(Roles = "GermanTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditGermanGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "HistoryTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditHistoryGrade(int studentId)
        {
            var historyGrade = _studentsService.GetSingleGradeForEdit(studentId, 6);
            return View(historyGrade);
        }
        [Authorize(Roles = "HistoryTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditHistoryGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }
        [Authorize(Roles = "MathTeacher, HeadTeacher")]
        [HttpGet]
        public IActionResult EditMathGrade(int studentId)
        {
            var mathGrade = _studentsService.GetSingleGradeForEdit(studentId, 7);
            return View(mathGrade);
        }
        [Authorize(Roles = "MathTeacher, HeadTeacher")]
        [HttpPost]
        public IActionResult EditMathGrade(EditGradesVm model)
        {
            if (ModelState.IsValid)
            {
                _studentsService.UpdateSingleGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }
    }
}
