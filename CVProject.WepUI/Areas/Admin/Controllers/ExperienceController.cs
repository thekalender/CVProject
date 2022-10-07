using CVProject.Business.Abstract;
using CVProject.Entities.Concrete;
using CVProject.WepUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.WepUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private IExperienceService _experienceService;
        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IActionResult Index()
        {
            var model = new ExperienceListViewModel
            {
                Experiences = _experienceService.Gelist()
            };
            return View(model);
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ExperienceAddViewModel
            {
                Experience = new Experience()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Experience experience)
        {
            _experienceService.Add(experience);
            return RedirectToAction("Index", "Experience");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var res = _experienceService.GetById(id);

            var model = new ExperienceUpdateViewModel
            {
                Experience = new Experience() {
                    ExperienceId = res.ExperienceId,
                    Title = res.Title,
                    SubTitle= res.SubTitle,
                    Description=res.Description,
                    Date=res.Date
                }
            };

            return View(model);
        }
        public IActionResult Update(Experience experience)
        {
            _experienceService.Update(experience);

            return RedirectToAction("Index", "Experience");
        }

        public IActionResult Delete(int id)
        {
            _experienceService.Delete(id);
            return RedirectToAction("Index", "Experience");
        }
    }
}
