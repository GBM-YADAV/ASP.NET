using System.ComponentModel.DataAnnotations;

namespace WMVC_View_model_DepT_emp.Models
{
    public class Employee
    {
        [Key]
        public int eid { get; set; }

        public string ename { get; set; }
        public int depno{ get; set; }
        public decimal salary{ get; set; }
}
}
