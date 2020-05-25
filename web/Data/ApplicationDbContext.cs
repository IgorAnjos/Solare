using System;
using System.Collections.Generic;
using System.Text;
using crmSolare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Solare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {                
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
    }
}
