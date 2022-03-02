using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class UserRoleDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public IEnumerable<UserDTO>? User { get; set; }
    }
}
