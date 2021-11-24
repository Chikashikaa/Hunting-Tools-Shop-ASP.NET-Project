using HTSP.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HTSP.Interaction.Database_Interaction
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<HTSPDbContext>(options =>
            {
                options.UseSqlite(@"Data Source=CHIKASHIKA.HTSP.db");
            });
            services.AddScoped<IHTSPDbContext>(provider =>
            provider.GetService<HTSPDbContext>());
            return services;
        }
    }
}
