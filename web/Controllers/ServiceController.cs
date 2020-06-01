using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Services(){
            return View();
        }

        public IActionResult ServiceAdd(){
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