using Microsoft.AspNetCore.Mvc;

namespace SolareWeb.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}