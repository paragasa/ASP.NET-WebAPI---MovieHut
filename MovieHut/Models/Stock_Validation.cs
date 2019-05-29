using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieHut.Models
{
    public class Stock_Validation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
            if (movie.NumberInStock >0 || movie.NumberInStock<21)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The number in stock should be between 1 and 20");
            }
        }
    }
}