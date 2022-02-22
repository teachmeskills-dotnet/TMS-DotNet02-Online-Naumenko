using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class File
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Link { get; set; }

        public int ExtensionId { get; set; }

        public int AuthorId { get; set; }
    }
}
