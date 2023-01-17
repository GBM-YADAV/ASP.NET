using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_DBFirst_practice.Models;

namespace MVC_DBFirst_practice.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
        public ActionResult Details(int id )
        {
            var department = _context.Departments.FirstOrDefault(dep=>dep.depno==id);
            return View(department);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department newDep)
        {
            try
            {
                if (ModelState.IsValid)

                    _context.Departments.Add(newDep);
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
            var dep = _context.Departments.FirstOrDefault(d => d.depno == id);
            try
            {
                if (dep != null)
                    _context.Departments.Remove(dep);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

        }
        public ActionResult Edit(int? id)
        {
            if(id == null||id<0)
            {
                return BadRequest();
            }
            else
            {
                var d = _context.Departments.FirstOrDefault(d => d.depno == id);
                return View(d);
            }
           
        }

        [HttpPost]
        public ActionResult Edit(int id, Department d)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _context.Departments.Update(d);
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
