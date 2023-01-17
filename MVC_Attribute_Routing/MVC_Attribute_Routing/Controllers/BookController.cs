using Microsoft.AspNetCore.Mvc;

namespace MVC_Attribute_Routing.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
