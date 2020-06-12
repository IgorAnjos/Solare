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
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<AddressBirth> AddressBirths { get; set; }
        public DbSet<AddressCurrent> AddressCurrents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
