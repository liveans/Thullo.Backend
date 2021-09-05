using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Utility.Helpers.Hash.Interfaces
{
    public interface IPasswordHashHelper
    {
        string HashPassword(string password);
        bool VerifyHash(string password, string passwordHash);
    }
}
