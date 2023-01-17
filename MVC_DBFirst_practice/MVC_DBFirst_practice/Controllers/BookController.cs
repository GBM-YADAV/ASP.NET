using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_DBFirst_practice.Models;

namespace MVC_DBFirst_practice.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
        public ActionResult Details(int id)
        {
            var book = _context.Books.FirstOrDefault(book => book.bookid == id);
            return View(book);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)

                    _context.Books.Add(book);
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
            var book = _context.Books.FirstOrDefault(book => book.bookid == id);
            try
            {
                if (book != null)
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
           
        }

        //[HttpPost]
        //public ActionResult Delete(Book book)
        //{
        //    try
        //    {
        //        if (book != null)
        //          _context.Books.Remove(book);
        //        _context.SaveChanges();
        //        return RedirectToAction(nameof(Index));

        //    }
        //    catch 
        //    { 
        //        return View();
        //    }

        //}
        public ActionResult Edit(int id)
        {
            var emp = _context.Books.FirstOrDefault(b=> b.bookid == id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(int id, Book b)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var data = _context.Books.FirstOrDefault(b => b.bookid == id);
                    if (data != null)
                    {
                        data.booktype = b.booktype;
                        data.price = b.price;
                        data.brand = b.brand;
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
