using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web.Models;

namespace web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Service> Services { get; set; }
        DbSet<Promotion> Promotions { get; set; }
        public DbSet<AddressBirth> AddressBirths { get; set; }
        DbSet<AddressCurrent> AddressCurrents { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Customer> Customers{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
