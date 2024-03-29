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
    public class DocumentController : ControllerBase
    {
       
            private readonly AppDbContext _context;

            public DocumentController(AppDbContext context)
            {
                _context = context;
            }

        //HttpGet method to fetch all the records from the Documents table
        public ActionResult Get()
            {
                var data = _context.Documents.ToList();
                return Ok(data);
            }

        //HttpGet method to fetch one record from the Documents table 
        [HttpGet("{id}")]
            public ActionResult get(int id)
            {
                var data = _context.Documents.FirstOrDefault(p => p.documentId == id);
                return Ok(data);
            }
        //HttpPost method to push one record from the Documents table
        [HttpPost]
            public ActionResult post(Document newdoc)
            {
                if (ModelState.IsValid)
                {
                    _context.Documents.Add(newdoc);
                    _context.SaveChanges();
                return CreatedAtAction("get", new { id = newdoc.documentId }, newdoc);
            }
                else
                    return BadRequest();
            }

            
        }
    }
