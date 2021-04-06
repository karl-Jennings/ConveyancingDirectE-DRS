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
            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Name should not be Empty");
        }
    }
}
