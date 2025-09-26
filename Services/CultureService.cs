using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace LibroNovedades.Services
{
    public class CultureService
    {

        private readonly UsuarioContexto usuarioContexto;
        private CultureInfo? userCulture;

        public CultureService(UsuarioContexto usuarioContexto)
        {
            this.usuarioContexto = usuarioContexto;
        }

        public async Task EstablecerCulturaDesdeUsuarioAsync()
        {
            var usuario = await usuarioContexto.ObtenerUsuarioActualAsync();
            var cultureName = usuario?.CultureName ?? "es";
            userCulture = new CultureInfo(cultureName);

            // ✅ Aplicar cultura correctamente al hilo
            CultureInfo.DefaultThreadCurrentCulture = userCulture;
            CultureInfo.DefaultThreadCurrentUICulture = userCulture;

            Console.WriteLine($"✅ Cultura aplicada desde usuario: {userCulture.Name}");


        }


        public string GetCultureName()
        {
            return userCulture?.Name ?? CultureInfo.CurrentCulture.Name;
        }

        public CultureInfo GetCultureInfo()
        {
            return userCulture ?? CultureInfo.CurrentCulture;
        }
        
        
    }

    
}