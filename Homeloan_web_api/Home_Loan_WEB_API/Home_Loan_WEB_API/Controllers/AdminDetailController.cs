﻿using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Home_Loan_WEB_API.Models;

namespace Home_Loan_Web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDetailController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdminDetailController(AppDbContext context)
        {
            _context = context;
        }

        //HttpGet method to fetch all the records from the Account Details table
        public ActionResult Get()
        {
            var data = _context.AdminDetails.ToList();
            return Ok(data);
        }
        //HttpGet method to fetch one record from the Admin Details table 
        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.AdminDetails.FirstOrDefault(a => a.adminId == id);
            return Ok(data);
        }

        //HttpPost method to push one record from the Admin Details table 

        [HttpPost]
        public ActionResult post(AdminDetail newobj)
        {
            if (ModelState.IsValid)
            {
                _context.AdminDetails.Add(newobj);
                _context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        
    }
}


