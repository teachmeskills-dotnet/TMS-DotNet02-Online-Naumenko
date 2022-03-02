using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? PasswordHash { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public DateTime RegisteredAt { get; set; }

        public int RoleId { get; set; }

        public IEnumerable<PostDTO>? Posts { get; set; }

        public IEnumerable<TermDTO>? Terms { get; set; }

        public IEnumerable<FileDTO>? Files { get; set; }

        public int UserRoleId { get; set; }

        public UserRoleDTO? UserRole { get; set; }
    }
}
