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
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {// connect to sqlite database
            options.UseSqlite(@"Data Source=CostaRicaData.db");
        }

        public DbSet<TravelProject.Models.Activities> Activities { get; set; } = default!;
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
