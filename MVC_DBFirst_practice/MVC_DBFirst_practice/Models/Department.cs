using System.ComponentModel.DataAnnotations;

namespace MVC_DBFirst_practice.Models
{
    public class Department
    {
        [Key]
        public int depno { get; set; }
        public string depname { get; set; }
        public string location { get; set; }


    }
}
