using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Ex.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength:20)]
        [Required(ErrorMessage ="Firstanme is cumpulsory")]
        public string FirstName { get; set; }

        [StringLength(maximumLength: 20)]
        [Required(ErrorMessage = "LAstName is cumpulsory")]
        public string LastName { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Salary { get; set; }

        [EmailAddress(ErrorMessage ="Email should be in XXXX@yyy.com format")]
        public string Email { get; set; }

        [Range(16,60)]
        public int age { get; set; }

        [StringLength(20)]
        public string depno { get; set; }


    }
}
