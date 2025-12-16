using FluentValidation;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Validators
{
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(e => e.OwnerId)
                .NotEmpty().WithMessage("OwnerId must be provided.");

            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(e => e.Type)
                .IsInEnum().WithMessage("Invalid equipment type.");

            RuleFor(e => e.Brand)
                .NotEmpty().WithMessage("Brand is required.")
                .MaximumLength(100).WithMessage("Brand must not exceed 100 characters.");

            RuleFor(e => e.Model)
                .NotEmpty().WithMessage("Model is required.")
                .MaximumLength(100).WithMessage("Model must not exceed 100 characters.");

            RuleFor(e => e.SerialNumber)
                .NotEmpty().WithMessage("Serial number is required.")
                .MaximumLength(100).WithMessage("Serial number must not exceed 100 characters.");

            RuleFor(e => e.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(300).WithMessage("Description must not exceed 300 characters.");

            RuleFor(e => e.DailyRate)
                .GreaterThan(0).WithMessage("Daily rate must be greater than zero.");

            RuleFor(e => e.AcquisitionDate)
                .LessThanOrEqualTo(DateTime.UtcNow)
                .WithMessage("Acquisition date cannot be in the future");

            RuleFor(e => e.ConservationStatus)
                .IsInEnum().WithMessage("Invalid conservation status");

            RuleFor(e => e.Notes)
                .MaximumLength(500).WithMessage("Notes must not exceed 500 characters.")
                .When(e => e.Notes != null);
        }
    }
}
