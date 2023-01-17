
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualBasic;

namespace mvc_Code_first_practice2.Models
{
    public class Valid
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="name is reqired")]
        [RegularExpression("([a-zA-Z .]+)",ErrorMessage ="enter ur name correectly")]
        public string name { get; set; }

        
        [Required]
        [EmailAddress(ErrorMessage ="Invalid email please enter a valid mail id")]
        public string mail { get; set; }
    }
}
