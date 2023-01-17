using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_DBFirst_practice.Models;

namespace MVC_DBFirst_practice.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var Employees = _context.Employees.ToList();
            return View(Employees);
        }
        public ActionResult Details(int id)
        {
            var employees = _context.Employees.FirstOrDefault(emp=>emp.eid==id);
            return View(employees);
        }

        public ActionResult Create()
        {


            //List<SelectListItem> departments = new List<SelectListItem>() 
            //{ 
            //    new SelectListItem { Text = "Accounts", Value = "1"}, 
            //    new SelectListItem { Text = "Sales", Value ="2" }, 
            //    new SelectListItem { Text = "IT", Value = "3" }

            //};



            //   ViewBag.dept = departments;

            // Department data fetched from department table and binding with drop down list

            var deptlist = (from dept in _context.Departments
                           select new SelectListItem()
                           {
                               Text = dept.depname,
                               Value = dept.depno.ToString()
                           }).ToList();

            ViewBag.dept = deptlist;

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee newemp)
        {
            try
            {
                if (ModelState.IsValid)
                
                    _context.Employees.Add(newemp);
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
            var emp = _context.Employees.FirstOrDefault(emp => emp.eid == id);
            try
            {
                if (emp != null)
                    _context.Employees.Remove(emp);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

        }
        public ActionResult Edit(int id )
        {
            var deptlist = (from dept in _context.Departments
                            select new SelectListItem()
                            {
                                Text = dept.depname,
                                Value = dept.depno.ToString()
                            }).ToList();

            ViewBag.dept = deptlist;
            var emp= _context.Employees.FirstOrDefault(emp=>emp.eid==id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(int id , Employee emp)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    var data =_context.Employees.FirstOrDefault(e=>e.eid==id);
                    if (data != null)
                    {
                        data.ename = emp.ename;
                        data.depno = emp.depno;
                        data.salary = emp.salary;
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
