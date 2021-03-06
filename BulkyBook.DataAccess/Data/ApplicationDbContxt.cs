using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess
{
    public class ApplicationDbContxt : DbContext
    {
        

        public ApplicationDbContxt(DbContextOptions<ApplicationDbContxt> options) : base(options)
        {    
        }

        public DbSet<Category> Categories { get; set; }  
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
