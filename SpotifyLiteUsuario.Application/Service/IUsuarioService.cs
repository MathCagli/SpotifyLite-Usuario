﻿using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDto> Criar(UsuarioInputDto dto);
        Task<List<UsuarioOutputDto>> ListarTodos();
        Task<UsuarioOutputDto> BuscarPorID(string id);
        Task<UsuarioOutputDto> Atualizar(UsuarioOutputDto dto);
        Task<string> Remover(string id);
    }
}