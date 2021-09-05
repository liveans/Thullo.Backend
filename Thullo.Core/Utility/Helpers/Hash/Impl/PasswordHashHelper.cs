using System;
using Thullo.Core.Utility.Helpers.Hash.Interfaces;

namespace Thullo.Core.Utility.Helpers.Hash.Impl
{
    public class PasswordHashHelper : IPasswordHashHelper
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyHash(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
