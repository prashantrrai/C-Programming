using crud3.Models;
using Microsoft.EntityFrameworkCore;

namespace crud3.ApplicationDbContext
{
	public class myDbContext: DbContext
	{
        public myDbContext(DbContextOptions<myDbContext> options): base(options)
        {
            
        }
        public DbSet<employee> employees { get; set; }
    }
}
