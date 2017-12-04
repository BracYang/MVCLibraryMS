using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCtest.Help
{
    public class Validation
    { 
        public class BookNameValidation : ValidationAttribute
        {
           
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value==null)
                {
                    return new ValidationResult("得写");
                }
                else
                {
                    if (value.ToString().Contains("j8"))
                    {
                        return new ValidationResult("敏感词");
                    }
                }
                return ValidationResult.Success;
            }
        }
    }
}