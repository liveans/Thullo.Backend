using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thullo.Core.Entity.Abstract;

namespace Thullo.Entities
{
    public class User : CUEntity<Guid>, ISoftDelete
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        [Index(IsUnique = true)]
        public string EmailNormalized { get; set; }
        public string Username { get; set; }
        [Index(IsUnique = true)]
        public string UsernameNormalized { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        //TODO: Will Implement Regex in Business Logic (Register/Update)
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        //TODO: Will use on deletion for 30 days count (Cron Job)
        public DateTime DeletedAt { get; set; }
    }
}
