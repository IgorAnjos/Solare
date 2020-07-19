using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using System.Linq;

namespace SolareWeb.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {

        public IActionResult Index()
        {
            return Ok();
        }
    }
}