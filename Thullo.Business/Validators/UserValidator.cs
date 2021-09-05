using FluentValidation;
using Thullo.Entities;

namespace Thullo.Business.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("EMAIL_CANNOT_NULL");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("PHONE_NUMBER_CANNOT_NULL");
            RuleFor(x => x.Username).NotNull().WithMessage("USERNAME_CANNOT_NULL").MinimumLength(3).WithMessage("USERNAME_LENGTH_TOO_SHORT");
            RuleFor(x => x.FullName).NotNull().WithMessage("FULL_NAME_CANNOT_NULL");
        }
    }
}
