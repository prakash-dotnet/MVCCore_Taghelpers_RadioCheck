using Microsoft.AspNetCore.Mvc;
using MVCCore_Taghelpers_RadioCheck.Models;

namespace MVCCore_Taghelpers_RadioCheck.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitForm( )
        {
             return View();
        }
        [HttpPost]
        public IActionResult SubmitForm(MyViewModel mv)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Gender=mv.Gender;
                ViewBag.Graduate = mv.IsGraduated;
                
                return View(mv);
            }
            
            return View();
        }
    }
}
