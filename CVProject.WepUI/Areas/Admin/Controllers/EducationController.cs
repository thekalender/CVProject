using CVProject.Business.Abstract;
using CVProject.Entities.Concrete;
using CVProject.WepUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.WepUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        public IActionResult Index()
        {
            var model = new EducationListViewModel
            {
                Educations = _educationService.Gelist()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new EducationAddViewModel
            {
                Education = new Education()
            };
            return View(model);
        }

        public IActionResult Add(Education education)
        {
            _educationService.Add(education);
            return RedirectToAction("Index", "Education");
        }
    }
}
