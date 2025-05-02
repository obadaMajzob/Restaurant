using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
