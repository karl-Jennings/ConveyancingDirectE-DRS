using System;
using System.Collections.Generic;
using System.Text;
using eDrsDB.Models;
using FluentValidation;

namespace eDrsManagers.FluentValidation
{
    public class ApplicationValidator : AbstractValidator<ApplicationForm>
    {
        public ApplicationValidator()
        {
            RuleFor(x => x.Priority)
               .NotNull().NotEmpty().WithMessage("Priority should not be Empty");

            RuleFor(x => x.Variety)
                .NotNull().NotEmpty().WithMessage("Variety should not be Empty");

            When(x => x.Variety == "other", () =>
            {
                RuleFor(x => x.Type)
                    .NotNull().NotEmpty().WithMessage("Type should not be Empty");

                RuleFor(x => x.Document)
                    .NotNull().NotEmpty().WithMessage("Other Type Applications must be supported by a document");
            });

            When(x => x.Variety == "charge", () =>
            {
                RuleFor(x => x.ChargeDate)
                    .NotNull().NotEmpty().WithMessage("ChargeDate should not be Empty");

                RuleFor(x => x.IsMdRef)
                    .NotNull().NotEmpty().WithMessage("IsMdRef should not be Empty");
            });
             
            RuleFor(x => x.Value)
                .NotNull().NotEmpty().WithMessage("Value should not be Empty");

            RuleFor(x => x.FeeInPence)
                .NotNull().NotEmpty().WithMessage("FeeInPence should not be Empty");

            RuleFor(x => x.CertifiedCopy)
                .NotNull().NotEmpty().WithMessage("CertifiedCopy should not be Empty");

            //RuleFor(x => x.ExternalReference)
            //    .NotNull().NotEmpty().WithMessage("CertifiedCopy should not be Empty");

            //RuleFor(x => x.Document)
            //    .NotNull().NotEmpty().WithMessage("Document should not be Empty");

            //RuleFor(x => x.Document.Base64)
            //    .NotNull().NotEmpty().WithMessage("Base64 should not be Empty");

            //RuleFor(x => x.Document.FileName)
            //    .NotNull().NotEmpty().WithMessage("FileName should not be Empty");

            //RuleFor(x => x.Document.FileExtension)
            //    .NotNull().NotEmpty().WithMessage("FileExtension should not be Empty");

        }
    }
}
