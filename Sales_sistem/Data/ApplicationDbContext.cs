using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sales_sistem.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_sistem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {           
        }

        public DbSet<TUsers> TUsers { get; set; }
    }
}
