using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thullo.DataAccess.Interfaces;
using TanvirArjel.EFCore.GenericRepository;
using Thullo.Dto;
using Thullo.Entities;
using Thullo.Core.Utility.Helpers.Hash.Interfaces;

namespace Thullo.DataAccess.Impl
{
    public class EfUserDal : IUserDal
    {
        private readonly IRepository _repository;
        private readonly IPasswordHashHelper _passwordHashHelper;
        public EfUserDal(IRepository repository, IPasswordHashHelper passwordHashHelper)
        {
            _repository = repository;
            _passwordHashHelper = passwordHashHelper;
        }

        public async Task<Guid> Register(UserRegisterDto registerDto)
        {
            Guid id = (Guid)(await _repository.InsertAsync<User>(new User
            {
                Email = registerDto.Email,
                EmailNormalized = registerDto.Email.ToUpperInvariant(),
                PasswordHash = _passwordHashHelper.HashPassword(registerDto.Password)
            }))[0];
            return id;
        }
    }
}
