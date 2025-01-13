using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config, bool isDevelopment)
        {
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<LogUserActivity>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILikesRepository, LikesRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

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