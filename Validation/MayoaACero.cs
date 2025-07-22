using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidMayorACero : ValidationAttribute
    {
        private string GetErrorMessage(int idPais)
        {
            if (idPais == 5)
                return "You must enter a value greater than 0";
            return "Debe colocar un valor mayor a 0";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int idPais = 0;
            var idPaisProp = validationContext.ObjectType.GetProperty("IdPais");
            if (idPaisProp != null)
            {
                var val = idPaisProp.GetValue(validationContext.ObjectInstance);
                if (val != null && int.TryParse(val.ToString(), out int pais))
                {
                    idPais = pais;
                }
            }

            if (value != null)
            {
                if (Int64.TryParse(value.ToString(), out long valNum) && (valNum > 0 || valNum == -1))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(GetErrorMessage(idPais));
        }
    }
}