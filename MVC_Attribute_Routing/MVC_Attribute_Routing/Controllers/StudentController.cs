using Microsoft.AspNetCore.Mvc;

namespace MVC_Attribute_Routing.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
