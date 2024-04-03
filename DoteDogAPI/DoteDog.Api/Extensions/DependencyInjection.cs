using System.Data;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace DoteDog.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            // Configura o serviço de conexão com o banco de dados
            services.AddScoped<IDbConnection>((sp) =>
            {
                var configuration = sp.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                return new NpgsqlConnection(connectionString);
            });




            return services;
        }
    }
}
