using System;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidDiferenteACero : ValidationAttribute
    {
        private string GetErrorMessage(int idPais)
        {
            if (idPais == 5)
                return "You must enter a value";

            return "Debe colocar un valor";
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

            // Permitir null si aplica (campo opcional)
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (!string.Equals(value.ToString(), "0", StringComparison.Ordinal))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(GetErrorMessage(idPais));
        }
    }
}