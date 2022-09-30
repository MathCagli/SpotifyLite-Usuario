using SpotifyLiteUsuario.CrossCutting.Entity;

namespace SpotifyLiteUsuario.Domain.Models
{
    public class Playlist : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
