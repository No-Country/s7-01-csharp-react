using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using s7_01.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VeterinariaContext>(  options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("vet")
    ));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IMascotaPropietarioRepository, MascotaPropietarioRepository>();
builder.Services.AddScoped<IPropietarioRepository, PropietarioRepository>();

builder.Services.AddScoped<IPropietarioRepository, PropietarioRepository>();
builder.Services.AddScoped<IGenericRepository<Propietario>, PropietarioRepository>();
builder.Services.AddScoped<IPropietarioService, PropietarioService>();

builder.Services.AddScoped<IAutorizacionRepository, AutorizacionRepository>();
builder.Services.AddScoped<IGenericRepository<Autorizacion>, AutorizacionRepository>();
builder.Services.AddScoped<IAutorizacionService, AutorizacionService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); 

app.Run();
