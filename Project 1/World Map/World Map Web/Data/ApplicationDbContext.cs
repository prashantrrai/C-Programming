using System;
using Microsoft.EntityFrameworkCore;
using World_Map_Web.Models;

namespace World_Map_Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            builder.Entity<State>().HasOne(v => v.Address).WithMany().
                HasForeignKey(v => v.AddressId);
        }*/
    }
}
