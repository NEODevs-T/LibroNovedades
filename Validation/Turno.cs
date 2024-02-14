using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidTurno : ValidationAttribute
    {
        public string GetErrorMessage() => $"Los datos validos son: 1,2 y 3";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null){
                if(value.ToString() == "1" || value.ToString() == "2" || value.ToString() == "3"){
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(GetErrorMessage());
        }
    }
}