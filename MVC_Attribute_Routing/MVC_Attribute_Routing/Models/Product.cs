using System.ComponentModel.DataAnnotations;

namespace MVC_Attribute_Routing.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }
        public string proCate;
    }
}
