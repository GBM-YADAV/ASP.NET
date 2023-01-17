using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Layout_Ex.Models;

namespace MVC_Layout_Ex.Controllers
{
	public class HomeController : Controller
	{
		

		public IActionResult Index()
		{
			return View();
		}

		

		public ActionResult ContactUs()
		{
			return View();
		}

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Enquiry()
        {
            return View();
        }
    }
}
