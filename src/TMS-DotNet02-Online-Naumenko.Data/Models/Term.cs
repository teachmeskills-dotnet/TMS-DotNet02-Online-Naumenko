﻿using TMS_DotNet02_Online_Naumenko.Data.Models.Enums;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Term
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Parent { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public TermType TermTypeId { get; set; }

        public IEnumerable<PostTerm> PostTerms { get; set; }

        public IEnumerable<FileTerm> FileTerms { get; set; }
    }
}
