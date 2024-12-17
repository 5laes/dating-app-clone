using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config, bool isDevelopment)
        {
            
            services.AddScoped<ITokenService, TokenService>();

            if (isDevelopment)
            {       
                // Development specific functions goes here
                services.AddDbContext<DataContext>(options => 
                {
                    options.UseSqlite(config.GetConnectionString("DefaultConnection"));
                });
            }
            else
            {
                // Production specific functions goes here
            }

            return services;
        }
    }
}