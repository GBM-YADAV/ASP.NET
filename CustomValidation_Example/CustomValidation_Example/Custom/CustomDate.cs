using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace CustomValidation_Example.Custom
{
    public class CustomDate:ValidationAttribute 
    {
        public override bool IsValid(object value)
        {
            DateTime datetime = Convert.ToDateTime(value);
        
            return datetime<DateTime.Now;
        }


    }
}
