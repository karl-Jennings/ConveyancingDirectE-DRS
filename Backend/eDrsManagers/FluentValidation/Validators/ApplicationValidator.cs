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
            RuleFor(x => x.Variety)
                .NotNull().NotEmpty().WithMessage("Variety should not be Empty");

            RuleFor(x => x.Type)
                .NotNull().NotEmpty().WithMessage("Type should not be Empty");
            
            RuleFor(x => x.Value)
                .NotNull().NotEmpty().WithMessage("Value should not be Empty");
            
            RuleFor(x => x.FeeInPence)
                .NotNull().NotEmpty().WithMessage("FeeInPence should not be Empty");
            
            RuleFor(x => x.CertifiedCopy)
                .NotNull().NotEmpty().WithMessage("CertifiedCopy should not be Empty");
            
            RuleFor(x => x.ExternalReference)
                .NotNull().NotEmpty().WithMessage("CertifiedCopy should not be Empty");
            
            RuleFor(x => x.Document)
                .NotNull().NotEmpty().WithMessage("Document should not be Empty");

        }
    }
}
