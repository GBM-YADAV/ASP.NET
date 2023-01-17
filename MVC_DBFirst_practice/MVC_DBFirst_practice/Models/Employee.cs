using System.ComponentModel.DataAnnotations;

namespace MVC_DBFirst_practice.Models
{
    public class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }

        public int depno { get; set; }

        public decimal salary { get; set; }
    }
}
