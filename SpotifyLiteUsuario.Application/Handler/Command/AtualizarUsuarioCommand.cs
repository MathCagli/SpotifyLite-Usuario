﻿using MediatR;
using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Handler.Command
{
    public class AtualizarUsuarioCommand : IRequest<AtualizarUsuarioCommandResponse>
    {
        public UsuarioOutputDto Usuario { get; set; }
        public Guid IdBanda { get; set; }

        public AtualizarUsuarioCommand(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }

    public class AtualizarUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public AtualizarUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
