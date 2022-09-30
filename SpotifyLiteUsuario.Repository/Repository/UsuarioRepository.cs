using Microsoft.EntityFrameworkCore;
using SpotifyLiteUsuario.Domain.Models;
using SpotifyLiteUsuario.Domain.Repository;
using SpotifyLiteUsuario.Repository.Context;
using SpotifyLiteUsuario.Repository.Database;

namespace SpotifyLiteUsuario.Repository.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SpotifyUsuarioContext context) : base(context)
        {
        }
    }
}
