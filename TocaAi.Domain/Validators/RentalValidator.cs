using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validators
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.UserAccountId)
                .NotEmpty().WithMessage("User ID is required.");

            RuleFor(r => r.EquipmentId)
                .NotEmpty().WithMessage("Equipment ID is required.");

            RuleFor(r => r.PickupDate)
                .NotEmpty().WithMessage("Pickup date is required.")
                .LessThan(r => r.ExpectedReturnDate)
                .WithMessage("Pickup date must be earlier than expected return date.");

            RuleFor(r => r.ExpectedReturnDate)
                .NotEmpty().WithMessage("Expected return date is required.")
                .GreaterThan(r => r.PickupDate)
                .WithMessage("Expected return date must be after pickup date.");

            RuleFor(r => r.ActualReturnDate)
                .GreaterThanOrEqualTo(r => r.PickupDate)
                .When(r => r.ActualReturnDate.HasValue)
                .WithMessage("Actual return date must be after pickup date.");

            RuleFor(r => r.DailyRate)
                .GreaterThan(0).WithMessage("Daily rate must be greater than zero.");

            RuleFor(r => r.LateFeeRate)
                .GreaterThanOrEqualTo(0).WithMessage("Late fee rate must be zero or greater.");

            RuleFor(r => r.PaymentMethod)
                .IsInEnum().WithMessage("Invalid payment method.");

            RuleFor(r => r.RentalStatus)
                .IsInEnum().WithMessage("Invalid rental status.");

            RuleFor(r => r.Notes)
                .MaximumLength(500).WithMessage("Notes cannot exceed 500 characters.")
                .When(r => r.Notes != null);
        }
    }
}
