using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public byte TwoFactorEnable { get; set; }
        public DateTime LockoutDateTime { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public byte IsLocked { get; set; }
        public byte AccessFailedCount { get; set; }
    }
}
