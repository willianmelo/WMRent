using FluentValidation;

namespace WMRent.Business.Models.Validation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Automaker)
                .NotEmpty().WithMessage("The property {PropertyName} is required.")
                .Length(1, 100).WithMessage("The property {PropertyName} must be between {MinLength} and {MaxLength}");

            RuleFor(c => c.Renavam)
               .NotEmpty().WithMessage("The property {PropertyName} is required.")
               .Length(9, 11).WithMessage("The property {PropertyName} must be between {MinLength} and {MaxLength}");

            RuleFor(c => c.Color)
                .NotEmpty().WithMessage("The property {PropertyName} is required.")
                .Length(1, 100).WithMessage("The property {PropertyName} must be between {MinLength} and {MaxLength}");

            RuleFor(c => c.Value)
                .NotNull().WithMessage("The property {PropertyName} is required.");

            RuleFor(c => c.NumberOfPlaces)
                .NotEmpty().WithMessage("The property {PropertyName} is required.")
                .InclusiveBetween(1, 12);

            RuleFor(c => c.YearOfManufacture)
                .NotEmpty().WithMessage("The property {PropertyName} is required.");
        }
    }
}

