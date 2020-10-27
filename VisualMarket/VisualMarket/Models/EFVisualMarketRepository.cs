using VisualMarket.Models;
using System.Linq;

namespace VisualMarket.VisualMarket.Models
{
    public class EFVisualMarketRepository : IVisualMarketRepository
    {
        private VisualMarketDbContext context;

        public EFVisualMarketRepository(VisualMarketDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
