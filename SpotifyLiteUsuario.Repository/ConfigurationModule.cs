using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLiteUsuario.Domain.Repository;
using SpotifyLiteUsuario.Repository.Context;
using SpotifyLiteUsuario.Repository.Database;
using SpotifyLiteUsuario.Repository.Repository;

namespace SpotifyLiteUsuario.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SpotifyUsuarioContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
