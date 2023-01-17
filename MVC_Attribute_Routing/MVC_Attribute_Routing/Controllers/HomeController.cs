using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Attribute_Routing.Models;

namespace MVC_Attribute_Routing.Controllers
{
    
    public class HomeController : Controller
    {
       
        public string index(int? id)
        {
            if (id != null)
            {
                return "received" + id.ToString();
            }
            else
            return "recieved Nothing";

        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login us)
        {

            if (us.user == "Admin"|| us.user== "Giri Babu")
            {
                TempData["user"] = us.user;
                return RedirectToAction(nameof(Welcome));
            }
            else
                return View();
            
            
        }
        
        public IActionResult Welcome()
        {
            return View();
        }
      
        public IActionResult SignUp()
        {
            return View();
        }
            public IActionResult about()
        {
            return View();
        }


    }
}
