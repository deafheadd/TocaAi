using FluentValidation;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.Street)
                .NotEmpty().WithMessage("Street is required.")
                .MaximumLength(100).WithMessage("Street must not exceed 100 characters.");

            RuleFor(a => a.Number)
                .NotEmpty().WithMessage("Number is required.")
                .MaximumLength(10).WithMessage("Number must not exceed 10 characters.");

            RuleFor(a => a.Neighborhood)
                .NotEmpty().WithMessage("Neighborhood is required.")
                .MaximumLength(50).WithMessage("Neighborhood must not exceed 50 characters.");

            RuleFor(a => a.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(100).WithMessage("City must not exceed 100 characters.");

            RuleFor(a => a.State)
                .NotEmpty().WithMessage("State is required.")
                .Length(2).WithMessage("State must contain exactly 2 characters.");

            RuleFor(a => a.PostalCode)
                .NotEmpty().WithMessage("Postal code is required.")
                .MaximumLength(8).WithMessage("Postal code must not exceed 8 characters.");
        }
    }
}
