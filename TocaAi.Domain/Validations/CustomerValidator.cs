using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty().WithMessage("Customer name is required.")
                .NotNull().WithMessage("Customer name cannot be null.")
                .MaximumLength(100).WithMessage("Customer name must not exceed 100 characters.");

            RuleFor(c => c.Email)
                    .NotEmpty().WithMessage("Customer email is required.")
                    .EmailAddress().WithMessage("Invalid customer email.");

            RuleFor(c => c.CPF)
                    .NotEmpty().WithMessage("Customer CPF is required.")
                    .Length(11).WithMessage("Customer CPF must have 11 digits.");
            
            RuleFor(c => c.Address)
        }
    }
}
