using FastEndpoints;
using FluentValidation;

namespace custom_chat_backend.Api.Controllers.Auth.Login;

public sealed class LoginValidator
    : Validator<LoginRequest>
{
    public LoginValidator()
    {
        // El usuario es obligatorio.
        RuleFor(x => x.User)
            .NotEmpty()
            .WithMessage("User is required.")
            .MaximumLength(50)
            .WithMessage("User is maximum 50 characters.")
            .Matches("^[a-zA-Z0-9]+$")
            .WithMessage("User contains invalid characters.");

        // La contraseña es obligatoria.
        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required.")
            .MaximumLength(100)
            .WithMessage("Password is maximum 100 characters");
    }
}