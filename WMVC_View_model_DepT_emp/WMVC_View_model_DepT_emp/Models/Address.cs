using System.ComponentModel.DataAnnotations;

namespace WMVC_View_model_DepT_emp.Models
{
    public class Address
    {
        [Key]
        public int stid { get; set; }
        public string City { get; set; }
        public string PIn { get; set; }
    }
}
