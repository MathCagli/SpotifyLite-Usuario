using MediatR;
using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Handler.Query
{
    public class ListarTodasPlaylistsQuery : IRequest<ListarTodasPlaylistsQueryResponse>
    {
    }

    public class ListarTodasPlaylistsQueryResponse
    {
        public IList<PlaylistOutputDto> Playlists { get; set; }

        public ListarTodasPlaylistsQueryResponse(IList<PlaylistOutputDto> playlists)
        {
            Playlists = playlists;
        }
    }
}
