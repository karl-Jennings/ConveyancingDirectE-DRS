using eDrsDB.Models;
using eDrsManagers.ViewModels;
using FluentValidation;

namespace eDrsManagers.FluentValidation
{
    public class DocumentReferenceValidator : AbstractValidator<DocumentReferenceViewModel>
    {
        public DocumentReferenceValidator()
        {
            RuleFor(x => x.Reference)
                .NotNull().NotEmpty().WithMessage("Reference should not be Empty");

            RuleFor(x => x.TotalFeeInPence)
                .NotNull().NotEmpty().WithMessage("TotoalFeeInPence should not be Empty");

            RuleFor(x => x.Email)
                .NotNull().NotEmpty().WithMessage("Email should not be Empty")
                .EmailAddress().WithMessage("Invalid Email Address");

            RuleFor(x => x.TelephoneNumber)
                .NotNull().NotEmpty().WithMessage("Telephone Number should not be Empty");

            RuleFor(x => x.AdditionalProviderFilter)
                .NotNull().NotEmpty().WithMessage("AdditionalProviderFilter should not be Empty");

            RuleFor(x => x.ExternalReference)
                .NotNull().NotEmpty().WithMessage("ExternalReference should not be Empty");

            RuleFor(x => x.ApplicationDate)
                .NotNull().NotEmpty().WithMessage("ApplicationDate should not be Empty");

            RuleFor(x => x.DisclosableOveridingInterests)
                .NotNull().NotEmpty().WithMessage("DisclosableOveridingInterests should not be Empty");

            RuleFor(x => x.RegistrationTypeId)
                .NotNull().NotEmpty().WithMessage("RegistrationTypeId should not be Empty");

            RuleFor(x => x.UserId)
                .NotNull().NotEmpty().WithMessage("UserId should not be Empty");

            RuleFor(x => x.Titles)
                .NotNull().NotEmpty().WithMessage("Titles should not be Empty");

            RuleForEach(x => x.Titles).SetValidator(new TitleValidator());
        }

    }
}
