using System.ComponentModel.DataAnnotations;

namespace MVC_DBFirst_practice.Models
{
    public class Product
    {
        [Key]
        public int productid { get; set; }
        public string? productname { get; set; }

        public decimal? price { get; set; }

        public int? catid{ get; set; }

    }
}
