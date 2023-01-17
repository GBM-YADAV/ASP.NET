using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Attribute_Routing.Models.Services;
using MVC_Attribute_Routing.Models;

namespace MVC_Attribute_Routing.Controllers
{
    [Route("Product")]
    [Route("pro")]
    [Route("material")]

    public class ProductController : Controller
    {

        [Route("")]
        [Route("Index")]
        [Route("~/List")]
        public IActionResult Index()
        {
            List<Product> productlist = ProductService.GetProducts();
            return View(productlist);
        }
        [Route("~/Details")]

        public ActionResult Details(int id)
        {
            Product product = ProductService.GetProduct(id);
            return View(product);
        }
    }
}
