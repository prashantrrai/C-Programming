using Crud_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Web_App.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


        public DbSet<Registration> Registrations { get; set; }
    }
}
