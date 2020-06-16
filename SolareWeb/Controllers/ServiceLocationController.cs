using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using SolareWeb.Models;
using System;
using System.Linq;

namespace SolareWeb.Controllers
{
    public class ServiceLocationController : Controller
    {
        private readonly ApplicationDbContext database;
        public ServiceLocationController(ApplicationDbContext _dbContext)
        {
            this.database = _dbContext;
        }

        public IActionResult ServiceLocations()
        {
            var svl = database.ServiceLocations.Where(_s => _s.Enable == true).ToList();
            return View(svl);
        }

        public IActionResult ServiceLocationAdd(){
            return View();
        }

        [HttpPost]
        public IActionResult Save(ServiceLocation _svl)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("", "");
            }

            ServiceLocation sl = new ServiceLocation();

            sl.Id = _svl.Id;
            sl.ServiceLocationName = _svl.ServiceLocationName;
            sl.Enable = true;
            sl.CreatedBy = 1;
            sl.CreatedOn = sl.ModifieldOn = DateTime.Now;

            database.ServiceLocations.Add(sl);
            database.SaveChanges();
            
            return RedirectToAction("ServiceLocations", "ServiceLocation");
        }

        public IActionResult Update(){
            return View();
        }

        public IActionResult Delete(){
            return View();
        }
    }
}