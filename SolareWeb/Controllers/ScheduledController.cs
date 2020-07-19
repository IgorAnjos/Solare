using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using SolareWeb.Models;

namespace SolareWeb.Controllers
{
    [ApiController]
    public class ScheduledController : ControllerBase
    {
        private readonly ApplicationDbContext database;
        public ScheduledController(ApplicationDbContext _dbContext)
        {
            this.database = _dbContext;
        }

        public IActionResult Scheduleds()
        {
            //ViewBag.Customers = database.Customers.ToList();
            //ViewBag.Services = database.Services.ToList();
            return Ok();
        }

        [HttpPost]
        public IActionResult Save([FromBody]Scheduled _scheduled)
        {
            if (!ModelState.IsValid)
            {
                return Ok();
            }

            Scheduled s = new Scheduled();

            s.Id = _scheduled.Id;
            s.Date = _scheduled.Date;
            s.Time = _scheduled.Time;
            s.CustomerId = _scheduled.CustomerId;
            s.ServiceId = _scheduled.ServiceId;
            s.CreatedBy = 1;
            s.CreatedOn = s.ModifieldOn = DateTime.Now;

            database.Scheduleds.Add(s);
            database.SaveChanges();

            return RedirectToAction("Scheduleds");
        }
    }
}
