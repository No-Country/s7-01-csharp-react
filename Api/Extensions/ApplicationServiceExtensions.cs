using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Repositories;

namespace s7_01.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMascotaRepository, MascotaRepository>();
        }
    }
}
