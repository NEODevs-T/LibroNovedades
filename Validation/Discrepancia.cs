using System;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidDiscrepancia : ValidationAttribute
    {
        private string GetErrorMessage(int idPais)
        {
            if (idPais == 5)
                return "Please enter an issue.";

            return "Coloque la discrepancia.";
        }

        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
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

            // Si el valor no es nulo ni vacío → válido
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(GetErrorMessage(idPais));
        }
    }
}