using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}