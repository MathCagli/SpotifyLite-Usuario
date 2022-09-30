using MediatR;
using SpotifyLiteUsuario.Application.DTO;

namespace SpotifyLiteUsuario.Application.Handler.Query
{
    public class BuscarPorIDUsuarioQuery : IRequest<BuscarPorIDUsuarioQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDUsuarioQueryResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public BuscarPorIDUsuarioQueryResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
