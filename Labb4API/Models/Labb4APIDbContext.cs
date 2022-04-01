using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Models
{
    public class Labb4APIDbContext : DbContext
    {
        public Labb4APIDbContext(DbContextOptions<Labb4APIDbContext>options) : base(options)
        {

        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Interest> Interests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        } 

    }
}
