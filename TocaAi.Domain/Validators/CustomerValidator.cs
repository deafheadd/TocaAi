using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty().WithMessage("Customer name is required.")
                .MaximumLength(100).WithMessage("Customer name must not exceed 100 characters.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Customer email is required.")
                .EmailAddress().WithMessage("Invalid customer email.");

            RuleFor(c => c.DocumentNumber)
                .NotEmpty().WithMessage("Customer document is required.")
                .Length(11).WithMessage("Customer document must contain exactly 11 digits.");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(20).WithMessage("Phone number must not exceed 20 characters.");

            RuleFor(c => c.Address)
                .NotNull().WithMessage("Customer address is required.")
                .SetValidator(new AddressValidator());
        }
    }
}
