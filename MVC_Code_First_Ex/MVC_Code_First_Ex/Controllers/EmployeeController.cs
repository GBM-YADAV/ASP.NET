using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Code_First_Ex.Models;

namespace MVC_Code_First_Ex.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public  ActionResult Index()
        {
            var emp = _context.Employees.ToList();
            return View(emp);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _context.Employees.FirstOrDefault(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        
        public IActionResult Create()
        {
            var deptlist = (from dept in _context.Departments
                            select new SelectListItem()
                            {
                                Text = dept.DepName,
                                Value = dept.DepId.ToString()
                            }).ToList();
            ViewBag.dep = deptlist;


            return View();
        }

       
        [HttpPost]
   
        public IActionResult Create( Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

     
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deptlist = (from dept in _context.Departments
                            select new SelectListItem()
                            {
                                Text = dept.DepName,
                                Value = dept.DepId.ToString()
                            }).ToList();

            ViewBag.dep = deptlist;
            var employee =  _context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
       
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    _context.SaveChanges();
                }
                catch 
                {
                    return View(employee);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _context.Employees
                .FirstOrDefault(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
      
        public IActionResult Delete(int id,Employee employee)
        {
            _context.Employees.Remove(employee);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
