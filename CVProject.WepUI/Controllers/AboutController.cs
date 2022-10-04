using CVProject.Business.Abstract;
using CVProject.WepUI.Model.AboutModel;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.WepUI.Controllers
{
    public class AboutController : Controller
    {
        IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var nodel = new AboutListViewModel
            {
                Abouts = _aboutService.Gelist()
            };
            return View(nodel);
        }
    }
}
