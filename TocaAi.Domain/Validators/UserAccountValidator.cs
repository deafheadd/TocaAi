using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validators
{
    public class UserAccountValidator : AbstractValidator<UserAccount>
    {
        public UserAccountValidator()
        {
            RuleFor(u => u.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MaximumLength(30).WithMessage("Username must not exceed 30 characters");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("User email is required.")
                .MaximumLength(150).WithMessage("User email must not exceed 150 characters.")
                .EmailAddress().WithMessage("Invalid user email.");

            RuleFor(u => u.PasswordHash)
                .NotEmpty().WithMessage("User password is required.")
                .MinimumLength(6).WithMessage("User password must have at least 6 characters.");

            RuleFor(u => u.Role)
                .IsInEnum().WithMessage("Invalid role.");
        }
    }
}
