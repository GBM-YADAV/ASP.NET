using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_In_Memory_crud_Operations.Models;
using MVC_In_Memory_crud_Operations.Models.Services;

namespace MVC_In_Memory_crud_Operations.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> productlist = ProductService.GetProducts();
            return View(productlist);
        }

        [HttpGet]
        public ActionResult DetailsProduct(int id)
        {
            Product product = ProductService.GetProduct(id);
            return View(product);
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Product product = ProductService.GetProduct(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult EditProduct(int id, Product modifiedProduct)
        {
            ProductService.UpdateProduct(id,modifiedProduct);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> categories = new LIst<SelectListItem>()
   {



       new SelectListItem { Text="Biscuits", Value="Bisuits"},
       new SelectListItem { Text="Soap",Value="Soap"},
       new SelectListItem { Text="Oil",Value="Oil"},
         new SelectListItem { Text=" Grain",Value="Grain"}




};
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product newProduct)
        {
            try
            {


                ProductService.AddProduct(newProduct);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
            public ActionResult DeleteProduct(int id)
            {
                CustomerService.DeleteCustomer(id);
                return RedirectToAction(nameof(Index));
            }

    }
}
