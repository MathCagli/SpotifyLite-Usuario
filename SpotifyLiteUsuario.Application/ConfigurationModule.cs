﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLiteUsuario.Application.Service;

namespace SpotifyLiteUsuario.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);
            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IPlaylistService, PlaylistService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
