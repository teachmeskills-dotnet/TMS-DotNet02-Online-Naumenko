﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models.Enums;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class PostDto
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }

        public string Excerpt { get; set; }

        public string ReadingTime { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public PostStatus PostStatusId { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public IEnumerable<PostTermDto> PostTerms { get; set; }

        public int FileId { get; set; }

        public FileDto File { get; set; }
    }
}
