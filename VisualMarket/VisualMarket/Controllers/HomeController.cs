using Microsoft.AspNetCore.Mvc;
using VisualMarket.VisualMarket.Models;

namespace VisualMarket.Controllers
{
    public class HomeController: Controller
    {
        private IVisualMarketRepository repositiry;
        public HomeController(IVisualMarketRepository repo){
            repositiry = repo;
        }
        public IActionResult Index() => View(repositiry.Products); //Controller to display list of products
    }
}