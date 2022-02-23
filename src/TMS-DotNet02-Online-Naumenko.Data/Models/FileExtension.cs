using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class FileExtension
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<File>? File { get; set; } = new();
    }
}
