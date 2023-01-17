using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Ex.Models
{
    public class Department
    {
        [Key]
        public int  DepId { get; set; }

        [StringLength(maximumLength: 20)]
        [Required(ErrorMessage ="Department Name is Cumpulsory")]
        public string DepName { get; set; }

        [StringLength (maximumLength: 20)]

        public string Location { get; set; }
    }
}
