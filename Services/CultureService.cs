using System.Globalization;
using LibroNovedades;
using LibroNovedades.Service.Autenticacion;

namespace LibroNovedades.Services
{
    public class CultureService
    {
        private readonly UsuarioContexto _usuarioContexto;

        public CultureInfo UserCulture { get; private set; } = new CultureInfo("es");

        public CultureService(UsuarioContexto usuarioContexto)
        {
            _usuarioContexto = usuarioContexto;
        }

        public void SetCulture(string cultureName)
        {
            if (!string.IsNullOrWhiteSpace(cultureName))
            {
                UserCulture = new CultureInfo(cultureName);
                CultureInfo.DefaultThreadCurrentCulture = UserCulture;
                CultureInfo.DefaultThreadCurrentUICulture = UserCulture;
            }
        }

        public string GetCultureName()
        {
            return UserCulture.Name;
        }

        public async Task EstablecerCulturaDesdeUsuarioAsync()
        {
            var usuario = await _usuarioContexto.ObtenerUsuarioActualAsync();
            if (usuario != null)
            {
                SetCulture(usuario.CultureName);
            }
        }
    }
}
