using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using s7_01.Api.Services;
using s7_01.Api.Extensions;
using s7_01.Api.Services.Email;
using System.ComponentModel;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    c.CustomSchemaIds(x => x.GetCustomAttributes<DisplayNameAttribute>()
                              .SingleOrDefault()?.DisplayName ?? x.Name);
});


/*builder.Services.AddSwaggerGen(c =>
 c.CustomSchemaIds(x => x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault().DisplayName));*/


builder.Services.AddControllersWithViews();
builder.Services.AddAplicationServices();

builder.Services.AddDbContext<VeterinariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("vet")
    ));

var emailConfig = builder.Configuration
      .GetSection(EmailConfiguration.Section)
      .Get<EmailConfiguration>();

builder.Services.AddSingleton(emailConfig);

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IVeterinariaRepository, VeterinariaRepository>();
builder.Services.AddScoped<IGenericRepository<Veterinaria>, VeterinariaRepository>();
builder.Services.AddScoped<IVeterinariaService, VeterinariaService>();

builder.Services.AddScoped<IGenericRepository<Producto>, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddScoped<IGenericRepository<Servicio>, ServicioRepository>();
builder.Services.AddScoped<IServicioService, ServicioService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
