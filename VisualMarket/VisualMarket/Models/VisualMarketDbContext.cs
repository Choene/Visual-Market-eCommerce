using Microsoft.EntityFrameworkCore;

namespace VisualMarket.Models
{
    public class VisualMarketDbContext: DbContext
    {
        public VisualMarketDbContext(DbContextOptions<VisualMarketDbContext> options) : base(options){}

        public DbSet<Product> Products {get; set; }
    }
}