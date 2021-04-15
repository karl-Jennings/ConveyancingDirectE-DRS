using eDrsDB.Models;
using eDrsManagers.FluentValidation.Validators;
using eDrsManagers.ViewModels;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
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


            RuleFor(x => x.AP1WarningUnderstood)
                .NotNull().NotEmpty().WithMessage("AP1WarningUnderstood should not be Empty");

           
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

            RuleFor(x => x.ApplicationAffects)
              .NotNull().NotEmpty().WithMessage("Application Affects should not be Empty");

            RuleFor(x => x.Applications)
                .NotNull().NotEmpty().WithMessage("Applications should not be Empty");

            //RuleFor(x => x.SupportingDocuments)
            //    .NotNull().NotEmpty().WithMessage("SupportingDocuments should not be Empty");

            RuleFor(x => x.Representations)
                .NotNull().NotEmpty().WithMessage("Representations should not be Empty");

            RuleFor(x => x.Parties)
                .NotNull().NotEmpty().WithMessage("Parties should not be Empty");

            RuleForEach(x => x.Titles).SetValidator(new TitleValidator());

            RuleForEach(x => x.Applications).SetValidator(new ApplicationValidator());

            RuleForEach(x => x.SupportingDocuments).SetValidator(new SupportingDocumentValidator());

            RuleForEach(x => x.Representations).SetValidator(new RepresentationValidator());

            RuleForEach(x => x.Parties).SetValidator(new PartyValidator());

        }

    }
}
