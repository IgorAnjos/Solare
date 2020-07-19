using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using SolareWeb.Models;
using System;
using System.Linq;

namespace SolareWeb.Controllers
{
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ApplicationDbContext database;
        public ServiceController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }

        public IActionResult Services(){
            var ser = database.Services.ToList();
            return Ok(ser);
        }

        public IActionResult ServiceAdd(){
            return Ok();
        }

        [HttpPost]
        public IActionResult Save(Service _ser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("ServiceAdd");
            }
            Service s = new Service();

            s.Id = _ser.Id;
            s.ServiceName = _ser.ServiceName;
            s.Price = _ser.Price;
            s.Enabled = true;
            s.CreatedBy = 1;
            s.CreatedOn = s.ModifieldOn = DateTime.Now;

            database.Services.Add(s);
            database.SaveChanges();

            return RedirectToAction("Services", "Service");
        }

        public IActionResult Update(){
            return Ok();
        }

        public IActionResult Delete(){
            return Ok();
        }
    }
}