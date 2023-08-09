using Microsoft.EntityFrameworkCore;
using sales_order_creation.Models;

namespace sales_order_creation
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Items> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
