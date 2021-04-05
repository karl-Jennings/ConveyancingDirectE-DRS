using eDrsManagers.ViewModels;
using FluentValidation;

namespace eDrsManagers.FluentValidation
{
    public class DocumentReferenceValidator : AbstractValidator<DocumentReferenceViewModel>
    {
        public DocumentReferenceValidator()
        {
            RuleFor(x => x.Reference).NotNull();
            RuleFor(x => x.TotalFeeInPence).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.TelephoneNumber).NotNull();
            RuleFor(x => x.AdditionalProviderFilter).NotNull();
            RuleFor(x => x.ExternalReference).NotNull();
            RuleFor(x => x.ApplicationDate).NotNull();
            RuleFor(x => x.DisclosableOveridingInterests).NotNull();
            RuleFor(x => x.RegistrationTypeId).NotNull();
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.Applications).NotEmpty();

        }

    }
}
