using System;
using System.Collections.Generic;
using System.Text;
using eDrsDB.Models;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
{
    public class SupportingDocumentValidator : AbstractValidator<SupportingDocuments>
    {
        public SupportingDocumentValidator()
        {
            RuleFor(x => x.DocumentType)
                .NotNull().NotEmpty().WithMessage("DocumentType should not be Empty");

            RuleFor(x => x.CertifiedCopy)
                .NotNull().NotEmpty().WithMessage("CertifiedCopy should not be Empty");

            RuleFor(x => x.AdditionalProviderFilter)
                .NotNull().NotEmpty().WithMessage("AdditionalProviderFilter should not be Empty");

            When(x => x.DocumentType == "supDoc", () =>
            {
                RuleFor(x => x.DocumentName)
                    .NotNull().NotEmpty().WithMessage("DocumentName should not be Empty");

                RuleFor(x => x.Base64)
                    .NotNull().NotEmpty().WithMessage("Base64 should not be Empty");

                RuleFor(x => x.FileName)
                    .NotNull().NotEmpty().WithMessage("FileName should not be Empty");

                RuleFor(x => x.FileExtension)
                    .NotNull().NotEmpty().WithMessage("FileExtension should not be Empty");
            });

            When(x => x.DocumentType == "notes", () =>
            {
                RuleFor(x => x.Notes)
                    .NotNull().NotEmpty().WithMessage("Notes should not be Empty");
            });

        }
    }
}
