using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolareWeb.Models;

namespace SolareWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<AddressBirth> AddressBirths { get; set; }
        public DbSet<AddressCurrent> AddressCurrents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceLocation> ServiceLocations { get; set; }
        public DbSet<Scheduled> Scheduleds { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
