using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Enums;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Term
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Slug { get; set; }

        public int Parent { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public TermType? TermTypeId { get; set; }

        public List<PostTerm>? PostTerms { get; set; }

        public List<FileTerm>? FileTerms { get; set; }
    }
}
