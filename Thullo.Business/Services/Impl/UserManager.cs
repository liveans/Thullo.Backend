using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thullo.Business.Services.Interfaces;
using Thullo.Core.Result;
using Thullo.Core.Result.DataResult;
using Thullo.DataAccess.Interfaces;
using Thullo.Dto;
using Thullo.Entities;

namespace Thullo.Business.Services.Impl
{
    public class UserManager : IUserService
    {
        private readonly IValidator<User> _userValidator;
        private readonly IValidator<UserRegisterDto> _userRegisterValidator;
        private readonly IUserDal _userDal;
        
        public UserManager(IValidator<User> userValidator, IValidator<UserRegisterDto> userRegisterValidator, IUserDal userDal)
        {
            _userValidator = userValidator;
            _userRegisterValidator = userRegisterValidator;
            _userDal = userDal;
        }
        public Task<IResult> Login(string credential, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Register(UserRegisterDto registerDto)
        {
            ValidationResult results = _userRegisterValidator.Validate(registerDto);
            IResult returnVal;
            if(!results.IsValid)
            {
                returnVal = new ErrorResult(results.Errors.Select(s => s.ErrorMessage).ToList());
            }
            else
            {
                await _userDal.Register(registerDto);
                returnVal = new SuccessResult();
            }
            return returnVal;
        }

        public Task<IResult> Update()
        {
            throw new NotImplementedException();
        }
    }
}
