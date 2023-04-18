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
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;

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
builder.Services.AddJwt(builder.Configuration);

builder.Services.AddDbContext<VeterinariaContext>(options =>

#if DEBUG
     options.UseSqlServer(builder.Configuration.GetConnectionString("vet"))
#elif (RELEASE)
     options.UseSqlite(builder.Configuration.GetConnectionString("vet2"))
#endif

    );

var emailConfig = builder.Configuration
      .GetSection(EmailConfiguration.Section)
      .Get<EmailConfiguration>();

builder.Services.AddSingleton(emailConfig);

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IMascotaPropietarioRepository, MascotaPropietarioRepository>();
builder.Services.AddScoped<IPropietarioRepository, PropietarioRepository>();

builder.Services.AddScoped<IPropietarioRepository, PropietarioRepository>();
builder.Services.AddScoped<IGenericRepository<Propietario>, PropietarioRepository>();
builder.Services.AddScoped<IPropietarioService, PropietarioService>();

builder.Services.AddScoped<IAutorizacionRepository, AutorizacionRepository>();
builder.Services.AddScoped<IGenericRepository<Autorizacion>, AutorizacionRepository>();
builder.Services.AddScoped<IAutorizacionService, AutorizacionService>();



builder.Services.AddScoped<IGenericRepository<Veterinaria>, VeterinariaRepository>();
builder.Services.AddScoped<IVeterinariaRepository, VeterinariaRepository>();
builder.Services.AddScoped<IVeterinariaService, VeterinariaService>();

builder.Services.AddScoped<IGenericRepository<Producto>, ProductoRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddScoped<IGenericRepository<Servicio>, ServicioRepository>();
builder.Services.AddScoped<IServicioRepository, ServicioRepository>();
builder.Services.AddScoped<IServicioService, ServicioService>();

builder.Services.AddScoped<IHistoriaClinicaService, HistoriaClinicaService>();
builder.Services.AddScoped<IHistoriaClinicaRepository, HistoriaClinicaRepository>();
builder.Services.AddScoped<IGenericRepository<HistoriaClinica>, HistoriaClinicaRepository>();


builder.Services.AddScoped<IGenericRepository<Vacuna>, VacunaRepository>();
builder.Services.AddScoped<IVacunaService, VacunaService>();
builder.Services.AddScoped<IVacunaRepository, VacunaRepository>();

builder.Services.AddScoped<IGenericRepository<Tratamiento>, TratamientoRepository>();
builder.Services.AddScoped<ITratamientoService, TratamientoService>();
builder.Services.AddScoped<ITratamientoRepository, TratamientoRepository>();

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);

var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;
    var context = services.GetRequiredService<VeterinariaContext>();
}



app.UseCors();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
