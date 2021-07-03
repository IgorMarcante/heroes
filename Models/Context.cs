using Microsoft.EntityFrameworkCore;

namespace hero.Models
{
    public class Context: DbContext {
        public Context (DbContextOptions options) : base (options) {
        }
        public DbSet<Hero> Heroes { get; set; }
    }
}