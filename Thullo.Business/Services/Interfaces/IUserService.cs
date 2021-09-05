using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thullo.Core.Result;
using Thullo.Dto;

namespace Thullo.Business.Services.Interfaces
{
    public interface IUserService
    {
        Task<IResult> Login(string credential, string password);
        Task<IResult> Register(UserRegisterDto registerDto);
        Task<IResult> Update();
    }
}
