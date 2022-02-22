using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Term
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Parent { get; set; }

        public int TypeId { get; set; }

        public int AuthorId { get; set; }
    }
}
