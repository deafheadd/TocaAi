using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FullName)
                .NotEmpty().WithMessage("Person name is required.")
                .MaximumLength(100).WithMessage("Person name must not exceed 100 characters.");

            RuleFor(p => p.DocumentNumber)
                .NotEmpty().WithMessage("Person document is required.")
                .Length(11).WithMessage("Person document must contain exactly 11 digits.");

            RuleFor(p => p.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(20).WithMessage("Phone number must not exceed 20 characters.");

            RuleFor(p => p.Address)
                .NotNull().WithMessage("Person address is required.")
                .SetValidator(new AddressValidator());
        }
    }
}
