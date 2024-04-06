using System.Data;
using DoteDog.Api.Configurations;
using DoteDog.DataAccess.Data.Implementations;
using DoteDog.DataAccess.Data.Interfaces;
using DoteDog.DataAccess.DataAccess;
using DotEnv.Core;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;


namespace DoteDog.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            new EnvLoader().Load();
            // Configura o serviço de conexão com o banco de dados
            services.AddScoped<IDbConnection>((sp) =>
            {
                var settings = new EnvBinder().Bind<AppSettings>();
                return new NpgsqlConnection(settings.ConnectionString);
            });

            services.AddScoped<ISqlDataAccess, SqlDataAccess>();
            services.AddScoped<IUserProfileData, UserProfileData>();

            return services;
        }
    }
}
