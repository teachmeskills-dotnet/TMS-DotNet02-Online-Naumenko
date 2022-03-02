using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FileTermDTO
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public FileDTO? File { get; set; }

        public int TermId { get; set; }

        public Term? Term { get; set; }
    }
}
