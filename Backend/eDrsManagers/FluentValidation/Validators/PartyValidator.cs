using System;
using System.Collections.Generic;
using System.Text;
using eDrsDB.Models;
using eDrsManagers.ViewModels;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
{
    public class PartyValidator : AbstractValidator<Party>
    {
        public PartyValidator()
        {
            RuleFor(x => x.PartyType)
                .NotNull().NotEmpty().WithMessage("PartyType should not be Empty");
            
            RuleFor(x => x.IsApplicant)
                .NotNull().NotEmpty().WithMessage("IsApplicant should not be Empty");
            
            RuleFor(x => x.CompanyOrForeName)
                .NotNull().NotEmpty().WithMessage("CompanyOrForeName should not be Empty");
            
            RuleFor(x => x.ViewModelRoles)
                .NotNull().NotEmpty().WithMessage("ViewModelRoles should not be Empty");
            
            RuleFor(x => x.AddressForService)
                .NotNull().NotEmpty().WithMessage("AddressForService should not be Empty");

        }
    }
}
