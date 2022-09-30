using MediatR;
using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Handler.Command
{
    public class RemoverUsuarioCommand : IRequest<RemoverUsuarioCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverUsuarioCommandResponse
    {
        public string Id { get; set; }

        public RemoverUsuarioCommandResponse(string id)
        {
            Id = id;
        }
    }
}
