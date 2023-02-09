using System.Text.Json;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;

using BlazorStrap;
using Blazored.SessionStorage;
// using Blazored.LocalStorage;

using LibroNovedades.Data;
using LibroNovedades.Models;
using LibroNovedades.ModelsDocIng;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorStrap();

// builder.Services.AddHttpClient();
// builder.Services.AddBlazoredLocalStorage();
// builder.Services.AddControllersWithViews();
// builder.Services.AddAuthorizationCore();


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

// builder.Services.AddScoped<global::Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider,global:: LibroNovedades.Service.Autenticacion.CustomAuthStateProvider>();


builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataArea, global::LibroNovedades.Data.Global.DataArea>();
builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataCentro, global::LibroNovedades.Data.Global.DataCentro>();
builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataLinea, global::LibroNovedades.Data.Global.DataLinea>();
builder.Services.AddScoped<global::LibroNovedades.Data.API.IDataAPI, global::LibroNovedades.Data.API.DataAPI>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataLibroNov, global::LibroNovedades.Data.LibroNov.DataLibroNov>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataTiParTP, global::LibroNovedades.Data.LibroNov.DataTiParTP>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataPizarra, global::LibroNovedades.Data.LibroNov.DataPizarra>();
builder.Services.AddScoped<global::LibroNovedades.Logic.ILogicLibroNov, global::LibroNovedades.Logic.LogicLibroNov>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataClasifiTPM, global::LibroNovedades.Data.LibroNov.DataClasifiTPM>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataEquipoEAM, global::LibroNovedades.Data.LibroNov.DataEquipoEAM>();

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
