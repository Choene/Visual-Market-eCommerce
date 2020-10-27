using System.Linq;
using VisualMarket.Models;

namespace VisualMarket.VisualMarket.Models
{
    public interface IVisualMarketRepository
    {
        IQueryable<Product> Products {get; }
    }
}