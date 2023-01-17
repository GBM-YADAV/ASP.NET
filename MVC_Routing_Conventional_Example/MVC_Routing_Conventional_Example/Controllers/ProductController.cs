using Microsoft.AspNetCore.Mvc;

namespace MVC_Routing_Conventional_Example.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetProducts()
        {
            return View();
        }
    }
}
