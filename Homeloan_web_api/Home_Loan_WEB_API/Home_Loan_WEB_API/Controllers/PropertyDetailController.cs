﻿using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Home_Loan_WEB_API.Models;

namespace Home_Loan_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyDetailController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PropertyDetailController(AppDbContext context)
        {
            _context = context;
        }
        //HttpGet method to fetch all the records from the Property Details table
        public ActionResult get()
        {
            var data = _context.PropertyDetails.ToList();
            return Ok(data);
        }

        //HttpGet method to fetch one record from the Property Details table 
        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.PropertyDetails.FirstOrDefault(p => p.propertyId == id);
            return Ok(data);
        }

        //HttpPost method to push one record from the Property Details table 
        [HttpPost]
        public ActionResult post(PropertyDetail newproperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.PropertyDetails.Add(newproperty);
                _context.SaveChanges();
                return CreatedAtAction("get", new { id = newproperty.propertyId }, newproperty);
            }
        }
        
    }
}
