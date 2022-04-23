using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContxt : DbContext
    {
        

        public ApplicationDbContxt(DbContextOptions<ApplicationDbContxt> options) : base(options)
        {
             
        }

        public DbSet<Category> Categories { get; set; }  

    }
}
