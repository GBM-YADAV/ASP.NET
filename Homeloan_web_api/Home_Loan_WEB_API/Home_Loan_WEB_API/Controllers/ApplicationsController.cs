using Home_Loan_WEB_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Home_Loan_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApplicationsController(AppDbContext context)
        {
            _context = context;
        }

        //HttpGet method to fetch the list using Stored Procedure
        [HttpGet]
        public ActionResult get()
        {
            var data = _context.ApplicationsSp.FromSqlInterpolated($"dbo.Applications");
            return Ok(data);
        }
        [HttpGet]


        //HttpGet method to fetch the list using Stored Procedure status wise.
        [Route("ApplicationsBystatus")]

        public ActionResult ApplicationsBystatus()
        {
            var data = _context.ApplicationsSp.FromSqlInterpolated($"dbo.ApplicationsByStatus");
            return Ok(data);
        }
    }
}
