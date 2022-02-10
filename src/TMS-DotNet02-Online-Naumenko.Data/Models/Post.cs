using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Type { get; set; }
        
        public string Title { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }

        public string Excerpt { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateModification { get; set; }

        public int Author { get; set; }

        public string Status { get; set; }

        public string ImageUrl { get; set; }
    }
}
