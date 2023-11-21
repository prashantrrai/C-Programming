using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSelling.Model;
using Microsoft.EntityFrameworkCore;

namespace BookSelling.DataAccess
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options): base(options)
        {
            
        }

        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}
