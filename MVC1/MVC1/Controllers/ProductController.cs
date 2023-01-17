using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
	public class ProductController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsDetails()
		{
			Product product = new Product(){ProductId = 101,ProductName = "chair",ProductPrice = 1000,proCate = category.wood};

			ViewData["product"]=product;


			return View();
		}

        public ActionResult ProductInfo()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = category.wood });
            product.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = category.iron });
            product.Add(new Product() {ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = category.vehicle });
            product.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = category.wood });
            product.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = category.iron });
            product.Add(new Product() { ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = category.vehicle });




            ViewBag.product = product;
            

            return View();
        }

        public ActionResult MyViewBag()
        {
            ViewBag.Name = "GiriBabu";



            return View();
        }
    }
}



















