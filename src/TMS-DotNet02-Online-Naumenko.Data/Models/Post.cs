﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        
        public string Title { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }

        public string Excerpt { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public int AuthorId { get; set; }

        public int StatusId { get; set; }
    }
}
