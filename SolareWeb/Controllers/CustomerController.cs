using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SolareWeb.Data;
using SolareWeb.Models;

namespace SolareWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext database;

        public CustomerController(ApplicationDbContext _applicationDbContext)
        {
            this.database = _applicationDbContext;
        }

        public IActionResult Customers()
        {
            var cst = database.Customers.ToList();
            return View(cst);
        }

        public IActionResult CustomerAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Customer _cst)
        {
            try
            {
                if (ModelState.IsValid)
                {                   
                    #region Customer

                    Customer c = new Customer();

                    c.Id             = _cst.Id;
                    c.FullName       = _cst.FullName;
                    c.DateOfBirth    = _cst.DateOfBirth;
                    c.BirthTime      = _cst.BirthTime;
                    c.CityBirth      = _cst.CityBirth;
                    c.BirthOfState   = _cst.BirthOfState;
                    c.Enable         = true;
                    c.CreatedBy      = 1; //teste Igor será usuário logado
                    c.CreatedOn      = c.ModifieldOn = DateTime.Now;

                    database.Customers.Add(c);
                    database.SaveChanges();

                    #endregion
                
                }
                return RedirectToAction("Customers","Customer");
            }
            catch (System.Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public IActionResult Update(){
            return View();
        }

        public IActionResult Delete(){
            return View();
        }
    }
}