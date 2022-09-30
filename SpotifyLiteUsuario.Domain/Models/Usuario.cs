using FluentValidation;
using SpotifyLiteUsuario.CrossCutting.Entity;
using SpotifyLiteUsuario.CrossCutting.Utils;
using SpotifyLiteUsuario.Domain.Rules;
using SpotifyLiteUsuario.Domain.ValueObject;

namespace SpotifyLiteUsuario.Domain.Models
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Sexo { get; set; }

        public virtual IList<Playlist> Playlists { get; set; }

        public void SetSenha()
        {
            this.Senha.Valor = SecurityUtils.HashSHA1(this.Senha.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);
    }
}
