using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ArbeidskravDocker.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
