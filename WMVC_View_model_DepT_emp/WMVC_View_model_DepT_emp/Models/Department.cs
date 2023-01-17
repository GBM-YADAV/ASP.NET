using System.ComponentModel.DataAnnotations;

namespace WMVC_View_model_DepT_emp.Models
{
    public class Department
    {
        [Key]
        public int depno { get; set; }
        public string depname { get; set; }

        public string location { get; set; }
    }
}
