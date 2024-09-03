using Microsoft.EntityFrameworkCore;
using WebApi.Data;

namespace WebApi.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoDb"));
            return services;
        }
    }
}
