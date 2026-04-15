using System.Text.Json;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;

using BlazorStrap;
using Blazored.SessionStorage;
using Blazored.LocalStorage;

using LibroNovedades.Services;
using LibroNovedades.Service.Autenticacion;
using LibroNovedades.Data.API;
using LibroNovedades.Data.Maestra;
using LibroNovedades.Data.LibroNov;

using LibroNovedades.ModelsDocIng;
using LibroNovedades.Logic;

using LibroNovedades.Interface.Maestra;
using LibroNovedades.Interface;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorStrap();

builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage(config =>
{
    config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.DefaultIgnoreCondition =
        System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
    config.JsonSerializerOptions.WriteIndented = false;
});

builder.Services.AddControllersWithViews()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization();

builder.Services.AddAuthorizationCore();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddScoped<NotificationService>();

var connectionString = builder.Configuration.GetConnectionString("ConnectionDbIng")
    ?? throw new InvalidOperationException(
        "La cadena de conexión 'ConnectionDbIng' no está configurada.");

builder.Services.AddDbContext<DOC_IngIContext>(options =>
    options.UseSqlServer(connectionString),
    ServiceLifetime.Transient
);

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<CustomAuthStateProvider>();

builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<LocalizationService>();

builder.Services.AddScoped<IPaisData, PaisData>();
builder.Services.AddScoped<IEmpresaData, EmpresaData>();
builder.Services.AddScoped<ICentroData, CentroData>();
builder.Services.AddScoped<IDivisionData, DivisionData>();
builder.Services.AddScoped<ILineaData, LineaData>();
builder.Services.AddScoped<IEquipoEAMData, EquipoEAMData>();

builder.Services.AddScoped<IDataAPI, DataAPI>();
builder.Services.AddScoped<ILibroNovData, LibroNovData>();

builder.Services.AddScoped<IDataTiParTP, DataTiParTP>();
builder.Services.AddScoped<IDataPizarra, DataPizarra>();
builder.Services.AddScoped<IClasifiTPMData, ClasifiTPMData>();
builder.Services.AddScoped<IDataAvisador, DataAvisador>();

builder.Services.AddScoped<ILogicLibroNov, LogicLibroNov>();

var app = builder.Build();

// PATH BASE (🚨 SIEMPRE PRIMERO)
app.UsePathBase("/LibroNovedades");

// LOCALIZATION
var supportedCultures = new[] { "es", "en" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("es")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

// IMPORTANTE: después del PathBase
localizationOptions.RequestCultureProviders.Insert(0, new TokenCultureProvider());
app.UseRequestLocalization(localizationOptions);

// PIPELINE
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();