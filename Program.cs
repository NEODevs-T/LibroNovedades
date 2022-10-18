using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using LibroNovedades.Data;
using LibroNovedades.Models;
using BlazorStrap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorStrap();

builder.Services.AddDbContext<DbNeoContext>();

builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataArea, global::LibroNovedades.Data.Global.DataArea>();
builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataCentro, global::LibroNovedades.Data.Global.DataCentro>();
builder.Services.AddScoped<global::LibroNovedades.Data.Global.IDataLinea, global::LibroNovedades.Data.Global.DataLinea>();
builder.Services.AddScoped<global::LibroNovedades.Data.APIOEE.IDataAPIOEE, global::LibroNovedades.Data.APIOEE.DataAPIOEE>();
builder.Services.AddScoped<global::LibroNovedades.Data.LibroNov.IDataLibroNov, global::LibroNovedades.Data.LibroNov.DataLibroNov>();

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
