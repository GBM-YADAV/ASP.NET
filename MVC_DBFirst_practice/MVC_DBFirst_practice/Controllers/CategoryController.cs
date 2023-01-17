using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_DBFirst_practice.Models;

namespace MVC_DBFirst_practice.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        public ActionResult Details(int id)
        {
            var categories = _context.Categories.FirstOrDefault(cat=> cat.catid == id);
            return View(categories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            try
            {
                if (ModelState.IsValid)

                    _context.Categories.Add(cat);
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
            var cat = _context.Categories.FirstOrDefault(cat => cat.catid == id);
            try
            {
                if (cat != null)
                    _context.Categories.Remove(cat);
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
            var c = _context.Categories.FirstOrDefault(c => c.catid == id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category c)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var data = _context.Categories.FirstOrDefault(c => c.catid == id);
                    if (data != null)
                    {
                      
                        data.catid = c.catid;
                        data.category = c.category;
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
