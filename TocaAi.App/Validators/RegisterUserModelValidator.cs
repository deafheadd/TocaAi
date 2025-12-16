using FluentValidation;
using TocaAi.App.ViewModels;

namespace TocaAi.App.Validators
{
    public class RegisterUserModelValidator : AbstractValidator<RegisterUserModel>
    {
        public RegisterUserModelValidator()
        {
            RuleFor(u => u.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(u => u.ConfirmPassword)
                .Equal(u => u.Password).WithMessage("Passwords do not match.");
        }
    }
}
