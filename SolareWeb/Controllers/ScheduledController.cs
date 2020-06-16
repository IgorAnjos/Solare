using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;

namespace SolareWeb.Controllers
{
    public class ScheduledController : Controller
    {
        private readonly ApplicationDbContext database;
        public ScheduledController(ApplicationDbContext _dbContext)
        {
            this.database = _dbContext;
        }

        public IActionResult Scheduleds()
        {
            ViewBag.Customers = database.Customers.ToList();
            ViewBag.Services = database.Services.ToList();
            return View();
        }
    }
}
