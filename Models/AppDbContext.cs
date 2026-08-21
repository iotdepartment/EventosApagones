using Microsoft.EntityFrameworkCore;
namespace EventosApagones.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Apagones> Apagones { get; set; }

    }
}
