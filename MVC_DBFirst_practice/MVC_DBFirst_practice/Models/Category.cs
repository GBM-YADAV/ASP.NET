using System.ComponentModel.DataAnnotations;

namespace MVC_DBFirst_practice.Models
{
    public class Category
    {
        [Key]
        public int catid { get; set; }
        public string category { get; set; }
    }
}
