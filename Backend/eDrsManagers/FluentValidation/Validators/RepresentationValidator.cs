using System;
using System.Collections.Generic;
using System.Text;
using eDrsDB.Models;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
{
    public class RepresentationValidator : AbstractValidator<Representation>
    {

        public RepresentationValidator()
        {
            RuleFor(x => x.Type)
                .NotNull().NotEmpty().WithMessage("Type should not be Empty");

            RuleFor(x => x.RepresentativeId)
                .NotNull().NotEmpty().WithMessage("RepresentativeId should not be Empty");

            When(x => x.Type == "RepresentingConveyancer", () =>
            {
                RuleFor(x => x.Name)
                    .NotNull().NotEmpty().WithMessage("Name should not be Empty");

                RuleFor(x => x.Reference)
                    .NotNull().NotEmpty().WithMessage("Reference should not be Empty");

                RuleFor(x => x.AddressType)
                    .NotNull().NotEmpty().WithMessage("AddressType should not be Empty");

                RuleFor(x => x.AddressType)
                    .NotNull().NotEmpty().WithMessage("AddressType should not be Empty");

                When(x => x.AddressType == "DXAddress", () =>
                {
                    RuleFor(x => x.DxNumber)
                        .NotNull().NotEmpty().WithMessage("DxNumber should not be Empty");

                    RuleFor(x => x.DxExchange)
                        .NotNull().NotEmpty().WithMessage("DxExchange should not be Empty");
                });

                When(x => x.AddressType == "PostalAddress", () =>
                {
                    RuleFor(x => x.AddressLine1)
                        .NotNull().NotEmpty().WithMessage("AddressLine1 should not be Empty");

                    RuleFor(x => x.DxExchange)
                     .NotNull().NotEmpty().WithMessage("DxExchange should not be Empty");

                });
            });

           
        }
    }
}
