using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thullo.Dto;

namespace Thullo.Business.Validators
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("EMAIL_CANNOT_BE_EMPTY").EmailAddress().WithMessage("EMAIL_NOT_VALID");
            RuleFor(x => x.Password).NotEmpty().WithMessage("PASSWORD_CANNOT_BE_EMPTY").Matches(@"[a-zA-Z0-9\S]{8,}").WithMessage("PASSWORD_NOT_VALID");
        }
    }
}
