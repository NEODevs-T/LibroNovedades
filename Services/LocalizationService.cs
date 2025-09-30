
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace LibroNovedades.Services
{
    public class LocalizationService
    {
        private readonly AuthenticationStateProvider _authStateProvider;

        public LocalizationService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }

        public async Task EstablecerCulturaDesdeTokenAsync()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity is not null && user.Identity.IsAuthenticated)
            {
                var cultureClaim = user.FindFirst(c => c.Type == "Culture")?.Value ?? "es";
                var culture = new CultureInfo(cultureClaim);

                // Apply culture to current thread and globally
                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                Console.WriteLine($"🌐 Cultura establecida desde Claim: {culture.Name}");
            }
        }
    }
}