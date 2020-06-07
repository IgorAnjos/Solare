using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class ServiceLocationController : Controller
    {
        public IActionResult ServiceLocations(){
            return View();
        }

        public IActionResult ServiceLocationAdd(){
            return View();
        }

        [HttpPost]
        public IActionResult Save(){
            return View();
        }

        public IActionResult Update(){
            return View();
        }

        public IActionResult Delete(){
            return View();
        }
    }
}