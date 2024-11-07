using FluentValidation;
using SquadManager.Models;
namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email não pode ser vazio");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Digite a senha do usuário");
        }
    }
}
