using System;
using System.Collections.Generic;
using System.Text;
using eDrsManagers.ViewModels;
using FluentValidation;

namespace eDrsManagers.FluentValidation.Validators
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserId)
                .NotNull().WithMessage("User ID should not be null");

            RuleFor(x => x.Firstname)
                .NotNull().NotEmpty().WithMessage("Firstname should not be empty");

            RuleFor(x => x.Lastname)
                .NotNull().NotEmpty().WithMessage("Lastname should not be empty");

            RuleFor(x => x.Username)
                .NotNull().NotEmpty().WithMessage("Username should not be empty");

            RuleFor(x => x.Email)
                .NotNull().NotEmpty().WithMessage("Email should not be empty")
                .EmailAddress().WithMessage("Please enter a valid Email");

            When(x => x.UserId == 0, () =>
            {
                RuleFor(x => x.Password)
                    .NotNull().NotEmpty().WithMessage("Password should not be empty");
            });

            When(x => !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(x => x.Password).MinimumLength(8)
                    .WithMessage("Password should contain at least 8 characters");
            });


        }
    }
}
