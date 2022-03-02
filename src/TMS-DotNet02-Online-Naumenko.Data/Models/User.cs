using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? PasswordHash { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public DateTime RegisteredAt { get; set; }

        public int RoleId { get; set; }

        public IEnumerable<Post>? Posts { get; set; }

        public IEnumerable<Term>? Terms { get; set; }

        public IEnumerable<File>? Files { get; set; }

        public int UserRoleId { get; set; }

        public UserRole? UserRole { get; set; }
    }
}
