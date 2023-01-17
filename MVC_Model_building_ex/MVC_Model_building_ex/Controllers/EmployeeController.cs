using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Model_building_ex.Models;

namespace MVC_Model_building_ex.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            IList<Employee> emplist = new List<Employee>()
            {
                new Employee() { id = 1, name = "Bill", designation = "Director", salary = 102758 },
                new Employee() { id = 2, name = "kiran", designation = "Executive", salary = 84558 },
                new Employee() { id = 3, name = "latha", designation = "manager", salary = 1024648 },
                new Employee() { id = 4, name = "bau", designation = "Administrator", salary = 108578 },
                new Employee() { id = 5, name = "giri", designation = "ceo", salary = 1905488 }

        };
            return View(emplist);
        }

        private void List<T>()
        {
            throw new NotImplementedException();
        }

        public ActionResult GetEmployee()
        {
            Employee emp = new Employee() { id = 1, name = "Bill", designation = "Director", salary = 102758 };
            return View(emp);
        }


    }
}
