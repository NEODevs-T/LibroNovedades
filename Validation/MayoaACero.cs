using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidMayorACero : ValidationAttribute
    {
        public string GetErrorMessage() => $"Debe colocar un valor mayor a 0";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null){
                if(Int64.Parse(value.ToString()) > 0 || Int64.Parse(value.ToString()) == -1){
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(GetErrorMessage());
        }
    }
}