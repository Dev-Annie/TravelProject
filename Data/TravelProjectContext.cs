using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelProject.Models;

namespace TravelProject.Data
{
    public class TravelProjectContext : DbContext
    {
        public TravelProjectContext (DbContextOptions<TravelProjectContext> options)
            : base(options)
        {
        }

        public DbSet<TravelProject.Models.Activities> Activities { get; set; } = default!;
    }
}
