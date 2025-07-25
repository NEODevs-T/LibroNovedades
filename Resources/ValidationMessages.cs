using System.Resources;
using System.Globalization;

namespace LibroNovedades.Resources
{
    public static class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("LibroNovedades.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

        public static string RequiredUserName => _resourceManager.GetString("RequiredUserName", CultureInfo.CurrentUICulture);
        public static string RequiredPassword => _resourceManager.GetString("RequiredPassword", CultureInfo.CurrentUICulture);
        public static string RequiredEquipment => _resourceManager.GetString("RequiredEquipment", CultureInfo.CurrentUICulture);
        public static string RequiredObservation => _resourceManager.GetString("RequiredObservation", CultureInfo.CurrentUICulture);
        public static string RequiredSheet => _resourceManager.GetString("RequiredSheet", CultureInfo.CurrentCulture); 
    }
}
