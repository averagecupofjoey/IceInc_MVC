using IceIncWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace IceIncWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //creates table
        public DbSet<Category> Categories { get; set; }
    }
}
