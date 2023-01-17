using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WMVC_View_model_DepT_emp.Models;

namespace WMVC_View_model_DepT_emp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees(int? Id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.depno== Id);
            List<Employee> emplist = _context.Employees.Where(e => e.depno == department.depno).ToList();
            
            DeptEmpViewModel data = new DeptEmpViewModel()
            {
                Employeelist = emplist,
                depart = department
            };
            return View(data);

        }

        public ActionResult StudentDetails()
        {
            Student s1 = new Student() { stid = 1, name = "Bill", branch = "IT" };
            Address a1 = new Address() { stid = 1, City = "Pune", PIn = "411032" };



            StudentsDetails S = new StudentsDetails()
            {
                Id = s1.stid,
                student = s1,
                address = a1,
                Title = "Topper of University",
                University = "Pune University"



            };
            return View(S);


        }

    }
}
