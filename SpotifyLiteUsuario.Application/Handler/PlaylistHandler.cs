using MediatR;
using SpotifyLiteUsuario.Application.Handler.Command;
using SpotifyLiteUsuario.Application.Handler.Query;
using SpotifyLiteUsuario.Application.Service;

namespace SpotifyLiteUsuario.Application.Handler
{
    public class PlaylistHandler : IRequestHandler<CriarPlaylistCommand, CriarPlaylistCommandResponse>,
                                IRequestHandler<ListarTodasPlaylistsQuery, ListarTodasPlaylistsQueryResponse>,
                                IRequestHandler<BuscarPorIDPlaylistQuery, BuscarPorIDPlaylistQueryResponse>,
                                IRequestHandler<AtualizarPlaylistCommand, AtualizarPlaylistCommandResponse>,
                                IRequestHandler<RemoverPlaylistCommand, RemoverPlaylistCommandResponse>
    {
        private readonly IPlaylistService _playlistService;

        public PlaylistHandler(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        public async Task<CriarPlaylistCommandResponse> Handle(CriarPlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.Criar(request.Playlist);
            return new CriarPlaylistCommandResponse(result);
        }

        public async Task<ListarTodasPlaylistsQueryResponse> Handle(ListarTodasPlaylistsQuery request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.ListarTodos();
            return new ListarTodasPlaylistsQueryResponse(result);
        }

        public async Task<BuscarPorIDPlaylistQueryResponse> Handle(BuscarPorIDPlaylistQuery request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.BuscarPorID(request.Id);
            return new BuscarPorIDPlaylistQueryResponse(result);
        }

        public async Task<AtualizarPlaylistCommandResponse> Handle(AtualizarPlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.Atualizar(request.Playlist);
            return new AtualizarPlaylistCommandResponse(result);
        }

        public async Task<RemoverPlaylistCommandResponse> Handle(RemoverPlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.Remover(request.Id);
            return new RemoverPlaylistCommandResponse(result);
        }
    }
}
