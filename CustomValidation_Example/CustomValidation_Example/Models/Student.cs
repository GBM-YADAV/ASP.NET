using System;
using System.ComponentModel.DataAnnotations;
using CustomValidation_Example.Custom;

namespace CustomValidation_Example.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="firstname required")]  
        [StringLength(20)]
        [RegularExpression("[a-zA-Z .]+")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "lastname required")]
        [RegularExpression("[a-zA-Z .]+")]
        [StringLength(20)]
        public string lastname { get; set; }
        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage ="enter valid mail id")]
        public string Email{ get; set; }
        [Phone(ErrorMessage ="phone number should be 10 digits")]
        public string phone { get; set; }
        [Range(5,22,ErrorMessage ="Age should be between 5 to 25")]
        [Required(ErrorMessage ="age is required")]
        public int age { get; set; }
        [CustomDate(ErrorMessage ="Data of Admission should be less than crrent date ")]
        public DateTime DOA { get; set; }
        [Required(ErrorMessage ="password is reqyired")]
        public string password { get; set; }
        [Required(ErrorMessage = "confirm password is reqyired")]
        [Compare("password",ErrorMessage ="passwords do not match ")]
        public string confirmpassword { get; set; }
        [Url(ErrorMessage =" emter url in the format http://www.xxx.com from")]
        [Required(ErrorMessage ="url is required")]
        public string url { get; set; }
       



    }
}
