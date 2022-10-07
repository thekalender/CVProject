using CVProject.Business.Abstract;
using CVProject.Entities.Concrete;
using CVProject.WepUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.WepUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            
            return View();

        }

        //[HttpGet]
        //public IActionResult Update()
        //{
        //    var model = new AboutUpdateViewModelAdmin
        //    {
        //       About = new About()
        //    };
        //    return View(model);
        //}

        //[HttpPut]
        //public IActionResult Update(About about)
        //{
        //    _aboutService.Update(about);
        //    return RedirectToAction("Update", "Cart");
    }  
}
