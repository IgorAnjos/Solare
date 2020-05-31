using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Customers(){
            return View();
        }

        public IActionResult CustomerAdd(){
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