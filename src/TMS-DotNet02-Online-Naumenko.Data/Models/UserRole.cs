using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<User>? User { get; set; } = new();
    }
}
