using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Home_Loan_WEB_API.Models;

namespace Home_Loan_WEB_API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoanDetailController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LoanDetailController(AppDbContext context)

        {
            _context = context;
        }

        //HttpGet method to fetch all the records from the Loan Details table
        public ActionResult Get()
        {
            var data = _context.LoanDetails.ToList();
            return Ok(data);
        }

        //HttpGet method to fetch one record from the Loan Details table 

        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.LoanDetails.FirstOrDefault(p => p.applicationId == id);
            return Ok(data);
        }

        //HttpPost method to push one record from the Loan Details table 

        [HttpPost]
        public ActionResult post(LoanDetail newobj)
        {
            if (ModelState.IsValid)
            {
                _context.LoanDetails.Add(newobj);
                _context.SaveChanges();
                return CreatedAtAction("get", new { id = newobj.applicationId }, newobj);
            }
            else
                return BadRequest();
        }

        //Httpput method to update  one record in the Loan Details table that is changing sent for verification to Approved

        [HttpPut]
        [Route("Approve/{id}")]
        public ActionResult put(int? id)
        {
            if (id == null)
                return NotFound();
            else
            { 
                var data = _context.LoanDetails.FirstOrDefault(p => p.applicationId == id);
                data.loanStatus = "Approved";
                _context.SaveChanges();
                return Ok();
            }
        }
        //Httpput method to update  one record in the Loan Details table that is changing sent for verification to rejected
        [HttpPut]
        [HttpPut("Reject/{id}")]
        public ActionResult Reject(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var data = _context.LoanDetails.FirstOrDefault(p => p.applicationId == id);
                data.loanStatus = "Rejected";
                _context.SaveChanges();
                return Ok();
            }
        }

    }
}
