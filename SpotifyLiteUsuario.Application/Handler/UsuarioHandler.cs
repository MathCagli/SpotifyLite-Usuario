﻿using MediatR;
using SpotifyLiteUsuario.Application.Handler.Command;
using SpotifyLiteUsuario.Application.Handler.Query;
using SpotifyLiteUsuario.Application.Service;

namespace SpotifyLiteUsuario.Application.Handler
{
    public class UsuarioHandler : IRequestHandler<CriarUsuarioCommand, CriarUsuarioCommandResponse>,
                                IRequestHandler<ListarTodosUsuariosQuery, ListarTodosUsuariosQueryResponse>,
                                IRequestHandler<BuscarPorIDUsuarioQuery, BuscarPorIDUsuarioQueryResponse>,
                                IRequestHandler<AtualizarUsuarioCommand, AtualizarUsuarioCommandResponse>,
                                IRequestHandler<RemoverUsuarioCommand, RemoverUsuarioCommandResponse>
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<CriarUsuarioCommandResponse> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await _usuarioService.Criar(request.Usuario);
            return new CriarUsuarioCommandResponse(result);
        }

        public async Task<ListarTodosUsuariosQueryResponse> Handle(ListarTodosUsuariosQuery request, CancellationToken cancellationToken)
        {
            var result = await _usuarioService.ListarTodos();
            return new ListarTodosUsuariosQueryResponse(result);
        }

        public async Task<BuscarPorIDUsuarioQueryResponse> Handle(BuscarPorIDUsuarioQuery request, CancellationToken cancellationToken)
        {
            var result = await _usuarioService.BuscarPorID(request.Id);
            return new BuscarPorIDUsuarioQueryResponse(result);
        }

        public async Task<AtualizarUsuarioCommandResponse> Handle(AtualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await _usuarioService.Atualizar(request.Usuario);
            return new AtualizarUsuarioCommandResponse(result);
        }

        public async Task<RemoverUsuarioCommandResponse> Handle(RemoverUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await _usuarioService.Remover(request.Id);
            return new RemoverUsuarioCommandResponse(result);
        }
    }
}
