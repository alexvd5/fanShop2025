using Microsoft.AspNetCore.Mvc;

namespace fanShop2025.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
