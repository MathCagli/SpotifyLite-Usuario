using MediatR;
using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Handler.Command
{
    public class RemoverPlaylistCommand : IRequest<RemoverPlaylistCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverPlaylistCommandResponse
    {
        public string Id { get; set; }

        public RemoverPlaylistCommandResponse(string id)
        {
            Id = id;
        }
    }
}
