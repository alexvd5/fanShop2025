using Microsoft.AspNetCore.Mvc;

namespace fanShop2025.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
