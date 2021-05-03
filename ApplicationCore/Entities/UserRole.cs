using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class UserRole
    {
        public int UserId { get; set; }
        public User user { get; set; }
        public int RoleId { get; set; }
        public Role role { get; set; }
    }
}
