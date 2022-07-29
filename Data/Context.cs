using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelProject.Models;

namespace TravelProject.Data
{
    public class Context : DbContext
    {
        public Context() : base() { }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {// connect to sqlite database
            options.UseSqlite(@"Data Source=app.db");
        }

        public DbSet<TravelProject.Models.Activities> Activities { get; set; } = default!;

        public DbSet<TravelProject.Models.Rentals>? Rentals { get; set; }
       
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
