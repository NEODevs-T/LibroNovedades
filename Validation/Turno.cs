using System;
using System.ComponentModel.DataAnnotations;

namespace LibroNovedades.Validate
{
    public class ValidTurno : ValidationAttribute
    {
        private string GetErrorMessage(int idPais)
        {
            if (idPais == 5)
                return "You must enter your shift number (valid values are: 1, 2 and 3)";

            return "Debe ingresar el número de su turno (los valores válidos son: 1, 2 y 3)";
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

            if (value == null)
            {
                return ValidationResult.Success;
            }

            var turno = value.ToString();

            if (turno == "1" || turno == "2" || turno == "3")
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(GetErrorMessage(idPais));
        }
    }
}