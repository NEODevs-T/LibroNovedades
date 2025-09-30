using System.Globalization;
using LibroNovedades.Resources;

namespace LibroNovedades.Services
{
    public class TranslationService : ITranslationService
    {
        public string Traducir(string clave)
        {
            var traduccion = ValidationMessages.ResourceManager.GetString(clave, CultureInfo.CurrentUICulture);
            return string.IsNullOrEmpty(traduccion) ? clave : traduccion;
        }
    }
}