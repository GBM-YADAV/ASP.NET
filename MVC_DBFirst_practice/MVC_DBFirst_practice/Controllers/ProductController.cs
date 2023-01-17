using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_DBFirst_practice.Models;

namespace MVC_DBFirst_practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var products = _context.Products.ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            
            var product = _context.Products.FirstOrDefault(pro => pro.productid == id);
            return View(product);
        }
        public ActionResult Create()
        {
            var cat =(from ca in _context.Categories
                select new SelectListItem()
                {
                    Value =ca.catid.ToString(),
                    Text=ca.category
                 }).ToList();
            ViewBag.cat=cat;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product newproduct)
        {
            try
            {
                if (ModelState.IsValid)

                _context.Products.Add(newproduct);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            catch
            {



                return RedirectToAction(nameof(Index));
            }
        }
        public ActionResult Delete(int id)
        {
            var pro = _context.Products.FirstOrDefault(pro => pro.productid == id);
            try
            {
                if (pro != null)
                    _context.Products.Remove(pro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

        }
        public ActionResult Edit(int id)
        {
            var cat = (from ca in _context.Categories
                       select new SelectListItem()
                       {
                           Value = ca.catid.ToString(),
                           Text = ca.category
                       }).ToList();
            ViewBag.cat = cat;
           
            var pro = _context.Products.FirstOrDefault(pro => pro.productid == id);
            return View(pro);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product pro)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var data = _context.Products.FirstOrDefault(p => p.productid == id);
                    if (data != null)
                    {
                        data.productid = pro.productid;
                        data.productname = pro.productname;
                        data.price = pro.price;
                        data.catid = pro.catid;
                    }
                    _context.SaveChanges();
                    return RedirectToAction("Index");


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }

}