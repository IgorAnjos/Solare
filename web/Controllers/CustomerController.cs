using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using web.Data;
using web.Models;
using web.Models.DTO;

namespace web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext database;

        public CustomerController(ApplicationDbContext _applicationDbContext)
        {
            this.database = _applicationDbContext;
        }

        public IActionResult Customers(){
            return View();
        }

        public IActionResult CustomerAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(CustomerDTO _customerDTO)
        {
            
            if (ModelState.IsValid)
            {
                Customer customer = new Customer();

                customer.FullName = _customerDTO.FullName;
                customer.Type = _customerDTO.Type;
                customer.AddressBirth = database.AddressBirths.First(i => i.Id == _customerDTO.AddressBirthID);
                customer.Enable = true;
                customer.CreatedOn = DateTime.Now;



                //database.Customers.Add(customer);
                database.SaveChanges();
                
                return RedirectToAction("","");
            }
            else
            {
                return RedirectToAction("","");
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