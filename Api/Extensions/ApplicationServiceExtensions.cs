using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Repositories;
using s7_01.Api.Services;

namespace s7_01.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMascotaRepository, MascotaRepository>();
            services.AddScoped<IMascotaPropietarioRepository, MascotaPropietarioRepository>();
            services.AddScoped<IMascotaService, MascotaService>();
        }
    }
}
