using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_In_Memory_crud_Operations.Models
{
	public class Customer
	{
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string PAN_Number { get; set; }
    }
}
