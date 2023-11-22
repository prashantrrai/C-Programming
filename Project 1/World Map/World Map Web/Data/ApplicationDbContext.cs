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
    }
}
