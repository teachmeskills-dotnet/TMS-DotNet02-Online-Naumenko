using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class File
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public string? Name { get; set; }

        public string? Slug { get; set; }

        public string? Link { get; set; }

        public int FileExtensionId { get; set; }

        public FileExtension? FileExtension { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public List<FileTerm>? FileTerms { get; set; }
    }
}
