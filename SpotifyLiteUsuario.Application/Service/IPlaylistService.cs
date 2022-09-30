using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Service
{
    public interface IPlaylistService
    {
        Task<PlaylistOutputDto> Criar(PlaylistInputDto dto);
        Task<List<PlaylistOutputDto>> ListarTodos();
        Task<PlaylistOutputDto> BuscarPorID(string id);
        Task<PlaylistOutputDto> Atualizar(PlaylistOutputDto dto);
        Task<string> Remover(string id);
    }
}