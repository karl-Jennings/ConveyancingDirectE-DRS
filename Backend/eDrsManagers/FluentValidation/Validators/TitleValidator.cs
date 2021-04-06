using eDrsDB.Models;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
{
    public class TitleValidator : AbstractValidator<TitleNumber>
    {
        public TitleValidator()
        {
            RuleFor(x => x.TitleNumberCode)
                .NotNull().NotEmpty().WithMessage("TitleNumberCode should not be Empty");
        }
    }
}
