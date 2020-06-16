using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using System.Linq;

namespace SolareWeb.Controllers
{
    public class MainController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}