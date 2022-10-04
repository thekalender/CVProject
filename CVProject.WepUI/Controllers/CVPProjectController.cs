using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.WepUI.Model.CVPProjectModel;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.WepUI.Controllers
{
    public class CVPProjectController : Controller
    {
        private IAboutService _aboutService;
        private IAwardService _awardService;
        private IEducationService _educationService;
        private IExperienceService _experienceService;
        private IInterestService _interestService;
        private ISkillService _skillService;

        public CVPProjectController(IAboutService aboutService, IAwardService awardService, IEducationService educationService, IExperienceService experienceService, IInterestService interestService, ISkillService skillService)
        {
            _aboutService = aboutService;
            _awardService = awardService;
            _educationService = educationService;
            _experienceService = experienceService;
            _interestService = interestService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var model = new CVPProjectListViewModel
            {
                Abouts = _aboutService.Gelist(),
                Awards = _awardService.Gelist(),
                Educations = _educationService.Gelist(),
                Experiences = _experienceService.Gelist(),
                Interests = _interestService.Gelist(),
                Skills = _skillService.Gelist()
            };

            return View(model);
        }
    }
}
