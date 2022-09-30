using FluentValidation;
using SpotifyLiteUsuario.Domain.Models;

namespace SpotifyLiteUsuario.Domain.Rules
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Email).SetValidator(new EmailValidator());
            RuleFor(x => x.Senha).SetValidator(new SenhaValidator());

        }
    }
}
