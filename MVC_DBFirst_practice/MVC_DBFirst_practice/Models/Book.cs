using System.ComponentModel.DataAnnotations;

namespace MVC_DBFirst_practice.Models
{
    public class Book
    {
        [Key]
        public int bookid { get; set; }
        public string booktype { get; set; }
        public  decimal price { get; set; }

        public string brand{ get; set; }
    }


}
