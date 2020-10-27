using Microsoft.AspNetCore.Mvc;

namespace VisualMarket.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() => View();
    }
}