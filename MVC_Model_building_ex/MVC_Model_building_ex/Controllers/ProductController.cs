using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Model_building_ex.Models;

namespace MVC_Model_building_ex.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            List<Product> product = new List<Product>();
            product.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = category.wood });
            product.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = category.iron });
            product.Add(new Product() { ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = category.vehicle });
            product.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = category.wood });
            product.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = category.iron });
            product.Add(new Product() { ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = category.vehicle });

            return View(product);
        }

        public ActionResult product()
        {
            Product pro = new Product { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = category.wood };
            return View(pro);
        }


    }
}
