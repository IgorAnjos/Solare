using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Promotions(){
            return View();
        }

        public IActionResult PromotionAdd(){
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