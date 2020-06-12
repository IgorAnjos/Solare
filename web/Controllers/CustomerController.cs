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
        public IActionResult Save(CustomerViewModel _customerDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                
                    #region Informação de Nascimento

                        AddressBirth aBirth = new AddressBirth();

                        aBirth.Id               = _customerDTO.AddressBirth.Id;
                        aBirth.DateOfBirth      = _customerDTO.AddressBirth.DateOfBirth.ToString();
                        aBirth.BirthTime        = _customerDTO.AddressBirth.BirthTime.ToString();
                        aBirth.CityBirth        = _customerDTO.AddressBirth.CityBirth;
                        aBirth.BirthOfState     = _customerDTO.AddressBirth.BirthOfState; 

                        database.AddressBirths.Add(aBirth);
                        database.SaveChanges();
                    #endregion

                    #region Contato

                        Contact contact = new Contact();

                        contact.Id          = _customerDTO.Contact.Id;
                        contact.Mobile      = _customerDTO.Contact.Mobile;
                        contact.Telephone   = _customerDTO.Contact.Telephone;

                        database.Contacts.Add(contact);
                        database.SaveChanges();
                            
                    #endregion
                    
                    #region Customer

                        Customer customer = new Customer();

                        customer.Id             = _customerDTO.Customer.Id;
                        customer.FullName       = _customerDTO.Customer.FullName;
                        customer.Type           = _customerDTO.Customer.Type;
                        customer.Enable         = true;
                        customer.CreatedBy      = 1; //teste Igor será usuário logado
                        customer.CreatedOn      = DateTime.Now;
                        customer.AddressBirth   = aBirth;
                        customer.Contact        = contact;

                        database.Customers.Add(customer);
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