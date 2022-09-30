using SpotifyLiteUsuario.Application.DTO;
using SpotifyLiteUsuario.Domain.Models;

namespace SpotifyLiteUsuario.Application.Profile
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            // Playlist
            CreateMap<PlaylistInputDto, Playlist>();
            CreateMap<Playlist, PlaylistOutputDto>();
            CreateMap<PlaylistOutputDto, Playlist>();

            // Usuário
            CreateMap<UsuarioInputDto, Usuario>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email))
                .ForPath(x => x.Senha.Valor, f => f.MapFrom(m => m.Senha));
            CreateMap<Usuario, UsuarioOutputDto>()
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Email.Valor))
                .ForMember(x => x.Senha, f => f.MapFrom(m => m.Senha.Valor));
            CreateMap<UsuarioOutputDto, Usuario>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email))
                .ForPath(x => x.Senha.Valor, f => f.MapFrom(m => m.Senha));
        }
    }
}