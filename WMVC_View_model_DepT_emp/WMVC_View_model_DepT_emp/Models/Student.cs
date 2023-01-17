using System.ComponentModel.DataAnnotations;

namespace WMVC_View_model_DepT_emp.Models
{
    public class Student
    {
        [Key]
        public int stid { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
    }
}
