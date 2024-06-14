using System.Text.Json;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using Radzen;

using BlazorStrap;
using Blazored.SessionStorage;
using Blazored.LocalStorage;

using LibroNovedades.Data.API;
using LibroNovedades.Data.Global;
using LibroNovedades.Data.LibroNov;
using LibroNovedades.Data.User;
using LibroNovedades.Models.Neo;
using LibroNovedades.ModelsDocIng;
using LibroNovedades.Logic;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorStrap();

builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddControllersWithViews();
builder.Services.AddOptions();  
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<NotificationService>();

builder.Services.AddBlazoredSessionStorage(config =>
{
    config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.IgnoreNullValues = true;
    config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
    config.JsonSerializerOptions.WriteIndented = false;
});

builder.Services.AddBlazoredSessionStorage();

builder.Services.AddDbContext<DbNeoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDbNeo")),ServiceLifetime.Transient
);

builder.Services.AddDbContext<DOC_IngIContext>( options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDbIng")),ServiceLifetime.Transient
);

// builder.Services.AddDbContext<DOC_IngIContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

builder.Services.AddScoped<global::Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider,global:: LibroNovedades.Service.Autenticacion.CustomAuthStateProvider>();



builder.Services.AddScoped<IDataPais, DataPais>();
builder.Services.AddScoped<IDataEmpresa, DataEmpresa>();
builder.Services.AddScoped<IDataCentro, DataCentro>();
builder.Services.AddScoped<IDataDivision, DataDivision>();
builder.Services.AddScoped<IDataLinea, DataLinea>();
builder.Services.AddScoped<IDataArea, DataArea>();
builder.Services.AddScoped<IDataEquipoEAM, DataEquipoEAM>();


builder.Services.AddScoped<IDataAPI, DataAPI>();

builder.Services.AddScoped<IDataLibroNov, DataLibroNov>();
builder.Services.AddScoped<IDataTiParTP, DataTiParTP>();
builder.Services.AddScoped<IDataPizarra, DataPizarra>();
builder.Services.AddScoped<IDataClasifiTPM, DataClasifiTPM>();
builder.Services.AddScoped<IDataChismoso, DataChismoso>();


builder.Services.AddScoped<IDataNivel, DataNivel>();
builder.Services.AddScoped<IDataProyectoUsr, DataProyectoUsr>();
builder.Services.AddScoped<IDataUser, DataUser>();

builder.Services.AddScoped<ILogicLibroNov, LogicLibroNov>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
