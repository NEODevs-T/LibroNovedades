using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public  class ValidDiferenteACero : ValidationAttribute
    {
        public string GetErrorMessage() => $"Debe colocar un valor";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null){
                if(value.ToString() != "0"){
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(GetErrorMessage());
        }
    }
}