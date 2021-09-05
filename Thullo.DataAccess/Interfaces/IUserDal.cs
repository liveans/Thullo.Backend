using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thullo.Dto;

namespace Thullo.DataAccess.Interfaces
{
    public interface IUserDal
    {
        Task<Guid> Register(UserRegisterDto registerDto);
    }
}
