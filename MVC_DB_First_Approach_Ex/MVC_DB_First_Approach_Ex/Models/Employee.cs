using System.ComponentModel.DataAnnotations;

namespace MVC_DB_First_Approach_Ex.Models
{
    public class Employee
    {
        [Key]
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }

        public int Salary { get; set; }

        public int Deptno{ get; set; }
    }
}
