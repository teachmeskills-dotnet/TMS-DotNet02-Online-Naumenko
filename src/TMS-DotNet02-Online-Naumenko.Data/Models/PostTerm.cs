using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class PostTerm
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public int TermId { get; set; }

        public Term Term { get; set; }
    }
}
